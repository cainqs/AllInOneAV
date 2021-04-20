﻿using DataBaseManager.ScanDataBaseHelper;
using Model.OneOneFive;
using Model.ScanModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Utils;

namespace Service
{
    public class OneOneFiveService
    {
        private static readonly string FinFolder = "fin\\";
        private static readonly string UpFolder = "up115\\";

        public static bool Get115SearchResult(CookieContainer cc, string content, string folder = "1834397846621504875", string host = "115.com", string reffer = "https://115.com/?cid=0&offset=0&mode=wangpan", string ua = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/62.0.3202.94 Safari/537.36 115Browser/12.0.0")
        {
            bool ret = false;

            var url = string.Format(string.Format("https://webapi.115.com/files/search?search_value={0}&format=json&cid={1}", content, folder));
            var htmlRet = HtmlManager.GetHtmlWebClient("https://webapi.115.com", url, cc);
            if (htmlRet.Success)
            {
                if (!string.IsNullOrEmpty(htmlRet.Content))
                {
                    var data = Newtonsoft.Json.Linq.JObject.Parse(htmlRet.Content);

                    if (data.Property("count").HasValues && int.Parse(data.Property("count").Value.ToString()) > 0)
                    {
                        ret = true;
                    }
                }
            }

            return ret;
        }

        public static FileListModel Get115SearchResultInFolder(CookieContainer cc, string content, string folder = "1834397846621504875", string host = "115.com", string reffer = "https://115.com/?cid=0&offset=0&mode=wangpan", string ua = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/62.0.3202.94 Safari/537.36 115Browser/12.0.0")
        {
            FileListModel ret = new FileListModel();

            var url = string.Format(string.Format("https://webapi.115.com/files/search?search_value={0}&format=json&offset=0&limit=10&&date=&aid=1&cid={1}", content, folder));
            var htmlRet = HtmlManager.GetHtmlWebClient("https://115.com", url, cc);
            if (htmlRet.Success)
            {
                if (!string.IsNullOrEmpty(htmlRet.Content))
                {
                    ret = JsonConvert.DeserializeObject<FileListModel>(htmlRet.Content);
                }
            }

            return ret;
        }

        public static ValueTuple<bool, string> Add115MagTask(string cookieStr, string mag, string uid, string sign, string host = "115.com", string reffer = "https://115.com/?cid=1835025974666577373&offset=0&tab=download&mode=wangpan", string ua = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/62.0.3202.94 Safari/537.36 115Browser/12.0.0")
        {
            bool ret = false;
            string msg = "";

            CookieContainer cc = Get115Cookie();

            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("url", mag);
            param.Add("sign", sign);
            param.Add("uid", uid);
            param.Add("time", DateTime.Now.ToFileTimeUtc() + "");

            var returnStr = HtmlManager.Post("https://115.com/web/lixian/?ct=lixian&ac=add_task_url", param, cc);

            if (!string.IsNullOrEmpty(returnStr))
            {
                var data = Newtonsoft.Json.Linq.JObject.Parse(returnStr);

                bool.TryParse(data.Property("state").Value.ToString(), out ret);

                if (ret == false)
                {
                    msg = data.Property("error_msg").Value.ToString();
                }
            }

            return new ValueTuple<bool, string>(ret, msg);
        }

        public static CookieContainer Get115Cookie()
        {
            CookieContainer cc = new CookieContainer();

            var cookieData = new ChromeCookieReader().ReadCookies(".115.com");

            foreach (var item in cookieData.Where(x => !x.Value.Contains(",")).Distinct())
            {
                if (item.Name == "PHPSESSID" || item.Name == "UID" || item.Name == "CID" || item.Name == "SEID" || item.Name == "115_lang")
                {
                    Cookie c = new Cookie(item.Name, item.Value, "/", "115.com");
                    cc.Add(c);
                }
            }

            cookieData = new ChromeCookieReader().ReadCookies("webapi.115.com");

            foreach (var item in cookieData.Where(x => !x.Value.Contains(",")).Distinct())
            {
                Cookie c = new Cookie(item.Name, item.Value, "/", "115.com");
                cc.Add(c);
            }

            return cc;
        }

        public static int Get115PagesInFolder(int pageSize = 1, string folder = "1834397846621504875")
        {
            var url = $"https://webapi.115.com/files?aid=1&cid={folder}&o=user_ptime&asc=0&offset=0&show_dir=1&limit={pageSize}&code=&scid=&snap=0&natsort=1&record_open_time=1&source=&format=json";
            var cc = Get115Cookie();

            var htmlRet = HtmlManager.GetHtmlWebClient("https://webapi.115.com", url, cc);
            if (htmlRet.Success)
            {
                if (!string.IsNullOrEmpty(htmlRet.Content))
                {
                    var data = JsonConvert.DeserializeObject<FileListModel>(htmlRet.Content);

                    if (data != null && data.count > 0)
                    {
                        if (data.data == null)
                        {
                            return data.count % pageSize == 0 ? data.count / pageSize : data.count / pageSize + 1;
                        }

                        return data.count % data.page_size == 0 ? data.count / data.page_size : data.count / data.page_size + 1;
                    }
                }
            }

            return 0;
        }

        public static List<FileItemModel> Get115Files(int start = 0, int end = 0, int pageSize = 1150)
        {
            List<FileItemModel> ret = new List<FileItemModel>();

            var cc = Get115Cookie();
            for (int i = start; i <= end; i++)
            {
                var url = string.Format(@"https://webapi.115.com/files?aid=1&cid=1834397846621504875&o=user_ptime&asc=0&offset={0}&show_dir=1&limit={1}&code=&scid=&snap=0&natsort=1&record_open_time=1&source=&format=json", i * pageSize, pageSize);

                var htmlRet = HtmlManager.GetHtmlWebClient("https://115.com", url, cc);
                if (htmlRet.Success)
                {
                    if (!string.IsNullOrEmpty(htmlRet.Content))
                    {
                        var data = JsonConvert.DeserializeObject<FileListModel>(htmlRet.Content);

                        if (data != null && data.data != null)
                        {
                            foreach (var d in data.data)
                            {
                                if (!ret.Exists(x => x.sha == d.sha))
                                {
                                    ret.Add(d);
                                }
                            }
                        }
                    }
                }
            }

            return ret;
        }

        public static Dictionary<string, List<FileItemModel>> GetRepeatFiles(int pageSize = 1)
        {
            Dictionary<string, List<FileItemModel>> ret = new Dictionary<string, List<FileItemModel>>();
            var pattern = @"\(\d+\)";
            var data = OneOneFiveService.Get115Files(0, OneOneFiveService.Get115PagesInFolder(pageSize), pageSize);

            var retRepeat = data.Where(x => Regex.IsMatch(x.n, pattern)).ToList();

            foreach (var repeat in retRepeat)
            {
                var ori = Regex.Replace(repeat.n, pattern, "");

                if (!ret.ContainsKey(ori))
                {
                    var oriItem = data.FirstOrDefault(x => x.n == ori);

                    if (oriItem != null)
                    {
                        List<FileItemModel> temp = new List<FileItemModel>();

                        temp.Add(oriItem);
                        temp.Add(repeat);

                        ret.Add(ori, temp);
                    }
                    else
                    {
                        List<FileItemModel> temp = new List<FileItemModel>();

                        temp.Add(repeat);

                        ret.Add(ori, temp);
                    }
                }
                else
                {
                    ret[ori].Add(repeat);
                }
            }

            return ret;
        }

        public static string DeleteAndRename(Dictionary<string, List<FileItemModel>> input)
        {
            double deleteSize = 0;
            CookieContainer cc = Get115Cookie();
            var pattern = @"\(\d+\)";

            foreach (var data in input)
            {
                if (data.Value.Count >= 2)
                {
                    Console.WriteLine("正在处理 " + data.Key);

                    var biggest = data.Value.LastOrDefault();
                    var chinese = data.Value.FirstOrDefault(x => x.n.Contains("-C."));

                    Console.WriteLine("\t最大文件为 " + biggest.n + " 大小为 " + FileSize.GetAutoSizeString(biggest.s, 2));

                    data.Value.Remove(biggest);
  
                    foreach (var de in data.Value)
                    {
                        Console.WriteLine("\t删除 " + de.n + " 大小为 " + FileSize.GetAutoSizeString(de.s, 2));
                        Delete(de.fid, cc);
                        deleteSize += de.s;
                    }

                    Console.WriteLine("\t重命名 " + biggest.n + " 到 " + Regex.Replace(biggest.n, pattern, ""));
                    Rename(biggest.fid, Regex.Replace(biggest.n, pattern, ""), cc);
                    Console.WriteLine();
                }

                if (data.Value.Count == 1)
                {
                    Console.WriteLine("\t重命名 " + data.Value.LastOrDefault().n + " 到 " + Regex.Replace(data.Value.LastOrDefault().n, pattern, ""));
                    Rename(data.Value.LastOrDefault().fid, Regex.Replace(data.Value.LastOrDefault().n, pattern, ""), cc);
                }
            }

            return FileSize.GetAutoSizeString(deleteSize, 2);
        }

        public static void Delete(string fid, CookieContainer cc)
        {
            var url = @"https://webapi.115.com/rb/delete";

            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("pid", "0");
            param.Add("fid[0]", fid);

            HtmlManager.Post(url, param, cc);
        }

        public static void Rename(string fid, string newName, CookieContainer cc)
        {
            var url = @"https://webapi.115.com/files/batch_rename";

            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("files_new_name[" + fid + "]", newName);

            HtmlManager.Post(url, param, cc);
        }

        public static FileListModel GetOneOneFileInFolder(string folder, int page = 0, int pageSize = 1150)
        {
            FileListModel ret = new FileListModel();
            var cc = Get115Cookie();
            var url = $"https://webapi.115.com/files?aid=1&cid={folder}&o=user_ptime&asc=0&offset={page}&show_dir=1&limit={pageSize}&code=&scid=&snap=0&natsort=1&record_open_time=1&source=&format=json&type=&star=&is_q=&is_share=";

            var htmlRet = HtmlManager.GetHtmlWebClient("https://115.com", url, cc);
            if (htmlRet.Success)
            {
                if (!string.IsNullOrEmpty(htmlRet.Content))
                {
                    ret = JsonConvert.DeserializeObject<FileListModel>(htmlRet.Content);
                }
            }

            return ret;
        }

        public static string RemoveDuplicated115Files()
        {
            var repeat = GetRepeatFiles(1150);

            return DeleteAndRename(repeat);
        }

        public static List<FileItemModel> Get115FilesModel(string folder = "1834397846621504875")
        {
            List<FileItemModel> list = new List<FileItemModel>();

            var pages = OneOneFiveService.Get115PagesInFolder(1150);

            for (int i = 0; i < pages; i++)
            {
                var files = OneOneFiveService.GetOneOneFileInFolder(folder, i * 1150, 1150);

                if (files != null && files.data != null)
                {
                    list.AddRange(files.data);
                }
            }

            return list;
        }

        public static void Insert115FileSha(List<FileItemModel> models, bool truncate = false)
        {
            var files = models.Where(x => !string.IsNullOrEmpty(x.fid)).ToList();

            Console.WriteLine($"获取到{files.Count}个文件");
            int index = 1;

            if (files != null && files.Any())
            {
                if (truncate)
                {
                    ScanDataBaseManager.TruncateOneOneFiveFileShaMapping();
                }

                foreach (var file in files)
                {
                    Console.WriteLine($"正在处理{index++}");

                    OneOneFiveFileShaMapping entity = new OneOneFiveFileShaMapping()
                    {
                        FileName = file.n,
                        FileSize = file.s,
                        Sha = file.sha,
                        IsOnLocal = false
                    };

                    ScanDataBaseManager.InserOneOneFiveFileShaMapping(entity);
                }
            }
        }

        public static List<FileInfo> GetAllLocalAvs(bool includeUpFolder = true)
        {
            List<FileInfo> ret = new List<FileInfo>();

            foreach (var drive in Environment.GetLogicalDrives())
            {
                if (Directory.Exists(drive + FinFolder))
                {
                    ret.AddRange(new DirectoryInfo(drive + FinFolder).GetFiles());
                }

                if (includeUpFolder && Directory.Exists(drive + UpFolder))
                {
                    ret.AddRange(new DirectoryInfo(drive + UpFolder).GetFiles());
                }
            }

            return ret;
        }

        public static List<string> InitLocalSha(bool earse = false)
        {
            List<string> needToCalculateSha = new List<string>();

            var filesIn115 = OneOneFiveService.Get115FilesModel();
            var localFiles = GetAllLocalAvs();

            if (filesIn115 != null && filesIn115.Any())
            {
                if (earse)
                {
                    ScanDataBaseManager.TruncateLocalShaMapping();
                }

                foreach (var localFile in localFiles)
                {
                    var matchedRecord = filesIn115.FirstOrDefault(x => x.n.Equals(localFile.Name, StringComparison.OrdinalIgnoreCase) && x.s == localFile.Length);

                    if (matchedRecord != null && !string.IsNullOrEmpty(matchedRecord.sha))
                    {
                        LocalShaMapping temp = new LocalShaMapping
                        {
                            FilePath = localFile.Name,
                            FileFolder = Path.GetPathRoot(localFile.FullName),
                            FileSize = localFile.Length,
                            Sha1 = matchedRecord.sha
                        };

                        ScanDataBaseManager.InsertLocalShaMapping(temp);
                    }
                    else
                    {
                        needToCalculateSha.Add(localFile.FullName);
                    }
                }
            }

            return needToCalculateSha;
        }

        public static void Match115AndMoveLocalFile()
        {
            var filesIn115 = OneOneFiveService.Get115FilesModel();

            foreach (var drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine($"处理 {drive}");

                List<string> files = new List<string>();
                List<string> toFin = new List<string>();
                List<string> to115 = new List<string>();

                var fin = drive + FinFolder;
                var up = drive + UpFolder;

                if (Directory.Exists(fin))
                {
                    files.AddRange(new DirectoryInfo(fin).GetFiles().Select(y => y.FullName).ToList());
                }

                if (Directory.Exists(up))
                {
                    files.AddRange(new DirectoryInfo(up).GetFiles().Select(y => y.FullName).ToList());
                }

                foreach (var file in files)
                {
                    var name = Path.GetFileName(file);
                    if (filesIn115.Exists(x => x.n.Equals(Path.GetFileName(file), StringComparison.OrdinalIgnoreCase) && x.s == new FileInfo(file).Length))
                    {
                        var path = Path.GetDirectoryName(file) + "\\";
                        if (path == up)
                        {
                            toFin.Add(file);
                        }
                    }
                    else
                    {
                        var path = Path.GetDirectoryName(file) + "\\";
                        if (path == fin)
                        {
                            to115.Add(file);
                        }
                    }
                }

                if (toFin.Count > 0)
                {
                    if (!Directory.Exists(fin))
                    {
                        Directory.CreateDirectory(fin);
                    }

                    Console.WriteLine($"移动 {toFin.Count} 到 FIN");

                    FileUtility.TransferFileUsingSystem(toFin, fin, true, true);
                }

                if (to115.Count > 0)
                {
                    if (!Directory.Exists(up))
                    {
                        Directory.CreateDirectory(up);
                    }

                    Console.WriteLine($"移动 {to115.Count} 到 UP115");

                    FileUtility.TransferFileUsingSystem(to115, up, true, true);
                }
            }
        }

        public static void SyncLocalAnd115FileStatus(string folder = "1834397846621504875", bool update115Maping = false)
        {
            var oneOneFiles = Get115FilesModel(folder);
            var localFiles = GetAllLocalAvs();
            var localShaMapping = ScanDataBaseManager.GetAllLocalShaMapping();

            if (oneOneFiles != null && oneOneFiles.Any())
            {
                if (update115Maping)
                {
                    Insert115FileSha(oneOneFiles);
                }

                //刷新本地sha，更新本地是否保存
                foreach (var oneOneFive in oneOneFiles)
                {
                    var matchedMapping = localShaMapping.FirstOrDefault(x => x.Sha1 == oneOneFive.sha);
                    
                    if (matchedMapping != null)
                    {
                        ScanDataBaseManager.UpdateOneOneFiveFileShaMapping(matchedMapping.Sha1, true);
                    }
                }
            }
        }

        public static List<FileInfo> GetFileToBeDeletedBySize(long gb = 1)
        {
            var files = GetAllLocalAvs();

            var delete = files.Where(x => x.Length <= gb * 1024 * 1024 * 1024).ToList();

            return delete;
        }
    }
}

﻿using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using Model.Common;
using Model.JavModels;
using Model.ScanModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Utils
{
    public class FileUtility
    {

        private const String Jian = "啊阿埃挨哎唉哀皑癌蔼矮艾碍爱隘鞍氨安俺按暗岸胺案肮昂盎凹敖熬翱袄傲奥懊澳芭捌扒叭吧笆疤巴拔跋靶把耙坝霸罢爸白柏百摆佰败拜稗斑班搬扳般颁板版扮拌伴瓣半办绊邦帮梆榜膀绑棒磅蚌镑傍谤苞胞包褒剥薄雹保堡饱宝抱报暴豹鲍爆杯碑悲卑北辈背贝钡倍狈备惫焙被奔苯本笨崩绷甭泵蹦迸逼鼻比鄙笔彼碧蓖蔽毕毙毖币庇痹闭敝弊必辟壁臂避陛鞭边编贬扁便变卞辨辩辫遍标彪膘表鳖憋别瘪彬斌濒滨宾摈兵冰柄丙秉饼炳病并玻菠播拨钵波博勃搏铂箔伯帛舶脖膊渤泊驳捕卜哺补埠不布步簿部怖擦猜裁材才财睬踩采彩菜蔡餐参蚕残惭惨灿苍舱仓沧藏操糙槽曹草厕策侧册测层蹭插叉茬茶查碴搽察岔差诧拆柴豺搀掺蝉馋谗缠铲产阐颤昌猖场尝常长偿肠厂敞畅唱倡超抄钞朝嘲潮巢吵炒车扯撤掣彻澈郴臣辰尘晨忱沉陈趁衬撑称城橙成呈乘程惩澄诚承逞骋秤吃痴持匙池迟弛驰耻齿侈尺赤翅斥炽充冲虫崇宠抽酬畴踌稠愁筹仇绸瞅丑臭初出橱厨躇锄雏滁除楚础储矗搐触处揣川穿椽传船喘串疮窗幢床闯创吹炊捶锤垂春椿醇唇淳纯蠢戳绰疵茨磁雌辞慈瓷词此刺赐次聪葱囱匆从丛凑粗醋簇促蹿篡窜摧崔催脆瘁粹淬翠村存寸磋撮搓措挫错搭达答瘩打大呆歹傣戴带殆代贷袋待逮怠耽担丹单郸掸胆旦氮但惮淡诞弹蛋当挡党荡档刀捣蹈倒岛祷导到稻悼道盗德得的蹬灯登等瞪凳邓堤低滴迪敌笛狄涤翟嫡抵底地蒂第帝弟递缔颠掂滇碘点典靛垫电佃甸店惦奠淀殿碉叼雕凋刁掉吊钓调跌爹碟蝶迭谍叠丁盯叮钉顶鼎锭定订丢东冬董懂动栋侗恫冻洞兜抖斗陡豆逗痘都督毒犊独读堵睹赌杜镀肚度渡妒端短锻段断缎堆兑队对墩吨蹲敦顿囤钝盾遁掇哆多夺垛躲朵跺舵剁惰堕蛾峨鹅俄额讹娥恶厄扼遏鄂饿恩而儿耳尔饵洱二贰发罚筏伐乏阀法珐藩帆番翻樊矾钒繁凡烦反返范贩犯饭泛坊芳方肪房防妨仿访纺放菲非啡飞肥匪诽吠肺废沸费芬酚吩氛分纷坟焚汾粉奋份忿愤粪丰封枫蜂峰锋风疯烽逢冯缝讽奉凤佛否夫敷肤孵扶拂辐幅氟符伏俘服浮涪福袱弗甫抚辅俯釜斧脯腑府腐赴副覆赋复傅付阜父腹负富讣附妇缚咐噶嘎该改概钙盖溉干甘杆柑竿肝赶感秆敢赣冈刚钢缸肛纲岗港杠篙皋高膏羔糕搞镐稿告哥歌搁戈鸽胳疙割革葛格蛤阁隔铬个各给根跟耕更庚羹埂耿梗工攻功恭龚供躬公宫弓巩汞拱贡共钩勾沟苟狗垢构购够辜菇咕箍估沽孤姑鼓古蛊骨谷股故顾固雇刮瓜剐寡挂褂乖拐怪棺关官冠观管馆罐惯灌贯光广逛瑰规圭硅归龟闺轨鬼诡癸桂柜跪贵刽辊滚棍锅郭国果裹过哈骸孩海氦亥害骇酣憨邯韩含涵寒函喊罕翰撼捍旱憾悍焊汗汉夯杭航壕嚎豪毫郝好耗号浩呵喝荷菏核禾和何合盒貉阂河涸赫褐鹤贺嘿黑痕很狠恨哼亨横衡恒轰哄烘虹鸿洪宏弘红喉侯猴吼厚候后呼乎忽瑚壶葫胡蝴狐糊湖弧虎唬护互沪户花哗华猾滑画划化话槐徊怀淮坏欢环桓还缓换患唤痪豢焕涣宦幻荒慌黄磺蝗簧皇凰惶煌晃幌恍谎灰挥辉徽恢蛔回毁悔慧卉惠晦贿秽会烩汇讳诲绘荤昏婚魂浑混豁活伙火获或惑霍货祸击圾基机畸稽积箕肌饥迹激讥鸡姬绩缉吉极棘辑籍集及急疾汲即嫉级挤几脊己蓟技冀季伎祭剂悸济寄寂计记既忌际继纪嘉枷夹佳家加荚颊贾甲钾假稼价架驾嫁歼监坚尖笺间煎兼肩艰奸缄茧检柬碱硷拣捡简俭剪减荐槛鉴践贱见键箭件健舰剑饯渐溅涧建僵姜将浆江疆蒋桨奖讲匠酱降蕉椒礁焦胶交郊浇骄娇嚼搅铰矫侥脚狡角饺缴绞剿教酵轿较叫窖揭接皆秸街阶截劫节茎睛晶鲸京惊精粳经井警景颈静境敬镜径痉靖竟竞净炯窘揪究纠玖韭久灸九酒厩救旧臼舅咎就疚鞠拘狙疽居驹菊局咀矩举沮聚拒据巨具距踞锯俱句惧炬剧捐鹃娟倦眷卷绢撅攫抉掘倔爵桔杰捷睫竭洁结解姐戒藉芥界借介疥诫届巾筋斤金今津襟紧锦仅谨进靳晋禁近烬浸尽劲荆兢觉决诀绝均菌钧军君峻俊竣浚郡骏喀咖卡咯开揩楷凯慨刊堪勘坎砍看康慷糠扛抗亢炕考拷烤靠坷苛柯棵磕颗科壳咳可渴克刻客课肯啃垦恳坑吭空恐孔控抠口扣寇枯哭窟苦酷库裤夸垮挎跨胯块筷侩快宽款匡筐狂框矿眶旷况亏盔岿窥葵奎魁傀馈愧溃坤昆捆困括扩廓阔垃拉喇蜡腊辣啦莱来赖蓝婪栏拦篮阑兰澜谰揽览懒缆烂滥琅榔狼廊郎朗浪捞劳牢老佬姥酪烙涝勒乐雷镭蕾磊累儡垒擂肋类泪棱楞冷厘梨犁黎篱狸离漓理李里鲤礼莉荔吏栗丽厉励砾历利傈例俐痢立粒沥隶力璃哩俩联莲连镰廉怜涟帘敛脸链恋炼练粮凉梁粱良两辆量晾亮谅撩聊僚疗燎寥辽潦了撂镣廖料列裂烈劣猎琳林磷霖临邻鳞淋凛赁吝拎玲菱零龄铃伶羚凌灵陵岭领另令溜琉榴硫馏留刘瘤流柳六龙聋咙笼窿隆垄拢陇楼娄搂篓漏陋芦卢颅庐炉掳卤虏鲁麓碌露路赂鹿潞禄录陆戮驴吕铝侣旅履屡缕虑氯律率滤绿峦挛孪滦卵乱掠略抡轮伦仑沦纶论萝螺罗逻锣箩骡裸落洛骆络妈麻玛码蚂马骂嘛吗埋买麦卖迈脉瞒馒蛮满蔓曼慢漫谩芒茫盲氓忙莽猫茅锚毛矛铆卯茂冒帽貌贸么玫枚梅酶霉煤没眉媒镁每美昧寐妹媚门闷们萌蒙檬盟锰猛梦孟眯醚靡糜迷谜弥米秘觅泌蜜密幂棉眠绵冕免勉娩缅面苗描瞄藐秒渺庙妙蔑灭民抿皿敏悯闽明螟鸣铭名命谬摸摹蘑模膜磨摩魔抹末莫墨默沫漠寞陌谋牟某拇牡亩姆母墓暮幕募慕木目睦牧穆拿哪呐钠那娜纳氖乃奶耐奈南男难囊挠脑恼闹淖呢馁内嫩能妮霓倪泥尼拟你匿腻逆溺蔫拈年碾撵捻念娘酿鸟尿捏聂孽啮镊镍涅您柠狞凝宁拧泞牛扭钮纽脓浓农弄奴努怒女暖虐疟挪懦糯诺哦欧鸥殴藕呕偶沤啪趴爬帕怕琶拍排牌徘湃派攀潘盘磐盼畔判叛乓庞旁耪胖抛咆刨炮袍跑泡呸胚培裴赔陪配佩沛喷盆砰抨烹澎彭蓬棚硼篷膨朋鹏捧碰坯砒霹批披劈琵毗啤脾疲皮匹痞僻屁譬篇偏片骗飘漂瓢票撇瞥拼频贫品聘乒坪苹萍平凭瓶评屏坡泼颇婆破魄迫粕剖扑铺仆莆葡菩蒲埔朴圃普浦谱曝瀑期欺栖戚妻七凄漆柒沏其棋奇歧畦崎脐齐旗祈祁骑起岂乞企启契砌器气迄弃汽泣讫掐洽牵扦钎铅千迁签仟谦乾黔钱钳前潜遣浅谴堑嵌欠歉枪呛腔羌墙蔷强抢橇锹敲悄桥瞧乔侨巧鞘撬翘峭俏窍切茄且怯窃钦侵亲秦琴勤芹擒禽寝沁青轻氢倾卿清擎晴氰情顷请庆琼穷秋丘邱球求囚酋泅趋区蛆曲躯屈驱渠取娶龋趣去圈颧权醛泉全痊拳犬券劝缺炔瘸却鹊榷确雀裙群然燃冉染瓤壤攘嚷让饶扰绕惹热壬仁人忍韧任认刃妊纫扔仍日戎茸蓉荣融熔溶容绒冗揉柔肉茹蠕儒孺如辱乳汝入褥软阮蕊瑞锐闰润若弱撒洒萨腮鳃塞赛三叁伞散桑嗓丧搔骚扫嫂瑟色涩森僧莎砂杀刹沙纱傻啥煞筛晒珊苫杉山删煽衫闪陕擅赡膳善汕扇缮墒伤商赏晌上尚裳梢捎稍烧芍勺韶少哨邵绍奢赊蛇舌舍赦摄射慑涉社设砷申呻伸身深娠绅神沈审婶甚肾慎渗声生甥牲升绳省盛剩胜圣师失狮施湿诗尸虱十石拾时什食蚀实识史矢使屎驶始式示士世柿事拭誓逝势是嗜噬适仕侍释饰氏市恃室视试收手首守寿授售受瘦兽蔬枢梳殊抒输叔舒淑疏书赎孰熟薯暑曙署蜀黍鼠属术述树束戍竖墅庶数漱恕刷耍摔衰甩帅栓拴霜双爽谁水睡税吮瞬顺舜说硕朔烁斯撕嘶思私司丝死肆寺嗣四伺似饲巳松耸怂颂送宋讼诵搜艘擞嗽苏酥俗素速粟僳塑溯宿诉肃酸蒜算虽隋随绥髓碎岁穗遂隧祟孙损笋蓑梭唆缩琐索锁所塌他它她塔獭挞蹋踏胎苔抬台泰酞太态汰坍摊贪瘫滩坛檀痰潭谭谈坦毯袒碳探叹炭汤塘搪堂棠膛唐糖倘躺淌趟烫掏涛滔绦萄桃逃淘陶讨套特藤腾疼誊梯剔踢锑提题蹄啼体替嚏惕涕剃屉天添填田甜恬舔腆挑条迢眺跳贴铁帖厅听烃汀廷停亭庭挺艇通桐酮瞳同铜彤童桶捅筒统痛偷投头透凸秃突图徒途涂屠土吐兔湍团推颓腿蜕褪退吞屯臀拖托脱鸵陀驮驼椭妥拓唾挖哇蛙洼娃瓦袜歪外豌弯湾玩顽丸烷完碗挽晚皖惋宛婉万腕汪王亡枉网往旺望忘妄威巍微危韦违桅围唯惟为潍维苇萎委伟伪尾纬未蔚味畏胃喂魏位渭谓尉慰卫瘟温蚊文闻纹吻稳紊问嗡翁瓮挝蜗涡窝我斡卧握沃巫呜钨乌污诬屋无芜梧吾吴毋武五捂午舞伍侮坞戊雾晤物勿务悟误昔熙析西硒矽晰嘻吸锡牺稀息希悉膝夕惜熄烯溪汐犀檄袭席习媳喜铣洗系隙戏细瞎虾匣霞辖暇峡侠狭下厦夏吓掀锨先仙鲜纤咸贤衔舷闲涎弦嫌显险现献县腺馅羡宪陷限线相厢镶香箱襄湘乡翔祥详想响享项巷橡像向象萧硝霄削哮嚣销消宵淆晓小孝校肖啸笑效楔些歇蝎鞋协挟携邪斜胁谐写械卸蟹懈泄泻谢屑薪芯锌欣辛新忻心信衅星腥猩惺兴刑型形邢行醒幸杏性姓兄凶胸匈汹雄熊休修羞朽嗅锈秀袖绣墟戌需虚嘘须徐许蓄酗叙旭序畜恤絮婿绪续轩喧宣悬旋玄选癣眩绚靴薛学穴雪血勋熏循旬询寻驯巡殉汛训讯逊迅压押鸦鸭呀丫芽牙蚜崖衙涯雅哑亚讶焉咽阉烟淹盐严研蜒岩延言颜阎炎沿奄掩眼衍演艳堰燕厌砚雁唁彦焰宴谚验殃央鸯秧杨扬佯疡羊洋阳氧仰痒养样漾邀腰妖瑶摇尧遥窑谣姚咬舀药要耀椰噎耶爷野冶也页掖业叶曳腋夜液一壹医揖铱依伊衣颐夷遗移仪胰疑沂宜姨彝椅蚁倚已乙矣以艺抑易邑屹亿役臆逸肄疫亦裔意毅忆义益溢诣议谊译异翼翌绎茵荫因殷音阴姻吟银淫寅饮尹引隐印英樱婴鹰应缨莹萤营荧蝇迎赢盈影颖硬映哟拥佣臃痈庸雍踊蛹咏泳涌永恿勇用幽优悠忧尤由邮铀犹油游酉有友右佑釉诱又幼迂淤于盂榆虞愚舆余俞逾鱼愉渝渔隅予娱雨与屿禹宇语羽玉域芋郁吁遇喻峪御愈欲狱育誉浴寓裕预豫驭鸳渊冤元垣袁原援辕园员圆猿源缘远苑愿怨院曰约越跃钥岳粤月悦阅耘云郧匀陨允运蕴酝晕韵孕匝砸杂栽哉灾宰载再在咱攒暂赞赃脏葬遭糟凿藻枣早澡蚤躁噪造皂灶燥责择则泽贼怎增憎曾赠扎喳渣札轧铡闸眨栅榨咋乍炸诈摘斋宅窄债寨瞻毡詹粘沾盏斩辗崭展蘸栈占战站湛绽樟章彰漳张掌涨杖丈帐账仗胀瘴障招昭找沼赵照罩兆肇召遮折哲蛰辙者锗蔗这浙珍斟真甄砧臻贞针侦枕疹诊震振镇阵蒸挣睁征狰争怔整拯正政帧症郑证芝枝支吱蜘知肢脂汁之织职直植殖执值侄址指止趾只旨纸志挚掷至致置帜峙制智秩稚质炙痔滞治窒中盅忠钟衷终种肿重仲众舟周州洲诌粥轴肘帚咒皱宙昼骤珠株蛛朱猪诸诛逐竹烛煮拄瞩嘱主著柱助蛀贮铸筑住注祝驻抓爪拽专砖转撰赚篆桩庄装妆撞壮状椎锥追赘坠缀谆准捉拙卓桌琢茁酌啄着灼浊兹咨资姿滋淄孜紫仔籽滓子自渍字鬃棕踪宗综总纵邹走奏揍租足卒族祖诅阻组钻纂嘴醉最罪尊遵昨左佐柞做作坐座亚儿亲奸马忏蜡总烧纵杂志书制门系";

        private const String Fan = "啊阿埃挨哎唉哀皚癌藹矮艾礙愛隘鞍氨咹俺按暗岸胺案肮昂盎凹敖熬翱襖傲奧懊澳芭捌扒叭吧笆疤巴拔跋靶紦耙壩霸罷爸苩柏百擺佰敗拜稗斑癍搬扳般頒板蝂扮拌伴瓣半か絆邦幫梆榜膀綁棒磅蚌鎊傍謗苞胞包褒剝薄雹保堡飽寶菢報暴豹鮑爆杯碑悲卑丠輩褙贔鋇倍狽備憊焙被奔苯夲笨崩繃甭泵蹦迸逼鼻仳鄙筆彼碧蓖蔽畢斃毖幣庇痹閉敝弊必辟壁臂避陛鞭邊編貶扁便變卞辨辯辮遍標彪膘表鱉憋別癟彬斌瀕濱賓擯兵栤柄丙秉餅炳疒並箥菠播撥缽波博葧搏鉑箔伯帛舶脖膊渤泊駁捕卜哺補埠鈈咘步簿蔀怖擦猜裁材才財睬踩采彩菜蔡餐參蠶殘慚慘燦蒼艙倉滄藏操糙槽曹草廁策側冊測層蹭插叉茬茶查碴搽察岔差詫拆柴豺攙摻蟬饞讒纏鏟產闡顫昌猖場嘗瑺長償腸廠敞暢唱倡超抄鈔朝嘲潮巢吵炒車扯撤掣徹澈郴臣辰塵晨忱沉陳趁襯撐稱城橙成呈乘程懲澄誠承逞騁秤吃癡持匙池遲弛馳恥齒侈尺赤翅斥熾充沖蟲崇寵抽酬疇躊稠愁籌仇綢瞅醜臭初絀櫥廚躇鋤雛滁除楚礎儲矗搐觸處揣〣穿椽傳船喘串瘡窗幢床闖創吹炊捶錘垂春椿醇唇淳純蠢戳綽疵茨磁雌辭慈瓷詞此刺賜佽聰蔥囪匆從叢湊粗醋簇促躥篡竄摧崔催脆瘁粹淬翠村存団磋撮搓措挫諎搭達答瘩咑夶槑歹傣戴帶殆玳貸袋待逮怠耽擔丼單鄲撣膽旦氮但憚淡誕彈蜑當擋黨蕩檔刀搗蹈倒島禱導箌稻悼噵盜德嘚啲蹬燈登等瞪凳鄧堤低滴迪敵笛狄滌翟嫡抵底地蒂第渧弟遞締顛掂滇碘點典靛墊電佃甸店惦奠澱殿碉叼雕凋刁掉吊釣調跌爹碟蝶迭諜疊丁盯叮釘頂鼎錠萣訂丟東冬董懂動棟侗恫凍洞兜抖鬥陡豆逗痘都督蝳犢獨讀堵睹賭杜鍍肚喥渡妒端短鍛段斷緞堆兌隊對墩噸蹲敦頓囤鈍盾遁掇哆哆奪垛躲朵跺舵剁惰墮蛾峨鵝俄額訛娥惡厄扼遏鄂餓恩洏ㄦ聑爾餌洱②貳發罰筏伐乏閥法琺藩帆番翻樊礬釩繁凡煩反返范販犯飯泛坊芳方肪房防妨仿訪紡放菲非啡飝肥匪誹吠肺廢沸費芬酚吩氛汾紛墳焚汾粉奮份忿憤糞豐葑楓蜂峰鋒闏瘋烽逢馮縫諷奉鳳佛否夫敷膚孵扶拂輻幅氟符伏俘垺浮涪鍢袱弗甫撫輔俯釜斧脯腑府腐赴副覆賦複傅付阜父腹負富訃附婦縛咐噶嘎該改概鈣蓋溉幹咁杆柑竿肝趕感稈敢贛岡剛鋼缸肛綱崗港杠篙皋高膏羔糕搞鎬稿告哥歌擱戈鴿胳疙割革葛格蛤閣隔鉻個各給根哏耕哽庚羹埂耿梗工攻功恭龔供躬公宮弓鞏汞拱貢囲鉤勾溝苟狗垢構購夠辜菇咕箍估沽孤姑鼓古蠱骨穀股故顧固雇刮瓜剮寡掛褂乖拐怪棺關官冠觀管館罐慣灌貫咣廣逛瑰規圭矽歸龜閨軌鬼詭癸桂櫃跪圚劊輥滾棍鍋郭國果裹過囧骸駭海氦亥害駭酣憨邯韓含涵寒函喊罕翰撼捍旱憾悍焊汗漢夯杭航壕嚎豪毫郝恏耗號浩呵喝荷菏核禾囷何匼盒貉閡河涸赫褐鶴賀嘿嫼痕很狠恨哼亨橫衡恒轟哄烘虹鴻洪宏弘紅喉侯猴吼厚候後呼乎忽瑚壺葫胡蝴狐糊鍸弧虤唬護互滬戶婲嘩囮猾滑畫劃囮話槐徊懷淮壞歡環桓還緩換患喚瘓豢煥渙宦幻荒慌黃磺蝗簧瑝凰惶煌晃幌恍謊咴揮輝徽恢蛔囙毀悔慧卉惠晦賄穢茴燴彙諱誨繪葷昏婚魂渾混豁活夥吙獲戓惑霍貨禍擊圾基機畸稽積箕肌饑跡噭譏雞姬績緝吉極棘輯籍集及ゑ疾汲即嫉級擠幾脊己薊技冀季伎祭劑悸濟寄寂計記既忌際繼紀嘉枷夾佳镓加莢頰賈甲鉀假稼價架駕嫁殲監堅尖箋間煎兼肩艱奸緘繭檢柬堿鹼揀撿簡儉剪減薦檻鑒踐賤見鍵箭件健艦劍餞漸濺澗建僵薑將漿江疆蔣槳獎講匠醬降蕉椒礁焦膠交郊澆驕嬌嚼攪鉸矯僥腳狡角餃繳絞剿教酵轎較叫窖揭接皆秸街階截劫節莖聙晶鯨京驚精粳經囲警景頸靜境敬鏡徑痙靖竟競淨炯窘揪究糾玖韭久灸九酒廄救舊臼舅咎就疚鞠拘狙疽居駒菊局咀矩舉沮聚拒據巨具距踞鋸俱句懼炬劇捐鵑娟倦眷卷絹撅攫抉掘倔爵桔傑捷睫竭潔結解姐戒藉芥堺借介疥誡屆巾筋斤金紟津襟緊錦僅謹進靳晉禁近燼浸盡勁荊兢覺決訣絕均菌鈞軍君峻俊竣浚郡駿喀咖鉲咯開揩楷凱慨刊堪勘坎砍看康慷糠扛抗亢炕考拷烤靠坷苛柯棵磕顆科殼咳鈳渴克刻愙課肯啃墾懇坑吭涳恐孔控摳ロ扣寇枯哭窟苦酷庫褲誇垮挎跨胯塊筷儈快寬款匡筐狂框礦眶曠況虧盔巋窺葵奎魁傀饋愧潰坤昆捆困括擴廓闊垃拉喇蠟臘辣啦萊唻賴藍婪欄攔籃闌蘭瀾讕攬覽懶纜爛濫琅榔狼廊郎朗浪撈勞牢咾佬姥酪烙澇勒圞雷鐳蕾磊累儡壘擂肋類淚棱楞冷厘梨犁黎籬狸離漓悝李裏鯉禮莉荔吏栗麗厲勵礫曆利傈例俐痢竝粒瀝隸仂璃哩倆聯蓮連鐮廉憐漣簾斂臉鏈戀煉練糧涼梁粱良両輛量晾煷諒撩聊僚療燎寥遼潦叻撂鐐廖料列裂烮劣獵琳林磷霖臨鄰鱗淋凜賃吝拎玲菱零齡鈴伶羚淩靈陵嶺領另囹溜琉榴硫餾留劉瘤鋶柳六龖聾嚨籠窿隆壟攏隴嘍婁摟簍漏陋蘆盧顱廬爐擄鹵虜魯麓碌露蕗賂麤潞祿錄陸戮驢呂鋁侶旅履屢縷慮氯律率濾綠巒攣孿灤卵亂掠略掄輪倫侖淪綸論蘿螺羅邏鑼籮騾裸落洛駱絡媽麻瑪碼螞骉罵嘛嗎埋買麥賣邁脈瞞饅蠻滿蔓曼慢漫謾芒茫吂氓忙莽貓茅錨毛矛鉚卯茂冒帽貌貿仫玫枚梅酶黴煤莈眉媒鎂烸媄昧寐妹媚闁悶們萌蒙檬盟錳猛夢孟眯醚靡糜迷謎彌米秘覓泌蜜密冪棉眠綿冕免勉娩緬面苗描瞄藐秒渺廟妙蔑滅囻抿皿敏憫閩朙螟鳴銘名命謬摸摹蘑模膜磨摩魔抹末莫墨默沫漠寞陌謀牟某拇牡畝姆毋墓暮幕募慕朩目睦牧穆拿哪呐鈉那娜納氖乃奶耐奈喃侽難囊撓腦惱鬧淖呢餒內嫩能妮霓倪苨胒擬伱匿膩逆溺蔫拈姩碾攆撚念娘釀茑尿捏聶孽齧鑷鎳涅您檸獰凝寧擰濘犇扭鈕紐膿濃農弄奴努怒囡暖虐瘧挪懦糯諾哦歐鷗毆藕嘔偶漚啪趴爬帕怕琶拍排牌徘湃派攀潘盤磐盼畔判叛乓龐旁耪胖拋咆刨炮袍跑泡呸胚培裴賠陪配佩沛噴盆砰抨烹澎彭蓬棚硼篷膨萠鵬捧碰坯砒霹批披劈琵毗啤脾疲皮匹痞僻屁譬篇偏爿騙飄漂瓢票撇瞥拼頻貧品聘乒坪蘋萍平憑瓶評屏坡潑頗嘙破魄迫粕剖撲鋪仆莆葡菩蒲埔樸圃普浦譜曝瀑期欺棲戚妻七淒漆柒沏其棋奇歧畦崎臍齊旗祈祁騎起豈乞企啟契砌器気迄棄汽泣訖掐洽牽扡釺鉛芉遷簽仟謙乾黔錢鉗前潛遣淺譴塹嵌欠歉槍嗆腔羌牆薔強搶橇鍬敲悄橋瞧喬僑巧鞘撬翹峭俏竅切茄且怯竊欽侵儭秦琴勤芹擒禽寢沁圊輕氫傾卿清擎晴氰情頃請慶瓊窮秋丘邱浗求囚酋泅趨區蛆曲軀屈驅渠取娶齲趣去圈顴權醛灥铨痊拳猋券勸缺炔瘸卻鵲榷確雀裙群然燃冉染瓤壤攘嚷讓饒擾繞惹熱壬仁囚忍韌任認刃妊紉扔仍ㄖ戎茸蓉榮融熔溶容絨冗揉柔禸茹蠕儒孺洳辱乳汝入褥軟阮蕊瑞銳閏潤若弱撒灑薩腮鰓塞賽三三傘散桑嗓喪搔騷掃嫂瑟銫澀森僧莎砂殺刹沙紗儍啥煞篩曬珊苫杉屾刪煽衫閃陝擅贍膳善汕扇繕墒傷商賞晌仩尚裳梢捎稍燒芍勺韶尐哨邵紹奢賒蛇舌舍赦攝射懾涉社設砷申呻伸身深娠紳神沈審嬸甚腎慎滲聲苼甥牲升繩渻盛剩勝聖師夨獅施濕詩屍虱┿石拾塒什喰蝕實識史矢使屎駛始式示壵卋柿倳拭誓逝勢昰嗜噬適仕侍釋飾氏市恃室視試收掱首垨壽授售受瘦獸蔬樞梳殊抒輸菽舒淑疏圕贖孰熟薯暑曙署蜀黍鼠屬術述樹束戍豎墅庶數漱恕刷耍摔衰甩帥栓拴霜雙爽誰沝睡稅吮瞬順舜詤碩朔爍斯撕嘶思私司絲迉肆寺嗣四伺似飼巳松聳慫頌送宋訟誦搜艘擻嗽蘇酥俗素速粟僳塑溯宿訴肅酸蒜算雖隋隨綏髓誶歲穗遂隧祟孫損筍蓑梭唆縮瑣索鎖所塌彵咜她塔獺撻蹋踏胎苔抬囼泰酞呔態汰坍攤貪癱灘壇檀痰潭譚談坦毯袒碳探歎炭湯塘搪堂棠膛唐糖倘躺淌趟燙掏濤滔絛萄桃逃淘陶討套特藤騰疼謄梯剔踢銻提題蹄啼體替嚏惕涕剃屜兲添填畾憇恬舔腆挑條迢眺跳貼鐵帖廳聽烴汀廷停亭庭挺艇通桐酮瞳哃銅彤童桶捅筒統痛偷投頭透凸禿突圖徒途塗屠汢吐兔湍團推穨腿蛻褪退吞屯臀拖托脫鴕陀馱駝橢妥拓唾挖哇蛙窪娃瓦襪歪外豌彎灣玩頑丸烷完碗挽晚皖惋宛婉萬腕汪迋亡枉網往旺望莣妄威巍微危韋違桅圍唯惟為濰維葦萎委偉偽尾緯未蔚菋畏胃喂魏位渭謂尉慰衛瘟溫蚊攵聞紋吻穩紊問嗡翁甕撾蝸渦窩莪斡臥握沃莁嗚鎢烏汙誣屋無蕪梧吾吳毋武五捂午舞伍侮塢戊霧晤粅勿務悟誤昔熙析覀硒矽晰嘻吸錫犧稀息希悉膝夕惜熄烯溪汐犀檄襲席習媳囍銑洗系隙戲細瞎蝦匣霞轄暇峽俠狹丅廈夏嚇掀鍁先仙鮮纖鹹賢銜舷閑涎弦嫌顯險哯獻縣腺餡羨憲陷限線相廂鑲馫箱襄湘鄉翔祥詳想響享項巷橡像姠潒蕭硝霄削哮囂銷消宵淆曉曉孝校肖嘯笑效楔些歇蠍鞋協挾攜邪斜脅諧寫械卸蟹懈泄瀉謝屑薪芯鋅欣辛噺忻惢信釁煋腥猩惺興刑型形邢荇醒圉杏性姓兄凶胸匈洶雄熊休修羞朽嗅鏽秀袖繡墟戌需虛噓須徐許蓄酗敘旭序畜恤絮婿緒續軒喧宣懸旋玄選癬眩絢靴薛學穴雪血勳熏循旬詢尋馴巡殉汛訓訊遜迅壓押鴉鴨吖丫芽牙蚜崖衙涯雅啞亜訝焉咽閹煙淹鹽嚴研蜒岩延訁顏閻燚沿奄掩眼衍演豔堰燕厭硯雁唁彥焰宴諺驗殃央鴦秧楊揚佯瘍羴洋陽氧仰癢養樣漾邀腰妖瑤搖堯遙窯謠姚咬舀藥偠耀椰噎耶爺野冶吔頁掖業旪曳腋夜液┅壹醫揖銥依伊衤頤夷遺移儀胰疑沂宜姨彝椅蟻倚巳乙矣鉯藝抑噫邑屹億役臆逸肄疫亦裔意毅憶図益溢詣議誼譯異翼翌繹茵蔭因殷喑陰姻吟銀淫寅飲尹引隱茚英櫻嬰鷹應纓瑩螢營熒蠅迎贏盈影穎硬映喲擁傭臃癰庸雍踴蛹詠泳湧詠恿勇鼡幽優悠憂尤由郵鈾猶油遊酉洧伖右佑釉誘又呦迂淤於盂榆虞愚輿餘俞逾鱻愉渝漁隅予娛雨與嶼禹宇語羽玊域芋鬱籲遇喻峪禦愈欲獄育譽浴寓裕預豫馭鴛淵冤え垣袁原援轅園員圓猿源緣遠苑願怨院曰約越躍鑰嶽粵仴悅閱耘雲鄖勻隕尣運蘊醞暈韻孕匝砸雜栽哉災宰載洅茬咱攢暫贊贓贓葬遭糟鑿藻棗早澡蚤躁噪造皂灶燥責擇則澤賊怎增憎曾贈紮喳渣劄軋鍘閘眨柵榨咋乍炸詐摘齋宅窄債寨瞻氈詹粘沾盞斬輾嶄展蘸棧占戰站湛綻樟嶂彰漳涨掌漲杖丈帳賬仗脹瘴障招昭找沼趙照罩兆肇召遮折哲蟄轍者鍺蔗這浙珍斟眞甄砧臻貞針偵枕疹診震振鎮陣蒸掙睜征猙爭怔整拯㊣政幀症鄭證芝枝支吱蜘知肢脂汁の織職直植殖執徝侄址指止趾呮旨紙志摯擲至致置幟峙制智秩稚質炙痔滯治窒ф盅忠鍾衷終種腫重仲眾舟周州洲謅粥軸肘帚咒皺宙晝驟珠株蛛朱豬諸誅逐竹燭煮拄矚囑主著柱助蛀貯鑄築住紸祝駐抓爪拽專磚轉撰賺篆樁莊裝妝撞壯狀椎錐縋贅墜綴諄准捉拙卓桌琢茁酌啄著灼濁茲咨資姿滋淄孜紫仔籽滓孓自漬芓鬃棕蹤宗綜總縱鄒赱奏揍租足卒族祖詛阻組鑽纂嘴醉朂罪尊遵昨咗佐柞做作唑座亞兒親姦馬懺蝋総焼縦雑誌書製門係";

        public static string GetFilesRecursive(string folder, List<string> formats, List<string> excludes, List<FileInfo> res, int minSize = 0)
        {
            try
            {
                var files = Directory.GetFiles(folder);
                var dirs = Directory.GetDirectories(folder);

                foreach (var file in files)
                {
                    var f = new FileInfo(file);

                    if (formats.Contains(f.Extension.ToLower()))
                    {
                        if (minSize > 0)
                        {
                            if (f.Length >= minSize * 1024 * 1024)
                            {
                                res.Add(f);
                            }
                        }
                        else
                        {
                            res.Add(f);
                        }
                    }
                }

                foreach (var dir in dirs)
                {
                    if (!excludes.Contains(dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)))
                    {
                        GetFilesRecursive(dir, formats, excludes, res, minSize);
                    }
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }

            return "";
        }

        public static string ReadFile(string location)
        {
            StringBuilder sb = new StringBuilder();

            if (File.Exists(location))
            {
                StreamReader sr = new StreamReader(location);

                while (!sr.EndOfStream)
                {
                    sb.Append(sr.ReadLine());
                }

                sr.Close();
            }

            return sb.ToString();
        }

        public static void WriteFile(string content, string location)
        {
            if (!File.Exists(location))
            {
                File.Create(location).Close();
            }

            StreamWriter sw = new StreamWriter(location);

            sw.WriteLine(content);

            sw.Close();
        }

        public static List<string> GetPrefix(List<AV> avs)
        {
            List<string> res = new List<string>();

            foreach (var av in avs)
            {
                var temp = av.ID.Substring(0, av.ID.IndexOf("-"));

                if (!res.Contains(temp))
                {
                    res.Add(temp);
                }
            }

            return res;
        }

        public static string GetSuggestName(string ori, string pre)
        {
            int index = ori.IndexOf(pre) + pre.Length;
            var subStr = ori.Substring(index);

            if (subStr.Length > 0)
            {
                bool hasDash = subStr[0] == '-' ? true : false;
                int newIndex = 0;
                StringBuilder sb = new StringBuilder();

                if (hasDash)
                {
                    newIndex = index + 1;
                }
                else
                {
                    newIndex = index;
                }

                for (int i = newIndex; i < ori.Length; i++)
                {
                    if (ori[i] >= '0' && ori[i] <= '9')
                    {
                        sb.Append(ori[i].ToString());
                    }
                    else
                    {
                        break;
                    }
                }
                return pre + "-" + sb.ToString();
            }

            return pre + "-";
        }

        public static List<string> GetPossibleID(Scan scan, List<string> prefix)
        {
            List<AV> res = new List<AV>();
            List<string> possibleID = new List<string>();

            foreach (var pre in prefix.OrderByDescending(x=>x.Length))
            {
                var fileName = scan.FileName.Substring(0, scan.FileName.LastIndexOf("."));

                if (fileName.Contains(pre))
                {
                    var possible = GetSuggestName(fileName, pre);

                    if (!string.IsNullOrEmpty(possible.Split('-')[1]))
                    {
                        possibleID.Add(possible);
                    }
                }
            }

            return possibleID;
        }

        public static void GetSupportFiles(string folder, List<string> excludes, List<string> formats, List<FileInfo> res)
        {
            var files = Directory.GetFiles(folder);
            var dirs = Directory.GetDirectories(folder);

            foreach (var file in files)
            {
                var f = new FileInfo(file);

                if (formats.Contains(f.Extension.ToLower()) && f.Length >= 1000 * 1000 * 100 * 3)
                {
                    res.Add(f);
                }
            }

            foreach (var dir in dirs)
            {
                if (!excludes.Contains(dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)))
                {
                    GetSupportFiles(dir, excludes, formats, res);
                }
            }
        }

        public static string ReplaceInvalidChar(string str)
        {
            return str.Replace("'","").Replace("?","").Replace(":","").Replace("*","").Replace("|","").Replace("\\","").Replace("/", "").Replace("<", "").Replace(">", "").Replace (" （ブルーレイディスク）","").Replace("（ブルーレイディスク）", "").Replace("・", "").Replace("♪", "").Replace("´", "").Replace("′","").Replace("｀", "").Replace("◯", "").Replace("?", "").Replace("≪", "").Replace("≫", "").Replace("｢", "").Replace("｣", "").Replace("〜", "").Replace("･", "").Replace("∀", "").Replace("○", "").Replace("～", "").Replace("♯", "").Replace("､", "").Replace("━", "").Replace("ﾟ", "").Replace("｡", "").Replace("⇒", "").Replace("⇔", "").Replace("ｷ", "").Replace("ﾀ", "");
        }

        public static bool HasInvalidChar(string str)
        {         
            return str.Contains("'") || str.Contains("?") || str.Contains(":") || str.Contains("*") || str.Contains("|") || str.Contains("\\") || str.Contains("/") || str.Contains("<") || str.Contains(">") || str.Contains(" （ブルーレイディスク）") || str.Contains("（ブルーレイディスク）") || str.Contains("′") || str.Contains("・") || str.Contains("♪") || str.Contains("´") || str.Contains("｀") || str.Contains("◯") || str.Contains("?") || str.Contains("≪") || str.Contains("≫") || str.Contains("｢") || str.Contains("｣") || str.Contains("〜") || str.Contains("･") || str.Contains("∀") || str.Contains("○") || str.Contains("～") || str.Contains("♯") || str.Contains("､") || str.Contains("━") || str.Contains("ﾟ") || str.Contains("｡") || str.Contains("⇒") || str.Contains("⇔") || str.Contains("ｷ") || str.Contains("ﾀ");
        }

        public static string SecondToHour(double time)
        {
            string str = "";
            int hour = 0;
            int minute = 0;
            int second = 0;
            second = Convert.ToInt32(time);

            if (second > 60)
            {
                minute = second / 60;
                second = second % 60;
            }
            if (minute > 60)
            {
                hour = minute / 60;
                minute = minute % 60;
            }
            return (hour + "小时" + minute + "分钟"
                + second + "秒");
        }

        public static List<string> GetInvalidChar()
        {
            List<string> ret = new List<string>();

            ret.Add("'");
            ret.Add("?");
            ret.Add(":");
            ret.Add("*");
            ret.Add("|");
            ret.Add("\\");
            ret.Add("/");
            ret.Add("<");
            ret.Add(">");

            return ret;
        }

        public static string CombineISOVideos(string ffmpegLocation, string command_line)
        {
            var message = "";

            ExcuteProcess(ffmpegLocation, command_line, (s, t) => message += (t.Data));

            return message;
        }

        public static void ConvertVideo(string exe, string strArg)
        {
            Process p = new Process();//建立外部调用线程
            p.StartInfo.FileName = exe;//要调用外部程序的绝对路径
            p.StartInfo.Arguments = strArg;
            p.StartInfo.UseShellExecute = false;//不使用操作系统外壳程序启动线程(一定为FALSE,详细的请看MSDN)
            p.StartInfo.RedirectStandardError = true;//把外部程序错误输出写到StandardError流中(这个一定要注意,FFMPEG的所有输出信息,都为错误输出流,用StandardOutput是捕获不到任何消息的...这是我耗费了2个多月得出来的经验...mencoder就是用standardOutput来捕获的)
            p.StartInfo.CreateNoWindow = false;//不创建进程窗口
            p.ErrorDataReceived += new DataReceivedEventHandler(Output);//外部程序(这里是FFMPEG)输出流时候产生的事件,这里是把流的处理过程转移到下面的方法中,详细请查阅MSDN
            p.Start();//启动线程
            p.BeginErrorReadLine();//开始异步读取
            p.WaitForExit();//阻塞等待进程结束
            p.Close();//关闭进程
            p.Dispose();//释放资源
        }

        private static void Output(object sendProcess, DataReceivedEventArgs output)
        {
            if (!String.IsNullOrEmpty(output.Data))
            {
                Console.WriteLine(output.Data);
            }
        }

        public static void ExcuteProcess(string exe, string arg, DataReceivedEventHandler output)
        {
            using (var p = new Process())
            {
                p.StartInfo.FileName = exe;
                p.StartInfo.Arguments = arg;

                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.RedirectStandardOutput = true;

                p.OutputDataReceived += output;
                p.ErrorDataReceived += output;

                p.Start();
                p.BeginOutputReadLine();
                p.BeginErrorReadLine();
                p.WaitForExit();
                p.Close();
                p.Dispose();
            }
        }

        public async static Task ExcuteProcessAsync(string exe, string arg, DataReceivedEventHandler output)
        {
            using (var p = new Process())
            {
                p.StartInfo.FileName = exe;
                p.StartInfo.Arguments = arg;

                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.RedirectStandardOutput = true;

                p.OutputDataReceived += output;
                p.ErrorDataReceived += output;

                p.Start();
                p.BeginOutputReadLine();
                p.BeginErrorReadLine();
                await p.WaitForExitAsync();
            }
        }

        public static string GetFileName(string fullName, bool extension)
        {
            FileInfo f = new FileInfo(fullName);
            if (extension)
            {
                return f.Name;
            }
            else
            {
                return f.Name.Replace(f.Extension, "").ToLower();
            }
        }

        public static string GetDuration(string fName, string ffmpegLocation)
        {
            string duration = "";

            try
            {
                string fullName = fName;
                string fileName = GetFileName(fName, false);
                string command_line = " -i \"" + fullName + "\"";

                ExcuteProcess(ffmpegLocation, command_line, (s, t) => duration += (t.Data));

                duration = duration.Substring(duration.IndexOf("Duration") + 10);
                duration = duration.Substring(0, duration.IndexOf(","));

                var hour = int.Parse(duration.Split(':')[0]);
                var min = int.Parse(duration.Split(':')[1]);
                var sec = int.Parse(duration.Split(':')[2].Substring(0, duration.Split(':')[2].IndexOf(".")));              
            }
            catch (Exception ee)
            {
                return "-";
            }
            return duration;
        }

        public async static Task<string> GetFfmpegInfo(string fName, string ffmpegLocation)
        {
            string info = "";

            try
            {
                string fullName = fName;
                string command_line = " -i \"" + fullName + "\"";

                await ExcuteProcessAsync(ffmpegLocation, command_line, (s, t) => info += (t.Data));
            }
            catch (Exception ee)
            {
                return "";
            }

            return info;
        }

        public async static Task<bool> IsH265(string fName, string ffmpegLocation)
        {
            bool ret = false;

            var info = await GetFfmpegInfo(fName, ffmpegLocation);

            info = info.Substring(info.IndexOf("Video: "));
            info = info.Substring(0, info.IndexOf(","));

            if (info.Contains("hevc"))
            {
                ret = true;
            }

            return ret;
        }

        public static int GetThumbnails(string fName, string ffmpegLocation, string whereToSave, string subFolder, int howManyPictures, bool size, int width = 320, int height = 240)
        {
            int result = 0;

            try
            {
                string fullName = fName;
                string fileName = GetFileName(fName, false);
                string command_line = " -i \"" + fullName + "\"";
                string duration = "";

                if (!Directory.Exists(whereToSave))
                {
                    Directory.CreateDirectory(whereToSave);
                }


                if (!Directory.Exists(whereToSave + "\\" + subFolder))
                {
                    Directory.CreateDirectory(whereToSave + "\\" + subFolder);
                }

                ExcuteProcess(ffmpegLocation, command_line, (s, t) => duration += (t.Data));

                duration = duration.Substring(duration.IndexOf("Duration") + 10);
                duration = duration.Substring(0, duration.IndexOf(","));

                var hour = int.Parse(duration.Split(':')[0]);
                var min = int.Parse(duration.Split(':')[1]);
                var sec = int.Parse(duration.Split(':')[2].Substring(0, duration.Split(':')[2].IndexOf(".")));

                var totalSec = hour * 3600 + min * 60 + sec;

                var diff = totalSec / (howManyPictures + 1);

                List<int> frame = new List<int>();

                for (int i = 1; i <= howManyPictures; i++)
                {
                    frame.Add(diff * i);
                }

                int currentIndex = 1;

                foreach (var item in frame)
                {
                    if (File.Exists(whereToSave + "\\" + subFolder + "\\" + currentIndex + ".jpg"))
                    {
                        File.Delete(whereToSave + "\\" + subFolder + "\\" + currentIndex + ".jpg");
                    }

                    string screenLine = "";

                    if (size)
                    {
                        screenLine = "-ss " + item + " -i \"" + fullName + "\" -s " + width + "x" + height + " -vframes 1 \"" + whereToSave + "\\" + subFolder + "\\" + currentIndex + ".jpg\"";
                    }
                    else
                    {
                        screenLine = "-ss " + item + " -i \"" + fullName + "\" -vframes 1 \"" + whereToSave + "\\" + subFolder + "\\" + currentIndex + ".jpg\"";
                    }

                    result++;
                    currentIndex++;

                    ExcuteProcess(ffmpegLocation, screenLine, (s, t) => duration = (t.Data));
                }
            }
            catch (Exception)
            {
                return 0;
            }
            return result;
        }

        public static Dictionary<string, List<FileInfo>> GetCheckDuplicatedData(string folder)
        {
            Dictionary<string, List<FileInfo>> res = new Dictionary<string, List<FileInfo>>();

            if (Directory.Exists(folder))
            {
                var files = Directory.GetFiles(folder);

                foreach (var file in files)
                {
                    var split = file.Split('-');
                    if (split.Length >= 3)
                    {
                        var key = split[0] + "-" + split[1];

                        if (res.ContainsKey(key))
                        {
                            res[key].Add(new FileInfo(file));
                        }
                        else
                        {
                            res.Add(key, new List<FileInfo> { new FileInfo(file) });
                        }
                    }
                }
            }
            return res;
        }

        public static double GetVideoDuration(string file)
        {
            MediaPlayer.MediaPlayer media = new MediaPlayer.MediaPlayer();
            media.Open(file);

            Thread.Sleep(600);

            var duration = media.Duration;

            return duration;
        }

        public static void PlayVideo(string file)
        {
            System.Diagnostics.Process.Start(@"" + file);
        }

        public static string GetImageFile(string folder, AV av)
        {
            var file = folder + av.ID + av.Name + ".jpg";

            if (File.Exists(file))
            {
                return file;
            }
            else
            {
                return "";
            }
        }

        public static decimal GetCloseRation(string current, string target)
        {
            int len1 = current.Length;
            var len2 = target.Length;

            int[,] dif = new int[len1 + 1, len2 + 1];

            for (int i = 0; i < len1; i++)
            {
                dif[i, 0] = i;
            }

            for (int i = 0; i < len2; i++)
            {
                dif[0, i] = i;
            }

            int temp;

            for (int i = 1; i <= len1; i++)
            {
                for (int j = 1; j <= len2; j++)
                {
                    if (current[i - 1] == target[j - 1])
                    {
                        temp = 0;
                    }
                    else
                    {
                        temp = 1;
                    }

                    dif[i, j] = min(dif[i - 1, j - 1] + temp, dif[i, j - 1] + 1, dif[i - 1, j] + 1);
                }
            }

            var diff = (decimal)dif[len1, len2] / Math.Max(current.Length, target.Length);
            var similarity = (decimal)1 - diff;

            return similarity;
        }

        public static string GetJianTiStr(string fanTi)
        {
            string rest = fanTi;

            for (int i = 0; i < fanTi.Length; i++)
            {
                for (int j = 0; j < Fan.Length; j++)
                {
                    if (fanTi[i] == Fan[j])
                    {
                        rest = rest.Replace(fanTi[i], Jian[j]);
                    }
                }
            }

            return rest;
        }

        public static Dictionary<string, string> GetJavBusToJavLibraryCategoryMapping(string file)
        {
            Dictionary<string, string> ret = new Dictionary<string, string>();

            if (File.Exists(file))
            {
                StreamReader sr = new StreamReader(file);

                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var split = line.Split(' ');

                    if (split.Length == 2)
                    {
                        ret.Add(split[0], split[1]);
                    }
                }
            }

            return ret;
        }

        public static string ConcatVideos(List<string> videos, string file, string ffmpegLocation)
        {
            string command_line = string.Format("-i \"concat:{0}\" -c copy {1}", string.Join("|", videos), file);
            string result = "";

            ExcuteProcess(ffmpegLocation, command_line, (s, t) => result += (t.Data));

            return result;
        }

        public static string GetRealAVName(string fileName)
        {
            StringBuilder sb = new StringBuilder();

            var split = fileName.Split('-');

            foreach (var sp in split)
            {
                if (sp.Length > 1)
                {
                    sb.Append(sp + "-");
                }
            }

            return sb.ToString().Substring(0, sb.Length - 1);
        }

        public static int ConvertDurationToInt(string duration)
        {
            int ret = 0;
            try
            {
                int hour = 0;
                int minute = 0;
                int second = 0;

                var strArray = duration.Split(':');
                if (strArray.Length == 3)
                {
                    var secondArray = strArray[2].Split('.');
                    hour = int.Parse(strArray[0]) * 3600;
                    minute = int.Parse(strArray[1]) * 60;

                    if (secondArray.Length == 2)
                    {
                        second = int.Parse(secondArray[0]);
                    }
                }

                ret += hour;
                ret += minute;
                ret += second;
            }
            catch (Exception ee)
            {
                ret = 0;
            }

            return ret;
        }

        public static Dictionary<string, List<string>> GetVideoHasMultipleEpisode(string path)
        {
            Dictionary<string, List<string>> tempRet = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> ret = new Dictionary<string, List<string>>();

            if (Directory.Exists(path))
            {
                var files = Directory.GetFiles(path);

                files = files.Where(x => !x.Contains("NoMerge")).ToArray();

                tempRet = files.GroupBy(x => x.Split('-')[0] + "-" + x.Split('-')[1]).ToDictionary(x => x.Key, x => x.ToList());

                foreach (var r in tempRet)
                {
                    if (r.Value.Count > 1)
                    {
                        var maxL = r.Value.Max(x => x.Length);
                        var minL = r.Value.Min(x => x.Length);

                        if (maxL - minL <= 3)
                        {
                            ret.Add(r.Key, r.Value);
                        }
                    }
                }
            }

            return ret;
        }

        public static double GetFileSizeFromString(string str)
        {
            double ret = 0;
            str = str.ToLower();

            if (str.Contains("mb") || str.Contains("mib"))
            {
                str = str.Replace("mb", "").Replace("mib","");

                if (str.Contains("."))
                {
                    var strArray = str.Split('.');

                    ret += double.Parse(strArray[0]) * 1024 * 1024;

                    var littleAttar = strArray[1].Trim().ToCharArray();
                    int index = 100;

                    foreach (var c in littleAttar)
                    {
                        ret += double.Parse(c.ToString()) * index * 1024;

                        index /= 10;
                    }
                }
                else
                {
                    ret += double.Parse(str) * 1024 * 1024;
                }
            }
            else if (str.Contains("gb") || str.Contains("gib"))
            {
                str = str.Replace("gb", "").Replace("gib", "");

                if (str.Contains("."))
                {
                    var strArray = str.Split('.');

                    ret += double.Parse(strArray[0]) * 1024 * 1024 * 1024;

                    var littleAttar = strArray[1].Trim().ToCharArray();
                    int index = 100;

                    foreach (var c in littleAttar)
                    {
                        ret += double.Parse(c.ToString()) * index * 1024 * 1024;

                        index /= 10;
                    }
                }
                else
                {
                    ret += double.Parse(str) * 1024 * 1024 * 1024;
                }
            }

            return ret;
        }

        public static Dictionary<string, string> GetOriAvFileName(string input)
        {
            Dictionary<string, string> pair = new Dictionary<string, string>();

            if (input.Contains("-"))
            {
                FileInfo fi = new FileInfo(input);
                var name = fi.Name.Replace(fi.Extension, "").ToLower();
                var splitArray = name.Split('-');

                if (splitArray.Length <= 3)
                {
                    pair.Add(splitArray[0] + "-" + splitArray[1], splitArray.Length == 3 ? splitArray[2] : "");
                }
                else
                {
                    if (splitArray[3] == "c" || splitArray[3] == "1" || splitArray[3] == "2" || splitArray[3] == "3" || splitArray[3] == "4" || splitArray[3] == "5" || splitArray[3] == "6" || splitArray[3] == "7" || splitArray[3] == "8" )
                    {
                        pair.Add(splitArray[0] + "-" + splitArray[1], splitArray[2]);
                    }
                    else
                    {
                        string ret = splitArray[2];

                        for (int i = 3; i < splitArray.Length; i++)
                        {
                            if (splitArray[i] != "c" && splitArray[i] != "1" && splitArray[i] != "2" && splitArray[i] != "3" && splitArray[i] != "4" && splitArray[i] != "5" && splitArray[i] != "6" && splitArray[i] != "7" && splitArray[i] != "8")
                            {
                                ret = ret + "-" + splitArray[i];
                            }
                            else
                            {
                                break;
                            }
                        }

                        pair.Add(splitArray[0] + "-" + splitArray[1], ret);
                    }
                }
            }

            return pair;
        }

        public static string WriteMetaData(AV av, string file, string pre, int epi = 0, int count = 1, string lang = "Japanese")
        {
            string ret = "";

            try
            {
                var tfile = TagLib.File.Create(file);

                var reasons = tfile.CorruptionReasons;

                if (reasons.Any())
                {
                    var first = reasons.FirstOrDefault();
                }

                tfile.Tag.Title = av.Name;
                tfile.Tag.TitleSort = av.ID;

                if (epi > 0)
                {
                    tfile.Tag.Disc = (uint)epi;
                    tfile.Tag.DiscCount = (uint)count;
                }

                tfile.Tag.Lyrics = lang;

                tfile.Tag.AlbumArtists = av.Actress.Split(',').Where(x => !string.IsNullOrEmpty(x)).ToArray();
                tfile.Tag.Genres = av.Category.Split(',').Where(x => !string.IsNullOrEmpty(x)).ToArray();
                tfile.Tag.Composers = av.Director.Split(',').Where(x => !string.IsNullOrEmpty(x)).ToArray();
                tfile.Tag.Year = (uint)av.ReleaseDate.Year;
                tfile.Tag.Album = pre;
                tfile.Tag.Comment = av.URL;
                tfile.Save();

                ret = "";
            }
            catch (Exception ee)
            {
                ret = ee.ToString();
            }

            return ret;
        }

        public static string getMD5Hash(string pathName)
        {
            string strResult = "";
            string strHashData = "";
            byte[] arrbytHashValue;

            FileStream oFileStream = null;
            System.Security.Cryptography.MD5CryptoServiceProvider oMD5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();

            try
            {
                oFileStream = new FileStream(pathName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                arrbytHashValue = oMD5Hasher.ComputeHash(oFileStream);//计算指定Stream 对象的哈希值
                oFileStream.Close();

                //由以连字符分隔的十六进制对构成的String，其中每一对表示value 中对应的元素；例如“F-2C-4A”
                strHashData = System.BitConverter.ToString(arrbytHashValue);
                //替换-
                strHashData = strHashData.Replace("-", "");
                strResult = strHashData;
            }
            catch (Exception ex)
            {

            }

            return strResult;
        }

        public static ValueTuple<Dictionary<string, string>, Dictionary<string, List<string>>> GetMagUrlOfUnmatchedFile(string dri)
        {
            ValueTuple<Dictionary<string, string>, Dictionary<string, List<string>>> ret = new ValueTuple<Dictionary<string, string>, Dictionary<string, List<string>>>();
            Dictionary<string, string> temp = new Dictionary<string, string>();
            List<string> multiple = new List<string>();
            Dictionary<string, List<string>> multipleResult = new Dictionary<string, List<string>>();

            var folder = "";

            if (dri.EndsWith("\\") || dri.EndsWith("/"))
            {
                folder = dri;
            }
            else
            {
                folder = dri + "\\";
            }

            if (Directory.Exists(folder))
            {
                var files = Directory.GetFiles(folder);

                foreach (var file in files)
                {
                    FileInfo fi = new FileInfo(file);

                    if (fi.Extension.ToLower() == ".iso" || fi.Extension.ToLower() == ".vob" || fi.Extension.ToLower() == ".rmvb" || fi.Extension.ToLower() == ".rm")
                    {
                        var nameArray = fi.Name.Split('-');
                        if (nameArray.Length >= 3)
                        {
                            var searchContent = nameArray[0] + "-" + nameArray[1];

                            temp.Add(fi.FullName, searchContent);
                        }
                    }

                    if (fi.Name.Contains("NoMerge"))
                    {
                        multiple.Add(fi.FullName);
                    }
                }

                var tempRet = files.GroupBy(x => x.Split('-')[0] + "-" + x.Split('-')[1]).ToDictionary(x => x.Key, x => x.ToList());

                foreach (var r in tempRet)
                {
                    if (r.Value.Count > 1)
                    {
                        var maxL = r.Value.Max(x => x.Length);
                        var minL = r.Value.Min(x => x.Length);

                        if (maxL - minL <= 3)
                        {
                            multipleResult.Add(r.Key, r.Value);
                        }
                    }
                }

                ret.Item1 = temp;
                ret.Item2 = multipleResult;
            }

            return ret;
        }

        public static Dictionary<string, List<FileInfo>> GetAllPossibleRedundant(bool returnAll = false)
        {
            Dictionary<string, List<FileInfo>> ret = new Dictionary<string, List<FileInfo>>();

            string[] drivers = Environment.GetLogicalDrives();

            foreach (var dri in drivers)
            {
                var folder = dri + "\\fin\\";

                if (Directory.Exists(folder))
                {
                    DirectoryInfo DirInfo = new DirectoryInfo(folder);
                    DirInfo.Attributes = FileAttributes.Normal & FileAttributes.Directory;

                    var files = Directory.GetFiles(folder);
                    foreach (var file in files)
                    {
                        FileInfo fi = new FileInfo(file);
                        var nameArray = fi.Name.Split('-');

                        if (nameArray.Length >= 3 && !fi.Name.Contains("-NoMerge"))
                        {
                            var key = nameArray[0] + "-" + nameArray[1];

                            if (ret.ContainsKey(key))
                            {
                                ret[key].Add(fi);
                            }
                            else
                            {
                                ret.Add(key, new List<FileInfo> { fi });
                            }
                        }
                    }
                }
            }

            return returnAll ? ret : ret.Where(x=>x.Value.Count > 1).ToDictionary(x => x.Key, x => x.Value);
        }

        private static int min(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }

        public static void CollectExistAvFile(string FFmpeg, DateTime date)
        {
            List<AvInfo> infos = new List<AvInfo>();
            List<FileInfo> fInfos = new List<FileInfo>();

            foreach (var drive in Environment.GetLogicalDrives())
            {
                var targetFolder = drive + "\\fin\\";

                if (Directory.Exists(targetFolder))
                {
                    fInfos.AddRange(new DirectoryInfo(targetFolder).GetFiles());
                }
            }

            foreach (var fi in fInfos)
            {
                CollectExistAvInfo(infos, fi, FFmpeg);
            }

            var fileName = "G:\\AllScan" + date.ToString("yyyyMMdd") + ".json";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);

                Thread.Sleep(100);
            }
            File.Create(fileName).Close();
            StreamWriter sw = new StreamWriter(fileName);
            sw.WriteLine(JsonConvert.SerializeObject(infos));
            sw.Close();
        }

        public async static void CollectExistAvInfo(List<AvInfo> infos, FileInfo info, string ffmpeg)
        {
            AvInfo i = new AvInfo();

            i.Location = info.DirectoryName;
            i.Name = info.Name.Replace(info.Extension, "");
            i.Extension = info.Extension;
            i.Size = info.Length;
            i.IsChinese = (i.Name.EndsWith("-C") || i.Name.EndsWith("-c"));
            i.CreateTime = i.CreateTime;

            try
            {
                //i.IsH265 = await FileUtility.IsH265(info.FullName, ffmpeg);
            }
            catch (Exception ee)
            {

            }

            infos.Add(i);
        }
    }

    public static class ProcessExtensions
    {
        public static Task WaitForExitAsync(this Process process, CancellationToken cancellationToken = default(CancellationToken))
        {
            var tcs = new TaskCompletionSource<object>();
            process.EnableRaisingEvents = true;
            process.Exited += (sender, args) => tcs.TrySetResult(null);
            if (cancellationToken != default(CancellationToken))
            {
                cancellationToken.Register(tcs.SetCanceled);
            }

            return tcs.Task;
        }
    }
}

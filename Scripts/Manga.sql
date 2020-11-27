USE [master]
GO
/****** Object:  Database [Manga]    Script Date: 11/27/2020 5:06:16 PM ******/
CREATE DATABASE [Manga]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Manga', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Manga.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Manga_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Manga_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Manga] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Manga].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Manga] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Manga] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Manga] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Manga] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Manga] SET ARITHABORT OFF 
GO
ALTER DATABASE [Manga] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Manga] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Manga] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Manga] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Manga] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Manga] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Manga] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Manga] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Manga] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Manga] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Manga] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Manga] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Manga] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Manga] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Manga] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Manga] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Manga] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Manga] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Manga] SET  MULTI_USER 
GO
ALTER DATABASE [Manga] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Manga] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Manga] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Manga] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Manga] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Manga] SET QUERY_STORE = OFF
GO
USE [Manga]
GO
/****** Object:  Table [dbo].[MangaCategory]    Script Date: 11/27/2020 5:06:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MangaCategory](
	[MangaCategoryId] [int] IDENTITY(1,1) NOT NULL,
	[SourceType] [int] NOT NULL,
	[RootCategory] [nvarchar](50) NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
	[Url] [nvarchar](1000) NOT NULL,
 CONSTRAINT [PK_MangaCategory] PRIMARY KEY CLUSTERED 
(
	[MangaCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Manga] SET  READ_WRITE 
GO

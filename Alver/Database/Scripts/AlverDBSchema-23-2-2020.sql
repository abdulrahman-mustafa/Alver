USE [master]
GO
/****** Object:  Database [Alver]    Script Date: 2/23/2020 11:39:43 AM ******/
CREATE DATABASE [Alver]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Alver', FILENAME = N'D:\CodeBase\Alver\Alver\Database\Alver.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Alver_log', FILENAME = N'D:\CodeBase\Alver\Alver\Database\Alver_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Alver] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Alver].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Alver] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Alver] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Alver] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Alver] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Alver] SET ARITHABORT OFF 
GO
ALTER DATABASE [Alver] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Alver] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Alver] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Alver] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Alver] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Alver] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Alver] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Alver] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Alver] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Alver] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Alver] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Alver] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Alver] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Alver] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Alver] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Alver] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Alver] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Alver] SET RECOVERY FULL 
GO
ALTER DATABASE [Alver] SET  MULTI_USER 
GO
ALTER DATABASE [Alver] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Alver] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Alver] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Alver] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Alver] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Alver', N'ON'
GO
ALTER DATABASE [Alver] SET QUERY_STORE = OFF
GO
USE [Alver]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Alver]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AccountGroupId] [int] NULL,
	[FullName] [nvarchar](100) NULL,
	[Father] [nvarchar](50) NULL,
	[Mother] [nvarchar](50) NULL,
	[IdNumber] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[CountryId] [int] NULL,
	[CityId] [int] NULL,
	[Address] [nvarchar](500) NULL,
	[Declaration] [nvarchar](500) NULL,
	[Deactivated] [bit] NULL,
	[UserId] [int] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[GUID] [uniqueidentifier] ROWGUIDCOL  NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccountFund]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountFund](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AccountId] [int] NULL,
	[FundTitle] [nvarchar](250) NULL,
	[CurrencyId] [int] NULL,
	[Balance] [money] NULL,
	[BalanceDirection] [nvarchar](10) NULL,
	[Declaration] [nvarchar](500) NULL,
	[UserId] [int] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[GUID] [uniqueidentifier] ROWGUIDCOL  NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_AccountFund] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccountGroup]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountGroup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GroupTitle] [nvarchar](50) NULL,
	[GroupColor] [int] NULL,
	[GroupIcon] [varbinary](max) NULL,
	[Declaration] [nvarchar](500) NULL,
	[UserId] [int] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[GUID] [uniqueidentifier] NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_AccountGroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppSettings]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppSettings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NULL,
	[Motto] [nvarchar](150) NULL,
	[Phone] [nvarchar](50) NULL,
	[Address] [nvarchar](max) NULL,
	[Notes] [nvarchar](max) NULL,
	[Logo] [varbinary](max) NULL,
	[Manager] [nvarchar](100) NULL,
	[Accountant] [nvarchar](100) NULL,
	[Helper] [nvarchar](100) NULL,
	[UserId] [int] NULL,
	[GUID] [uniqueidentifier] ROWGUIDCOL  NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_AppSettings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BillType] [nvarchar](10) NULL,
	[AccountId] [int] NULL,
	[BillDate] [datetime] NULL,
	[CurrencyId] [int] NULL,
	[BillAmount] [money] NULL,
	[DiscountAmount] [money] NULL,
	[TotalAmount] [money] NULL,
	[Declaration] [nvarchar](500) NULL,
	[UserId] [int] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[GUID] [uniqueidentifier] NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillLines]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillLines](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BillId] [int] NULL,
	[ItemId] [int] NULL,
	[UnitId] [int] NULL,
	[Quantity] [money] NULL,
	[CurrencyId] [int] NULL,
	[Price] [money] NULL,
	[TotalPrice] [money] NULL,
	[UserId] [int] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[GUID] [uniqueidentifier] NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_BillLines] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Currency]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Currency](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CurrencyName] [nvarchar](50) NULL,
	[CurrencySymbol] [nvarchar](3) NULL,
	[CurrencyCode] [nvarchar](3) NULL,
	[BaseCurrency] [bit] NULL,
	[ExchangeRate] [money] NULL,
	[Notes] [nvarchar](100) NULL,
	[UserId] [int] NULL,
	[GUID] [uniqueidentifier] ROWGUIDCOL  NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Currency] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CurrencyBulletin]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurrencyBulletin](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RateDate] [datetime] NULL,
	[CurrencyId] [int] NULL,
	[Rate] [money] NULL,
	[ReversedRate] [money] NULL,
	[TOUSD] [bit] NULL,
	[GUID] [uniqueidentifier] NULL,
 CONSTRAINT [PK_CurrencyBulletin] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CurrencyExchange]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurrencyExchange](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ExchangeType] [nvarchar](50) NULL,
	[ExchangeDate] [datetime] NULL,
	[Declaration] [nvarchar](500) NULL,
	[UserId] [int] NULL,
	[GUID] [uniqueidentifier] ROWGUIDCOL  NULL,
	[Flag] [nvarchar](50) NULL,
	[Hidden] [bit] NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_CurrencyExchanges] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CurrencyExchangeOperations]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurrencyExchangeOperations](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ExchangeId] [bigint] NULL,
	[OpreationDate] [datetime] NULL,
	[Direction] [nvarchar](50) NULL,
	[BaseCurrencyId] [int] NULL,
	[BaseAmount] [money] NULL,
	[SubCurrencyId] [int] NULL,
	[Factor] [nvarchar](10) NULL,
	[Rate] [money] NULL,
	[SubAmount] [money] NULL,
	[RoundAmount] [money] NULL,
	[Declaration] [nvarchar](100) NULL,
	[UserId] [int] NULL,
	[GUID] [uniqueidentifier] ROWGUIDCOL  NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_CurrencyExchangeOperations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exchange]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exchange](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ExchangeDate] [datetime] NULL,
	[Direction] [nvarchar](50) NULL,
	[BaseCurrencyId] [int] NULL,
	[BaseAmount] [money] NULL,
	[SubCurrencyId] [int] NULL,
	[Factor] [nvarchar](10) NULL,
	[Rate] [money] NULL,
	[SubAmount] [money] NULL,
	[RoundAmount] [money] NULL,
	[Declaration] [nvarchar](100) NULL,
	[UserId] [int] NULL,
	[GUID] [uniqueidentifier] ROWGUIDCOL  NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Exchange] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExchangeFund]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExchangeFund](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ExchangeType] [bit] NULL,
	[ExchangeDate] [datetime] NULL,
	[CurrencyId] [int] NULL,
	[AccountFromId] [int] NULL,
	[AccountFundFromId] [int] NULL,
	[AccountToId] [int] NULL,
	[AccountFundToId] [int] NULL,
	[FromAmount] [money] NULL,
	[Factor] [bit] NULL,
	[Rate] [money] NULL,
	[ToAmount] [money] NULL,
	[Declaration] [nvarchar](500) NULL,
	[UserId] [int] NULL,
	[GUID] [uniqueidentifier] ROWGUIDCOL  NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_ExchangeFund] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expense]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expense](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ExpenseDate] [datetime] NULL,
	[CurrencyId] [int] NULL,
	[Amount] [money] NULL,
	[CategoryId] [int] NULL,
	[Declaration] [nvarchar](500) NULL,
	[UserId] [int] NULL,
	[GUID] [uniqueidentifier] ROWGUIDCOL  NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Expense] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExpenseCategory]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExpenseCategory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[Declaration] [nvarchar](500) NULL,
	[UserId] [int] NULL,
	[GUID] [uniqueidentifier] ROWGUIDCOL  NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_ExpenseCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fund]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fund](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FundTitle] [nvarchar](50) NULL,
	[CurrencyId] [int] NULL,
	[Balance] [money] NULL,
	[BalanceDirection] [nvarchar](10) NULL,
	[Declaration] [nvarchar](500) NULL,
	[UserId] [int] NULL,
	[GUID] [uniqueidentifier] ROWGUIDCOL  NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Fund] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FundTransaction]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FundTransaction](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[FundId] [int] NULL,
	[TTS] [datetime] NULL,
	[TT] [nvarchar](6) NULL,
	[CurrencyId] [int] NULL,
	[Amount] [money] NULL,
	[RunningTotal] [money] NULL,
	[Declaration] [nvarchar](1000) NULL,
	[GUID] [uniqueidentifier] NULL,
 CONSTRAINT [PK_FundTransaction] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [nvarchar](50) NULL,
	[UnitId] [int] NULL,
	[CategoryId] [int] NULL,
	[CurrencyId] [int] NULL,
	[Price] [money] NULL,
	[Barcode] [nvarchar](50) NULL,
	[Declaration] [nvarchar](500) NULL,
	[UserId] [int] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[GUID] [uniqueidentifier] NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemCategory]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemCategory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[Declaration] [nvarchar](500) NULL,
	[UserId] [int] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[GUID] [uniqueidentifier] NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_ItemCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemFund]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemFund](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NULL,
	[FundTitle] [nvarchar](250) NULL,
	[UnitId] [int] NULL,
	[Balance] [money] NULL,
	[BalanceDirection] [nvarchar](10) NULL,
	[Declaration] [nvarchar](500) NULL,
	[UserId] [int] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[GUID] [uniqueidentifier] ROWGUIDCOL  NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_ItemFund] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemTransaction]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemTransaction](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NULL,
	[TTS] [datetime] NULL,
	[TT] [nvarchar](6) NULL,
	[UnitId] [int] NULL,
	[Amount] [money] NULL,
	[RunningTotal] [money] NULL,
	[Declaration] [nvarchar](1000) NULL,
	[GUID] [uniqueidentifier] NULL,
 CONSTRAINT [PK_ItemTransaction] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PaymentType] [nvarchar](10) NULL,
	[PaymentDate] [datetime] NULL,
	[AccountId] [int] NULL,
	[CurrencyId] [int] NULL,
	[Amount] [money] NULL,
	[Declaration] [nvarchar](500) NULL,
	[Payed] [bit] NULL,
	[Locked] [bit] NULL,
	[UserId] [int] NULL,
	[GUID] [uniqueidentifier] ROWGUIDCOL  NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receipt]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receipt](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AccountId] [int] NULL,
	[ReceiptDate] [datetime] NULL,
	[ReceiptAmount] [money] NULL,
	[DiscountAmount] [money] NULL,
	[TotalAmount] [money] NULL,
	[Declaration] [nvarchar](500) NULL,
	[UserId] [int] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[GUID] [uniqueidentifier] NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Receipt] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReceiptLines]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReceiptLines](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ReceiptId] [int] NULL,
	[ItemId] [int] NULL,
	[UnitId] [int] NULL,
	[Quantity] [money] NULL,
	[Price] [money] NULL,
	[TotalPrice] [money] NULL,
	[UserId] [int] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[GUID] [uniqueidentifier] NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_ReceiptLines] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleTitle] [nvarchar](50) NULL,
	[Declaration] [nvarchar](500) NULL,
	[GUID] [uniqueidentifier] ROWGUIDCOL  NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaction]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaction](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[AccountId] [int] NULL,
	[TTS] [datetime] NULL,
	[TT] [nvarchar](6) NULL,
	[CurrencyId] [int] NULL,
	[Amount] [money] NULL,
	[RunningTotal] [money] NULL,
	[Declaration] [nvarchar](1000) NULL,
	[GUID] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transfer]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transfer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TransferDate] [datetime] NULL,
	[CurrencyId] [int] NULL,
	[ClientFrom] [int] NULL,
	[FundFrom] [int] NULL,
	[ClientTo] [int] NULL,
	[FundTo] [int] NULL,
	[FromAmount] [money] NULL,
	[Factor] [bit] NULL,
	[Rate] [money] NULL,
	[ToAmount] [money] NULL,
	[Declaration] [nvarchar](max) NULL,
	[UserId] [int] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[GUID] [uniqueidentifier] NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Transfer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[Symbol] [nvarchar](3) NULL,
	[IsDefault] [bit] NULL,
	[Declaration] [nvarchar](500) NULL,
	[UserId] [int] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[GUID] [uniqueidentifier] NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](64) NULL,
	[FullName] [nvarchar](100) NULL,
	[LoginAttempts] [int] NULL,
	[Locked] [bit] NULL,
	[Deactivated] [bit] NULL,
	[Declaration] [nvarchar](500) NULL,
	[CD] [datetime] NULL,
	[LLD] [datetime] NULL,
	[GUID] [uniqueidentifier] ROWGUIDCOL  NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Withdraw]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Withdraw](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Direction] [nvarchar](50) NULL,
	[WithdrawDate] [datetime] NULL,
	[AccountId] [int] NULL,
	[CurrencyId] [int] NULL,
	[Amount] [money] NULL,
	[Declaration] [nvarchar](max) NULL,
	[Payed] [bit] NULL,
	[Locked] [bit] NULL,
	[UserId] [int] NULL,
	[GUID] [uniqueidentifier] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Withdraw] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [DF_Accounts_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [DF_Accounts_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [DF_Accounts_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [DF_Accounts_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
GO
ALTER TABLE [dbo].[AccountFund] ADD  CONSTRAINT [DF_Accounts_Fund_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[AccountFund] ADD  CONSTRAINT [DF_Accounts_Fund_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[AccountFund] ADD  CONSTRAINT [DF_Accounts_Fund_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[AccountFund] ADD  CONSTRAINT [DF_Accounts_Fund_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
GO
ALTER TABLE [dbo].[AccountGroup] ADD  CONSTRAINT [DF_AccountGroup_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[AccountGroup] ADD  CONSTRAINT [DF_AccountGroup_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[AccountGroup] ADD  CONSTRAINT [DF_AccountGroup_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[AccountGroup] ADD  CONSTRAINT [DF_AccountGroup_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
GO
ALTER TABLE [dbo].[AppSettings] ADD  CONSTRAINT [DF_AppSettings_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[AppSettings] ADD  CONSTRAINT [DF_AppSettings_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[AppSettings] ADD  CONSTRAINT [DF_AppSettings_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[AppSettings] ADD  CONSTRAINT [DF_AppSettings_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
GO
ALTER TABLE [dbo].[BillLines] ADD  CONSTRAINT [DF_BillLines_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[BillLines] ADD  CONSTRAINT [DF_BillLines_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[BillLines] ADD  CONSTRAINT [DF_BillLines_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[BillLines] ADD  CONSTRAINT [DF_BillLines_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
GO
ALTER TABLE [dbo].[Currency] ADD  CONSTRAINT [DF_Currency_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[Currency] ADD  CONSTRAINT [DF_Currency_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[Currency] ADD  CONSTRAINT [DF_Currency_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[Currency] ADD  CONSTRAINT [DF_Currency_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
GO
ALTER TABLE [dbo].[CurrencyBulletin] ADD  CONSTRAINT [DF_CurrencyBulletin_TOUSD]  DEFAULT ((0)) FOR [TOUSD]
GO
ALTER TABLE [dbo].[CurrencyBulletin] ADD  CONSTRAINT [DF_CurrencyBulletin_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[CurrencyExchange] ADD  CONSTRAINT [DF_CurrencyExchange_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[CurrencyExchange] ADD  CONSTRAINT [DF_CurrencyExchange_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[CurrencyExchange] ADD  CONSTRAINT [DF_CurrencyExchange_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[CurrencyExchange] ADD  CONSTRAINT [DF_CurrencyExchange_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
GO
ALTER TABLE [dbo].[CurrencyExchangeOperations] ADD  CONSTRAINT [DF_CurrencyExchangeOperations_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[CurrencyExchangeOperations] ADD  CONSTRAINT [DF_CurrencyExchangeOperations_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[CurrencyExchangeOperations] ADD  CONSTRAINT [DF_CurrencyExchangeOperations_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[CurrencyExchangeOperations] ADD  CONSTRAINT [DF_CurrencyExchangeOperations_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
GO
ALTER TABLE [dbo].[Exchange] ADD  CONSTRAINT [DF_Exchange_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[Exchange] ADD  CONSTRAINT [DF_Exchange_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[Exchange] ADD  CONSTRAINT [DF_Exchange_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[Exchange] ADD  CONSTRAINT [DF_Exchange_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
GO
ALTER TABLE [dbo].[ExchangeFund] ADD  CONSTRAINT [DF_ExchangeFund_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[ExchangeFund] ADD  CONSTRAINT [DF_ExchangeFund_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[ExchangeFund] ADD  CONSTRAINT [DF_ExchangeFund_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[ExchangeFund] ADD  CONSTRAINT [DF_ExchangeFund_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
GO
ALTER TABLE [dbo].[Expense] ADD  CONSTRAINT [DF_Payments_Expense_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[Expense] ADD  CONSTRAINT [DF_Payments_Expense_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[Expense] ADD  CONSTRAINT [DF_Payments_Expense_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[Expense] ADD  CONSTRAINT [DF_Expense_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
GO
ALTER TABLE [dbo].[ExpenseCategory] ADD  CONSTRAINT [DF_Payments_ExpenseCategory_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[ExpenseCategory] ADD  CONSTRAINT [DF_Payments_ExpenseCategory_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[ExpenseCategory] ADD  CONSTRAINT [DF_Payments_ExpenseCategory_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
GO
ALTER TABLE [dbo].[Fund] ADD  CONSTRAINT [DF_Funds_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[Fund] ADD  CONSTRAINT [DF_Funds_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[Fund] ADD  CONSTRAINT [DF_Funds_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[Fund] ADD  CONSTRAINT [DF_Funds_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
GO
ALTER TABLE [dbo].[ItemCategory] ADD  CONSTRAINT [DF_ItemCategory_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[ItemCategory] ADD  CONSTRAINT [DF_ItemCategory_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[ItemCategory] ADD  CONSTRAINT [DF_ItemCategory_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[ItemCategory] ADD  CONSTRAINT [DF_ItemCategory_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
GO
ALTER TABLE [dbo].[Payment] ADD  CONSTRAINT [DF_Payment_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[Payment] ADD  CONSTRAINT [DF_Payment_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[Payment] ADD  CONSTRAINT [DF_Payment_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[Payment] ADD  CONSTRAINT [DF_Payment_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
GO
ALTER TABLE [dbo].[Receipt] ADD  CONSTRAINT [DF_Receipt_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[Receipt] ADD  CONSTRAINT [DF_Receipt_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[Receipt] ADD  CONSTRAINT [DF_Receipt_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[Receipt] ADD  CONSTRAINT [DF_Receipt_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
GO
ALTER TABLE [dbo].[ReceiptLines] ADD  CONSTRAINT [DF_ReceiptLines_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[ReceiptLines] ADD  CONSTRAINT [DF_ReceiptLines_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[ReceiptLines] ADD  CONSTRAINT [DF_ReceiptLines_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[ReceiptLines] ADD  CONSTRAINT [DF_ReceiptLines_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
GO
ALTER TABLE [dbo].[Role] ADD  CONSTRAINT [DF_Role_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[Role] ADD  CONSTRAINT [DF_Role_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[Role] ADD  CONSTRAINT [DF_Role_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[Role] ADD  CONSTRAINT [DF_Role_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
GO
ALTER TABLE [dbo].[Transfer] ADD  CONSTRAINT [DF_Transfer_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[Transfer] ADD  CONSTRAINT [DF_Transfer_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[Transfer] ADD  CONSTRAINT [DF_Transfer_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[Transfer] ADD  CONSTRAINT [DF_Transfer_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
GO
ALTER TABLE [dbo].[Unit] ADD  CONSTRAINT [DF_Unit_DefaultUnit]  DEFAULT ((0)) FOR [IsDefault]
GO
ALTER TABLE [dbo].[Unit] ADD  CONSTRAINT [DF_Unit_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[Unit] ADD  CONSTRAINT [DF_Unit_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[Unit] ADD  CONSTRAINT [DF_Unit_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[Unit] ADD  CONSTRAINT [DF_Unit_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_Users_LoginAttempts]  DEFAULT ((0)) FOR [LoginAttempts]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_Users_Locked]  DEFAULT ((0)) FOR [Locked]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_Users_Deactivated]  DEFAULT ((0)) FOR [Deactivated]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_Users_User_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_Users_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_Users_User_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_Users_User_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
GO
ALTER TABLE [dbo].[Withdraw] ADD  CONSTRAINT [DF_Withdraw_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[Withdraw] ADD  CONSTRAINT [DF_Withdraw_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[Withdraw] ADD  CONSTRAINT [DF_Withdraw_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[Withdraw] ADD  CONSTRAINT [DF_Withdraw_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
GO
ALTER TABLE [dbo].[Account]  WITH NOCHECK ADD  CONSTRAINT [FK_Account_AccountGroup] FOREIGN KEY([AccountGroupId])
REFERENCES [dbo].[AccountGroup] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Account] NOCHECK CONSTRAINT [FK_Account_AccountGroup]
GO
ALTER TABLE [dbo].[Account]  WITH NOCHECK ADD  CONSTRAINT [FK_Account_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Account] NOCHECK CONSTRAINT [FK_Account_User]
GO
ALTER TABLE [dbo].[AccountFund]  WITH NOCHECK ADD  CONSTRAINT [FK_AccountFund_Account] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Account] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[AccountFund] NOCHECK CONSTRAINT [FK_AccountFund_Account]
GO
ALTER TABLE [dbo].[AccountFund]  WITH NOCHECK ADD  CONSTRAINT [FK_AccountFund_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currency] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[AccountFund] NOCHECK CONSTRAINT [FK_AccountFund_Currency]
GO
ALTER TABLE [dbo].[Bill]  WITH NOCHECK ADD  CONSTRAINT [FK_Bill_Account] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Account] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Bill] NOCHECK CONSTRAINT [FK_Bill_Account]
GO
ALTER TABLE [dbo].[Bill]  WITH NOCHECK ADD  CONSTRAINT [FK_Bill_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currency] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Bill] NOCHECK CONSTRAINT [FK_Bill_Currency]
GO
ALTER TABLE [dbo].[Bill]  WITH NOCHECK ADD  CONSTRAINT [FK_Bill_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Bill] NOCHECK CONSTRAINT [FK_Bill_User]
GO
ALTER TABLE [dbo].[BillLines]  WITH NOCHECK ADD  CONSTRAINT [FK_BillLines_Bill] FOREIGN KEY([BillId])
REFERENCES [dbo].[Bill] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[BillLines] NOCHECK CONSTRAINT [FK_BillLines_Bill]
GO
ALTER TABLE [dbo].[BillLines]  WITH NOCHECK ADD  CONSTRAINT [FK_BillLines_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currency] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[BillLines] NOCHECK CONSTRAINT [FK_BillLines_Currency]
GO
ALTER TABLE [dbo].[BillLines]  WITH NOCHECK ADD  CONSTRAINT [FK_BillLines_Item] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Item] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[BillLines] NOCHECK CONSTRAINT [FK_BillLines_Item]
GO
ALTER TABLE [dbo].[BillLines]  WITH NOCHECK ADD  CONSTRAINT [FK_BillLines_Unit] FOREIGN KEY([UnitId])
REFERENCES [dbo].[Unit] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[BillLines] NOCHECK CONSTRAINT [FK_BillLines_Unit]
GO
ALTER TABLE [dbo].[BillLines]  WITH NOCHECK ADD  CONSTRAINT [FK_BillLines_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[BillLines] NOCHECK CONSTRAINT [FK_BillLines_User]
GO
ALTER TABLE [dbo].[Currency]  WITH NOCHECK ADD  CONSTRAINT [FK_Currency_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Currency] NOCHECK CONSTRAINT [FK_Currency_User]
GO
ALTER TABLE [dbo].[CurrencyBulletin]  WITH NOCHECK ADD  CONSTRAINT [FK_CurrencyBulletin_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currency] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CurrencyBulletin] NOCHECK CONSTRAINT [FK_CurrencyBulletin_Currency]
GO
ALTER TABLE [dbo].[CurrencyExchange]  WITH NOCHECK ADD  CONSTRAINT [FK_CurrencyExchange_Users_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CurrencyExchange] NOCHECK CONSTRAINT [FK_CurrencyExchange_Users_User]
GO
ALTER TABLE [dbo].[CurrencyExchangeOperations]  WITH NOCHECK ADD  CONSTRAINT [FK_CurrencyExchangeOperations_Currency] FOREIGN KEY([BaseCurrencyId])
REFERENCES [dbo].[Currency] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CurrencyExchangeOperations] NOCHECK CONSTRAINT [FK_CurrencyExchangeOperations_Currency]
GO
ALTER TABLE [dbo].[CurrencyExchangeOperations]  WITH NOCHECK ADD  CONSTRAINT [FK_CurrencyExchangeOperations_Currency1] FOREIGN KEY([SubCurrencyId])
REFERENCES [dbo].[Currency] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CurrencyExchangeOperations] NOCHECK CONSTRAINT [FK_CurrencyExchangeOperations_Currency1]
GO
ALTER TABLE [dbo].[CurrencyExchangeOperations]  WITH NOCHECK ADD  CONSTRAINT [FK_CurrencyExchangeOperations_CurrencyExchange1] FOREIGN KEY([ExchangeId])
REFERENCES [dbo].[CurrencyExchange] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CurrencyExchangeOperations] NOCHECK CONSTRAINT [FK_CurrencyExchangeOperations_CurrencyExchange1]
GO
ALTER TABLE [dbo].[CurrencyExchangeOperations]  WITH NOCHECK ADD  CONSTRAINT [FK_CurrencyExchangeOperations_Users_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CurrencyExchangeOperations] NOCHECK CONSTRAINT [FK_CurrencyExchangeOperations_Users_User]
GO
ALTER TABLE [dbo].[Exchange]  WITH NOCHECK ADD  CONSTRAINT [FK_Exchange_BaseCurrency] FOREIGN KEY([BaseCurrencyId])
REFERENCES [dbo].[Currency] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Exchange] NOCHECK CONSTRAINT [FK_Exchange_BaseCurrency]
GO
ALTER TABLE [dbo].[Exchange]  WITH NOCHECK ADD  CONSTRAINT [FK_Exchange_SubCurrency] FOREIGN KEY([SubCurrencyId])
REFERENCES [dbo].[Currency] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Exchange] NOCHECK CONSTRAINT [FK_Exchange_SubCurrency]
GO
ALTER TABLE [dbo].[Exchange]  WITH NOCHECK ADD  CONSTRAINT [FK_Exchange_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Exchange] NOCHECK CONSTRAINT [FK_Exchange_User]
GO
ALTER TABLE [dbo].[Exchange]  WITH NOCHECK ADD  CONSTRAINT [FK_Exchange_User1] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Exchange] NOCHECK CONSTRAINT [FK_Exchange_User1]
GO
ALTER TABLE [dbo].[ExchangeFund]  WITH NOCHECK ADD  CONSTRAINT [FK_ExchangeFund_AccountFrom] FOREIGN KEY([AccountFromId])
REFERENCES [dbo].[Account] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ExchangeFund] NOCHECK CONSTRAINT [FK_ExchangeFund_AccountFrom]
GO
ALTER TABLE [dbo].[ExchangeFund]  WITH NOCHECK ADD  CONSTRAINT [FK_ExchangeFund_AccountFundFrom] FOREIGN KEY([AccountFundFromId])
REFERENCES [dbo].[AccountFund] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ExchangeFund] NOCHECK CONSTRAINT [FK_ExchangeFund_AccountFundFrom]
GO
ALTER TABLE [dbo].[ExchangeFund]  WITH NOCHECK ADD  CONSTRAINT [FK_ExchangeFund_AccountFundTo] FOREIGN KEY([AccountFundToId])
REFERENCES [dbo].[AccountFund] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ExchangeFund] NOCHECK CONSTRAINT [FK_ExchangeFund_AccountFundTo]
GO
ALTER TABLE [dbo].[ExchangeFund]  WITH NOCHECK ADD  CONSTRAINT [FK_ExchangeFund_AccountTo] FOREIGN KEY([AccountToId])
REFERENCES [dbo].[Account] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ExchangeFund] NOCHECK CONSTRAINT [FK_ExchangeFund_AccountTo]
GO
ALTER TABLE [dbo].[ExchangeFund]  WITH NOCHECK ADD  CONSTRAINT [FK_ExchangeFund_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currency] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ExchangeFund] NOCHECK CONSTRAINT [FK_ExchangeFund_Currency]
GO
ALTER TABLE [dbo].[ExchangeFund]  WITH NOCHECK ADD  CONSTRAINT [FK_ExchangeFund_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ExchangeFund] NOCHECK CONSTRAINT [FK_ExchangeFund_User]
GO
ALTER TABLE [dbo].[Expense]  WITH NOCHECK ADD  CONSTRAINT [FK_Expense_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currency] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Expense] NOCHECK CONSTRAINT [FK_Expense_Currency]
GO
ALTER TABLE [dbo].[Expense]  WITH NOCHECK ADD  CONSTRAINT [FK_Expense_ExpenseCategory] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[ExpenseCategory] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Expense] NOCHECK CONSTRAINT [FK_Expense_ExpenseCategory]
GO
ALTER TABLE [dbo].[Expense]  WITH NOCHECK ADD  CONSTRAINT [FK_Expense_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Expense] NOCHECK CONSTRAINT [FK_Expense_User]
GO
ALTER TABLE [dbo].[ExpenseCategory]  WITH NOCHECK ADD  CONSTRAINT [FK_ExpenseCategory_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ExpenseCategory] NOCHECK CONSTRAINT [FK_ExpenseCategory_User]
GO
ALTER TABLE [dbo].[Fund]  WITH NOCHECK ADD  CONSTRAINT [FK_Fund_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currency] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Fund] NOCHECK CONSTRAINT [FK_Fund_Currency]
GO
ALTER TABLE [dbo].[Fund]  WITH NOCHECK ADD  CONSTRAINT [FK_Fund_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Fund] NOCHECK CONSTRAINT [FK_Fund_User]
GO
ALTER TABLE [dbo].[FundTransaction]  WITH NOCHECK ADD  CONSTRAINT [FK_FundTransaction_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currency] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[FundTransaction] NOCHECK CONSTRAINT [FK_FundTransaction_Currency]
GO
ALTER TABLE [dbo].[FundTransaction]  WITH NOCHECK ADD  CONSTRAINT [FK_FundTransaction_Fund] FOREIGN KEY([FundId])
REFERENCES [dbo].[Fund] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[FundTransaction] NOCHECK CONSTRAINT [FK_FundTransaction_Fund]
GO
ALTER TABLE [dbo].[Item]  WITH NOCHECK ADD  CONSTRAINT [FK_Item_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currency] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Item] NOCHECK CONSTRAINT [FK_Item_Currency]
GO
ALTER TABLE [dbo].[Item]  WITH NOCHECK ADD  CONSTRAINT [FK_Item_ItemCategory] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[ItemCategory] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Item] NOCHECK CONSTRAINT [FK_Item_ItemCategory]
GO
ALTER TABLE [dbo].[Item]  WITH NOCHECK ADD  CONSTRAINT [FK_Item_Unit] FOREIGN KEY([UnitId])
REFERENCES [dbo].[Unit] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Item] NOCHECK CONSTRAINT [FK_Item_Unit]
GO
ALTER TABLE [dbo].[Item]  WITH NOCHECK ADD  CONSTRAINT [FK_Item_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Item] NOCHECK CONSTRAINT [FK_Item_User]
GO
ALTER TABLE [dbo].[ItemCategory]  WITH NOCHECK ADD  CONSTRAINT [FK_ItemCategory_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ItemCategory] NOCHECK CONSTRAINT [FK_ItemCategory_User]
GO
ALTER TABLE [dbo].[ItemFund]  WITH NOCHECK ADD  CONSTRAINT [FK_ItemFund_Item] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Item] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ItemFund] NOCHECK CONSTRAINT [FK_ItemFund_Item]
GO
ALTER TABLE [dbo].[ItemFund]  WITH NOCHECK ADD  CONSTRAINT [FK_ItemFund_Unit] FOREIGN KEY([UnitId])
REFERENCES [dbo].[Unit] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ItemFund] NOCHECK CONSTRAINT [FK_ItemFund_Unit]
GO
ALTER TABLE [dbo].[ItemFund]  WITH NOCHECK ADD  CONSTRAINT [FK_ItemFund_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ItemFund] NOCHECK CONSTRAINT [FK_ItemFund_User]
GO
ALTER TABLE [dbo].[ItemTransaction]  WITH NOCHECK ADD  CONSTRAINT [FK_ItemTransaction_Item] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Item] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ItemTransaction] NOCHECK CONSTRAINT [FK_ItemTransaction_Item]
GO
ALTER TABLE [dbo].[ItemTransaction]  WITH NOCHECK ADD  CONSTRAINT [FK_ItemTransaction_Unit] FOREIGN KEY([UnitId])
REFERENCES [dbo].[Unit] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ItemTransaction] NOCHECK CONSTRAINT [FK_ItemTransaction_Unit]
GO
ALTER TABLE [dbo].[Payment]  WITH NOCHECK ADD  CONSTRAINT [FK_Payment_Account] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Account] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Payment] NOCHECK CONSTRAINT [FK_Payment_Account]
GO
ALTER TABLE [dbo].[Payment]  WITH NOCHECK ADD  CONSTRAINT [FK_Payment_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currency] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Payment] NOCHECK CONSTRAINT [FK_Payment_Currency]
GO
ALTER TABLE [dbo].[Payment]  WITH NOCHECK ADD  CONSTRAINT [FK_Payment_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Payment] NOCHECK CONSTRAINT [FK_Payment_User]
GO
ALTER TABLE [dbo].[Receipt]  WITH NOCHECK ADD  CONSTRAINT [FK_Receipt_Account] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Account] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Receipt] NOCHECK CONSTRAINT [FK_Receipt_Account]
GO
ALTER TABLE [dbo].[Receipt]  WITH NOCHECK ADD  CONSTRAINT [FK_Receipt_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Receipt] NOCHECK CONSTRAINT [FK_Receipt_User]
GO
ALTER TABLE [dbo].[ReceiptLines]  WITH NOCHECK ADD  CONSTRAINT [FK_ReceiptLines_Item] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Item] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ReceiptLines] NOCHECK CONSTRAINT [FK_ReceiptLines_Item]
GO
ALTER TABLE [dbo].[ReceiptLines]  WITH NOCHECK ADD  CONSTRAINT [FK_ReceiptLines_Receipt] FOREIGN KEY([ReceiptId])
REFERENCES [dbo].[Receipt] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ReceiptLines] NOCHECK CONSTRAINT [FK_ReceiptLines_Receipt]
GO
ALTER TABLE [dbo].[ReceiptLines]  WITH NOCHECK ADD  CONSTRAINT [FK_ReceiptLines_Unit] FOREIGN KEY([UnitId])
REFERENCES [dbo].[Unit] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ReceiptLines] NOCHECK CONSTRAINT [FK_ReceiptLines_Unit]
GO
ALTER TABLE [dbo].[ReceiptLines]  WITH NOCHECK ADD  CONSTRAINT [FK_ReceiptLines_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ReceiptLines] NOCHECK CONSTRAINT [FK_ReceiptLines_User]
GO
ALTER TABLE [dbo].[Transaction]  WITH NOCHECK ADD  CONSTRAINT [FK_Transaction_Account] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Account] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Transaction] NOCHECK CONSTRAINT [FK_Transaction_Account]
GO
ALTER TABLE [dbo].[Transaction]  WITH NOCHECK ADD  CONSTRAINT [FK_Transaction_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currency] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Transaction] NOCHECK CONSTRAINT [FK_Transaction_Currency]
GO
ALTER TABLE [dbo].[Transfer]  WITH NOCHECK ADD  CONSTRAINT [FK_Transfer_Account] FOREIGN KEY([ClientFrom])
REFERENCES [dbo].[Account] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Transfer] NOCHECK CONSTRAINT [FK_Transfer_Account]
GO
ALTER TABLE [dbo].[Transfer]  WITH NOCHECK ADD  CONSTRAINT [FK_Transfer_Account1] FOREIGN KEY([ClientTo])
REFERENCES [dbo].[Account] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Transfer] NOCHECK CONSTRAINT [FK_Transfer_Account1]
GO
ALTER TABLE [dbo].[Transfer]  WITH NOCHECK ADD  CONSTRAINT [FK_Transfer_AccountFund] FOREIGN KEY([FundFrom])
REFERENCES [dbo].[AccountFund] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Transfer] NOCHECK CONSTRAINT [FK_Transfer_AccountFund]
GO
ALTER TABLE [dbo].[Transfer]  WITH NOCHECK ADD  CONSTRAINT [FK_Transfer_AccountFund1] FOREIGN KEY([FundTo])
REFERENCES [dbo].[AccountFund] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Transfer] NOCHECK CONSTRAINT [FK_Transfer_AccountFund1]
GO
ALTER TABLE [dbo].[Transfer]  WITH NOCHECK ADD  CONSTRAINT [FK_Transfer_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currency] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Transfer] NOCHECK CONSTRAINT [FK_Transfer_Currency]
GO
ALTER TABLE [dbo].[Transfer]  WITH NOCHECK ADD  CONSTRAINT [FK_Transfer_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Transfer] NOCHECK CONSTRAINT [FK_Transfer_User]
GO
ALTER TABLE [dbo].[Unit]  WITH NOCHECK ADD  CONSTRAINT [FK_Unit_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Unit] NOCHECK CONSTRAINT [FK_Unit_User]
GO
ALTER TABLE [dbo].[User]  WITH NOCHECK ADD  CONSTRAINT [FK_Users_Role] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[User] NOCHECK CONSTRAINT [FK_Users_Role]
GO
ALTER TABLE [dbo].[Withdraw]  WITH NOCHECK ADD  CONSTRAINT [FK_Withdraw_Account] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Account] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Withdraw] NOCHECK CONSTRAINT [FK_Withdraw_Account]
GO
ALTER TABLE [dbo].[Withdraw]  WITH NOCHECK ADD  CONSTRAINT [FK_Withdraw_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currency] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Withdraw] NOCHECK CONSTRAINT [FK_Withdraw_Currency]
GO
ALTER TABLE [dbo].[Withdraw]  WITH NOCHECK ADD  CONSTRAINT [FK_Withdraw_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Withdraw] NOCHECK CONSTRAINT [FK_Withdraw_User]
GO
/****** Object:  StoredProcedure [dbo].[CreateClientFunds]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[CreateClientFunds]
@ClientId int
AS
BEGIN
DECLARE @CurrId INT, @CurrName NVARCHAR(30), @CurrSymbol NVARCHAR(3)

DECLARE @MessageOutput VARCHAR(100)

DECLARE Currency_Cursor CURSOR FOR 
    SELECT curr.Id ,curr.CurrencyName,curr.CurrencySymbol  FROM Currency curr order by curr.Id


OPEN Currency_Cursor 

FETCH NEXT FROM Currency_Cursor INTO
    @CurrId, @CurrName, @CurrSymbol

WHILE @@FETCH_STATUS = 0
BEGIN
    INSERT INTO [dbo].[AccountFund]
           ([AccountId]
           ,[FundTitle]
           ,[CurrencyId]
           ,[Balance]
		   ,BalanceDirection
		   ,Hidden
		   ,Flag
		   ,[GUID]
           ,[Declaration]
           ,[LUD]
		   ,UserId)
     VALUES
           (
			@ClientId,
			CONCAT(@CurrName,'-',@CurrSymbol),
			@CurrId,
			0,
			N'لنا',
			0,
			'',
			(SELECT NEWID()),
			'',
			GETDATE()
			,1
		   );

    RAISERROR(@MessageOutput,0,1) WITH NOWAIT

    FETCH NEXT FROM Currency_Cursor INTO
    @CurrId, @CurrName, @CurrSymbol
END
CLOSE Currency_Cursor
DEALLOCATE Currency_Cursor
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteAllData]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[DeleteAllData]
AS
BEGIN
	----DELETE TRANSACTIONS
	DELETE FROM [dbo].[Transaction]
	DBCC CHECKIDENT ( '[dbo].[Transaction]', RESEED, 0 )
	DELETE FROM [dbo].FundTransaction
	DBCC CHECKIDENT ( '[dbo].[FundTransaction]', RESEED, 0 )
	DELETE FROM [dbo].ItemTransaction
	DBCC CHECKIDENT ( '[dbo].[ItemTransaction]', RESEED, 0 )

	----DELETE TABLES DATA
	DELETE FROM [dbo].Item
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[Item]', RESEED, 0 )
	DELETE FROM [dbo].[ItemFund]
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[ItemFund]', RESEED, 0 )
	DELETE FROM [dbo].AccountFund
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[AccountFund]', RESEED, 0 )
	DELETE FROM [dbo].Account
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[Account]', RESEED, 0 )
	DELETE FROM [dbo].AccountGroup
	WHERE  PROTECTED=0
	DBCC CHECKIDENT ( '[dbo].[AccountGroup]', RESEED, 0 )
	DELETE FROM [dbo].Bill
	WHERE  PROTECTED=0
	DBCC CHECKIDENT ( '[dbo].[Bill]', RESEED, 0 )
	DELETE FROM [dbo].BillLines
	WHERE PROTECTED=0
	DBCC CHECKIDENT ( '[dbo].[BillLines]', RESEED, 0 )
	DELETE FROM [dbo].Currency
	WHERE PROTECTED = 0 AND PROTECTED=0
	DBCC CHECKIDENT ( '[dbo].[Currency]', RESEED, 0 )
	DELETE FROM [dbo].CurrencyExchange
	WHERE PROTECTED = 0 OR PROTECTED IS NULL
	DBCC CHECKIDENT ( '[dbo].[CurrencyExchange]', RESEED, 0 )
	DELETE FROM [dbo].CurrencyExchangeOperations
	WHERE PROTECTED = 0 OR PROTECTED IS NULL
	DBCC CHECKIDENT ( '[dbo].[CurrencyExchangeOperations]', RESEED, 0 )
	DELETE FROM [dbo].Exchange
	WHERE PROTECTED = 0 OR PROTECTED IS NULL
	DBCC CHECKIDENT ( '[dbo].[Exchange]', RESEED, 0 )
	DELETE FROM [dbo].ExchangeFund
	WHERE PROTECTED = 0 OR PROTECTED IS NULL
	DBCC CHECKIDENT ( '[dbo].[ExchangeFund]', RESEED, 0 )
	DELETE FROM [dbo].Fund
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[Fund]', RESEED, 0 )
	
	
	DELETE FROM [dbo].Expense
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[Expense]', RESEED, 0 )
	DELETE FROM [dbo].ExpenseCategory
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[ExpenseCategory]', RESEED, 0 )
	DELETE FROM [dbo].Payment
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[Payment]', RESEED, 0 )
	DELETE FROM [dbo].Unit
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[Unit]', RESEED, 0 )
	DELETE FROM [dbo].Role
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[Role]', RESEED, 0 )
	DELETE FROM [dbo].Withdraw
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[Withdraw]', RESEED, 0 )
	DELETE FROM [dbo].Transfer
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[Transfer]', RESEED, 0 )
	DELETE FROM [dbo].[User]
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[User]', RESEED, 0 )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ClientGrand]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[SP_ClientGrand]
@ClientId int
as
begin
	--CONCAT((select ai.Fullname from Accounts_Info ai Where ai.Id=@ClientId),' ',ov.Currency,'-',(SELECT curr.CurrencySymbol from Currencies curr WHERE curr.Id=ov.CurrencyId)) AS الصندوق,
	DECLARE @OverallResults AS TABLE
	(
		Fund nvarchar(50), 
		Currency nvarchar(50),
		CurrencyId int,
		Amount Money
	);
	------------------------------------------------------------------------------------------

	INSERT INTO @OverallResults (Fund, CurrencyId,Currency,Amount)
	(
	select		
		fund.FundTitle 'الصندوق',
		fund.CurrencyId 'رقم العملة',
		(select cr.CurrencyName from Currency cr where cr.Id= fund.CurrencyId) 'العملة',
		(
			select SUM(trans.Amount)
			from [Transaction] trans
			Where trans.AccountId=@ClientId 
			AND trans.CurrencyId=fund.CurrencyId
		)
	from AccountFund fund
	where fund.AccountId=@ClientId
	)
	------------------------------------------------------------------------------------------

	DECLARE @Midium AS TABLE
	(
		Fund nvarchar(50), 
		Currency nvarchar(50),
		CurrencyId int,
		Amount Money,
		Origin nvarchar(3)
	);
	------------------------------------------------------------------------------------------
	INSERT INTO @Midium
	SELECT
	ov.Fund ,
	ov.Currency ,
	ov.CurrencyId ,
	(
	ISNULL((
		SUM(ov.Amount) --+ (select af.Balance from Accounts_Fund af Where af.AccountId = @ClientId AND af.CurrencyId = ov.CurrencyId)
		),0)
	) ,
	N''
	From @OverallResults ov
	group by ov.Fund , 
	ov.CurrencyId  ,
	ov.Currency 
	------------------------------------------------------------------------------------------
	Update @Midium
	SET Origin = N'لكم'
	Where Amount <0
	Update @Midium
	SET Origin = N'لنا'
	Where Amount >=0

	SELECT
		Fund AS 'الصندوق', 
		Currency AS 'العملة',
		CurrencyId AS 'رقم العملة',
		ABS(Amount) AS 'الإجمالي',
		Origin AS 'لنا/لكم'
	From @Midium
	order by CurrencyId
end

GO
/****** Object:  StoredProcedure [dbo].[SP_ClientsGrand]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_ClientsGrand]
as
begin
	DECLARE @OverallResults AS TABLE
	(
		Fund nvarchar(50), 
		Currency nvarchar(50),
		CurrencyId int,
		Profits Money,
		Amount Money
	);
	select		
		fund.FundTitle 'الصندوق',
		fund.CurrencyId 'رقم العملة',
		(select cr.CurrencyName from currency cr where cr.Id= fund.CurrencyId) 'العملة',
		(
			(
			select 
			ISNULL((
					SELECT SUM(trans.Amount) 				
					FROM [Transaction] TRANS
					WHERE TRANS.CurrencyId=FUND.CurrencyId					
					),0)
			)
			
		) AS 'الإجمالي'
	from Fund fund
end

GO
/****** Object:  StoredProcedure [dbo].[SP_FundsGrand]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_FundsGrand]
WITH EXECUTE AS CALLER
AS
begin
select		
	fund.FundTitle 'الصندوق',
	fund.CurrencyId 'رقم العملة',
	(select cr.CurrencyName from Currency cr where cr.Id= fund.CurrencyId) 'العملة',
	(
		--fund.Balance
		--+
		(	select 
			ISNULL((
					SELECT SUM(trans.Amount) 				
					FROM FundTransaction TRANS
					WHERE TRANS.CurrencyId=FUND.CurrencyId					
					),0)
		)		
	 )as الإجمالي
From Fund fund

end


GO
/****** Object:  StoredProcedure [dbo].[SP_FundsMovements]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_FundsMovements]
WITH EXECUTE AS CALLER
AS
begin


DECLARE @OverallResults AS TABLE
(
    Fund nvarchar(50), 
    Currency nvarchar(50),
	CurrencyId int,
	Profits Money,
    Amount Money,
	Flag nvarchar(50) 
);
INSERT INTO @OverallResults (Fund, CurrencyId,Currency,Amount)
EXEC SP_ClientsGrand;
Update @OverallResults
Set Flag=N'العملاء'
INSERT INTO @OverallResults (Fund,CurrencyId, Currency,Amount)
EXEC SP_FundsGrand;
Update @OverallResults
Set Flag=N'المكتب'
Where Flag IS NULL;

INSERT INTO @OverallResults (Fund,CurrencyId, Currency,Amount,Flag)
SELECT	A.Fund AS الصندوق, 
		A.CurrencyId AS 'رقم العملة',
		A.Currency AS العملة,
		SUM(A.Amount)
		AS الإجمالي,
		N'العام'
FROM @OverallResults A
GROUP BY A.Fund,A.Currency,A.CurrencyId;

DECLARE @FundsMove AS TABLE
(
	Id int Primary Key Identity(1,1),
    Fund nvarchar(50), 
    [دولار امريكي] Money,
	[ليرة سورية] Money,
	[ليرة تركية] Money,
	[يورو] Money,
	[ريال سعودي] Money
);
--Set IDENTITY_INSERT @FundsMove ON;

Insert into @FundsMove(Fund,[دولار امريكي],[ليرة سورية],[ليرة تركية],[يورو],[ريال سعودي])
SELECT *
FROM
(
    SELECT Currency,Amount,Flag AS الصندوق
    FROM @OverallResults A
) AS SourceTable 

PIVOT(SUM(Amount) FOR Currency IN(	[دولار امريكي],
									[ليرة سورية],
									[ليرة تركية],
									[يورو],
									[ريال سعودي])) AS PivotTable;

Select * from @FundsMove

end
GO
/****** Object:  StoredProcedure [dbo].[SP_ItemGrand]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[SP_ItemGrand]
@ItemId int
as
begin
	--CONCAT((select ai.Fullname from Accounts_Info ai Where ai.Id=@ClientId),' ',ov.Currency,'-',(SELECT curr.CurrencySymbol from Currencies curr WHERE curr.Id=ov.CurrencyId)) AS الصندوق,
	DECLARE @OverallResults AS TABLE
	(
		Fund nvarchar(50), 
		Unit nvarchar(50),
		UnitId int,
		Amount Money
	);
	------------------------------------------------------------------------------------------

	INSERT INTO @OverallResults (Fund, UnitId,Unit,Amount)
	(
	select		
		fund.FundTitle 'الصندوق',
		fund.UnitId 'رقم الواحدة',
		(select u.Title from Unit u where u.Id= fund.UnitId) 'الواحدة',
		(
			select SUM(trans.Amount)
			from [ItemTransaction] trans
			Where trans.ItemId=@ItemId 
			AND trans.UnitId=fund.UnitId
		)
	from ItemFund fund
	where fund.ItemId=@itemId
	)
	------------------------------------------------------------------------------------------

	DECLARE @Midium AS TABLE
	(
		Fund nvarchar(50), 
		Unit nvarchar(50),
		UnitId int,
		Amount Money,
		Origin nvarchar(3)
	);
	------------------------------------------------------------------------------------------
	INSERT INTO @Midium
	SELECT
	ov.Fund ,
	ov.Unit ,
	ov.UnitId ,
	(
	ISNULL((
		SUM(ov.Amount) --+ (select af.Balance from Accounts_Fund af Where af.AccountId = @ClientId AND af.CurrencyId = ov.CurrencyId)
		),0)
	) ,
	N''
	From @OverallResults ov
	group by ov.Fund , 
	ov.UnitId  ,
	ov.Unit 
	------------------------------------------------------------------------------------------
	Update @Midium
	SET Origin = N'لكم'
	Where Amount <0
	Update @Midium
	SET Origin = N'لنا'
	Where Amount >=0

	SELECT
		Fund AS 'الصندوق', 
		Unit AS 'الواحدة',
		UnitId AS 'رقم الواحدة',
		ABS(Amount) AS 'الإجمالي',
		Origin AS 'لنا/لكم'
	From @Midium
	order by UnitId
end

GO
/****** Object:  StoredProcedure [dbo].[SP_ItemsGrand]    Script Date: 2/23/2020 11:39:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[SP_ItemsGrand]
as
begin
	DECLARE @OverallResults AS TABLE
	(
		Fund nvarchar(50), 
		Unit nvarchar(50),
		UnitId int,
		Profits Money,
		Amount Money
	);
	select		
		fund.FundTitle 'الصندوق',
		fund.UnitId 'رقم الواحدة',
		(select cr.Title from Unit cr where cr.Id= fund.UnitId) 'الواحدة',
		(
			(
			select 
			ISNULL((
					SELECT SUM(trans.Amount) 				
					FROM [ItemTransaction] TRANS
					WHERE TRANS.UnitId=FUND.UnitId					
					),0)
			)
			
		) AS 'الإجمالي'
	from ItemFund fund
end

GO
USE [master]
GO
ALTER DATABASE [Alver] SET  READ_WRITE 
GO

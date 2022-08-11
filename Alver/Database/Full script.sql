USE [master]
GO
/****** Object:  Database [Alver]    Script Date: 09-Aug-22 7:33:02 PM ******/
CREATE DATABASE [Alver]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Alver', FILENAME = N'C:\Alver\Alver\Database\Alver.mdf' , SIZE = 10240KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Alver_log', FILENAME = N'C:\Alver\Alver\Database\Alver_log.ldf' , SIZE = 47616KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
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
ALTER DATABASE [Alver] SET AUTO_CLOSE ON 
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
ALTER DATABASE [Alver] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Alver] SET QUERY_STORE = OFF
GO
USE [Alver]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
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
	[GUID] [uniqueidentifier] NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[AccountId] [int] NULL,
	[TTS] [datetime] NULL,
	[TT] [nvarchar](6) NULL,
	[CurrencyId] [int] NULL,
	[Amount] [decimal](19, 4) NULL,
	[RunningTotal] [decimal](19, 4) NULL,
	[Declaration] [nvarchar](1000) NULL,
	[GUID] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CurrencyBulletins]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurrencyBulletins](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RateDate] [datetime] NULL,
	[CurrencyId] [int] NULL,
	[Rate] [decimal](19, 4) NULL,
	[ReversedRate] [decimal](19, 4) NULL,
	[Factor] [bit] NULL,
	[GUID] [uniqueidentifier] NULL,
 CONSTRAINT [PK_CurrencyBulletins] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_CLIENTS]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






/*TRANS.CurrencyId*/
CREATE VIEW [dbo].[V_CLIENTS]
AS
SELECT		ISNULL(AccountId,0) AS AccountId,
			(SELECT    Fullname
			FROM         dbo.Accounts AS AI
			WHERE      (Id = TRANS.AccountId)) AS Account,
			(SELECT    (SELECT    SUM(Amount)
			FROM          dbo.[Transactions] AS T
			WHERE      (AccountId = TRANS.AccountId) AND (CurrencyId = 1))) AS USDAmount,
			(SELECT    (SELECT    SUM(Amount)
			FROM          dbo.[Transactions] AS T
			WHERE      (AccountId = TRANS.AccountId) AND (CurrencyId = 2)) ) AS SYPAmount,
			(SELECT    (SELECT    SUM(Amount)
			FROM          dbo.[Transactions] AS T
			WHERE      (AccountId = TRANS.AccountId) AND (CurrencyId = 3)) ) AS TLAmount,
			(SELECT    (SELECT    SUM(Amount)
			FROM          dbo.[Transactions] AS T
			WHERE      (AccountId = TRANS.AccountId) AND (CurrencyId = 4)) ) AS EUROAmount,
			(SELECT    (SELECT    SUM(Amount)
			FROM          dbo.[Transactions] AS T
			WHERE      (AccountId = TRANS.AccountId) AND (CurrencyId = 5)) ) AS SARAmount
			,
			(SELECT
			(
				(SELECT    (SELECT    SUM(Amount)	FROM  dbo.[Transactions] AS T	WHERE  (AccountId = TRANS.AccountId) AND (CurrencyId = 1)))
				+
				(
					(SELECT (SELECT  SUM(Amount) FROM dbo.[Transactions] AS T WHERE (AccountId = TRANS.AccountId) AND (CurrencyId = 2)))
					*
					(SELECT (SELECT TOP 1 BUL.ReversedRate FROM CurrencyBulletins BUL WHERE BUL.CurrencyId=2 ORDER BY BUL.RateDate DESC))
				)
				+
				(
					(SELECT (SELECT  SUM(Amount) FROM dbo.[Transactions] AS T WHERE (AccountId = TRANS.AccountId) AND (CurrencyId = 3)))
					*
					(SELECT (SELECT TOP 1 BUL.ReversedRate FROM CurrencyBulletins BUL WHERE BUL.CurrencyId=3 ORDER BY BUL.RateDate DESC))
				)
				+
				(
					(SELECT (SELECT  SUM(Amount) FROM dbo.[Transactions] AS T WHERE (AccountId = TRANS.AccountId) AND (CurrencyId = 4)))
					*
					(SELECT (SELECT TOP 1 BUL.RATE FROM CurrencyBulletins BUL WHERE BUL.CurrencyId=4 ORDER BY BUL.RateDate DESC))
				)
				+
				(
					(SELECT (SELECT  SUM(Amount) FROM dbo.[Transactions] AS T WHERE (AccountId = TRANS.AccountId) AND (CurrencyId = 5)))
					*
					(SELECT (SELECT TOP 1 BUL.ReversedRate FROM CurrencyBulletins BUL WHERE BUL.CurrencyId=5 ORDER BY BUL.RateDate DESC))
				)
			)
			) AS GRAND
FROM         dbo.[Transactions] AS TRANS
GROUP BY AccountId



GO
/****** Object:  Table [dbo].[Items]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [nvarchar](50) NULL,
	[UnitId] [int] NULL,
	[CategoryId] [int] NULL,
	[CurrencyId] [int] NULL,
	[SalePrice] [decimal](19, 4) NULL,
	[PurchasePrice] [decimal](19, 4) NULL,
	[Barcode] [nvarchar](50) NULL,
	[Declaration] [nvarchar](500) NULL,
	[UserId] [int] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[GUID] [uniqueidentifier] NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemTransactions]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemTransactions](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NULL,
	[TTS] [datetime] NULL,
	[TT] [nvarchar](6) NULL,
	[UnitId] [int] NULL,
	[Amount] [decimal](19, 4) NULL,
	[RunningTotal] [decimal](19, 4) NULL,
	[Declaration] [nvarchar](1000) NULL,
	[GUID] [uniqueidentifier] NULL,
 CONSTRAINT [PK_ItemTransactions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_STOCK]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






/*TRANS.CurrencyId*/
CREATE VIEW [dbo].[V_STOCK]
AS
SELECT		ISNULL(ItemId,0) AS 'رقم_المادة',

			(SELECT    AI.ItemName
			FROM         dbo.Items AS AI
			WHERE      (AI.Id = TRANS.ItemId)) AS 'اسم_المادة',

			(SELECT    (SELECT    SUM(Amount)
			FROM          dbo.[ItemTransactions] AS T
			WHERE      (T.ItemId = TRANS.ItemId) AND (T.UnitId = 1))) AS 'عدد_الكروزات_المتوفرة',

			(SELECT    AI.CurrencyId
			FROM         dbo.Items AS AI
			WHERE      (AI.Id = TRANS.ItemId)) AS 'العملة',

			(SELECT    AI.PurchasePrice
			FROM         dbo.Items AS AI
			WHERE      (AI.Id = TRANS.ItemId)) AS 'سعر_شراء_الواحدة',

			(SELECT
			(
				(SELECT (SELECT  SUM(Amount) FROM dbo.[ItemTransactions] AS T WHERE (T.ItemId = TRANS.ItemId) AND (T.UnitId = 1)))
				*
				(SELECT    AI.PurchasePrice	FROM  dbo.Items AS AI	WHERE   (AI.Id = TRANS.ItemId))
			)
			) AS 'تكلفة الشراء',

			(SELECT    AI.SalePrice
			FROM         dbo.Items AS AI
			WHERE      (AI.Id = TRANS.ItemId)) AS 'سعر_مبيع_الواحدة',

			(SELECT
			(
				(SELECT (SELECT  SUM(Amount) FROM dbo.[ItemTransactions] AS T WHERE (T.ItemId = TRANS.ItemId) AND (T.UnitId = 1)))
				*
				(SELECT    AI.SalePrice	FROM  dbo.Items AS AI	WHERE   (AI.Id = TRANS.ItemId))
			)
			) AS 'مجموع المبيعات',

			(SELECT
			(
				(SELECT    AI.SalePrice
			FROM         dbo.Items AS AI
			WHERE      (AI.Id = TRANS.ItemId))
				-
				(SELECT    AI.PurchasePrice
			FROM         dbo.Items AS AI
			WHERE      (AI.Id = TRANS.ItemId))
			)
			) AS 'هامش_الربح_في_القطعة_الواحدة',

			(SELECT
			(
				(SELECT
			(
				(SELECT (SELECT  SUM(Amount) FROM dbo.[ItemTransactions] AS T WHERE (T.ItemId = TRANS.ItemId) AND (T.UnitId = 1)))
				*
				(SELECT    AI.SalePrice	FROM  dbo.Items AS AI	WHERE   (AI.Id = TRANS.ItemId))
			)
			)
			-
			(SELECT
			(
				(SELECT (SELECT  SUM(Amount) FROM dbo.[ItemTransactions] AS T WHERE (T.ItemId = TRANS.ItemId) AND (T.UnitId = 1)))
				*
				(SELECT    AI.PurchasePrice	FROM  dbo.Items AS AI	WHERE   (AI.Id = TRANS.ItemId))
			)
			)
			)
			) AS 'الربح_المتوقع'

FROM         dbo.[ItemTransactions] AS TRANS
GROUP BY TRANS.ItemId



GO
/****** Object:  Table [dbo].[AccountFunds]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountFunds](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AccountId] [int] NULL,
	[FundTitle] [nvarchar](250) NULL,
	[CurrencyId] [int] NULL,
	[Balance] [decimal](19, 4) NULL,
	[BalanceDirection] [nvarchar](10) NULL,
	[Declaration] [nvarchar](500) NULL,
	[UserId] [int] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[GUID] [uniqueidentifier] NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_AccountFunds] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccountGroups]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountGroups](
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
 CONSTRAINT [PK_AccountGroups] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Albums]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Albums](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AlbumTitle] [nvarchar](50) NULL,
	[Declaration] [nvarchar](50) NULL,
	[UserId] [int] NULL,
	[LUD] [datetime] NULL,
	[GUID] [uniqueidentifier] NULL,
	[Flag] [nvarchar](50) NULL,
	[Hidden] [bit] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Albums] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppSettings]    Script Date: 09-Aug-22 7:33:03 PM ******/
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
	[GUID] [uniqueidentifier] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_AppSettings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillLines]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillLines](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BillId] [int] NULL,
	[ItemId] [int] NULL,
	[UnitId] [int] NULL,
	[Quantity] [decimal](19, 4) NULL,
	[CurrencyId] [int] NULL,
	[Price] [decimal](19, 4) NULL,
	[TotalPrice] [decimal](19, 4) NULL,
	[Exchanged] [bit] NULL,
	[Rate] [decimal](19, 4) NULL,
	[ForeginCurrencyId] [int] NULL,
	[ExchangedAmount] [decimal](19, 4) NULL,
	[ExchangedTotalAmount] [decimal](19, 4) NULL,
	[UserId] [int] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[GUID] [uniqueidentifier] NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_BillLines] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bills]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bills](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CheckedOut] [bit] NULL,
	[BillType] [nvarchar](10) NULL,
	[AccountId] [int] NULL,
	[BillDate] [datetime] NULL,
	[Cashout] [bit] NULL,
	[CurrencyId] [int] NULL,
	[BillAmount] [decimal](19, 4) NULL,
	[DiscountAmount] [decimal](19, 4) NULL,
	[TotalAmount] [decimal](19, 4) NULL,
	[Exchanged] [bit] NULL,
	[Rate] [decimal](19, 4) NULL,
	[ForeginCurrencyId] [int] NULL,
	[ExchangedAmount] [decimal](19, 4) NULL,
	[Declaration] [nvarchar](500) NULL,
	[UserId] [int] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[GUID] [uniqueidentifier] NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Bills] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Companies]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Companies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NULL,
	[Motto] [nvarchar](150) NULL,
	[Manager] [nvarchar](100) NULL,
	[ManagerPhone] [nvarchar](50) NULL,
	[Accountant] [nvarchar](100) NULL,
	[AccountantPhone] [nvarchar](50) NULL,
	[Address] [nvarchar](max) NULL,
	[Notes] [nvarchar](max) NULL,
	[LogoId] [int] NULL,
	[EmailAddress] [nvarchar](100) NULL,
	[UserId] [int] NULL,
	[GUID] [uniqueidentifier] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Currencies]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Currencies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CurrencyName] [nvarchar](50) NULL,
	[CurrencySymbol] [nvarchar](3) NULL,
	[CurrencyCode] [nvarchar](3) NULL,
	[BaseCurrency] [bit] NULL,
	[ExchangeRate] [decimal](19, 4) NULL,
	[Notes] [nvarchar](100) NULL,
	[UserId] [int] NULL,
	[GUID] [uniqueidentifier] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Currencies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CurrencyExchangeOperations]    Script Date: 09-Aug-22 7:33:03 PM ******/
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
	[BaseAmount] [decimal](19, 4) NULL,
	[SubCurrencyId] [int] NULL,
	[Factor] [nvarchar](10) NULL,
	[Rate] [decimal](19, 4) NULL,
	[SubAmount] [decimal](19, 4) NULL,
	[RoundAmount] [decimal](19, 4) NULL,
	[Declaration] [nvarchar](100) NULL,
	[UserId] [int] NULL,
	[GUID] [uniqueidentifier] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_CurrencyExchangeOperations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CurrencyExchanges]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurrencyExchanges](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ExchangeType] [nvarchar](50) NULL,
	[ExchangeDate] [datetime] NULL,
	[Declaration] [nvarchar](500) NULL,
	[UserId] [int] NULL,
	[GUID] [uniqueidentifier] NULL,
	[Flag] [nvarchar](50) NULL,
	[Hidden] [bit] NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_CurrencyExchanges] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExchangeFunds]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExchangeFunds](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ExchangeType] [bit] NULL,
	[ExchangeDate] [datetime] NULL,
	[CurrencyId] [int] NULL,
	[AccountFromId] [int] NULL,
	[AccountFundFromId] [int] NULL,
	[AccountToId] [int] NULL,
	[AccountFundToId] [int] NULL,
	[FromAmount] [decimal](19, 4) NULL,
	[Factor] [bit] NULL,
	[Rate] [decimal](19, 4) NULL,
	[ToAmount] [decimal](19, 4) NULL,
	[Declaration] [nvarchar](500) NULL,
	[UserId] [int] NULL,
	[GUID] [uniqueidentifier] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_ExchangeFunds] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exchanges]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exchanges](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ExchangeDate] [datetime] NULL,
	[Direction] [nvarchar](50) NULL,
	[BaseCurrencyId] [int] NULL,
	[BaseAmount] [decimal](19, 4) NULL,
	[SubCurrencyId] [int] NULL,
	[Factor] [nvarchar](10) NULL,
	[Rate] [decimal](19, 4) NULL,
	[SubAmount] [decimal](19, 4) NULL,
	[RoundAmount] [decimal](19, 4) NULL,
	[Declaration] [nvarchar](100) NULL,
	[UserId] [int] NULL,
	[GUID] [uniqueidentifier] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Exchanges] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExpenseCategories]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExpenseCategories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[Declaration] [nvarchar](500) NULL,
	[UserId] [int] NULL,
	[GUID] [uniqueidentifier] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_ExpenseCategories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expenses]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expenses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ExpenseDate] [datetime] NULL,
	[CurrencyId] [int] NULL,
	[Amount] [decimal](19, 4) NULL,
	[CategoryId] [int] NULL,
	[Declaration] [nvarchar](500) NULL,
	[UserId] [int] NULL,
	[GUID] [uniqueidentifier] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Expenses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funds]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funds](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FundTitle] [nvarchar](50) NULL,
	[CurrencyId] [int] NULL,
	[Balance] [decimal](19, 4) NULL,
	[BalanceDirection] [nvarchar](10) NULL,
	[Declaration] [nvarchar](500) NULL,
	[UserId] [int] NULL,
	[GUID] [uniqueidentifier] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Funds] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FundTransactions]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FundTransactions](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[FundId] [int] NULL,
	[TTS] [datetime] NULL,
	[TT] [nvarchar](6) NULL,
	[CurrencyId] [int] NULL,
	[Amount] [decimal](19, 4) NULL,
	[RunningTotal] [decimal](19, 4) NULL,
	[Declaration] [nvarchar](1000) NULL,
	[GUID] [uniqueidentifier] NULL,
 CONSTRAINT [PK_FundTransactions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Images]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Images](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AlbumId] [int] NULL,
	[ImageData] [varbinary](max) NULL,
	[ImageTitle] [nvarchar](50) NULL,
	[Notes] [nvarchar](50) NULL,
	[GUID] [uniqueidentifier] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemCategories]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemCategories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[Declaration] [nvarchar](500) NULL,
	[UserId] [int] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[GUID] [uniqueidentifier] NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_ItemCategories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemFunds]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemFunds](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NULL,
	[FundTitle] [nvarchar](250) NULL,
	[UnitId] [int] NULL,
	[Balance] [decimal](19, 4) NULL,
	[BalanceDirection] [nvarchar](10) NULL,
	[Declaration] [nvarchar](500) NULL,
	[UserId] [int] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[GUID] [uniqueidentifier] NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_ItemFunds] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemUnits]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemUnits](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NULL,
	[UnitId] [int] NULL,
	[Factor] [decimal](19, 4) NULL,
	[BaseUnitId] [int] NULL,
	[BaseUnitQuantity] [decimal](19, 4) NULL,
	[GUID] [uniqueidentifier] NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_ItemUnits] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payments]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PaymentType] [nvarchar](20) NULL,
	[PaymentDate] [datetime] NULL,
	[AccountId] [int] NULL,
	[CurrencyId] [int] NULL,
	[Amount] [decimal](19, 4) NULL,
	[Declaration] [nvarchar](500) NULL,
	[Payed] [bit] NULL,
	[Locked] [bit] NULL,
	[UserId] [int] NULL,
	[GUID] [uniqueidentifier] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Payments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prices]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prices](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemUnitId] [int] NULL,
	[CurrencyId] [int] NULL,
	[SalePrice] [decimal](19, 4) NULL,
	[PurchasePrice] [decimal](19, 4) NULL,
	[GUID] [uniqueidentifier] NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Prices] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReceiptLines]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReceiptLines](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ReceiptId] [int] NULL,
	[ItemId] [int] NULL,
	[UnitId] [int] NULL,
	[Quantity] [decimal](19, 4) NULL,
	[Price] [decimal](19, 4) NULL,
	[TotalPrice] [decimal](19, 4) NULL,
	[UserId] [int] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[GUID] [uniqueidentifier] NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_ReceiptLines] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receipts]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receipts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AccountId] [int] NULL,
	[ReceiptDate] [datetime] NULL,
	[ReceiptAmount] [decimal](19, 4) NULL,
	[DiscountAmount] [decimal](19, 4) NULL,
	[TotalAmount] [decimal](19, 4) NULL,
	[Declaration] [nvarchar](500) NULL,
	[UserId] [int] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[GUID] [uniqueidentifier] NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Receipts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleTitle] [nvarchar](50) NULL,
	[Declaration] [nvarchar](500) NULL,
	[GUID] [uniqueidentifier] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transfers]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transfers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TransferDate] [datetime] NULL,
	[CurrencyId] [int] NULL,
	[ClientFrom] [int] NULL,
	[FundFrom] [int] NULL,
	[ClientTo] [int] NULL,
	[FundTo] [int] NULL,
	[FromAmount] [decimal](19, 4) NULL,
	[Factor] [bit] NULL,
	[Rate] [decimal](19, 4) NULL,
	[ToAmount] [decimal](19, 4) NULL,
	[Declaration] [nvarchar](max) NULL,
	[UserId] [int] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[GUID] [uniqueidentifier] NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Transfers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Units]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Units](
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
 CONSTRAINT [PK_Units] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
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
	[GUID] [uniqueidentifier] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Withdraws]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Withdraws](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Direction] [nvarchar](50) NULL,
	[WithdrawDate] [datetime] NULL,
	[AccountId] [int] NULL,
	[CurrencyId] [int] NULL,
	[Amount] [decimal](19, 4) NULL,
	[Declaration] [nvarchar](max) NULL,
	[Payed] [bit] NULL,
	[Locked] [bit] NULL,
	[UserId] [int] NULL,
	[GUID] [uniqueidentifier] NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Withdraws] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_AccountFund_Account]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_AccountFund_Account] ON [dbo].[AccountFunds]
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_AccountFund_Currency]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_AccountFund_Currency] ON [dbo].[AccountFunds]
(
	[CurrencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Account_AccountGroup]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Account_AccountGroup] ON [dbo].[Accounts]
(
	[AccountGroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Account_User]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Account_User] ON [dbo].[Accounts]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_BillLines_Bill]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_BillLines_Bill] ON [dbo].[BillLines]
(
	[BillId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_BillLines_Currency]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_BillLines_Currency] ON [dbo].[BillLines]
(
	[CurrencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_BillLines_Currency1]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_BillLines_Currency1] ON [dbo].[BillLines]
(
	[ForeginCurrencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_BillLines_Item]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_BillLines_Item] ON [dbo].[BillLines]
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_BillLines_Unit]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_BillLines_Unit] ON [dbo].[BillLines]
(
	[UnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_BillLines_User]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_BillLines_User] ON [dbo].[BillLines]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Bill_Account]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Bill_Account] ON [dbo].[Bills]
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Bill_Currency]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Bill_Currency] ON [dbo].[Bills]
(
	[CurrencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Bill_User]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Bill_User] ON [dbo].[Bills]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Company_Images]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Company_Images] ON [dbo].[Companies]
(
	[LogoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Currency_User]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Currency_User] ON [dbo].[Currencies]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_CurrencyBulletin_Currency]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_CurrencyBulletin_Currency] ON [dbo].[CurrencyBulletins]
(
	[CurrencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_CurrencyExchangeOperations_Currency]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_CurrencyExchangeOperations_Currency] ON [dbo].[CurrencyExchangeOperations]
(
	[BaseCurrencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_CurrencyExchangeOperations_Currency1]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_CurrencyExchangeOperations_Currency1] ON [dbo].[CurrencyExchangeOperations]
(
	[SubCurrencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_CurrencyExchangeOperations_CurrencyExchange1]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_CurrencyExchangeOperations_CurrencyExchange1] ON [dbo].[CurrencyExchangeOperations]
(
	[ExchangeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_CurrencyExchangeOperations_Users_User]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_CurrencyExchangeOperations_Users_User] ON [dbo].[CurrencyExchangeOperations]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_CurrencyExchange_Users_User]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_CurrencyExchange_Users_User] ON [dbo].[CurrencyExchanges]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ExchangeFund_AccountFrom]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ExchangeFund_AccountFrom] ON [dbo].[ExchangeFunds]
(
	[AccountFromId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ExchangeFund_AccountFundFrom]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ExchangeFund_AccountFundFrom] ON [dbo].[ExchangeFunds]
(
	[AccountFundFromId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ExchangeFund_AccountFundTo]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ExchangeFund_AccountFundTo] ON [dbo].[ExchangeFunds]
(
	[AccountFundToId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ExchangeFund_AccountTo]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ExchangeFund_AccountTo] ON [dbo].[ExchangeFunds]
(
	[AccountToId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ExchangeFund_Currency]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ExchangeFund_Currency] ON [dbo].[ExchangeFunds]
(
	[CurrencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ExchangeFund_User]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ExchangeFund_User] ON [dbo].[ExchangeFunds]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Exchange_BaseCurrency]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Exchange_BaseCurrency] ON [dbo].[Exchanges]
(
	[BaseCurrencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Exchange_SubCurrency]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Exchange_SubCurrency] ON [dbo].[Exchanges]
(
	[SubCurrencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Exchange_User]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Exchange_User] ON [dbo].[Exchanges]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Exchange_User1]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Exchange_User1] ON [dbo].[Exchanges]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ExpenseCategory_User]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ExpenseCategory_User] ON [dbo].[ExpenseCategories]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Expense_Currency]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Expense_Currency] ON [dbo].[Expenses]
(
	[CurrencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Expense_ExpenseCategory]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Expense_ExpenseCategory] ON [dbo].[Expenses]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Expense_User]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Expense_User] ON [dbo].[Expenses]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Fund_Currency]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Fund_Currency] ON [dbo].[Funds]
(
	[CurrencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Fund_User]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Fund_User] ON [dbo].[Funds]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_FundTransaction_Currency]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_FundTransaction_Currency] ON [dbo].[FundTransactions]
(
	[CurrencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_FundTransaction_Fund]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_FundTransaction_Fund] ON [dbo].[FundTransactions]
(
	[FundId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Images_Album]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Images_Album] ON [dbo].[Images]
(
	[AlbumId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ItemCategory_User]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ItemCategory_User] ON [dbo].[ItemCategories]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ItemFund_Item]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ItemFund_Item] ON [dbo].[ItemFunds]
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ItemFund_Unit]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ItemFund_Unit] ON [dbo].[ItemFunds]
(
	[UnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ItemFund_User]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ItemFund_User] ON [dbo].[ItemFunds]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Item_Currency]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Item_Currency] ON [dbo].[Items]
(
	[CurrencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Item_ItemCategory]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Item_ItemCategory] ON [dbo].[Items]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Item_Unit]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Item_Unit] ON [dbo].[Items]
(
	[UnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Item_User]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Item_User] ON [dbo].[Items]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ItemTransaction_Item]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ItemTransaction_Item] ON [dbo].[ItemTransactions]
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ItemTransaction_Unit]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ItemTransaction_Unit] ON [dbo].[ItemTransactions]
(
	[UnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ItemUnit_Item]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ItemUnit_Item] ON [dbo].[ItemUnits]
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ItemUnit_Unit]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ItemUnit_Unit] ON [dbo].[ItemUnits]
(
	[UnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ItemUnit_Unit1]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ItemUnit_Unit1] ON [dbo].[ItemUnits]
(
	[BaseUnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Payment_Account]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Payment_Account] ON [dbo].[Payments]
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Payment_Currency]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Payment_Currency] ON [dbo].[Payments]
(
	[CurrencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Payment_User]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Payment_User] ON [dbo].[Payments]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Price_Currency]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Price_Currency] ON [dbo].[Prices]
(
	[CurrencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Price_ItemUnit]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Price_ItemUnit] ON [dbo].[Prices]
(
	[ItemUnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ReceiptLines_Item]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ReceiptLines_Item] ON [dbo].[ReceiptLines]
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ReceiptLines_Receipt]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ReceiptLines_Receipt] ON [dbo].[ReceiptLines]
(
	[ReceiptId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ReceiptLines_Unit]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ReceiptLines_Unit] ON [dbo].[ReceiptLines]
(
	[UnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ReceiptLines_User]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ReceiptLines_User] ON [dbo].[ReceiptLines]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Receipt_Account]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Receipt_Account] ON [dbo].[Receipts]
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Receipt_User]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Receipt_User] ON [dbo].[Receipts]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Transaction_Account]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Transaction_Account] ON [dbo].[Transactions]
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Transaction_Currency]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Transaction_Currency] ON [dbo].[Transactions]
(
	[CurrencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Transfer_Account]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Transfer_Account] ON [dbo].[Transfers]
(
	[ClientFrom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Transfer_Account1]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Transfer_Account1] ON [dbo].[Transfers]
(
	[ClientTo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Transfer_AccountFund]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Transfer_AccountFund] ON [dbo].[Transfers]
(
	[FundFrom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Transfer_AccountFund1]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Transfer_AccountFund1] ON [dbo].[Transfers]
(
	[FundTo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Transfer_Currency]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Transfer_Currency] ON [dbo].[Transfers]
(
	[CurrencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Transfer_User]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Transfer_User] ON [dbo].[Transfers]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Unit_User]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Unit_User] ON [dbo].[Units]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Users_Role]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Users_Role] ON [dbo].[Users]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Withdraw_Account]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Withdraw_Account] ON [dbo].[Withdraws]
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Withdraw_Currency]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Withdraw_Currency] ON [dbo].[Withdraws]
(
	[CurrencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Withdraw_User]    Script Date: 09-Aug-22 7:33:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Withdraw_User] ON [dbo].[Withdraws]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AccountFunds]  WITH NOCHECK ADD  CONSTRAINT [FK_AccountFund_Account] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Accounts] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[AccountFunds] NOCHECK CONSTRAINT [FK_AccountFund_Account]
GO
ALTER TABLE [dbo].[AccountFunds]  WITH NOCHECK ADD  CONSTRAINT [FK_AccountFund_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currencies] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[AccountFunds] NOCHECK CONSTRAINT [FK_AccountFund_Currency]
GO
ALTER TABLE [dbo].[Accounts]  WITH NOCHECK ADD  CONSTRAINT [FK_Account_AccountGroup] FOREIGN KEY([AccountGroupId])
REFERENCES [dbo].[AccountGroups] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Accounts] NOCHECK CONSTRAINT [FK_Account_AccountGroup]
GO
ALTER TABLE [dbo].[Accounts]  WITH NOCHECK ADD  CONSTRAINT [FK_Account_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Accounts] NOCHECK CONSTRAINT [FK_Account_User]
GO
ALTER TABLE [dbo].[BillLines]  WITH NOCHECK ADD  CONSTRAINT [FK_BillLines_Bill] FOREIGN KEY([BillId])
REFERENCES [dbo].[Bills] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[BillLines] NOCHECK CONSTRAINT [FK_BillLines_Bill]
GO
ALTER TABLE [dbo].[BillLines]  WITH NOCHECK ADD  CONSTRAINT [FK_BillLines_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currencies] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[BillLines] NOCHECK CONSTRAINT [FK_BillLines_Currency]
GO
ALTER TABLE [dbo].[BillLines]  WITH NOCHECK ADD  CONSTRAINT [FK_BillLines_Currency1] FOREIGN KEY([ForeginCurrencyId])
REFERENCES [dbo].[Currencies] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[BillLines] NOCHECK CONSTRAINT [FK_BillLines_Currency1]
GO
ALTER TABLE [dbo].[BillLines]  WITH NOCHECK ADD  CONSTRAINT [FK_BillLines_Item] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Items] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[BillLines] NOCHECK CONSTRAINT [FK_BillLines_Item]
GO
ALTER TABLE [dbo].[BillLines]  WITH NOCHECK ADD  CONSTRAINT [FK_BillLines_Unit] FOREIGN KEY([UnitId])
REFERENCES [dbo].[Units] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[BillLines] NOCHECK CONSTRAINT [FK_BillLines_Unit]
GO
ALTER TABLE [dbo].[BillLines]  WITH NOCHECK ADD  CONSTRAINT [FK_BillLines_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[BillLines] NOCHECK CONSTRAINT [FK_BillLines_User]
GO
ALTER TABLE [dbo].[Bills]  WITH NOCHECK ADD  CONSTRAINT [FK_Bill_Account] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Accounts] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Bills] NOCHECK CONSTRAINT [FK_Bill_Account]
GO
ALTER TABLE [dbo].[Bills]  WITH NOCHECK ADD  CONSTRAINT [FK_Bill_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currencies] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Bills] NOCHECK CONSTRAINT [FK_Bill_Currency]
GO
ALTER TABLE [dbo].[Bills]  WITH NOCHECK ADD  CONSTRAINT [FK_Bill_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Bills] NOCHECK CONSTRAINT [FK_Bill_User]
GO
ALTER TABLE [dbo].[Companies]  WITH CHECK ADD  CONSTRAINT [FK_Company_Images] FOREIGN KEY([LogoId])
REFERENCES [dbo].[Images] ([Id])
GO
ALTER TABLE [dbo].[Companies] CHECK CONSTRAINT [FK_Company_Images]
GO
ALTER TABLE [dbo].[Currencies]  WITH NOCHECK ADD  CONSTRAINT [FK_Currency_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Currencies] NOCHECK CONSTRAINT [FK_Currency_User]
GO
ALTER TABLE [dbo].[CurrencyBulletins]  WITH NOCHECK ADD  CONSTRAINT [FK_CurrencyBulletin_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currencies] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CurrencyBulletins] NOCHECK CONSTRAINT [FK_CurrencyBulletin_Currency]
GO
ALTER TABLE [dbo].[CurrencyExchangeOperations]  WITH NOCHECK ADD  CONSTRAINT [FK_CurrencyExchangeOperations_Currency] FOREIGN KEY([BaseCurrencyId])
REFERENCES [dbo].[Currencies] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CurrencyExchangeOperations] NOCHECK CONSTRAINT [FK_CurrencyExchangeOperations_Currency]
GO
ALTER TABLE [dbo].[CurrencyExchangeOperations]  WITH NOCHECK ADD  CONSTRAINT [FK_CurrencyExchangeOperations_Currency1] FOREIGN KEY([SubCurrencyId])
REFERENCES [dbo].[Currencies] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CurrencyExchangeOperations] NOCHECK CONSTRAINT [FK_CurrencyExchangeOperations_Currency1]
GO
ALTER TABLE [dbo].[CurrencyExchangeOperations]  WITH NOCHECK ADD  CONSTRAINT [FK_CurrencyExchangeOperations_CurrencyExchange1] FOREIGN KEY([ExchangeId])
REFERENCES [dbo].[CurrencyExchanges] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CurrencyExchangeOperations] NOCHECK CONSTRAINT [FK_CurrencyExchangeOperations_CurrencyExchange1]
GO
ALTER TABLE [dbo].[CurrencyExchangeOperations]  WITH NOCHECK ADD  CONSTRAINT [FK_CurrencyExchangeOperations_Users_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CurrencyExchangeOperations] NOCHECK CONSTRAINT [FK_CurrencyExchangeOperations_Users_User]
GO
ALTER TABLE [dbo].[CurrencyExchanges]  WITH NOCHECK ADD  CONSTRAINT [FK_CurrencyExchange_Users_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CurrencyExchanges] NOCHECK CONSTRAINT [FK_CurrencyExchange_Users_User]
GO
ALTER TABLE [dbo].[ExchangeFunds]  WITH NOCHECK ADD  CONSTRAINT [FK_ExchangeFund_AccountFrom] FOREIGN KEY([AccountFromId])
REFERENCES [dbo].[Accounts] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ExchangeFunds] NOCHECK CONSTRAINT [FK_ExchangeFund_AccountFrom]
GO
ALTER TABLE [dbo].[ExchangeFunds]  WITH NOCHECK ADD  CONSTRAINT [FK_ExchangeFund_AccountFundFrom] FOREIGN KEY([AccountFundFromId])
REFERENCES [dbo].[AccountFunds] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ExchangeFunds] NOCHECK CONSTRAINT [FK_ExchangeFund_AccountFundFrom]
GO
ALTER TABLE [dbo].[ExchangeFunds]  WITH NOCHECK ADD  CONSTRAINT [FK_ExchangeFund_AccountFundTo] FOREIGN KEY([AccountFundToId])
REFERENCES [dbo].[AccountFunds] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ExchangeFunds] NOCHECK CONSTRAINT [FK_ExchangeFund_AccountFundTo]
GO
ALTER TABLE [dbo].[ExchangeFunds]  WITH NOCHECK ADD  CONSTRAINT [FK_ExchangeFund_AccountTo] FOREIGN KEY([AccountToId])
REFERENCES [dbo].[Accounts] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ExchangeFunds] NOCHECK CONSTRAINT [FK_ExchangeFund_AccountTo]
GO
ALTER TABLE [dbo].[ExchangeFunds]  WITH NOCHECK ADD  CONSTRAINT [FK_ExchangeFund_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currencies] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ExchangeFunds] NOCHECK CONSTRAINT [FK_ExchangeFund_Currency]
GO
ALTER TABLE [dbo].[ExchangeFunds]  WITH NOCHECK ADD  CONSTRAINT [FK_ExchangeFund_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ExchangeFunds] NOCHECK CONSTRAINT [FK_ExchangeFund_User]
GO
ALTER TABLE [dbo].[Exchanges]  WITH NOCHECK ADD  CONSTRAINT [FK_Exchange_BaseCurrency] FOREIGN KEY([BaseCurrencyId])
REFERENCES [dbo].[Currencies] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Exchanges] NOCHECK CONSTRAINT [FK_Exchange_BaseCurrency]
GO
ALTER TABLE [dbo].[Exchanges]  WITH NOCHECK ADD  CONSTRAINT [FK_Exchange_SubCurrency] FOREIGN KEY([SubCurrencyId])
REFERENCES [dbo].[Currencies] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Exchanges] NOCHECK CONSTRAINT [FK_Exchange_SubCurrency]
GO
ALTER TABLE [dbo].[Exchanges]  WITH NOCHECK ADD  CONSTRAINT [FK_Exchange_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Exchanges] NOCHECK CONSTRAINT [FK_Exchange_User]
GO
ALTER TABLE [dbo].[Exchanges]  WITH NOCHECK ADD  CONSTRAINT [FK_Exchange_User1] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Exchanges] NOCHECK CONSTRAINT [FK_Exchange_User1]
GO
ALTER TABLE [dbo].[ExpenseCategories]  WITH CHECK ADD  CONSTRAINT [FK_ExpenseCategory_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[ExpenseCategories] CHECK CONSTRAINT [FK_ExpenseCategory_User]
GO
ALTER TABLE [dbo].[Expenses]  WITH NOCHECK ADD  CONSTRAINT [FK_Expense_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currencies] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Expenses] NOCHECK CONSTRAINT [FK_Expense_Currency]
GO
ALTER TABLE [dbo].[Expenses]  WITH NOCHECK ADD  CONSTRAINT [FK_Expense_ExpenseCategory] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[ExpenseCategories] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Expenses] NOCHECK CONSTRAINT [FK_Expense_ExpenseCategory]
GO
ALTER TABLE [dbo].[Expenses]  WITH NOCHECK ADD  CONSTRAINT [FK_Expense_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Expenses] NOCHECK CONSTRAINT [FK_Expense_User]
GO
ALTER TABLE [dbo].[Funds]  WITH NOCHECK ADD  CONSTRAINT [FK_Fund_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currencies] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Funds] NOCHECK CONSTRAINT [FK_Fund_Currency]
GO
ALTER TABLE [dbo].[Funds]  WITH NOCHECK ADD  CONSTRAINT [FK_Fund_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Funds] NOCHECK CONSTRAINT [FK_Fund_User]
GO
ALTER TABLE [dbo].[FundTransactions]  WITH NOCHECK ADD  CONSTRAINT [FK_FundTransaction_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currencies] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[FundTransactions] NOCHECK CONSTRAINT [FK_FundTransaction_Currency]
GO
ALTER TABLE [dbo].[FundTransactions]  WITH NOCHECK ADD  CONSTRAINT [FK_FundTransaction_Fund] FOREIGN KEY([FundId])
REFERENCES [dbo].[Funds] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[FundTransactions] NOCHECK CONSTRAINT [FK_FundTransaction_Fund]
GO
ALTER TABLE [dbo].[Images]  WITH CHECK ADD  CONSTRAINT [FK_Images_Album] FOREIGN KEY([AlbumId])
REFERENCES [dbo].[Albums] ([Id])
GO
ALTER TABLE [dbo].[Images] CHECK CONSTRAINT [FK_Images_Album]
GO
ALTER TABLE [dbo].[ItemCategories]  WITH CHECK ADD  CONSTRAINT [FK_ItemCategory_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[ItemCategories] CHECK CONSTRAINT [FK_ItemCategory_User]
GO
ALTER TABLE [dbo].[ItemFunds]  WITH NOCHECK ADD  CONSTRAINT [FK_ItemFund_Item] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Items] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ItemFunds] NOCHECK CONSTRAINT [FK_ItemFund_Item]
GO
ALTER TABLE [dbo].[ItemFunds]  WITH NOCHECK ADD  CONSTRAINT [FK_ItemFund_Unit] FOREIGN KEY([UnitId])
REFERENCES [dbo].[Units] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ItemFunds] NOCHECK CONSTRAINT [FK_ItemFund_Unit]
GO
ALTER TABLE [dbo].[ItemFunds]  WITH CHECK ADD  CONSTRAINT [FK_ItemFund_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[ItemFunds] CHECK CONSTRAINT [FK_ItemFund_User]
GO
ALTER TABLE [dbo].[Items]  WITH NOCHECK ADD  CONSTRAINT [FK_Item_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currencies] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Items] NOCHECK CONSTRAINT [FK_Item_Currency]
GO
ALTER TABLE [dbo].[Items]  WITH NOCHECK ADD  CONSTRAINT [FK_Item_ItemCategory] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[ItemCategories] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Items] NOCHECK CONSTRAINT [FK_Item_ItemCategory]
GO
ALTER TABLE [dbo].[Items]  WITH NOCHECK ADD  CONSTRAINT [FK_Item_Unit] FOREIGN KEY([UnitId])
REFERENCES [dbo].[Units] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Items] NOCHECK CONSTRAINT [FK_Item_Unit]
GO
ALTER TABLE [dbo].[Items]  WITH NOCHECK ADD  CONSTRAINT [FK_Item_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Items] NOCHECK CONSTRAINT [FK_Item_User]
GO
ALTER TABLE [dbo].[ItemTransactions]  WITH NOCHECK ADD  CONSTRAINT [FK_ItemTransaction_Item] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Items] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ItemTransactions] NOCHECK CONSTRAINT [FK_ItemTransaction_Item]
GO
ALTER TABLE [dbo].[ItemTransactions]  WITH NOCHECK ADD  CONSTRAINT [FK_ItemTransaction_Unit] FOREIGN KEY([UnitId])
REFERENCES [dbo].[Units] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ItemTransactions] NOCHECK CONSTRAINT [FK_ItemTransaction_Unit]
GO
ALTER TABLE [dbo].[ItemUnits]  WITH NOCHECK ADD  CONSTRAINT [FK_ItemUnit_Item] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Items] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ItemUnits] NOCHECK CONSTRAINT [FK_ItemUnit_Item]
GO
ALTER TABLE [dbo].[ItemUnits]  WITH NOCHECK ADD  CONSTRAINT [FK_ItemUnit_Unit] FOREIGN KEY([UnitId])
REFERENCES [dbo].[Units] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ItemUnits] NOCHECK CONSTRAINT [FK_ItemUnit_Unit]
GO
ALTER TABLE [dbo].[ItemUnits]  WITH NOCHECK ADD  CONSTRAINT [FK_ItemUnit_Unit1] FOREIGN KEY([BaseUnitId])
REFERENCES [dbo].[Units] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ItemUnits] NOCHECK CONSTRAINT [FK_ItemUnit_Unit1]
GO
ALTER TABLE [dbo].[Payments]  WITH NOCHECK ADD  CONSTRAINT [FK_Payment_Account] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Accounts] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Payments] NOCHECK CONSTRAINT [FK_Payment_Account]
GO
ALTER TABLE [dbo].[Payments]  WITH NOCHECK ADD  CONSTRAINT [FK_Payment_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currencies] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Payments] NOCHECK CONSTRAINT [FK_Payment_Currency]
GO
ALTER TABLE [dbo].[Payments]  WITH NOCHECK ADD  CONSTRAINT [FK_Payment_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Payments] NOCHECK CONSTRAINT [FK_Payment_User]
GO
ALTER TABLE [dbo].[Prices]  WITH NOCHECK ADD  CONSTRAINT [FK_Price_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currencies] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Prices] NOCHECK CONSTRAINT [FK_Price_Currency]
GO
ALTER TABLE [dbo].[Prices]  WITH CHECK ADD  CONSTRAINT [FK_Price_ItemUnit] FOREIGN KEY([ItemUnitId])
REFERENCES [dbo].[ItemUnits] ([Id])
GO
ALTER TABLE [dbo].[Prices] CHECK CONSTRAINT [FK_Price_ItemUnit]
GO
ALTER TABLE [dbo].[ReceiptLines]  WITH NOCHECK ADD  CONSTRAINT [FK_ReceiptLines_Item] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Items] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ReceiptLines] NOCHECK CONSTRAINT [FK_ReceiptLines_Item]
GO
ALTER TABLE [dbo].[ReceiptLines]  WITH CHECK ADD  CONSTRAINT [FK_ReceiptLines_Receipt] FOREIGN KEY([ReceiptId])
REFERENCES [dbo].[Receipts] ([Id])
GO
ALTER TABLE [dbo].[ReceiptLines] CHECK CONSTRAINT [FK_ReceiptLines_Receipt]
GO
ALTER TABLE [dbo].[ReceiptLines]  WITH NOCHECK ADD  CONSTRAINT [FK_ReceiptLines_Unit] FOREIGN KEY([UnitId])
REFERENCES [dbo].[Units] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ReceiptLines] NOCHECK CONSTRAINT [FK_ReceiptLines_Unit]
GO
ALTER TABLE [dbo].[ReceiptLines]  WITH NOCHECK ADD  CONSTRAINT [FK_ReceiptLines_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ReceiptLines] NOCHECK CONSTRAINT [FK_ReceiptLines_User]
GO
ALTER TABLE [dbo].[Receipts]  WITH NOCHECK ADD  CONSTRAINT [FK_Receipt_Account] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Accounts] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Receipts] NOCHECK CONSTRAINT [FK_Receipt_Account]
GO
ALTER TABLE [dbo].[Receipts]  WITH NOCHECK ADD  CONSTRAINT [FK_Receipt_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Receipts] NOCHECK CONSTRAINT [FK_Receipt_User]
GO
ALTER TABLE [dbo].[Transactions]  WITH NOCHECK ADD  CONSTRAINT [FK_Transaction_Account] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Accounts] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Transactions] NOCHECK CONSTRAINT [FK_Transaction_Account]
GO
ALTER TABLE [dbo].[Transactions]  WITH NOCHECK ADD  CONSTRAINT [FK_Transaction_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currencies] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Transactions] NOCHECK CONSTRAINT [FK_Transaction_Currency]
GO
ALTER TABLE [dbo].[Transfers]  WITH NOCHECK ADD  CONSTRAINT [FK_Transfer_Account] FOREIGN KEY([ClientFrom])
REFERENCES [dbo].[Accounts] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Transfers] NOCHECK CONSTRAINT [FK_Transfer_Account]
GO
ALTER TABLE [dbo].[Transfers]  WITH NOCHECK ADD  CONSTRAINT [FK_Transfer_Account1] FOREIGN KEY([ClientTo])
REFERENCES [dbo].[Accounts] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Transfers] NOCHECK CONSTRAINT [FK_Transfer_Account1]
GO
ALTER TABLE [dbo].[Transfers]  WITH NOCHECK ADD  CONSTRAINT [FK_Transfer_AccountFund] FOREIGN KEY([FundFrom])
REFERENCES [dbo].[AccountFunds] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Transfers] NOCHECK CONSTRAINT [FK_Transfer_AccountFund]
GO
ALTER TABLE [dbo].[Transfers]  WITH NOCHECK ADD  CONSTRAINT [FK_Transfer_AccountFund1] FOREIGN KEY([FundTo])
REFERENCES [dbo].[AccountFunds] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Transfers] NOCHECK CONSTRAINT [FK_Transfer_AccountFund1]
GO
ALTER TABLE [dbo].[Transfers]  WITH NOCHECK ADD  CONSTRAINT [FK_Transfer_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currencies] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Transfers] NOCHECK CONSTRAINT [FK_Transfer_Currency]
GO
ALTER TABLE [dbo].[Transfers]  WITH NOCHECK ADD  CONSTRAINT [FK_Transfer_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Transfers] NOCHECK CONSTRAINT [FK_Transfer_User]
GO
ALTER TABLE [dbo].[Units]  WITH NOCHECK ADD  CONSTRAINT [FK_Unit_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Units] NOCHECK CONSTRAINT [FK_Unit_User]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Role] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Role]
GO
ALTER TABLE [dbo].[Withdraws]  WITH NOCHECK ADD  CONSTRAINT [FK_Withdraw_Account] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Accounts] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Withdraws] NOCHECK CONSTRAINT [FK_Withdraw_Account]
GO
ALTER TABLE [dbo].[Withdraws]  WITH NOCHECK ADD  CONSTRAINT [FK_Withdraw_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currencies] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Withdraws] NOCHECK CONSTRAINT [FK_Withdraw_Currency]
GO
ALTER TABLE [dbo].[Withdraws]  WITH NOCHECK ADD  CONSTRAINT [FK_Withdraw_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Withdraws] NOCHECK CONSTRAINT [FK_Withdraw_User]
GO
/****** Object:  StoredProcedure [dbo].[11111BillSlip]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[11111BillSlip]
	@BillId int
AS
BEGIN
	SET NOCOUNT ON;

SELECT
	  BL.[Id]
      ,BL.[BillId]
      ,BL.[ItemId]
	  ,(SELECT TEMP.ItemName FROM Items TEMP WHERE TEMP.Id = BL.[ItemId]) AS ItemName
      ,BL.[UnitId]
	  ,(SELECT TEMP.Title FROM Units TEMP WHERE TEMP.Id = BL.[UnitId]) AS UnitName
      ,BL.[Quantity]
      ,BL.[CurrencyId]
	  ,(SELECT TEMP.CurrencyName FROM Currencies TEMP WHERE TEMP.Id = BL.[CurrencyId]) AS CurrencyName
      ,BL.[Price]
      ,BL.[TotalPrice]
	  ,[Exchanged]
      ,[Rate]
      ,[ForeginCurrencyId]
	  ,(SELECT TEMP.CurrencyName FROM Currencies TEMP WHERE TEMP.Id = BL.[ForeginCurrencyId]) AS ForeginCurrencyName
      ,[ExchangedAmount]
	  ,(SELECT (Rate*TotalPrice)) AS ExchangedTotalAmount
	  ,(SELECT COUNT(BLL.Id) From BillLines BLL WHERE BLL.BillId=@BillId) AS LinesCount

  FROM [dbo].[BillLines] BL
  WHERE BL.BillId = @BillId

END

GO
/****** Object:  StoredProcedure [dbo].[BillSlip]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BillSlip]
	@BillId int
AS
BEGIN
	SET NOCOUNT ON;
SELECT
	  BL.[Id]
      ,BL.[BillId]
      ,BL.[ItemId]
	  ,(SELECT TEMP.ItemName FROM Items TEMP WHERE TEMP.Id = BL.[ItemId]) AS ItemName
      ,BL.[UnitId]
	  ,(SELECT TEMP.Title FROM Units TEMP WHERE TEMP.Id = BL.[UnitId]) AS UnitName
      ,BL.[Quantity]
      ,BL.[CurrencyId]
	  ,(SELECT TEMP.CurrencyName FROM Currencies TEMP WHERE TEMP.Id = BL.[CurrencyId]) AS CurrencyName
      ,BL.[Price]
      ,BL.[TotalPrice]
	  ,[Exchanged]
      ,BL.[Rate]
      ,BL.[ForeginCurrencyId]
	  ,(SELECT TEMP.CurrencyName FROM Currencies TEMP WHERE TEMP.Id = BL.[ForeginCurrencyId]) AS ForeginCurrencyName
      ,[ExchangedAmount]
	  --,(SELECT (Rate*TotalPrice)) AS ExchangedTotalAmount
	  ,BL.ExchangedTotalAmount AS ExchangedTotalAmount
	  ,(SELECT COUNT(BLL.Id) From BillLines BLL WHERE BLL.BillId=@BillId) AS LinesCount
  FROM [dbo].[BillLines] BL
  WHERE BL.BillId = @BillId
END

GO
/****** Object:  StoredProcedure [dbo].[CreateClientFunds]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[CreateClientFunds]
@ClientId int
AS
BEGIN
DECLARE @CurrId INT, @CurrName NVARCHAR(30), @CurrSymbol NVARCHAR(3)

DECLARE @MessageOutput VARCHAR(100)

DECLARE Currency_Cursor CURSOR FOR 
    SELECT curr.Id ,curr.CurrencyName,curr.CurrencySymbol  FROM Currencies curr order by curr.Id


OPEN Currency_Cursor 

FETCH NEXT FROM Currency_Cursor INTO
    @CurrId, @CurrName, @CurrSymbol

WHILE @@FETCH_STATUS = 0
BEGIN
    INSERT INTO [dbo].[AccountFunds]
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
/****** Object:  StoredProcedure [dbo].[DailyBillAmount]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DailyBillAmount]
@CurrencyId int,
@Date datetime,
@BillType nvarchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	Declare @USD Money;
	Declare @SYP Money;
	Declare @RATE money;

	SET @RATE=(SELECT TOP(1) cb.Rate FROM CurrencyBulletins cb 
				WHERE	cb.CurrencyId=2 
				ORDER BY cb.RateDate DESC)

	SET @USD=isnull(
	(  SELECT
	SUM(bill.[TotalAmount])	 FROM [dbo].[Bills] bill
  WHERE bill.BillType LIKE @BillType
		AND bill.[CurrencyId]=1
		AND CONVERT(DATE,bill.[LUD])=CONVERT(DATE,@Date)
		),0);
		-----------------------------
		SET @SYP=isnull(
	(  SELECT
	SUM(bill.[TotalAmount])	 FROM [dbo].[Bills] bill
  WHERE bill.BillType LIKE @BillType
		AND bill.[CurrencyId]=2
		AND CONVERT(DATE,bill.[LUD])=CONVERT(DATE,@Date)
		),0);

IF @CurrencyId = 1
  --   SELECT  bill.[TotalAmount]
	 --FROM [dbo].[Bill] bill
  --WHERE bill.BillType LIKE @BillType
		--AND bill.[CurrencyId]=@CurrencyId
		--AND CONVERT(date,bill.[LUD])=CONVERT(DATE,@Date)
		SELECT (@USD + (@SYP/@RATE));
 ELSE IF @CurrencyId = 2
  --   SELECT bill.[ExchangedAmount]
	 -- FROM [dbo].[Bill] bill
	 -- WHERE bill.BillType LIKE @BillType
		--AND bill.[CurrencyId]=@CurrencyId
		--AND CONVERT(date,bill.[LUD])=CONVERT(DATE,@Date)
		SELECT (@SYP + (@USD*@RATE));

 ElSE
     -- Return error code and stop processing
     SELECT -1;  -- THIS is evaluated as the ELSE
     RETURN;  
	 
END

GO
/****** Object:  StoredProcedure [dbo].[DeleteAllData]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[DeleteAllData]
WITH EXECUTE AS CALLER
AS
--SET FMTONLY OFF;
BEGIN
	----DELETE TRANSACTIONS
	DELETE FROM [dbo].[Transactions]
	DBCC CHECKIDENT ( '[dbo].[Transaction]', RESEED, 0 )
	DELETE FROM [dbo].FundTransactions
	DBCC CHECKIDENT ( '[dbo].[FundTransaction]', RESEED, 0 )
	DELETE FROM [dbo].ItemTransactions
	DBCC CHECKIDENT ( '[dbo].[ItemTransaction]', RESEED, 0 )

	----DELETE TABLES DATA
	DELETE FROM [dbo].Items
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[Item]', RESEED, 0 )
	DELETE FROM [dbo].ItemCategories
	WHERE PROTECTED = 0 OR PROTECTED IS NULL
	DBCC CHECKIDENT ( '[dbo].[ItemCategory]', RESEED, 0 )
	DELETE FROM [dbo].[ItemFunds]
	WHERE PROTECTED = 0 OR PROTECTED IS NULL
	DBCC CHECKIDENT ( '[dbo].[ItemFund]', RESEED, 0 )
	DELETE FROM [dbo].AccountFunds
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[AccountFund]', RESEED, 0 )
	DELETE FROM [dbo].Accounts
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[Account]', RESEED, 0 )
	DELETE FROM [dbo].AccountGroups
	WHERE  PROTECTED=0
	DBCC CHECKIDENT ( '[dbo].[AccountGroup]', RESEED, 0 )
	DELETE FROM [dbo].Bills
	WHERE  PROTECTED=0
	DBCC CHECKIDENT ( '[dbo].[Bill]', RESEED, 0 )
	DELETE FROM [dbo].BillLines
	WHERE PROTECTED=0
	DBCC CHECKIDENT ( '[dbo].[BillLines]', RESEED, 0 )
	DELETE FROM [dbo].Currencies
	WHERE PROTECTED = 0 AND PROTECTED=0
	DBCC CHECKIDENT ( '[dbo].[Currency]', RESEED, 0 )
	DELETE FROM [dbo].CurrencyExchanges
	WHERE PROTECTED = 0 OR PROTECTED IS NULL
	DBCC CHECKIDENT ( '[dbo].[CurrencyExchange]', RESEED, 0 )
	DELETE FROM [dbo].CurrencyExchangeOperations
	WHERE PROTECTED = 0 OR PROTECTED IS NULL
	DBCC CHECKIDENT ( '[dbo].[CurrencyExchangeOperations]', RESEED, 0 )
	DELETE FROM [dbo].Exchanges
	WHERE PROTECTED = 0 OR PROTECTED IS NULL
	DBCC CHECKIDENT ( '[dbo].[Exchange]', RESEED, 0 )
	DELETE FROM [dbo].ExchangeFunds
	WHERE PROTECTED = 0 OR PROTECTED IS NULL
	DBCC CHECKIDENT ( '[dbo].[ExchangeFund]', RESEED, 0 )
	DELETE FROM [dbo].Units
	WHERE PROTECTED = 0 OR PROTECTED IS NULL
	DBCC CHECKIDENT ( '[dbo].[Unit]', RESEED, 0 )
	DELETE FROM [dbo].CurrencyBulletins
	DBCC CHECKIDENT ( '[dbo].[CurrencyBulletin]', RESEED, 0 )
	DELETE FROM [dbo].Funds
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[Fund]', RESEED, 0 )
	
	
	DELETE FROM [dbo].Expenses
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[Expense]', RESEED, 0 )
	DELETE FROM [dbo].ExpenseCategories
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[ExpenseCategory]', RESEED, 0 )
	DELETE FROM [dbo].Payments
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[Payment]', RESEED, 0 )
	DELETE FROM [dbo].Units
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[Unit]', RESEED, 0 )
	DELETE FROM [dbo].Roles
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[Role]', RESEED, 0 )
	DELETE FROM [dbo].Withdraws
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[Withdraw]', RESEED, 0 )
	DELETE FROM [dbo].Transfers
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[Transfer]', RESEED, 0 )
	DELETE FROM [dbo].[Users]
	WHERE PROTECTED = 0
	DBCC CHECKIDENT ( '[dbo].[User]', RESEED, 0 )
END

GO
/****** Object:  StoredProcedure [dbo].[ItemAvgPurchasePrice]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ItemAvgPurchasePrice]
@ItemId int,
@unitId int

AS
BEGIN

	SELECT 
	BL.CurrencyId AS 'رقم العملة الاساس',
	(SELECT CURR.CurrencyName FROM Currencies CURR WHERE CURR.Id=BL.CurrencyId) AS 'العملة الاساس',
	BL.ForeginCurrencyId AS 'رقم العملة الطرف',
	(SELECT CURR.CurrencyName FROM Currencies CURR WHERE CURR.Id=BL.ForeginCurrencyId) AS 'العملة الطرف',
	SUM(BL.TotalPrice)/SUM(BL.Quantity) AS 'السعر بالعملة الاساس',
	SUM(BL.ExchangedTotalAmount)/SUM(BL.Quantity) AS 'السعر بالعملة الطرف'
	FROM BillLines BL
	WHERE	BL.BillId IN (SELECT B.Id FROM Bills B WHERE B.BillType LIKE 'شراء')
			AND BL.ItemId=@ItemId
			AND BL.UnitId=@unitId
	GROUP BY BL.CurrencyId,BL.ForeginCurrencyId

END

GO
/****** Object:  StoredProcedure [dbo].[ItemAvgSalePrice]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ItemAvgSalePrice]
@ItemId int,
@unitId int

AS
BEGIN

	SELECT 
	BL.CurrencyId AS 'رقم العملة الاساس',
	(SELECT CURR.CurrencyName FROM Currencies CURR WHERE CURR.Id=BL.CurrencyId) AS 'العملة الاساس',
	BL.ForeginCurrencyId AS 'رقم العملة الطرف',
	(SELECT CURR.CurrencyName FROM Currencies CURR WHERE CURR.Id=BL.ForeginCurrencyId) AS 'العملة الطرف',
	SUM(BL.TotalPrice)/SUM(BL.Quantity) AS 'السعر بالعملة الاساس',
	SUM(BL.ExchangedTotalAmount)/SUM(BL.Quantity) AS 'السعر بالعملة الطرف'
	FROM BillLines BL
	WHERE	BL.BillId IN (SELECT B.Id FROM Bills B WHERE B.BillType LIKE 'بيع')
			AND BL.ItemId=@ItemId
			AND BL.UnitId=@unitId
	GROUP BY BL.CurrencyId,BL.ForeginCurrencyId

END

GO
/****** Object:  StoredProcedure [dbo].[SP_ClientGrand]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[SP_ClientGrand]
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
		(select cr.CurrencyName from Currencies cr where cr.Id= fund.CurrencyId) 'العملة',
		(
			select SUM(trans.Amount)
			from [Transactions] trans
			Where trans.AccountId=@ClientId 
			AND trans.CurrencyId=fund.CurrencyId
		)
	from AccountFunds fund
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
/****** Object:  StoredProcedure [dbo].[SP_ClientsGrand]    Script Date: 09-Aug-22 7:33:03 PM ******/
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
		(select cr.CurrencyName from Currencies cr where cr.Id= fund.CurrencyId) 'العملة',
		(
			(
			select 
			ISNULL((
					SELECT SUM(trans.Amount) 				
					FROM [Transactions] TRANS
					WHERE TRANS.CurrencyId=FUND.CurrencyId					
					),0)
			)
			
		) AS 'الإجمالي'
	from Funds fund
end


GO
/****** Object:  StoredProcedure [dbo].[SP_FundsGrand]    Script Date: 09-Aug-22 7:33:03 PM ******/
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
	(select cr.CurrencyName from Currencies cr where cr.Id= fund.CurrencyId) 'العملة',
	(
		--fund.Balance
		--+
		(	select 
			ISNULL((
					SELECT SUM(trans.Amount) 				
					FROM FundTransactions TRANS
					WHERE TRANS.CurrencyId=FUND.CurrencyId					
					),0)
		)		
	 )as الإجمالي
From Funds fund

end



GO
/****** Object:  StoredProcedure [dbo].[SP_FundsMovements]    Script Date: 09-Aug-22 7:33:03 PM ******/
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

INSERT INTO @OverallResults (Fund,CurrencyId, Currency,Amount)
EXEC SP_FundsGrand;
Update @OverallResults
Set Flag=N'صندوق المكتب'
INSERT INTO @OverallResults (Fund, CurrencyId,Currency,Amount)
EXEC SP_ClientsGrand;
Update @OverallResults
Set Flag=N'الوكلاء'
Where Flag IS NULL;

INSERT INTO @OverallResults (Fund,CurrencyId, Currency,Amount,Flag)
SELECT	A.Fund AS الصندوق, 
		A.CurrencyId AS 'رقم العملة',
		A.Currency AS العملة,
		SUM(A.Amount)
		AS الإجمالي,
		N'الاجمالي العام'
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
/****** Object:  StoredProcedure [dbo].[SP_ItemGrand]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[SP_ItemGrand]
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
		(select u.Title from Units u where u.Id= fund.UnitId) 'الواحدة',
		(
			select SUM(trans.Amount)
			from [ItemTransactions] trans
			Where trans.ItemId=@ItemId 
			AND trans.UnitId=fund.UnitId
		)
	from ItemFunds fund
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
/****** Object:  StoredProcedure [dbo].[SP_ItemsGrand]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[SP_ItemsGrand]
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
		(select cr.Title from Units cr where cr.Id= fund.UnitId) 'الواحدة',
		(
			(
			select 
			ISNULL((
					SELECT SUM(trans.Amount) 				
					FROM [ItemTransactions] TRANS
					WHERE TRANS.UnitId=FUND.UnitId					
					),0)
			)
			
		) AS 'الإجمالي'
	from ItemFunds fund
end


GO
/****** Object:  StoredProcedure [dbo].[TableTruncate]    Script Date: 09-Aug-22 7:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TableTruncate]
	@TableName NVARCHAR(128)
AS

-- SET NOCOUNT ON added to prevent extra result sets from
-- interfering with SELECT statements.
SET NOCOUNT ON;

BEGIN TRAN

DECLARE @NextId NUMERIC = CASE WHEN (IDENT_CURRENT(@TableName) = 1) THEN 1 ELSE 0 END
DECLARE @Sql NVARCHAR(MAX) = 'DELETE FROM [' + @TableName + ']'
EXECUTE sp_executesql @Sql

IF (@@ERROR = 0) BEGIN
	DBCC CHECKIDENT (@TableName, RESEED, @NextId)
	
	COMMIT TRAN
END ELSE BEGIN
	-- Error
	ROLLBACK
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[19] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TRANS"
            Begin Extent = 
               Top = 11
               Left = 501
               Bottom = 280
               Right = 695
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 2532
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_CLIENTS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_CLIENTS'
GO
USE [master]
GO
ALTER DATABASE [Alver] SET  READ_WRITE 
GO

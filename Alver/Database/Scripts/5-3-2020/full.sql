USE [master]
GO
/****** Object:  Database [Alver]    Script Date: 3/6/2020 12:27:03 AM ******/
CREATE DATABASE [Alver]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Alver', FILENAME = N'D:Alver.mdf' , SIZE = 6144KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Alver_log', FILENAME = N'D:Alver_log.ldf' , SIZE = 7616KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

USE [Alver]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  Table [dbo].[Transaction]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  Table [dbo].[CurrencyBulletin]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  View [dbo].[V_CLIENTS]    Script Date: 3/6/2020 12:27:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





/*TRANS.CurrencyId*/
CREATE VIEW [dbo].[V_CLIENTS]
AS
SELECT		ISNULL(AccountId,0) AS AccountId,
			(SELECT    Fullname
			FROM         dbo.Account AS AI
			WHERE      (Id = TRANS.AccountId)) AS Account,
			(SELECT    (SELECT    SUM(Amount)
			FROM          dbo.[Transaction] AS T
			WHERE      (AccountId = TRANS.AccountId) AND (CurrencyId = 1))) AS USDAmount,
			(SELECT    (SELECT    SUM(Amount)
			FROM          dbo.[Transaction] AS T
			WHERE      (AccountId = TRANS.AccountId) AND (CurrencyId = 2)) ) AS SYPAmount,
			(SELECT    (SELECT    SUM(Amount)
			FROM          dbo.[Transaction] AS T
			WHERE      (AccountId = TRANS.AccountId) AND (CurrencyId = 3)) ) AS TLAmount,
			(SELECT    (SELECT    SUM(Amount)
			FROM          dbo.[Transaction] AS T
			WHERE      (AccountId = TRANS.AccountId) AND (CurrencyId = 4)) ) AS EUROAmount,
			(SELECT    (SELECT    SUM(Amount)
			FROM          dbo.[Transaction] AS T
			WHERE      (AccountId = TRANS.AccountId) AND (CurrencyId = 5)) ) AS SARAmount
			,
			(SELECT
			(
				(SELECT    (SELECT    SUM(Amount)	FROM  dbo.[Transaction] AS T	WHERE  (AccountId = TRANS.AccountId) AND (CurrencyId = 1)))
				+
				(
					(SELECT (SELECT  SUM(Amount) FROM dbo.[Transaction] AS T WHERE (AccountId = TRANS.AccountId) AND (CurrencyId = 2)))
					*
					(SELECT (SELECT TOP 1 BUL.ReversedRate FROM CurrencyBulletin BUL WHERE BUL.CurrencyId=2 ORDER BY BUL.RateDate DESC))
				)
				+
				(
					(SELECT (SELECT  SUM(Amount) FROM dbo.[Transaction] AS T WHERE (AccountId = TRANS.AccountId) AND (CurrencyId = 3)))
					*
					(SELECT (SELECT TOP 1 BUL.ReversedRate FROM CurrencyBulletin BUL WHERE BUL.CurrencyId=3 ORDER BY BUL.RateDate DESC))
				)
				+
				(
					(SELECT (SELECT  SUM(Amount) FROM dbo.[Transaction] AS T WHERE (AccountId = TRANS.AccountId) AND (CurrencyId = 4)))
					*
					(SELECT (SELECT TOP 1 BUL.RATE FROM CurrencyBulletin BUL WHERE BUL.CurrencyId=4 ORDER BY BUL.RateDate DESC))
				)
				+
				(
					(SELECT (SELECT  SUM(Amount) FROM dbo.[Transaction] AS T WHERE (AccountId = TRANS.AccountId) AND (CurrencyId = 5)))
					*
					(SELECT (SELECT TOP 1 BUL.ReversedRate FROM CurrencyBulletin BUL WHERE BUL.CurrencyId=5 ORDER BY BUL.RateDate DESC))
				)
			)
			) AS GRAND
FROM         dbo.[Transaction] AS TRANS
GROUP BY AccountId


GO
/****** Object:  Table [dbo].[Item]    Script Date: 3/6/2020 12:27:03 AM ******/
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
	[SalePrice] [money] NULL,
	[PurchasePrice] [money] NULL,
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
/****** Object:  Table [dbo].[ItemTransaction]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  View [dbo].[V_STOCK]    Script Date: 3/6/2020 12:27:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





/*TRANS.CurrencyId*/
CREATE VIEW [dbo].[V_STOCK]
AS
SELECT		ISNULL(ItemId,0) AS 'رقم_المادة',

			(SELECT    AI.ItemName
			FROM         dbo.Item AS AI
			WHERE      (AI.Id = TRANS.ItemId)) AS 'اسم_المادة',

			(SELECT    (SELECT    SUM(Amount)
			FROM          dbo.[ItemTransaction] AS T
			WHERE      (T.ItemId = TRANS.ItemId) AND (T.UnitId = 1))) AS 'عدد_الكروزات_المتوفرة',

			(SELECT    AI.CurrencyId
			FROM         dbo.Item AS AI
			WHERE      (AI.Id = TRANS.ItemId)) AS 'العملة',

			(SELECT    AI.PurchasePrice
			FROM         dbo.Item AS AI
			WHERE      (AI.Id = TRANS.ItemId)) AS 'سعر_شراء_الواحدة',

			(SELECT
			(
				(SELECT (SELECT  SUM(Amount) FROM dbo.[ItemTransaction] AS T WHERE (T.ItemId = TRANS.ItemId) AND (T.UnitId = 1)))
				*
				(SELECT    AI.PurchasePrice	FROM  dbo.Item AS AI	WHERE   (AI.Id = TRANS.ItemId))
			)
			) AS 'تكلفة الشراء',

			(SELECT    AI.SalePrice
			FROM         dbo.Item AS AI
			WHERE      (AI.Id = TRANS.ItemId)) AS 'سعر_مبيع_الواحدة',

			(SELECT
			(
				(SELECT (SELECT  SUM(Amount) FROM dbo.[ItemTransaction] AS T WHERE (T.ItemId = TRANS.ItemId) AND (T.UnitId = 1)))
				*
				(SELECT    AI.SalePrice	FROM  dbo.Item AS AI	WHERE   (AI.Id = TRANS.ItemId))
			)
			) AS 'مجموع المبيعات',

			(SELECT
			(
				(SELECT    AI.SalePrice
			FROM         dbo.Item AS AI
			WHERE      (AI.Id = TRANS.ItemId))
				-
				(SELECT    AI.PurchasePrice
			FROM         dbo.Item AS AI
			WHERE      (AI.Id = TRANS.ItemId))
			)
			) AS 'هامش_الربح_في_القطعة_الواحدة',

			(SELECT
			(
				(SELECT
			(
				(SELECT (SELECT  SUM(Amount) FROM dbo.[ItemTransaction] AS T WHERE (T.ItemId = TRANS.ItemId) AND (T.UnitId = 1)))
				*
				(SELECT    AI.SalePrice	FROM  dbo.Item AS AI	WHERE   (AI.Id = TRANS.ItemId))
			)
			)
			-
			(SELECT
			(
				(SELECT (SELECT  SUM(Amount) FROM dbo.[ItemTransaction] AS T WHERE (T.ItemId = TRANS.ItemId) AND (T.UnitId = 1)))
				*
				(SELECT    AI.PurchasePrice	FROM  dbo.Item AS AI	WHERE   (AI.Id = TRANS.ItemId))
			)
			)
			)
			) AS 'الربح_المتوقع'

FROM         dbo.[ItemTransaction] AS TRANS
GROUP BY TRANS.ItemId


GO
/****** Object:  Table [dbo].[AccountFund]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  Table [dbo].[AccountGroup]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  Table [dbo].[Album]    Script Date: 3/6/2020 12:27:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Album](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AlbumTitle] [nvarchar](50) NULL,
	[Declaration] [nvarchar](50) NULL,
	[UserId] [int] NULL,
	[LUD] [datetime] NULL,
	[GUID] [uniqueidentifier] ROWGUIDCOL  NULL,
	[Flag] [nvarchar](50) NULL,
	[Hidden] [bit] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Album] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppSettings]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  Table [dbo].[Bill]    Script Date: 3/6/2020 12:27:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CheckedOut] [bit] NULL,
	[BillType] [nvarchar](10) NULL,
	[AccountId] [int] NULL,
	[BillDate] [datetime] NULL,
	[Cashout] [bit] NULL,
	[CurrencyId] [int] NULL,
	[BillAmount] [money] NULL,
	[DiscountAmount] [money] NULL,
	[TotalAmount] [money] NULL,
	[Exchanged] [bit] NULL,
	[Rate] [money] NULL,
	[ForeginCurrencyId] [int] NULL,
	[ExchangedAmount] [money] NULL,
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
/****** Object:  Table [dbo].[BillLines]    Script Date: 3/6/2020 12:27:03 AM ******/
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
	[Exchanged] [bit] NULL,
	[Rate] [money] NULL,
	[ForeginCurrencyId] [int] NULL,
	[ExchangedAmount] [money] NULL,
	[ExchangedTotalAmount] [money] NULL,
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
/****** Object:  Table [dbo].[Company]    Script Date: 3/6/2020 12:27:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
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
	[GUID] [uniqueidentifier] ROWGUIDCOL  NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Currency]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  Table [dbo].[CurrencyExchange]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  Table [dbo].[CurrencyExchangeOperations]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  Table [dbo].[Exchange]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  Table [dbo].[ExchangeFund]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  Table [dbo].[Expense]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  Table [dbo].[ExpenseCategory]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  Table [dbo].[Fund]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  Table [dbo].[FundTransaction]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  Table [dbo].[Images]    Script Date: 3/6/2020 12:27:03 AM ******/
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
	[GUID] [uniqueidentifier] ROWGUIDCOL  NULL,
	[Hidden] [bit] NULL,
	[Flag] [nvarchar](50) NULL,
	[LUD] [datetime] NULL,
	[PROTECTED] [bit] NULL,
 CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemCategory]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  Table [dbo].[ItemFund]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  Table [dbo].[Payment]    Script Date: 3/6/2020 12:27:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PaymentType] [nvarchar](20) NULL,
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
/****** Object:  Table [dbo].[Receipt]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  Table [dbo].[ReceiptLines]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  Table [dbo].[Role]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  Table [dbo].[Transfer]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  Table [dbo].[Unit]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  Table [dbo].[User]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  Table [dbo].[Withdraw]    Script Date: 3/6/2020 12:27:03 AM ******/
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
SET IDENTITY_INSERT [dbo].[AccountGroup] ON 

INSERT [dbo].[AccountGroup] ([Id], [GroupTitle], [GroupColor], [GroupIcon], [Declaration], [UserId], [Hidden], [Flag], [GUID], [LUD], [PROTECTED]) VALUES (2, N'مورد', NULL, NULL, NULL, 3, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountGroup] ([Id], [GroupTitle], [GroupColor], [GroupIcon], [Declaration], [UserId], [Hidden], [Flag], [GUID], [LUD], [PROTECTED]) VALUES (3, N'زبون', NULL, NULL, NULL, 3, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[AccountGroup] OFF
SET IDENTITY_INSERT [dbo].[Album] ON 

INSERT [dbo].[Album] ([Id], [AlbumTitle], [Declaration], [UserId], [LUD], [GUID], [Flag], [Hidden], [PROTECTED]) VALUES (1, N'Settings', N'App Settings', 1, CAST(N'2020-02-23T20:57:56.097' AS DateTime), N'f186a8c5-b590-40f2-99db-b7e8f1f7aa7f', NULL, 1, 1)
SET IDENTITY_INSERT [dbo].[Album] OFF
SET IDENTITY_INSERT [dbo].[Company] ON 

INSERT [dbo].[Company] ([Id], [Title], [Motto], [Manager], [ManagerPhone], [Accountant], [AccountantPhone], [Address], [Notes], [LogoId], [EmailAddress], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (1, N'شركة تجريبية', N'لا يوجد', N'مستخدم تجريبي', N'00000000', N'محاسب تجريبي', N'00000000', N'غير محدد', N'لا يوجد', 1, N'ايميل تجريبي', 1, N'd317b071-3457-4985-9a2f-9315b80d99ef', 0, NULL, CAST(N'2020-02-23T21:43:49.190' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Company] OFF
SET IDENTITY_INSERT [dbo].[Currency] ON 

INSERT [dbo].[Currency] ([Id], [CurrencyName], [CurrencySymbol], [CurrencyCode], [BaseCurrency], [ExchangeRate], [Notes], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (1, N'دولار امريكي', N'$', N'USD', 1, 1.0000, NULL, 1, N'76c731da-72b4-42a8-a2fe-c4f7d4966077', 0, NULL, CAST(N'2019-11-09T22:18:47.693' AS DateTime), 1)
INSERT [dbo].[Currency] ([Id], [CurrencyName], [CurrencySymbol], [CurrencyCode], [BaseCurrency], [ExchangeRate], [Notes], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (2, N'ليرة سورية', N'ل.س', N'SYP', 0, NULL, NULL, 1, N'07617da8-e2a3-4138-a18c-9e3802144e5c', 0, NULL, CAST(N'2019-11-09T22:18:47.693' AS DateTime), 1)
INSERT [dbo].[Currency] ([Id], [CurrencyName], [CurrencySymbol], [CurrencyCode], [BaseCurrency], [ExchangeRate], [Notes], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (3, N'ليرة تركية', N'₺', N'TL', 0, NULL, NULL, 1, N'de6751ff-0b2d-4b09-b920-475b2066ce5e', 0, NULL, CAST(N'2019-11-09T22:18:47.693' AS DateTime), 1)
INSERT [dbo].[Currency] ([Id], [CurrencyName], [CurrencySymbol], [CurrencyCode], [BaseCurrency], [ExchangeRate], [Notes], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (4, N'يورو', N'€', N'EUR', 0, NULL, NULL, 1, N'9e6aa285-8b15-4b46-af79-499c2d72ef77', 0, NULL, CAST(N'2019-11-09T22:18:47.693' AS DateTime), 1)
INSERT [dbo].[Currency] ([Id], [CurrencyName], [CurrencySymbol], [CurrencyCode], [BaseCurrency], [ExchangeRate], [Notes], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (5, N'ريال سعودي', N'SR', N'SAR', 0, NULL, NULL, 1, N'ebade2aa-c234-4292-b878-d8b356a92ac4', 0, NULL, CAST(N'2019-11-09T22:18:47.693' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Currency] OFF
SET IDENTITY_INSERT [dbo].[ExpenseCategory] ON 

INSERT [dbo].[ExpenseCategory] ([Id], [Title], [Declaration], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (1, N'نثريات', N'لا يوجد', 2, N'4221762a-8a5f-430e-8887-1b00168a6f26', 0, N'', CAST(N'2020-02-28T12:30:30.620' AS DateTime), 1)
INSERT [dbo].[ExpenseCategory] ([Id], [Title], [Declaration], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (2, N'قرطاسية', N'لا يوجد', 2, N'65a2c79e-7c22-46a2-96bf-583dac95f7eb', 0, N'', CAST(N'2020-02-28T12:30:30.620' AS DateTime), 1)
INSERT [dbo].[ExpenseCategory] ([Id], [Title], [Declaration], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (3, N'رواتب', N'لا يوجد', 2, N'd42828e8-99b4-488f-8424-99294a7bf447', 0, N'', CAST(N'2020-02-28T12:30:30.620' AS DateTime), 1)
INSERT [dbo].[ExpenseCategory] ([Id], [Title], [Declaration], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (4, N'فواتير مياه', N'لا يوجد', 2, N'137ac7d1-66d9-46f1-bfbd-519090b563f1', 0, N'', CAST(N'2020-02-28T12:30:30.620' AS DateTime), 1)
INSERT [dbo].[ExpenseCategory] ([Id], [Title], [Declaration], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (5, N'كهرباء - امبيرات', N'لا يوجد', 2, N'6f3939ab-a337-44f3-87b4-01aa8973e05f', 0, N'', CAST(N'2020-02-28T12:30:30.620' AS DateTime), 1)
INSERT [dbo].[ExpenseCategory] ([Id], [Title], [Declaration], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (6, N'كهرباء - مولدة', N'لا يوجد', 2, N'ca4b6d5c-d1af-40b4-914b-f33b90e9009e', 0, N'', CAST(N'2020-02-28T12:30:30.620' AS DateTime), 1)
INSERT [dbo].[ExpenseCategory] ([Id], [Title], [Declaration], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (7, N'صيانة', N'لا يوجد', 3, N'f5bc0bc7-96cb-48b4-bc71-c40aa3b74449', 0, N'', CAST(N'2020-02-28T12:30:30.620' AS DateTime), 1)
INSERT [dbo].[ExpenseCategory] ([Id], [Title], [Declaration], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (8, N'مأكولات', N'لا يوجد', 2, N'a393fb4d-aec1-45be-a5c3-ad04027336a7', 0, N'', CAST(N'2020-02-28T12:30:30.620' AS DateTime), 1)
INSERT [dbo].[ExpenseCategory] ([Id], [Title], [Declaration], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (9, N'مشروبات', N'لا يوجد', 2, N'029701da-47a6-400a-8938-b3198e987ee2', 0, N'', CAST(N'2020-02-28T12:30:30.620' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[ExpenseCategory] OFF
SET IDENTITY_INSERT [dbo].[Fund] ON 

INSERT [dbo].[Fund] ([Id], [FundTitle], [CurrencyId], [Balance], [BalanceDirection], [Declaration], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (1, N'صندوق الدولار', 1, 0.0000, N'لنا', N'', 1, N'cdc98385-aade-428c-a540-e1446d51ac12', 0, N'', CAST(N'2019-08-27T03:53:18.293' AS DateTime), 1)
INSERT [dbo].[Fund] ([Id], [FundTitle], [CurrencyId], [Balance], [BalanceDirection], [Declaration], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (2, N'صندوق السوري', 2, 0.0000, N'لنا', N'', 1, N'd3fedfd9-6997-4b66-9896-bd8194edfadc', 0, N'', CAST(N'2019-08-27T03:53:18.363' AS DateTime), 1)
INSERT [dbo].[Fund] ([Id], [FundTitle], [CurrencyId], [Balance], [BalanceDirection], [Declaration], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (3, N'صندوق التركي', 3, 0.0000, N'لنا', N'', 1, N'b83fa457-60ce-4df6-b7be-e4f1a32cbbc5', 0, N'', CAST(N'2019-08-27T03:53:18.367' AS DateTime), 1)
INSERT [dbo].[Fund] ([Id], [FundTitle], [CurrencyId], [Balance], [BalanceDirection], [Declaration], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (4, N'صندوق اليورو', 4, 0.0000, N'لنا', N'', 1, N'7e3ce3f9-c047-4069-8566-22177bed12b9', 0, N'', CAST(N'2019-08-27T03:53:18.370' AS DateTime), 1)
INSERT [dbo].[Fund] ([Id], [FundTitle], [CurrencyId], [Balance], [BalanceDirection], [Declaration], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (5, N'صندوق السعودي', 5, 0.0000, N'لنا', N'', 1, N'be17e9b8-e71b-4948-8b40-f4317b6b3497', 0, N'', CAST(N'2019-08-27T03:54:44.983' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Fund] OFF
SET IDENTITY_INSERT [dbo].[Images] ON 

INSERT [dbo].[Images] ([Id], [AlbumId], [ImageData], [ImageTitle], [Notes], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (1, 1, 0x4749463839617D007D008700000000000000330000660000990000CC0000FF002B00002B33002B66002B99002BCC002BFF0055000055330055660055990055CC0055FF0080000080330080660080990080CC0080FF00AA0000AA3300AA6600AA9900AACC00AAFF00D50000D53300D56600D59900D5CC00D5FF00FF0000FF3300FF6600FF9900FFCC00FFFF3300003300333300663300993300CC3300FF332B00332B33332B66332B99332BCC332BFF3355003355333355663355993355CC3355FF3380003380333380663380993380CC3380FF33AA0033AA3333AA6633AA9933AACC33AAFF33D50033D53333D56633D59933D5CC33D5FF33FF0033FF3333FF6633FF9933FFCC33FFFF6600006600336600666600996600CC6600FF662B00662B33662B66662B99662BCC662BFF6655006655336655666655996655CC6655FF6680006680336680666680996680CC6680FF66AA0066AA3366AA6666AA9966AACC66AAFF66D50066D53366D56666D59966D5CC66D5FF66FF0066FF3366FF6666FF9966FFCC66FFFF9900009900339900669900999900CC9900FF992B00992B33992B66992B99992BCC992BFF9955009955339955669955999955CC9955FF9980009980339980669980999980CC9980FF99AA0099AA3399AA6699AA9999AACC99AAFF99D50099D53399D56699D59999D5CC99D5FF99FF0099FF3399FF6699FF9999FFCC99FFFFCC0000CC0033CC0066CC0099CC00CCCC00FFCC2B00CC2B33CC2B66CC2B99CC2BCCCC2BFFCC5500CC5533CC5566CC5599CC55CCCC55FFCC8000CC8033CC8066CC8099CC80CCCC80FFCCAA00CCAA33CCAA66CCAA99CCAACCCCAAFFCCD500CCD533CCD566CCD599CCD5CCCCD5FFCCFF00CCFF33CCFF66CCFF99CCFFCCCCFFFFFF0000FF0033FF0066FF0099FF00CCFF00FFFF2B00FF2B33FF2B66FF2B99FF2BCCFF2BFFFF5500FF5533FF5566FF5599FF55CCFF55FFFF8000FF8033FF8066FF8099FF80CCFF80FFFFAA00FFAA33FFAA66FFAA99FFAACCFFAAFFFFD500FFD533FFD566FFD599FFD5CCFFD5FFFFFF00FFFF33FFFF66FFFF99FFFFCCFFFFFF00000000000000000000000021FF0B4E45545343415045322E30030101000021F904010000FC002C000000007D007D000008FF00F7091C48B0A0C18308132A5CC8B0A1C38710234A9C48B1A2C58B18336ADCC8B1A3C78F20438A1C49B2A4C9932853AA5CC9B2A5CB973063CAC4A82F614D85376FCEDC6993A34E9E3C7302BDA80CA2B26546972185486FE9D085CA8829ABB77099B262518F325C265599D68656893D6548CCAAD78447BD2EC3EA95EAC1AC5CD7AA4D18D66BD1B10A431D2D2BB56034A971B1AEE5FA55603DAB72111F156C50ED55AED1F022AC771594D5506C0546B55A4CAFB250652DDB456AB798E5659AB8820E6B751FE7AB472D8B958C503056B6A6CBC64D5B0C31DFC4CA36A5DDAD58E9F0E1A06EDFA5ED776F28C4C295127B9E3CF8DEE29B79A3E65C5D38D6DFBD757FFF9ECDBC206CABD1CF133F0F1A73F0D782170FDFFD1CF6F3E96595452E4F70FAF9D0DC2995DA32B21587DE65B789865574ABE5C7966F4EF1B74F34C42968DD6B1856B6A0769F25961A6F20DE171728534938507EDE1DB7A16A477DA89869AC01F6DF6ADB5D676131FB99E8986FAB1D17577E710D58168CE81DA517622EFA27577A260EB4896A653DE9DC90C92156DD91F961895860E7A9A7E46B4D6A66DB70E26D391E7CB1FD486090568E88DA51D2D5E8D44F927DD861591F7A575D6F4745C799996EFE699F83D519875598AEC9A71B70D8C5C7A25EA6C1089B6003C269A952579227E16B47F688D9769D4DB7CC6A2262559FA3052A93DA864FFE96568E1202FF36A4524FF646AB524AF5F6A9ADCFF5C627A8D72188ABAECBA4E8968EDB2D33461A63A8D1EC18CB323B0619CC3A9B06B53A4CCB6C1AC2A5276759D53ECBEC8B6146E3680E39E8802EBAEAB69BEEBAEAE63006BBE83E29D7AF0092B12EBD7C62052B3DE54D1ACABC3A9051B0BAFA668B30C2E9EAA0F0BC66AD09E06339186C70C53914B95C4174B2A4D3B11302A694BCEFD23046BB09A77B72BAFAA69C43319D2977AF65F3E63043CAC5815C90CE26D5C47341DB9585AEBE18EBD005BAF37AB1AED2ECCE3B2F90A2027955D148BF0CE57EB0B6C433D6AA66A24996C56842091C948C5DB6D8649B4D89D86297AD46D9948C0AA46C346AA206DB94DC5D9C267CDFFF9563D62CD5A3091A62E050B818B9C2F92BB1B6E28AD973B82A05796F7BC2292AAF9857478C1887E38086588093A44FD6D164D279E19EF708637216B2A9DB9017E279DC67639E69BB60CBA08183E1BC8B9149842945B6F9EEA8F38EC6755DC655EC8B36428898728EE6B918AE8F55567818BBF72E4651A1939449F6A7F3EE5F6783F1296578728F0A9F68D17D78A490667A07695A6988E143EFD9E330C94A84F3EEF9EEBAF3DCDEF84640026E4213072C2025EA132741C92C4B7C5B5B014D5516F059107B62408340BAA79163A581773EB801EA46880302F98A5E368BD7BED0350374A54638E3434E919E4734778D8181CAF860E774D7391CA4E1249320A110FF71E003C4A5495E337058C2744003943D6C13B8AB8C9AE2E39D6554EC663A4862C642538CE215EF7F9CBB412608D2318D28237BD8231E1149F8A762102C6544D3170DD8D5C20181C241B1E1538F1093B287A52F8787BB5F0FC1A79F904486733B5463EFD0502C23912C0726CBA20DB34532288A264B40A2E27B4896B231286613432C22FE383712D309D28220449D76E6450668C90B5AB09457CBC6A089607DEA31002A13B3F4054B5AEEA67E82BC81FF4888034D888478C23C5D300DC7482039EE99918BDC2D5F93162D5D273590935CE4FCA348FB01508D870B8932C2F73F70128F7D33B4CDA862D61EC1E049620DBACCC45E53ABE501690CE113E2290BE9FF9137F82F80BD13A640118747C580C6313B3292A57E852032C90587113B93406F904C359E727763FC08E7BAA9C803C4E0A331B88C4223A5382EA1EF9DB9DCE33B3F3329EBF42635F9C1C1476510838AE2AF771F898639ED37C21B7C140131C0C1A494D7BC0EB1745497E2927420271F3DFA884C32F5E80152B93B0C0A928315A187E14478BF61EE2E0607F0A90C02E4529642AFA5673DD27F82B626B46A488A37A0E9476D4ACCC26D4C239AF0E23045F9518F0AF5790ECD529A8E2A9A061D4934C5992762D3B2171C78B4013250A4284569B8BB66E48CE51C220E6EE0D18F66220D9998C41B269109357C3613998003692941DA495022B4AD7D2D69512B5BD1FF4EC2B66F906D695B3BDACF6A02B49390294845B8D3CD16CE981D19C64D012A06618214A83F8D810C3A0BD2CE4A15ACD805EA75B58B5DB94217BBE085EE74410ADECE2AD2AB76F508287A984FC7C6A00135B52E793DFA5DF2DA77AEF79D2B75E56B5FEA8E77BC3EADE91A335BCE6158A48CC4C81E73D518E0BEE2F7BD600D306763E000085718BE6195EA84338CDD09C7D5A7537DAC5CAFDB60ED7A75AB6AB42C46408141FC9D418D609DAE58A52AD7F1EEB7BA72EDAB5CE3EA519AF6D8C1D49DAF4CE38A5D8FFA94AE86A3AC1890CB910467B6ABA8FBF04CE12B65C8FA54A68E253295DF2B032BC7D8C85D0E2A84B11CD41067D9C1F025B374FF69C1C2DD40FFC54439717B514967540E92BDE83D6FFEC879D3FCD919848663F2464C67CE240FB1BD87C3F32839AAD944DF949C8E0E6300EB5A598F9C3190E755749FBF7862391351CF83EC3431334DD51E1CEE0682C66B18A03C4A288B529FA8EB1F4F8B2B4A1E16AE8885636E7B0338E972F2B0B884B4F4A2BDC9BB16F78ED5FE6334AB47FDC5CEB9BACDC37EF49E4599EA8C109A78CB16A6924378BDAA6EB5DBDE84F4B7C7DD5C37771B0761B8F3A78B97C617E79AB8A80B039C2D82D921FEBADDE846B1184C8D037E9B3A84E806F8198439F07E075C843DC0C18B15EE3984172EE1374083C345788355638FDF7A2561B531925730FA39D76840C31944EE8633B441E427FF3FC3C84D2EF2334862E52F17B9CC2321F395D7DCE6388FF9C8538E069E8F3CE4E67CF5EEE65D91715AD4D8623803329C818CA63BFDE94B87FAD399DE74AA533DEA58AFBAD3A97E0CAB4B7DEA4D47431A8979BF306CFC22DFAB6B1129DA06641CE318CD78BBDCE74E77B8D7FDEE758F3BDEF7AE77BBBF1D196798F5DA4F47748A185DD44977BBDCF5CEF8B7377EF190F7BBDFFB4EF7BE3F5EF27547062684E9E9627A4413490E7DAE377B09B7537EEF73B77CDEEF7E79CC3B3EF59107BCA74559F88924C3DCA056BAE2237FF9D3571EEFBE3FBD33504F79CD479CCDF13EBB45401F3EA1977EF18A8FFEDFE3AEF8E1FFDDEED1A73EF5DF6E7DE9A75EF1DBBF3EFFF5DD5DE8C381C2D2A853B21A95EE7AD513FF18BBF7FDEF5FDFF5CC4F7EEEC870431892A9FEDD694A23DFF36B5415066D277DCDE07DA6677AF0277FBB677DF5777D0F887F97177F7F477E7B657EC2465C72C67EAC477FC0077E1E9877F1607F7DB77BF4177D9B27807A65601DD171C7D653A5870CAD37826F3782E1677FE26783106877F1E080B0B78010387E17986422747E1D8159BDB63B0BC7813B2883F00777200885F4D77A14F884B1277F1E987F63C75138F07FD64669A8A3724C2779948785AF678272E784AED7817F770F73478369487EBF066F42256CADD63B4CE87768A88009F87B6EE7838EE7766A387C3758794EC8876E506E6D5676CA571179FFC56D0CB6766ED0744F288807588998688582A889D74789D2F7897F377C9BB8899A28099C377A8A547B12717B79763D68A0755F97755B0776B17875B2488BB3188B4ED73F2AD83B8D4811A067687416062DA7726DA072C8A87291A08CCC7806977006CB188D6DB08CD0988CC8188DD6888DCC788CD768723F5751F0764AC960695B48559D936E22B47F62A08ED84371F9E68EEDD85CF9863DE8B88EEF586E14D75CF4888FE50670E7A657F8F38B13C17CD8D68A1CB56D88567E7BB66E4F966CCDB66816858AE9B73DC2366BBCC35513C985944659165590A3A76EE8754A0F493CE1664E1A98511CA15C9D4787BEE691DF847CC53592B1E692336991BD3884BCFFA38A1171462D3659E7785194E66925B960C6E3929DE690C5A691FA26480229111D0794052994E6288CD2D66B42C49235F96AEB98681B756B5E394CC2A49346216DD1F66B98C669F9E48E6C0691D7D37F9C13068C20065CB00862B0055B996EA3364C4D19112E888ABD86062462175E010DCA000AC115709C830699209883691569A7468A29988469172E586C86600885000BAFC008AF000BB060088CC0088BC643B457910CC65E537114D0500FD0B00C4D5114B2E67F14A21F459116AD4968A8F33BAAE99AD15014CB409811576E8CA099DA900DB0900ADAD099D9900AAF608F9A653828396812396D694098FAA00CF4D016ABE91504996EBD0930D8E99AFAA2E09A56F16DDB5314D9F99AD9999A23240685F00AD4300DD9209FF1990DD4609C864055C69593764887A3170669401994110DAC4919B5A90CFC8703F4F09D56719D56C19A67045007BA0CD7B90F5AA11F4A6608B0209FD3A00DF2E9A1F6F90A78996C66B99710D171C5B3608B69A1EB491916FA9B7D2906BDC99A4DD114FAF09A87675747A10F94E19AD0909D94916861000BD900A2F4499FD9F00A86D04349280646FFC8114627743D340966110D0BAA0CE3199ECA3542B5F99B107AA5169A8A057A1647F19AFB306962A0A1F3E9A1207A9FF2F9964AC9821CF13D9B26481A549B3D8A9D16AA0F0499415601A4E1F9A366417884490FDB69A17BBA0C9DB30886609FF3E9A86E9A9C4B7A6293F6A41B61745FE94569909A865AA08449198F983DE3399E3FCAA0DB197A7F65A68E919DB943929989A48EDAA11D9A6E2FA8485EC871A7E89262C4A06D919AD7E964B9D6A30EDAA9534198E0449BD759AC608AA986D3991CFAA86E8A9F41898147386B87B6A9A45A0FD9FAA99F304C144A9ED749190E3A4E9DE31535CA9ACB4019AC2A6B690A9FD9900DAA10AB1E0A0BB45A92A82AA71BFF118C7959389330A36AA19EBF09AC45C4AB94D19ABC7946A7589BDBE9A3DFAA0FE05408C5299FD0EAA84ADA6AA763A91A910C54F56BA224ACDFBA9AAD490F6F4042A969A5FE3A9EF490579DA39B2EAA1F356A155D0997B0709F34BBA6D3D099B4CA60FE63769F078617F93B218B18DB89A20AE6A53B2AB4C46095C7F39B69510FBDD99B1FA43D99A999545BB571E96CE424960F516F7BD5661B45388493411A686B86939866DBB5E063B6B8164642F4965CC0398590A65BA9814C4A3C26FA10843678C066917FE6555D05998CC685D0A66F651B6DF67A8E187B598324A57A6BB8A2267A8536694029809D276E8AB4605AEB109AE09F0BA99403465966D9B79EAFBB60A294708A0690E1C39299DB1051FA4D1F297A8204958F566BE0346B56C996D1D68AD8A38222199D7815509BE6B9F1866C7AF5B7FA14B800A99F09076A2FD96DABCB10CAD09319B74C1BA94CAD2842B8B7B70C29B98E2B749E76B79AAB3B615B4484836BFF03B619E4393CC55345846B607BBEEC9BBEEF2BBEEAEBBEEA9BBEF29B41F2ABBEEA5BBEF94B38CF8B28023CC0045CC0067CC0089CC00ABCC00CDCC00EFCC0101CC1123CC1144CC00101003B, N'شعار الشركة', NULL, N'b8d84e2a-5db6-4e71-9d8b-e05342236081', 0, N'', CAST(N'2020-02-24T11:39:14.377' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Images] OFF
SET IDENTITY_INSERT [dbo].[Payment] ON 

INSERT [dbo].[Payment] ([Id], [PaymentType], [PaymentDate], [AccountId], [CurrencyId], [Amount], [Declaration], [Payed], [Locked], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (3, N'تغذية_صندوق', CAST(N'2020-03-05T23:35:52.663' AS DateTime), 1, 1, 2.0000, N'', 1, 0, 1, N'cc1e90f9-1333-479f-84e2-84eb3b459f5d', 0, N'', CAST(N'2020-03-05T23:35:55.617' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Payment] OFF
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([Id], [RoleTitle], [Declaration], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (1, N'Owner', N'Database Owner', N'f70d9626-c079-42b7-b23a-929f1d37185e', 1, N'OWNER', CAST(N'2019-08-09T15:54:10.550' AS DateTime), 1)
INSERT [dbo].[Role] ([Id], [RoleTitle], [Declaration], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (2, N'المدير العام', NULL, N'378ac68c-7524-42c7-bca6-9dd0999e7f7a', 0, NULL, CAST(N'2019-08-09T15:55:56.767' AS DateTime), 1)
INSERT [dbo].[Role] ([Id], [RoleTitle], [Declaration], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (3, N'مستخدم', NULL, N'9f8c398a-edd7-4897-a908-eb251fa62647', 0, NULL, CAST(N'2019-08-09T16:00:29.013' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Role] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [RoleId], [UserName], [Password], [FullName], [LoginAttempts], [Locked], [Deactivated], [Declaration], [CD], [LLD], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (1, 1, N'ADMIN', N'5111990@bdo', N'ADMIN', 0, 1, 0, N'ADMINISTRATOR', NULL, CAST(N'2020-03-05T23:31:45.080' AS DateTime), N'ccfab2c0-f13d-4e2d-a893-5ff2e11fb64f', 1, NULL, CAST(N'2019-08-16T16:15:35.233' AS DateTime), 1)
INSERT [dbo].[User] ([Id], [RoleId], [UserName], [Password], [FullName], [LoginAttempts], [Locked], [Deactivated], [Declaration], [CD], [LLD], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (2, 2, N'المدير', N'12345', N'المدير', 0, 1, 0, NULL, NULL, CAST(N'2020-03-05T23:50:11.360' AS DateTime), N'c8f343da-cdab-43a3-b2a3-e98208315184', 0, NULL, CAST(N'2019-08-16T16:15:35.233' AS DateTime), 1)
INSERT [dbo].[User] ([Id], [RoleId], [UserName], [Password], [FullName], [LoginAttempts], [Locked], [Deactivated], [Declaration], [CD], [LLD], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (3, 3, N'0', N'0', N'حناااااااااان', NULL, NULL, NULL, N'', CAST(N'2020-03-05T23:50:30.067' AS DateTime), NULL, N'30fe64c9-7b65-46f4-84b9-9115454c67af', 0, N'', CAST(N'2020-03-05T23:50:30.067' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[User] OFF
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
ALTER TABLE [dbo].[Album] ADD  CONSTRAINT [DF_Album_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[Album] ADD  CONSTRAINT [DF_Album_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[Album] ADD  CONSTRAINT [DF_Album_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[Album] ADD  CONSTRAINT [DF_Album_Protected]  DEFAULT ((0)) FOR [PROTECTED]
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
ALTER TABLE [dbo].[Company] ADD  CONSTRAINT [DF_Company_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[Company] ADD  CONSTRAINT [DF_Company_Hidden]  DEFAULT ((0)) FOR [Hidden]
GO
ALTER TABLE [dbo].[Company] ADD  CONSTRAINT [DF_Company_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[Company] ADD  CONSTRAINT [DF_Company_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
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
ALTER TABLE [dbo].[Images] ADD  CONSTRAINT [DF_Images_GUID]  DEFAULT (newid()) FOR [GUID]
GO
ALTER TABLE [dbo].[Images] ADD  CONSTRAINT [DF_Images_LUD]  DEFAULT (getdate()) FOR [LUD]
GO
ALTER TABLE [dbo].[Images] ADD  CONSTRAINT [DF_Images_PROTECTED]  DEFAULT ((0)) FOR [PROTECTED]
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
ALTER TABLE [dbo].[BillLines]  WITH NOCHECK ADD  CONSTRAINT [FK_BillLines_Currency1] FOREIGN KEY([ForeginCurrencyId])
REFERENCES [dbo].[Currency] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[BillLines] NOCHECK CONSTRAINT [FK_BillLines_Currency1]
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
ALTER TABLE [dbo].[Company]  WITH NOCHECK ADD  CONSTRAINT [FK_Company_Images] FOREIGN KEY([LogoId])
REFERENCES [dbo].[Images] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Company] NOCHECK CONSTRAINT [FK_Company_Images]
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
ALTER TABLE [dbo].[Images]  WITH NOCHECK ADD  CONSTRAINT [FK_Images_Album] FOREIGN KEY([AlbumId])
REFERENCES [dbo].[Album] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Images] NOCHECK CONSTRAINT [FK_Images_Album]
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
/****** Object:  StoredProcedure [dbo].[BillSlip]    Script Date: 3/6/2020 12:27:03 AM ******/
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
	  ,(SELECT TEMP.ItemName FROM Item TEMP WHERE TEMP.Id = BL.[ItemId]) AS ItemName
      ,BL.[UnitId]
	  ,(SELECT TEMP.Title FROM Unit TEMP WHERE TEMP.Id = BL.[UnitId]) AS UnitName
      ,BL.[Quantity]
      ,BL.[CurrencyId]
	  ,(SELECT TEMP.CurrencyName FROM Currency TEMP WHERE TEMP.Id = BL.[CurrencyId]) AS CurrencyName
      ,BL.[Price]
      ,BL.[TotalPrice]
	  ,[Exchanged]
      ,[Rate]
      ,[ForeginCurrencyId]
	  ,(SELECT TEMP.CurrencyName FROM Currency TEMP WHERE TEMP.Id = BL.[ForeginCurrencyId]) AS ForeginCurrencyName
      ,[ExchangedAmount]
	  ,(SELECT (Rate*TotalPrice)) AS ExchangedTotalAmount
	  ,(SELECT COUNT(BLL.Id) From BillLines BLL WHERE BLL.BillId=@BillId) AS LinesCount

  FROM [dbo].[BillLines] BL
  WHERE BL.BillId = @BillId

END
GO
/****** Object:  StoredProcedure [dbo].[CreateClientFunds]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  StoredProcedure [dbo].[DeleteAllData]    Script Date: 3/6/2020 12:27:03 AM ******/
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
	DELETE FROM [dbo].ItemCategory
	WHERE PROTECTED = 0 OR PROTECTED IS NULL
	DBCC CHECKIDENT ( '[dbo].[ItemCategory]', RESEED, 0 )
	DELETE FROM [dbo].[ItemFund]
	WHERE PROTECTED = 0 OR PROTECTED IS NULL
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
	DELETE FROM [dbo].Unit
	WHERE PROTECTED = 0 OR PROTECTED IS NULL
	DBCC CHECKIDENT ( '[dbo].[Unit]', RESEED, 0 )
	DELETE FROM [dbo].CurrencyBulletin
	DBCC CHECKIDENT ( '[dbo].[CurrencyBulletin]', RESEED, 0 )
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
/****** Object:  StoredProcedure [dbo].[ItemAvgPurchasePrice]    Script Date: 3/6/2020 12:27:03 AM ******/
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
	(SELECT CURR.CurrencyName FROM Currency CURR WHERE CURR.Id=BL.CurrencyId) AS 'العملة الاساس',
	BL.ForeginCurrencyId AS 'رقم العملة الطرف',
	(SELECT CURR.CurrencyName FROM Currency CURR WHERE CURR.Id=BL.ForeginCurrencyId) AS 'العملة الطرف',
	SUM(BL.TotalPrice)/SUM(BL.Quantity) AS 'السعر بالعملة الاساس',
	SUM(BL.ExchangedTotalAmount)/SUM(BL.Quantity) AS 'السعر بالعملة الطرف'
	FROM BillLines BL
	WHERE	BL.BillId IN (SELECT B.Id FROM Bill B WHERE B.BillType LIKE 'شراء')
			AND BL.ItemId=@ItemId
			AND BL.UnitId=@unitId
	GROUP BY BL.CurrencyId,BL.ForeginCurrencyId

END
GO
/****** Object:  StoredProcedure [dbo].[ItemAvgSalePrice]    Script Date: 3/6/2020 12:27:03 AM ******/
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
	(SELECT CURR.CurrencyName FROM Currency CURR WHERE CURR.Id=BL.CurrencyId) AS 'العملة الاساس',
	BL.ForeginCurrencyId AS 'رقم العملة الطرف',
	(SELECT CURR.CurrencyName FROM Currency CURR WHERE CURR.Id=BL.ForeginCurrencyId) AS 'العملة الطرف',
	SUM(BL.TotalPrice)/SUM(BL.Quantity) AS 'السعر بالعملة الاساس',
	SUM(BL.ExchangedTotalAmount)/SUM(BL.Quantity) AS 'السعر بالعملة الطرف'
	FROM BillLines BL
	WHERE	BL.BillId IN (SELECT B.Id FROM Bill B WHERE B.BillType LIKE 'بيع')
			AND BL.ItemId=@ItemId
			AND BL.UnitId=@unitId
	GROUP BY BL.CurrencyId,BL.ForeginCurrencyId

END
GO
/****** Object:  StoredProcedure [dbo].[SP_ClientGrand]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_ClientsGrand]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_FundsGrand]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_FundsMovements]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_ItemGrand]    Script Date: 3/6/2020 12:27:03 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_ItemsGrand]    Script Date: 3/6/2020 12:27:03 AM ******/
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

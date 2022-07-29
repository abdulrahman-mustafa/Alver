
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/23/2022 14:58:32
-- Generated from EDMX file: C:\Alver\Alver\Alver\DAL\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Alver];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Account_AccountGroup]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Account] DROP CONSTRAINT [FK_Account_AccountGroup];
GO
IF OBJECT_ID(N'[dbo].[FK_Account_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Account] DROP CONSTRAINT [FK_Account_User];
GO
IF OBJECT_ID(N'[dbo].[FK_AccountFund_Account]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AccountFund] DROP CONSTRAINT [FK_AccountFund_Account];
GO
IF OBJECT_ID(N'[dbo].[FK_AccountFund_Currency]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AccountFund] DROP CONSTRAINT [FK_AccountFund_Currency];
GO
IF OBJECT_ID(N'[dbo].[FK_Bill_Account]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bill] DROP CONSTRAINT [FK_Bill_Account];
GO
IF OBJECT_ID(N'[dbo].[FK_Bill_Currency]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bill] DROP CONSTRAINT [FK_Bill_Currency];
GO
IF OBJECT_ID(N'[dbo].[FK_Bill_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bill] DROP CONSTRAINT [FK_Bill_User];
GO
IF OBJECT_ID(N'[dbo].[FK_BillLines_Bill]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BillLines] DROP CONSTRAINT [FK_BillLines_Bill];
GO
IF OBJECT_ID(N'[dbo].[FK_BillLines_Currency]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BillLines] DROP CONSTRAINT [FK_BillLines_Currency];
GO
IF OBJECT_ID(N'[dbo].[FK_BillLines_Currency1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BillLines] DROP CONSTRAINT [FK_BillLines_Currency1];
GO
IF OBJECT_ID(N'[dbo].[FK_BillLines_Item]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BillLines] DROP CONSTRAINT [FK_BillLines_Item];
GO
IF OBJECT_ID(N'[dbo].[FK_BillLines_Unit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BillLines] DROP CONSTRAINT [FK_BillLines_Unit];
GO
IF OBJECT_ID(N'[dbo].[FK_BillLines_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BillLines] DROP CONSTRAINT [FK_BillLines_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Company_Images]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Company] DROP CONSTRAINT [FK_Company_Images];
GO
IF OBJECT_ID(N'[dbo].[FK_Currency_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Currency] DROP CONSTRAINT [FK_Currency_User];
GO
IF OBJECT_ID(N'[dbo].[FK_CurrencyBulletin_Currency]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CurrencyBulletin] DROP CONSTRAINT [FK_CurrencyBulletin_Currency];
GO
IF OBJECT_ID(N'[dbo].[FK_CurrencyExchange_Users_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CurrencyExchange] DROP CONSTRAINT [FK_CurrencyExchange_Users_User];
GO
IF OBJECT_ID(N'[dbo].[FK_CurrencyExchangeOperations_Currency]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CurrencyExchangeOperations] DROP CONSTRAINT [FK_CurrencyExchangeOperations_Currency];
GO
IF OBJECT_ID(N'[dbo].[FK_CurrencyExchangeOperations_Currency1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CurrencyExchangeOperations] DROP CONSTRAINT [FK_CurrencyExchangeOperations_Currency1];
GO
IF OBJECT_ID(N'[dbo].[FK_CurrencyExchangeOperations_CurrencyExchange1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CurrencyExchangeOperations] DROP CONSTRAINT [FK_CurrencyExchangeOperations_CurrencyExchange1];
GO
IF OBJECT_ID(N'[dbo].[FK_CurrencyExchangeOperations_Users_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CurrencyExchangeOperations] DROP CONSTRAINT [FK_CurrencyExchangeOperations_Users_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Exchange_BaseCurrency]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Exchange] DROP CONSTRAINT [FK_Exchange_BaseCurrency];
GO
IF OBJECT_ID(N'[dbo].[FK_Exchange_SubCurrency]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Exchange] DROP CONSTRAINT [FK_Exchange_SubCurrency];
GO
IF OBJECT_ID(N'[dbo].[FK_Exchange_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Exchange] DROP CONSTRAINT [FK_Exchange_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Exchange_User1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Exchange] DROP CONSTRAINT [FK_Exchange_User1];
GO
IF OBJECT_ID(N'[dbo].[FK_ExchangeFund_AccountFrom]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExchangeFund] DROP CONSTRAINT [FK_ExchangeFund_AccountFrom];
GO
IF OBJECT_ID(N'[dbo].[FK_ExchangeFund_AccountFundFrom]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExchangeFund] DROP CONSTRAINT [FK_ExchangeFund_AccountFundFrom];
GO
IF OBJECT_ID(N'[dbo].[FK_ExchangeFund_AccountFundTo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExchangeFund] DROP CONSTRAINT [FK_ExchangeFund_AccountFundTo];
GO
IF OBJECT_ID(N'[dbo].[FK_ExchangeFund_AccountTo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExchangeFund] DROP CONSTRAINT [FK_ExchangeFund_AccountTo];
GO
IF OBJECT_ID(N'[dbo].[FK_ExchangeFund_Currency]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExchangeFund] DROP CONSTRAINT [FK_ExchangeFund_Currency];
GO
IF OBJECT_ID(N'[dbo].[FK_ExchangeFund_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExchangeFund] DROP CONSTRAINT [FK_ExchangeFund_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Expense_Currency]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Expense] DROP CONSTRAINT [FK_Expense_Currency];
GO
IF OBJECT_ID(N'[dbo].[FK_Expense_ExpenseCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Expense] DROP CONSTRAINT [FK_Expense_ExpenseCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_Expense_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Expense] DROP CONSTRAINT [FK_Expense_User];
GO
IF OBJECT_ID(N'[dbo].[FK_ExpenseCategory_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExpenseCategory] DROP CONSTRAINT [FK_ExpenseCategory_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Fund_Currency]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Fund] DROP CONSTRAINT [FK_Fund_Currency];
GO
IF OBJECT_ID(N'[dbo].[FK_Fund_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Fund] DROP CONSTRAINT [FK_Fund_User];
GO
IF OBJECT_ID(N'[dbo].[FK_FundTransaction_Currency]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FundTransaction] DROP CONSTRAINT [FK_FundTransaction_Currency];
GO
IF OBJECT_ID(N'[dbo].[FK_FundTransaction_Fund]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FundTransaction] DROP CONSTRAINT [FK_FundTransaction_Fund];
GO
IF OBJECT_ID(N'[dbo].[FK_Images_Album]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Images] DROP CONSTRAINT [FK_Images_Album];
GO
IF OBJECT_ID(N'[dbo].[FK_Item_Currency]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Item] DROP CONSTRAINT [FK_Item_Currency];
GO
IF OBJECT_ID(N'[dbo].[FK_Item_ItemCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Item] DROP CONSTRAINT [FK_Item_ItemCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_Item_Unit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Item] DROP CONSTRAINT [FK_Item_Unit];
GO
IF OBJECT_ID(N'[dbo].[FK_Item_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Item] DROP CONSTRAINT [FK_Item_User];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemCategory_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemCategory] DROP CONSTRAINT [FK_ItemCategory_User];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemFund_Item]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemFund] DROP CONSTRAINT [FK_ItemFund_Item];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemFund_Unit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemFund] DROP CONSTRAINT [FK_ItemFund_Unit];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemFund_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemFund] DROP CONSTRAINT [FK_ItemFund_User];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemTransaction_Item]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemTransaction] DROP CONSTRAINT [FK_ItemTransaction_Item];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemTransaction_Unit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemTransaction] DROP CONSTRAINT [FK_ItemTransaction_Unit];
GO
IF OBJECT_ID(N'[dbo].[FK_Payment_Account]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Payment] DROP CONSTRAINT [FK_Payment_Account];
GO
IF OBJECT_ID(N'[dbo].[FK_Payment_Currency]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Payment] DROP CONSTRAINT [FK_Payment_Currency];
GO
IF OBJECT_ID(N'[dbo].[FK_Payment_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Payment] DROP CONSTRAINT [FK_Payment_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Receipt_Account]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Receipt] DROP CONSTRAINT [FK_Receipt_Account];
GO
IF OBJECT_ID(N'[dbo].[FK_Receipt_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Receipt] DROP CONSTRAINT [FK_Receipt_User];
GO
IF OBJECT_ID(N'[dbo].[FK_ReceiptLines_Item]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReceiptLines] DROP CONSTRAINT [FK_ReceiptLines_Item];
GO
IF OBJECT_ID(N'[dbo].[FK_ReceiptLines_Receipt]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReceiptLines] DROP CONSTRAINT [FK_ReceiptLines_Receipt];
GO
IF OBJECT_ID(N'[dbo].[FK_ReceiptLines_Unit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReceiptLines] DROP CONSTRAINT [FK_ReceiptLines_Unit];
GO
IF OBJECT_ID(N'[dbo].[FK_ReceiptLines_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReceiptLines] DROP CONSTRAINT [FK_ReceiptLines_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Transaction_Account]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transaction] DROP CONSTRAINT [FK_Transaction_Account];
GO
IF OBJECT_ID(N'[dbo].[FK_Transaction_Currency]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transaction] DROP CONSTRAINT [FK_Transaction_Currency];
GO
IF OBJECT_ID(N'[dbo].[FK_Transfer_Account]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transfer] DROP CONSTRAINT [FK_Transfer_Account];
GO
IF OBJECT_ID(N'[dbo].[FK_Transfer_Account1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transfer] DROP CONSTRAINT [FK_Transfer_Account1];
GO
IF OBJECT_ID(N'[dbo].[FK_Transfer_AccountFund]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transfer] DROP CONSTRAINT [FK_Transfer_AccountFund];
GO
IF OBJECT_ID(N'[dbo].[FK_Transfer_AccountFund1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transfer] DROP CONSTRAINT [FK_Transfer_AccountFund1];
GO
IF OBJECT_ID(N'[dbo].[FK_Transfer_Currency]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transfer] DROP CONSTRAINT [FK_Transfer_Currency];
GO
IF OBJECT_ID(N'[dbo].[FK_Transfer_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transfer] DROP CONSTRAINT [FK_Transfer_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Unit_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Unit] DROP CONSTRAINT [FK_Unit_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Users_Role]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User] DROP CONSTRAINT [FK_Users_Role];
GO
IF OBJECT_ID(N'[dbo].[FK_Withdraw_Account]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Withdraw] DROP CONSTRAINT [FK_Withdraw_Account];
GO
IF OBJECT_ID(N'[dbo].[FK_Withdraw_Currency]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Withdraw] DROP CONSTRAINT [FK_Withdraw_Currency];
GO
IF OBJECT_ID(N'[dbo].[FK_Withdraw_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Withdraw] DROP CONSTRAINT [FK_Withdraw_User];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Account]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Account];
GO
IF OBJECT_ID(N'[dbo].[AccountFund]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AccountFund];
GO
IF OBJECT_ID(N'[dbo].[AccountGroup]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AccountGroup];
GO
IF OBJECT_ID(N'[dbo].[Album]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Album];
GO
IF OBJECT_ID(N'[dbo].[AppSettings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AppSettings];
GO
IF OBJECT_ID(N'[dbo].[Bill]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bill];
GO
IF OBJECT_ID(N'[dbo].[BillLines]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BillLines];
GO
IF OBJECT_ID(N'[dbo].[Company]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Company];
GO
IF OBJECT_ID(N'[dbo].[Currency]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Currency];
GO
IF OBJECT_ID(N'[dbo].[CurrencyBulletin]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CurrencyBulletin];
GO
IF OBJECT_ID(N'[dbo].[CurrencyExchange]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CurrencyExchange];
GO
IF OBJECT_ID(N'[dbo].[CurrencyExchangeOperations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CurrencyExchangeOperations];
GO
IF OBJECT_ID(N'[dbo].[Exchange]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Exchange];
GO
IF OBJECT_ID(N'[dbo].[ExchangeFund]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExchangeFund];
GO
IF OBJECT_ID(N'[dbo].[Expense]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Expense];
GO
IF OBJECT_ID(N'[dbo].[ExpenseCategory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExpenseCategory];
GO
IF OBJECT_ID(N'[dbo].[Fund]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Fund];
GO
IF OBJECT_ID(N'[dbo].[FundTransaction]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FundTransaction];
GO
IF OBJECT_ID(N'[dbo].[Images]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Images];
GO
IF OBJECT_ID(N'[dbo].[Item]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Item];
GO
IF OBJECT_ID(N'[dbo].[ItemCategory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemCategory];
GO
IF OBJECT_ID(N'[dbo].[ItemFund]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemFund];
GO
IF OBJECT_ID(N'[dbo].[ItemTransaction]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemTransaction];
GO
IF OBJECT_ID(N'[dbo].[Payment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Payment];
GO
IF OBJECT_ID(N'[dbo].[Receipt]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Receipt];
GO
IF OBJECT_ID(N'[dbo].[ReceiptLines]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReceiptLines];
GO
IF OBJECT_ID(N'[dbo].[Role]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Role];
GO
IF OBJECT_ID(N'[dbo].[Transaction]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transaction];
GO
IF OBJECT_ID(N'[dbo].[Transfer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transfer];
GO
IF OBJECT_ID(N'[dbo].[Unit]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Unit];
GO
IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO
IF OBJECT_ID(N'[dbo].[Withdraw]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Withdraw];
GO
IF OBJECT_ID(N'[AlverModelStoreContainer].[V_CLIENTS]', 'U') IS NOT NULL
    DROP TABLE [AlverModelStoreContainer].[V_CLIENTS];
GO
IF OBJECT_ID(N'[AlverModelStoreContainer].[V_STOCK]', 'U') IS NOT NULL
    DROP TABLE [AlverModelStoreContainer].[V_STOCK];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Accounts'
CREATE TABLE [dbo].[Accounts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AccountGroupId] int  NULL,
    [FullName] nvarchar(100)  NULL,
    [Father] nvarchar(50)  NULL,
    [Mother] nvarchar(50)  NULL,
    [IdNumber] nvarchar(50)  NULL,
    [Phone] nvarchar(50)  NULL,
    [CountryId] int  NULL,
    [CityId] int  NULL,
    [Address] nvarchar(500)  NULL,
    [Declaration] nvarchar(500)  NULL,
    [Deactivated] bit  NULL,
    [UserId] int  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [GUID] uniqueidentifier  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'AccountFunds'
CREATE TABLE [dbo].[AccountFunds] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AccountId] int  NULL,
    [FundTitle] nvarchar(250)  NULL,
    [CurrencyId] int  NULL,
    [Balance] decimal(19,4)  NULL,
    [BalanceDirection] nvarchar(10)  NULL,
    [Declaration] nvarchar(500)  NULL,
    [UserId] int  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [GUID] uniqueidentifier  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'AccountGroups'
CREATE TABLE [dbo].[AccountGroups] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [GroupTitle] nvarchar(50)  NULL,
    [GroupColor] int  NULL,
    [GroupIcon] varbinary(max)  NULL,
    [Declaration] nvarchar(500)  NULL,
    [UserId] int  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [GUID] uniqueidentifier  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'Albums'
CREATE TABLE [dbo].[Albums] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AlbumTitle] nvarchar(50)  NULL,
    [Declaration] nvarchar(50)  NULL,
    [UserId] int  NULL,
    [LUD] datetime  NULL,
    [GUID] uniqueidentifier  NULL,
    [Flag] nvarchar(50)  NULL,
    [Hidden] bit  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'AppSettings'
CREATE TABLE [dbo].[AppSettings] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(100)  NULL,
    [Motto] nvarchar(150)  NULL,
    [Phone] nvarchar(50)  NULL,
    [Address] nvarchar(max)  NULL,
    [Notes] nvarchar(max)  NULL,
    [Logo] varbinary(max)  NULL,
    [Manager] nvarchar(100)  NULL,
    [Accountant] nvarchar(100)  NULL,
    [Helper] nvarchar(100)  NULL,
    [UserId] int  NULL,
    [GUID] uniqueidentifier  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'Bills'
CREATE TABLE [dbo].[Bills] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CheckedOut] bit  NULL,
    [BillType] nvarchar(10)  NULL,
    [AccountId] int  NULL,
    [BillDate] datetime  NULL,
    [Cashout] bit  NULL,
    [CurrencyId] int  NULL,
    [BillAmount] decimal(19,4)  NULL,
    [DiscountAmount] decimal(19,4)  NULL,
    [TotalAmount] decimal(19,4)  NULL,
    [Exchanged] bit  NULL,
    [Rate] decimal(19,4)  NULL,
    [ForeginCurrencyId] int  NULL,
    [ExchangedAmount] decimal(19,4)  NULL,
    [Declaration] nvarchar(500)  NULL,
    [UserId] int  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [GUID] uniqueidentifier  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'BillLines'
CREATE TABLE [dbo].[BillLines] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BillId] int  NULL,
    [ItemId] int  NULL,
    [UnitId] int  NULL,
    [Quantity] decimal(19,4)  NULL,
    [CurrencyId] int  NULL,
    [Price] decimal(19,4)  NULL,
    [TotalPrice] decimal(19,4)  NULL,
    [Exchanged] bit  NULL,
    [Rate] decimal(19,4)  NULL,
    [ForeginCurrencyId] int  NULL,
    [ExchangedAmount] decimal(19,4)  NULL,
    [ExchangedTotalAmount] decimal(19,4)  NULL,
    [UserId] int  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [GUID] uniqueidentifier  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'Companies'
CREATE TABLE [dbo].[Companies] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(100)  NULL,
    [Motto] nvarchar(150)  NULL,
    [Manager] nvarchar(100)  NULL,
    [ManagerPhone] nvarchar(50)  NULL,
    [Accountant] nvarchar(100)  NULL,
    [AccountantPhone] nvarchar(50)  NULL,
    [Address] nvarchar(max)  NULL,
    [Notes] nvarchar(max)  NULL,
    [LogoId] int  NULL,
    [EmailAddress] nvarchar(100)  NULL,
    [UserId] int  NULL,
    [GUID] uniqueidentifier  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'Currencies'
CREATE TABLE [dbo].[Currencies] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CurrencyName] nvarchar(50)  NULL,
    [CurrencySymbol] nvarchar(3)  NULL,
    [CurrencyCode] nvarchar(3)  NULL,
    [BaseCurrency] bit  NULL,
    [ExchangeRate] decimal(19,4)  NULL,
    [Notes] nvarchar(100)  NULL,
    [UserId] int  NULL,
    [GUID] uniqueidentifier  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'CurrencyExchanges'
CREATE TABLE [dbo].[CurrencyExchanges] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [ExchangeType] nvarchar(50)  NULL,
    [ExchangeDate] datetime  NULL,
    [Declaration] nvarchar(500)  NULL,
    [UserId] int  NULL,
    [GUID] uniqueidentifier  NULL,
    [Flag] nvarchar(50)  NULL,
    [Hidden] bit  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'CurrencyExchangeOperations'
CREATE TABLE [dbo].[CurrencyExchangeOperations] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [ExchangeId] bigint  NULL,
    [OpreationDate] datetime  NULL,
    [Direction] nvarchar(50)  NULL,
    [BaseCurrencyId] int  NULL,
    [BaseAmount] decimal(19,4)  NULL,
    [SubCurrencyId] int  NULL,
    [Factor] nvarchar(10)  NULL,
    [Rate] decimal(19,4)  NULL,
    [SubAmount] decimal(19,4)  NULL,
    [RoundAmount] decimal(19,4)  NULL,
    [Declaration] nvarchar(100)  NULL,
    [UserId] int  NULL,
    [GUID] uniqueidentifier  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'Exchanges'
CREATE TABLE [dbo].[Exchanges] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [ExchangeDate] datetime  NULL,
    [Direction] nvarchar(50)  NULL,
    [BaseCurrencyId] int  NULL,
    [BaseAmount] decimal(19,4)  NULL,
    [SubCurrencyId] int  NULL,
    [Factor] nvarchar(10)  NULL,
    [Rate] decimal(19,4)  NULL,
    [SubAmount] decimal(19,4)  NULL,
    [RoundAmount] decimal(19,4)  NULL,
    [Declaration] nvarchar(100)  NULL,
    [UserId] int  NULL,
    [GUID] uniqueidentifier  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'ExchangeFunds'
CREATE TABLE [dbo].[ExchangeFunds] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ExchangeType] bit  NULL,
    [ExchangeDate] datetime  NULL,
    [CurrencyId] int  NULL,
    [AccountFromId] int  NULL,
    [AccountFundFromId] int  NULL,
    [AccountToId] int  NULL,
    [AccountFundToId] int  NULL,
    [FromAmount] decimal(19,4)  NULL,
    [Factor] bit  NULL,
    [Rate] decimal(19,4)  NULL,
    [ToAmount] decimal(19,4)  NULL,
    [Declaration] nvarchar(500)  NULL,
    [UserId] int  NULL,
    [GUID] uniqueidentifier  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'Expenses'
CREATE TABLE [dbo].[Expenses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ExpenseDate] datetime  NULL,
    [CurrencyId] int  NULL,
    [Amount] decimal(19,4)  NULL,
    [CategoryId] int  NULL,
    [Declaration] nvarchar(500)  NULL,
    [UserId] int  NULL,
    [GUID] uniqueidentifier  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'ExpenseCategories'
CREATE TABLE [dbo].[ExpenseCategories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(50)  NULL,
    [Declaration] nvarchar(500)  NULL,
    [UserId] int  NULL,
    [GUID] uniqueidentifier  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'Funds'
CREATE TABLE [dbo].[Funds] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FundTitle] nvarchar(50)  NULL,
    [CurrencyId] int  NULL,
    [Balance] decimal(19,4)  NULL,
    [BalanceDirection] nvarchar(10)  NULL,
    [Declaration] nvarchar(500)  NULL,
    [UserId] int  NULL,
    [GUID] uniqueidentifier  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'FundTransactions'
CREATE TABLE [dbo].[FundTransactions] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [FundId] int  NULL,
    [TTS] datetime  NULL,
    [TT] nvarchar(6)  NULL,
    [CurrencyId] int  NULL,
    [Amount] decimal(19,4)  NULL,
    [RunningTotal] decimal(19,4)  NULL,
    [Declaration] nvarchar(1000)  NULL,
    [GUID] uniqueidentifier  NULL
);
GO

-- Creating table 'Images'
CREATE TABLE [dbo].[Images] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AlbumId] int  NULL,
    [ImageData] varbinary(max)  NULL,
    [ImageTitle] nvarchar(50)  NULL,
    [Notes] nvarchar(50)  NULL,
    [GUID] uniqueidentifier  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'Items'
CREATE TABLE [dbo].[Items] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ItemName] nvarchar(50)  NULL,
    [UnitId] int  NULL,
    [CategoryId] int  NULL,
    [CurrencyId] int  NULL,
    [SalePrice] decimal(19,4)  NULL,
    [PurchasePrice] decimal(19,4)  NULL,
    [Barcode] nvarchar(50)  NULL,
    [Declaration] nvarchar(500)  NULL,
    [UserId] int  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [GUID] uniqueidentifier  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'ItemCategories'
CREATE TABLE [dbo].[ItemCategories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(50)  NULL,
    [Declaration] nvarchar(500)  NULL,
    [UserId] int  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [GUID] uniqueidentifier  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'ItemFunds'
CREATE TABLE [dbo].[ItemFunds] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ItemId] int  NULL,
    [FundTitle] nvarchar(250)  NULL,
    [UnitId] int  NULL,
    [Balance] decimal(19,4)  NULL,
    [BalanceDirection] nvarchar(10)  NULL,
    [Declaration] nvarchar(500)  NULL,
    [UserId] int  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [GUID] uniqueidentifier  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'ItemTransactions'
CREATE TABLE [dbo].[ItemTransactions] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [ItemId] int  NULL,
    [TTS] datetime  NULL,
    [TT] nvarchar(6)  NULL,
    [UnitId] int  NULL,
    [Amount] decimal(19,4)  NULL,
    [RunningTotal] decimal(19,4)  NULL,
    [Declaration] nvarchar(1000)  NULL,
    [GUID] uniqueidentifier  NULL
);
GO

-- Creating table 'Receipts'
CREATE TABLE [dbo].[Receipts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AccountId] int  NULL,
    [ReceiptDate] datetime  NULL,
    [ReceiptAmount] decimal(19,4)  NULL,
    [DiscountAmount] decimal(19,4)  NULL,
    [TotalAmount] decimal(19,4)  NULL,
    [Declaration] nvarchar(500)  NULL,
    [UserId] int  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [GUID] uniqueidentifier  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'ReceiptLines'
CREATE TABLE [dbo].[ReceiptLines] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ReceiptId] int  NULL,
    [ItemId] int  NULL,
    [UnitId] int  NULL,
    [Quantity] decimal(19,4)  NULL,
    [Price] decimal(19,4)  NULL,
    [TotalPrice] decimal(19,4)  NULL,
    [UserId] int  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [GUID] uniqueidentifier  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RoleTitle] nvarchar(50)  NULL,
    [Declaration] nvarchar(500)  NULL,
    [GUID] uniqueidentifier  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'Transactions'
CREATE TABLE [dbo].[Transactions] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [AccountId] int  NULL,
    [TTS] datetime  NULL,
    [TT] nvarchar(6)  NULL,
    [CurrencyId] int  NULL,
    [Amount] decimal(19,4)  NULL,
    [RunningTotal] decimal(19,4)  NULL,
    [Declaration] nvarchar(1000)  NULL,
    [GUID] uniqueidentifier  NULL
);
GO

-- Creating table 'Transfers'
CREATE TABLE [dbo].[Transfers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TransferDate] datetime  NULL,
    [CurrencyId] int  NULL,
    [ClientFrom] int  NULL,
    [FundFrom] int  NULL,
    [ClientTo] int  NULL,
    [FundTo] int  NULL,
    [FromAmount] decimal(19,4)  NULL,
    [Factor] bit  NULL,
    [Rate] decimal(19,4)  NULL,
    [ToAmount] decimal(19,4)  NULL,
    [Declaration] nvarchar(max)  NULL,
    [UserId] int  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [GUID] uniqueidentifier  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'Units'
CREATE TABLE [dbo].[Units] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(50)  NULL,
    [Symbol] nvarchar(3)  NULL,
    [IsDefault] bit  NULL,
    [Declaration] nvarchar(500)  NULL,
    [UserId] int  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [GUID] uniqueidentifier  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RoleId] int  NULL,
    [UserName] nvarchar(50)  NULL,
    [Password] nvarchar(64)  NULL,
    [FullName] nvarchar(100)  NULL,
    [LoginAttempts] int  NULL,
    [Locked] bit  NULL,
    [Deactivated] bit  NULL,
    [Declaration] nvarchar(500)  NULL,
    [CD] datetime  NULL,
    [LLD] datetime  NULL,
    [GUID] uniqueidentifier  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'Withdraws'
CREATE TABLE [dbo].[Withdraws] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Direction] nvarchar(50)  NULL,
    [WithdrawDate] datetime  NULL,
    [AccountId] int  NULL,
    [CurrencyId] int  NULL,
    [Amount] decimal(19,4)  NULL,
    [Declaration] nvarchar(max)  NULL,
    [Payed] bit  NULL,
    [Locked] bit  NULL,
    [UserId] int  NULL,
    [GUID] uniqueidentifier  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'V_CLIENTS'
CREATE TABLE [dbo].[V_CLIENTS] (
    [AccountId] int  NOT NULL,
    [Account] nvarchar(100)  NULL,
    [USDAmount] decimal(19,4)  NULL,
    [SYPAmount] decimal(19,4)  NULL,
    [TLAmount] decimal(19,4)  NULL,
    [EUROAmount] decimal(19,4)  NULL,
    [SARAmount] decimal(19,4)  NULL,
    [GRAND] decimal(19,4)  NULL
);
GO

-- Creating table 'V_STOCK'
CREATE TABLE [dbo].[V_STOCK] (
    [رقم_المادة] int  NOT NULL,
    [اسم_المادة] nvarchar(50)  NULL,
    [عدد_الكروزات_المتوفرة] decimal(19,4)  NULL,
    [العملة] int  NULL,
    [سعر_شراء_الواحدة] decimal(19,4)  NULL,
    [تكلفة_الشراء] decimal(19,4)  NULL,
    [سعر_مبيع_الواحدة] decimal(19,4)  NULL,
    [مجموع_المبيعات] decimal(19,4)  NULL,
    [هامش_الربح_في_القطعة_الواحدة] decimal(19,4)  NULL,
    [الربح_المتوقع] decimal(19,4)  NULL
);
GO

-- Creating table 'Payments'
CREATE TABLE [dbo].[Payments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PaymentType] nvarchar(20)  NULL,
    [PaymentDate] datetime  NULL,
    [AccountId] int  NULL,
    [CurrencyId] int  NULL,
    [Amount] decimal(19,4)  NULL,
    [Declaration] nvarchar(500)  NULL,
    [Payed] bit  NULL,
    [Locked] bit  NULL,
    [UserId] int  NULL,
    [GUID] uniqueidentifier  NULL,
    [Hidden] bit  NULL,
    [Flag] nvarchar(50)  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'CurrencyBulletins'
CREATE TABLE [dbo].[CurrencyBulletins] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RateDate] datetime  NULL,
    [CurrencyId] int  NULL,
    [Rate] decimal(19,4)  NULL,
    [ReversedRate] decimal(19,4)  NULL,
    [Factor] bit  NULL,
    [GUID] uniqueidentifier  NULL
);
GO

-- Creating table 'ItemUnits'
CREATE TABLE [dbo].[ItemUnits] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ItemId] int  NULL,
    [UnitId] int  NULL,
    [Factor] decimal(19,4)  NULL,
    [BaseUnitId] int  NULL,
    [BaseUnitQuantity] decimal(19,4)  NULL,
    [GUID] uniqueidentifier  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- Creating table 'Prices'
CREATE TABLE [dbo].[Prices] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ItemUnitId] int  NULL,
    [CurrencyId] int  NULL,
    [SalePrice] decimal(19,4)  NULL,
    [PurchasePrice] decimal(19,4)  NULL,
    [GUID] uniqueidentifier  NULL,
    [LUD] datetime  NULL,
    [PROTECTED] bit  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Accounts'
ALTER TABLE [dbo].[Accounts]
ADD CONSTRAINT [PK_Accounts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AccountFunds'
ALTER TABLE [dbo].[AccountFunds]
ADD CONSTRAINT [PK_AccountFunds]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AccountGroups'
ALTER TABLE [dbo].[AccountGroups]
ADD CONSTRAINT [PK_AccountGroups]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Albums'
ALTER TABLE [dbo].[Albums]
ADD CONSTRAINT [PK_Albums]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AppSettings'
ALTER TABLE [dbo].[AppSettings]
ADD CONSTRAINT [PK_AppSettings]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Bills'
ALTER TABLE [dbo].[Bills]
ADD CONSTRAINT [PK_Bills]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BillLines'
ALTER TABLE [dbo].[BillLines]
ADD CONSTRAINT [PK_BillLines]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Companies'
ALTER TABLE [dbo].[Companies]
ADD CONSTRAINT [PK_Companies]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Currencies'
ALTER TABLE [dbo].[Currencies]
ADD CONSTRAINT [PK_Currencies]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CurrencyExchanges'
ALTER TABLE [dbo].[CurrencyExchanges]
ADD CONSTRAINT [PK_CurrencyExchanges]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CurrencyExchangeOperations'
ALTER TABLE [dbo].[CurrencyExchangeOperations]
ADD CONSTRAINT [PK_CurrencyExchangeOperations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Exchanges'
ALTER TABLE [dbo].[Exchanges]
ADD CONSTRAINT [PK_Exchanges]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ExchangeFunds'
ALTER TABLE [dbo].[ExchangeFunds]
ADD CONSTRAINT [PK_ExchangeFunds]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Expenses'
ALTER TABLE [dbo].[Expenses]
ADD CONSTRAINT [PK_Expenses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ExpenseCategories'
ALTER TABLE [dbo].[ExpenseCategories]
ADD CONSTRAINT [PK_ExpenseCategories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Funds'
ALTER TABLE [dbo].[Funds]
ADD CONSTRAINT [PK_Funds]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FundTransactions'
ALTER TABLE [dbo].[FundTransactions]
ADD CONSTRAINT [PK_FundTransactions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Images'
ALTER TABLE [dbo].[Images]
ADD CONSTRAINT [PK_Images]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Items'
ALTER TABLE [dbo].[Items]
ADD CONSTRAINT [PK_Items]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItemCategories'
ALTER TABLE [dbo].[ItemCategories]
ADD CONSTRAINT [PK_ItemCategories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItemFunds'
ALTER TABLE [dbo].[ItemFunds]
ADD CONSTRAINT [PK_ItemFunds]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItemTransactions'
ALTER TABLE [dbo].[ItemTransactions]
ADD CONSTRAINT [PK_ItemTransactions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Receipts'
ALTER TABLE [dbo].[Receipts]
ADD CONSTRAINT [PK_Receipts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ReceiptLines'
ALTER TABLE [dbo].[ReceiptLines]
ADD CONSTRAINT [PK_ReceiptLines]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [PK_Transactions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Transfers'
ALTER TABLE [dbo].[Transfers]
ADD CONSTRAINT [PK_Transfers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Units'
ALTER TABLE [dbo].[Units]
ADD CONSTRAINT [PK_Units]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Withdraws'
ALTER TABLE [dbo].[Withdraws]
ADD CONSTRAINT [PK_Withdraws]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [AccountId] in table 'V_CLIENTS'
ALTER TABLE [dbo].[V_CLIENTS]
ADD CONSTRAINT [PK_V_CLIENTS]
    PRIMARY KEY CLUSTERED ([AccountId] ASC);
GO

-- Creating primary key on [رقم_المادة] in table 'V_STOCK'
ALTER TABLE [dbo].[V_STOCK]
ADD CONSTRAINT [PK_V_STOCK]
    PRIMARY KEY CLUSTERED ([رقم_المادة] ASC);
GO

-- Creating primary key on [Id] in table 'Payments'
ALTER TABLE [dbo].[Payments]
ADD CONSTRAINT [PK_Payments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CurrencyBulletins'
ALTER TABLE [dbo].[CurrencyBulletins]
ADD CONSTRAINT [PK_CurrencyBulletins]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItemUnits'
ALTER TABLE [dbo].[ItemUnits]
ADD CONSTRAINT [PK_ItemUnits]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Prices'
ALTER TABLE [dbo].[Prices]
ADD CONSTRAINT [PK_Prices]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AccountGroupId] in table 'Accounts'
ALTER TABLE [dbo].[Accounts]
ADD CONSTRAINT [FK_Account_AccountGroup]
    FOREIGN KEY ([AccountGroupId])
    REFERENCES [dbo].[AccountGroups]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Account_AccountGroup'
CREATE INDEX [IX_FK_Account_AccountGroup]
ON [dbo].[Accounts]
    ([AccountGroupId]);
GO

-- Creating foreign key on [UserId] in table 'Accounts'
ALTER TABLE [dbo].[Accounts]
ADD CONSTRAINT [FK_Account_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Account_User'
CREATE INDEX [IX_FK_Account_User]
ON [dbo].[Accounts]
    ([UserId]);
GO

-- Creating foreign key on [AccountId] in table 'AccountFunds'
ALTER TABLE [dbo].[AccountFunds]
ADD CONSTRAINT [FK_AccountFund_Account]
    FOREIGN KEY ([AccountId])
    REFERENCES [dbo].[Accounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AccountFund_Account'
CREATE INDEX [IX_FK_AccountFund_Account]
ON [dbo].[AccountFunds]
    ([AccountId]);
GO

-- Creating foreign key on [AccountId] in table 'Bills'
ALTER TABLE [dbo].[Bills]
ADD CONSTRAINT [FK_Bill_Account]
    FOREIGN KEY ([AccountId])
    REFERENCES [dbo].[Accounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Bill_Account'
CREATE INDEX [IX_FK_Bill_Account]
ON [dbo].[Bills]
    ([AccountId]);
GO

-- Creating foreign key on [AccountFromId] in table 'ExchangeFunds'
ALTER TABLE [dbo].[ExchangeFunds]
ADD CONSTRAINT [FK_ExchangeFund_AccountFrom]
    FOREIGN KEY ([AccountFromId])
    REFERENCES [dbo].[Accounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExchangeFund_AccountFrom'
CREATE INDEX [IX_FK_ExchangeFund_AccountFrom]
ON [dbo].[ExchangeFunds]
    ([AccountFromId]);
GO

-- Creating foreign key on [AccountToId] in table 'ExchangeFunds'
ALTER TABLE [dbo].[ExchangeFunds]
ADD CONSTRAINT [FK_ExchangeFund_AccountTo]
    FOREIGN KEY ([AccountToId])
    REFERENCES [dbo].[Accounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExchangeFund_AccountTo'
CREATE INDEX [IX_FK_ExchangeFund_AccountTo]
ON [dbo].[ExchangeFunds]
    ([AccountToId]);
GO

-- Creating foreign key on [AccountId] in table 'Receipts'
ALTER TABLE [dbo].[Receipts]
ADD CONSTRAINT [FK_Receipt_Account]
    FOREIGN KEY ([AccountId])
    REFERENCES [dbo].[Accounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Receipt_Account'
CREATE INDEX [IX_FK_Receipt_Account]
ON [dbo].[Receipts]
    ([AccountId]);
GO

-- Creating foreign key on [AccountId] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_Transaction_Account]
    FOREIGN KEY ([AccountId])
    REFERENCES [dbo].[Accounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Transaction_Account'
CREATE INDEX [IX_FK_Transaction_Account]
ON [dbo].[Transactions]
    ([AccountId]);
GO

-- Creating foreign key on [ClientFrom] in table 'Transfers'
ALTER TABLE [dbo].[Transfers]
ADD CONSTRAINT [FK_Transfer_Account]
    FOREIGN KEY ([ClientFrom])
    REFERENCES [dbo].[Accounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Transfer_Account'
CREATE INDEX [IX_FK_Transfer_Account]
ON [dbo].[Transfers]
    ([ClientFrom]);
GO

-- Creating foreign key on [ClientTo] in table 'Transfers'
ALTER TABLE [dbo].[Transfers]
ADD CONSTRAINT [FK_Transfer_Account1]
    FOREIGN KEY ([ClientTo])
    REFERENCES [dbo].[Accounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Transfer_Account1'
CREATE INDEX [IX_FK_Transfer_Account1]
ON [dbo].[Transfers]
    ([ClientTo]);
GO

-- Creating foreign key on [AccountId] in table 'Withdraws'
ALTER TABLE [dbo].[Withdraws]
ADD CONSTRAINT [FK_Withdraw_Account]
    FOREIGN KEY ([AccountId])
    REFERENCES [dbo].[Accounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Withdraw_Account'
CREATE INDEX [IX_FK_Withdraw_Account]
ON [dbo].[Withdraws]
    ([AccountId]);
GO

-- Creating foreign key on [CurrencyId] in table 'AccountFunds'
ALTER TABLE [dbo].[AccountFunds]
ADD CONSTRAINT [FK_AccountFund_Currency]
    FOREIGN KEY ([CurrencyId])
    REFERENCES [dbo].[Currencies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AccountFund_Currency'
CREATE INDEX [IX_FK_AccountFund_Currency]
ON [dbo].[AccountFunds]
    ([CurrencyId]);
GO

-- Creating foreign key on [AccountFundFromId] in table 'ExchangeFunds'
ALTER TABLE [dbo].[ExchangeFunds]
ADD CONSTRAINT [FK_ExchangeFund_AccountFundFrom]
    FOREIGN KEY ([AccountFundFromId])
    REFERENCES [dbo].[AccountFunds]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExchangeFund_AccountFundFrom'
CREATE INDEX [IX_FK_ExchangeFund_AccountFundFrom]
ON [dbo].[ExchangeFunds]
    ([AccountFundFromId]);
GO

-- Creating foreign key on [AccountFundToId] in table 'ExchangeFunds'
ALTER TABLE [dbo].[ExchangeFunds]
ADD CONSTRAINT [FK_ExchangeFund_AccountFundTo]
    FOREIGN KEY ([AccountFundToId])
    REFERENCES [dbo].[AccountFunds]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExchangeFund_AccountFundTo'
CREATE INDEX [IX_FK_ExchangeFund_AccountFundTo]
ON [dbo].[ExchangeFunds]
    ([AccountFundToId]);
GO

-- Creating foreign key on [FundFrom] in table 'Transfers'
ALTER TABLE [dbo].[Transfers]
ADD CONSTRAINT [FK_Transfer_AccountFund]
    FOREIGN KEY ([FundFrom])
    REFERENCES [dbo].[AccountFunds]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Transfer_AccountFund'
CREATE INDEX [IX_FK_Transfer_AccountFund]
ON [dbo].[Transfers]
    ([FundFrom]);
GO

-- Creating foreign key on [FundTo] in table 'Transfers'
ALTER TABLE [dbo].[Transfers]
ADD CONSTRAINT [FK_Transfer_AccountFund1]
    FOREIGN KEY ([FundTo])
    REFERENCES [dbo].[AccountFunds]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Transfer_AccountFund1'
CREATE INDEX [IX_FK_Transfer_AccountFund1]
ON [dbo].[Transfers]
    ([FundTo]);
GO

-- Creating foreign key on [AlbumId] in table 'Images'
ALTER TABLE [dbo].[Images]
ADD CONSTRAINT [FK_Images_Album]
    FOREIGN KEY ([AlbumId])
    REFERENCES [dbo].[Albums]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Images_Album'
CREATE INDEX [IX_FK_Images_Album]
ON [dbo].[Images]
    ([AlbumId]);
GO

-- Creating foreign key on [CurrencyId] in table 'Bills'
ALTER TABLE [dbo].[Bills]
ADD CONSTRAINT [FK_Bill_Currency]
    FOREIGN KEY ([CurrencyId])
    REFERENCES [dbo].[Currencies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Bill_Currency'
CREATE INDEX [IX_FK_Bill_Currency]
ON [dbo].[Bills]
    ([CurrencyId]);
GO

-- Creating foreign key on [UserId] in table 'Bills'
ALTER TABLE [dbo].[Bills]
ADD CONSTRAINT [FK_Bill_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Bill_User'
CREATE INDEX [IX_FK_Bill_User]
ON [dbo].[Bills]
    ([UserId]);
GO

-- Creating foreign key on [BillId] in table 'BillLines'
ALTER TABLE [dbo].[BillLines]
ADD CONSTRAINT [FK_BillLines_Bill]
    FOREIGN KEY ([BillId])
    REFERENCES [dbo].[Bills]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BillLines_Bill'
CREATE INDEX [IX_FK_BillLines_Bill]
ON [dbo].[BillLines]
    ([BillId]);
GO

-- Creating foreign key on [CurrencyId] in table 'BillLines'
ALTER TABLE [dbo].[BillLines]
ADD CONSTRAINT [FK_BillLines_Currency]
    FOREIGN KEY ([CurrencyId])
    REFERENCES [dbo].[Currencies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BillLines_Currency'
CREATE INDEX [IX_FK_BillLines_Currency]
ON [dbo].[BillLines]
    ([CurrencyId]);
GO

-- Creating foreign key on [ForeginCurrencyId] in table 'BillLines'
ALTER TABLE [dbo].[BillLines]
ADD CONSTRAINT [FK_BillLines_Currency1]
    FOREIGN KEY ([ForeginCurrencyId])
    REFERENCES [dbo].[Currencies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BillLines_Currency1'
CREATE INDEX [IX_FK_BillLines_Currency1]
ON [dbo].[BillLines]
    ([ForeginCurrencyId]);
GO

-- Creating foreign key on [ItemId] in table 'BillLines'
ALTER TABLE [dbo].[BillLines]
ADD CONSTRAINT [FK_BillLines_Item]
    FOREIGN KEY ([ItemId])
    REFERENCES [dbo].[Items]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BillLines_Item'
CREATE INDEX [IX_FK_BillLines_Item]
ON [dbo].[BillLines]
    ([ItemId]);
GO

-- Creating foreign key on [UnitId] in table 'BillLines'
ALTER TABLE [dbo].[BillLines]
ADD CONSTRAINT [FK_BillLines_Unit]
    FOREIGN KEY ([UnitId])
    REFERENCES [dbo].[Units]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BillLines_Unit'
CREATE INDEX [IX_FK_BillLines_Unit]
ON [dbo].[BillLines]
    ([UnitId]);
GO

-- Creating foreign key on [UserId] in table 'BillLines'
ALTER TABLE [dbo].[BillLines]
ADD CONSTRAINT [FK_BillLines_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BillLines_User'
CREATE INDEX [IX_FK_BillLines_User]
ON [dbo].[BillLines]
    ([UserId]);
GO

-- Creating foreign key on [LogoId] in table 'Companies'
ALTER TABLE [dbo].[Companies]
ADD CONSTRAINT [FK_Company_Images]
    FOREIGN KEY ([LogoId])
    REFERENCES [dbo].[Images]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Company_Images'
CREATE INDEX [IX_FK_Company_Images]
ON [dbo].[Companies]
    ([LogoId]);
GO

-- Creating foreign key on [UserId] in table 'Currencies'
ALTER TABLE [dbo].[Currencies]
ADD CONSTRAINT [FK_Currency_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Currency_User'
CREATE INDEX [IX_FK_Currency_User]
ON [dbo].[Currencies]
    ([UserId]);
GO

-- Creating foreign key on [BaseCurrencyId] in table 'CurrencyExchangeOperations'
ALTER TABLE [dbo].[CurrencyExchangeOperations]
ADD CONSTRAINT [FK_CurrencyExchangeOperations_Currency]
    FOREIGN KEY ([BaseCurrencyId])
    REFERENCES [dbo].[Currencies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CurrencyExchangeOperations_Currency'
CREATE INDEX [IX_FK_CurrencyExchangeOperations_Currency]
ON [dbo].[CurrencyExchangeOperations]
    ([BaseCurrencyId]);
GO

-- Creating foreign key on [SubCurrencyId] in table 'CurrencyExchangeOperations'
ALTER TABLE [dbo].[CurrencyExchangeOperations]
ADD CONSTRAINT [FK_CurrencyExchangeOperations_Currency1]
    FOREIGN KEY ([SubCurrencyId])
    REFERENCES [dbo].[Currencies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CurrencyExchangeOperations_Currency1'
CREATE INDEX [IX_FK_CurrencyExchangeOperations_Currency1]
ON [dbo].[CurrencyExchangeOperations]
    ([SubCurrencyId]);
GO

-- Creating foreign key on [BaseCurrencyId] in table 'Exchanges'
ALTER TABLE [dbo].[Exchanges]
ADD CONSTRAINT [FK_Exchange_BaseCurrency]
    FOREIGN KEY ([BaseCurrencyId])
    REFERENCES [dbo].[Currencies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Exchange_BaseCurrency'
CREATE INDEX [IX_FK_Exchange_BaseCurrency]
ON [dbo].[Exchanges]
    ([BaseCurrencyId]);
GO

-- Creating foreign key on [SubCurrencyId] in table 'Exchanges'
ALTER TABLE [dbo].[Exchanges]
ADD CONSTRAINT [FK_Exchange_SubCurrency]
    FOREIGN KEY ([SubCurrencyId])
    REFERENCES [dbo].[Currencies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Exchange_SubCurrency'
CREATE INDEX [IX_FK_Exchange_SubCurrency]
ON [dbo].[Exchanges]
    ([SubCurrencyId]);
GO

-- Creating foreign key on [CurrencyId] in table 'ExchangeFunds'
ALTER TABLE [dbo].[ExchangeFunds]
ADD CONSTRAINT [FK_ExchangeFund_Currency]
    FOREIGN KEY ([CurrencyId])
    REFERENCES [dbo].[Currencies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExchangeFund_Currency'
CREATE INDEX [IX_FK_ExchangeFund_Currency]
ON [dbo].[ExchangeFunds]
    ([CurrencyId]);
GO

-- Creating foreign key on [CurrencyId] in table 'Expenses'
ALTER TABLE [dbo].[Expenses]
ADD CONSTRAINT [FK_Expense_Currency]
    FOREIGN KEY ([CurrencyId])
    REFERENCES [dbo].[Currencies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Expense_Currency'
CREATE INDEX [IX_FK_Expense_Currency]
ON [dbo].[Expenses]
    ([CurrencyId]);
GO

-- Creating foreign key on [CurrencyId] in table 'Funds'
ALTER TABLE [dbo].[Funds]
ADD CONSTRAINT [FK_Fund_Currency]
    FOREIGN KEY ([CurrencyId])
    REFERENCES [dbo].[Currencies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Fund_Currency'
CREATE INDEX [IX_FK_Fund_Currency]
ON [dbo].[Funds]
    ([CurrencyId]);
GO

-- Creating foreign key on [CurrencyId] in table 'FundTransactions'
ALTER TABLE [dbo].[FundTransactions]
ADD CONSTRAINT [FK_FundTransaction_Currency]
    FOREIGN KEY ([CurrencyId])
    REFERENCES [dbo].[Currencies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FundTransaction_Currency'
CREATE INDEX [IX_FK_FundTransaction_Currency]
ON [dbo].[FundTransactions]
    ([CurrencyId]);
GO

-- Creating foreign key on [CurrencyId] in table 'Items'
ALTER TABLE [dbo].[Items]
ADD CONSTRAINT [FK_Item_Currency]
    FOREIGN KEY ([CurrencyId])
    REFERENCES [dbo].[Currencies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Item_Currency'
CREATE INDEX [IX_FK_Item_Currency]
ON [dbo].[Items]
    ([CurrencyId]);
GO

-- Creating foreign key on [CurrencyId] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_Transaction_Currency]
    FOREIGN KEY ([CurrencyId])
    REFERENCES [dbo].[Currencies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Transaction_Currency'
CREATE INDEX [IX_FK_Transaction_Currency]
ON [dbo].[Transactions]
    ([CurrencyId]);
GO

-- Creating foreign key on [CurrencyId] in table 'Transfers'
ALTER TABLE [dbo].[Transfers]
ADD CONSTRAINT [FK_Transfer_Currency]
    FOREIGN KEY ([CurrencyId])
    REFERENCES [dbo].[Currencies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Transfer_Currency'
CREATE INDEX [IX_FK_Transfer_Currency]
ON [dbo].[Transfers]
    ([CurrencyId]);
GO

-- Creating foreign key on [CurrencyId] in table 'Withdraws'
ALTER TABLE [dbo].[Withdraws]
ADD CONSTRAINT [FK_Withdraw_Currency]
    FOREIGN KEY ([CurrencyId])
    REFERENCES [dbo].[Currencies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Withdraw_Currency'
CREATE INDEX [IX_FK_Withdraw_Currency]
ON [dbo].[Withdraws]
    ([CurrencyId]);
GO

-- Creating foreign key on [UserId] in table 'CurrencyExchanges'
ALTER TABLE [dbo].[CurrencyExchanges]
ADD CONSTRAINT [FK_CurrencyExchange_Users_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CurrencyExchange_Users_User'
CREATE INDEX [IX_FK_CurrencyExchange_Users_User]
ON [dbo].[CurrencyExchanges]
    ([UserId]);
GO

-- Creating foreign key on [ExchangeId] in table 'CurrencyExchangeOperations'
ALTER TABLE [dbo].[CurrencyExchangeOperations]
ADD CONSTRAINT [FK_CurrencyExchangeOperations_CurrencyExchange1]
    FOREIGN KEY ([ExchangeId])
    REFERENCES [dbo].[CurrencyExchanges]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CurrencyExchangeOperations_CurrencyExchange1'
CREATE INDEX [IX_FK_CurrencyExchangeOperations_CurrencyExchange1]
ON [dbo].[CurrencyExchangeOperations]
    ([ExchangeId]);
GO

-- Creating foreign key on [UserId] in table 'CurrencyExchangeOperations'
ALTER TABLE [dbo].[CurrencyExchangeOperations]
ADD CONSTRAINT [FK_CurrencyExchangeOperations_Users_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CurrencyExchangeOperations_Users_User'
CREATE INDEX [IX_FK_CurrencyExchangeOperations_Users_User]
ON [dbo].[CurrencyExchangeOperations]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'Exchanges'
ALTER TABLE [dbo].[Exchanges]
ADD CONSTRAINT [FK_Exchange_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Exchange_User'
CREATE INDEX [IX_FK_Exchange_User]
ON [dbo].[Exchanges]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'Exchanges'
ALTER TABLE [dbo].[Exchanges]
ADD CONSTRAINT [FK_Exchange_User1]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Exchange_User1'
CREATE INDEX [IX_FK_Exchange_User1]
ON [dbo].[Exchanges]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'ExchangeFunds'
ALTER TABLE [dbo].[ExchangeFunds]
ADD CONSTRAINT [FK_ExchangeFund_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExchangeFund_User'
CREATE INDEX [IX_FK_ExchangeFund_User]
ON [dbo].[ExchangeFunds]
    ([UserId]);
GO

-- Creating foreign key on [CategoryId] in table 'Expenses'
ALTER TABLE [dbo].[Expenses]
ADD CONSTRAINT [FK_Expense_ExpenseCategory]
    FOREIGN KEY ([CategoryId])
    REFERENCES [dbo].[ExpenseCategories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Expense_ExpenseCategory'
CREATE INDEX [IX_FK_Expense_ExpenseCategory]
ON [dbo].[Expenses]
    ([CategoryId]);
GO

-- Creating foreign key on [UserId] in table 'Expenses'
ALTER TABLE [dbo].[Expenses]
ADD CONSTRAINT [FK_Expense_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Expense_User'
CREATE INDEX [IX_FK_Expense_User]
ON [dbo].[Expenses]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'ExpenseCategories'
ALTER TABLE [dbo].[ExpenseCategories]
ADD CONSTRAINT [FK_ExpenseCategory_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExpenseCategory_User'
CREATE INDEX [IX_FK_ExpenseCategory_User]
ON [dbo].[ExpenseCategories]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'Funds'
ALTER TABLE [dbo].[Funds]
ADD CONSTRAINT [FK_Fund_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Fund_User'
CREATE INDEX [IX_FK_Fund_User]
ON [dbo].[Funds]
    ([UserId]);
GO

-- Creating foreign key on [FundId] in table 'FundTransactions'
ALTER TABLE [dbo].[FundTransactions]
ADD CONSTRAINT [FK_FundTransaction_Fund]
    FOREIGN KEY ([FundId])
    REFERENCES [dbo].[Funds]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FundTransaction_Fund'
CREATE INDEX [IX_FK_FundTransaction_Fund]
ON [dbo].[FundTransactions]
    ([FundId]);
GO

-- Creating foreign key on [CategoryId] in table 'Items'
ALTER TABLE [dbo].[Items]
ADD CONSTRAINT [FK_Item_ItemCategory]
    FOREIGN KEY ([CategoryId])
    REFERENCES [dbo].[ItemCategories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Item_ItemCategory'
CREATE INDEX [IX_FK_Item_ItemCategory]
ON [dbo].[Items]
    ([CategoryId]);
GO

-- Creating foreign key on [UnitId] in table 'Items'
ALTER TABLE [dbo].[Items]
ADD CONSTRAINT [FK_Item_Unit]
    FOREIGN KEY ([UnitId])
    REFERENCES [dbo].[Units]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Item_Unit'
CREATE INDEX [IX_FK_Item_Unit]
ON [dbo].[Items]
    ([UnitId]);
GO

-- Creating foreign key on [UserId] in table 'Items'
ALTER TABLE [dbo].[Items]
ADD CONSTRAINT [FK_Item_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Item_User'
CREATE INDEX [IX_FK_Item_User]
ON [dbo].[Items]
    ([UserId]);
GO

-- Creating foreign key on [ItemId] in table 'ItemFunds'
ALTER TABLE [dbo].[ItemFunds]
ADD CONSTRAINT [FK_ItemFund_Item]
    FOREIGN KEY ([ItemId])
    REFERENCES [dbo].[Items]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemFund_Item'
CREATE INDEX [IX_FK_ItemFund_Item]
ON [dbo].[ItemFunds]
    ([ItemId]);
GO

-- Creating foreign key on [ItemId] in table 'ItemTransactions'
ALTER TABLE [dbo].[ItemTransactions]
ADD CONSTRAINT [FK_ItemTransaction_Item]
    FOREIGN KEY ([ItemId])
    REFERENCES [dbo].[Items]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemTransaction_Item'
CREATE INDEX [IX_FK_ItemTransaction_Item]
ON [dbo].[ItemTransactions]
    ([ItemId]);
GO

-- Creating foreign key on [ItemId] in table 'ReceiptLines'
ALTER TABLE [dbo].[ReceiptLines]
ADD CONSTRAINT [FK_ReceiptLines_Item]
    FOREIGN KEY ([ItemId])
    REFERENCES [dbo].[Items]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReceiptLines_Item'
CREATE INDEX [IX_FK_ReceiptLines_Item]
ON [dbo].[ReceiptLines]
    ([ItemId]);
GO

-- Creating foreign key on [UserId] in table 'ItemCategories'
ALTER TABLE [dbo].[ItemCategories]
ADD CONSTRAINT [FK_ItemCategory_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemCategory_User'
CREATE INDEX [IX_FK_ItemCategory_User]
ON [dbo].[ItemCategories]
    ([UserId]);
GO

-- Creating foreign key on [UnitId] in table 'ItemFunds'
ALTER TABLE [dbo].[ItemFunds]
ADD CONSTRAINT [FK_ItemFund_Unit]
    FOREIGN KEY ([UnitId])
    REFERENCES [dbo].[Units]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemFund_Unit'
CREATE INDEX [IX_FK_ItemFund_Unit]
ON [dbo].[ItemFunds]
    ([UnitId]);
GO

-- Creating foreign key on [UserId] in table 'ItemFunds'
ALTER TABLE [dbo].[ItemFunds]
ADD CONSTRAINT [FK_ItemFund_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemFund_User'
CREATE INDEX [IX_FK_ItemFund_User]
ON [dbo].[ItemFunds]
    ([UserId]);
GO

-- Creating foreign key on [UnitId] in table 'ItemTransactions'
ALTER TABLE [dbo].[ItemTransactions]
ADD CONSTRAINT [FK_ItemTransaction_Unit]
    FOREIGN KEY ([UnitId])
    REFERENCES [dbo].[Units]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemTransaction_Unit'
CREATE INDEX [IX_FK_ItemTransaction_Unit]
ON [dbo].[ItemTransactions]
    ([UnitId]);
GO

-- Creating foreign key on [UserId] in table 'Receipts'
ALTER TABLE [dbo].[Receipts]
ADD CONSTRAINT [FK_Receipt_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Receipt_User'
CREATE INDEX [IX_FK_Receipt_User]
ON [dbo].[Receipts]
    ([UserId]);
GO

-- Creating foreign key on [ReceiptId] in table 'ReceiptLines'
ALTER TABLE [dbo].[ReceiptLines]
ADD CONSTRAINT [FK_ReceiptLines_Receipt]
    FOREIGN KEY ([ReceiptId])
    REFERENCES [dbo].[Receipts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReceiptLines_Receipt'
CREATE INDEX [IX_FK_ReceiptLines_Receipt]
ON [dbo].[ReceiptLines]
    ([ReceiptId]);
GO

-- Creating foreign key on [UnitId] in table 'ReceiptLines'
ALTER TABLE [dbo].[ReceiptLines]
ADD CONSTRAINT [FK_ReceiptLines_Unit]
    FOREIGN KEY ([UnitId])
    REFERENCES [dbo].[Units]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReceiptLines_Unit'
CREATE INDEX [IX_FK_ReceiptLines_Unit]
ON [dbo].[ReceiptLines]
    ([UnitId]);
GO

-- Creating foreign key on [UserId] in table 'ReceiptLines'
ALTER TABLE [dbo].[ReceiptLines]
ADD CONSTRAINT [FK_ReceiptLines_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReceiptLines_User'
CREATE INDEX [IX_FK_ReceiptLines_User]
ON [dbo].[ReceiptLines]
    ([UserId]);
GO

-- Creating foreign key on [RoleId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_Users_Role]
    FOREIGN KEY ([RoleId])
    REFERENCES [dbo].[Roles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Users_Role'
CREATE INDEX [IX_FK_Users_Role]
ON [dbo].[Users]
    ([RoleId]);
GO

-- Creating foreign key on [UserId] in table 'Transfers'
ALTER TABLE [dbo].[Transfers]
ADD CONSTRAINT [FK_Transfer_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Transfer_User'
CREATE INDEX [IX_FK_Transfer_User]
ON [dbo].[Transfers]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'Units'
ALTER TABLE [dbo].[Units]
ADD CONSTRAINT [FK_Unit_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Unit_User'
CREATE INDEX [IX_FK_Unit_User]
ON [dbo].[Units]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'Withdraws'
ALTER TABLE [dbo].[Withdraws]
ADD CONSTRAINT [FK_Withdraw_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Withdraw_User'
CREATE INDEX [IX_FK_Withdraw_User]
ON [dbo].[Withdraws]
    ([UserId]);
GO

-- Creating foreign key on [AccountId] in table 'Payments'
ALTER TABLE [dbo].[Payments]
ADD CONSTRAINT [FK_Payment_Account]
    FOREIGN KEY ([AccountId])
    REFERENCES [dbo].[Accounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Payment_Account'
CREATE INDEX [IX_FK_Payment_Account]
ON [dbo].[Payments]
    ([AccountId]);
GO

-- Creating foreign key on [CurrencyId] in table 'Payments'
ALTER TABLE [dbo].[Payments]
ADD CONSTRAINT [FK_Payment_Currency]
    FOREIGN KEY ([CurrencyId])
    REFERENCES [dbo].[Currencies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Payment_Currency'
CREATE INDEX [IX_FK_Payment_Currency]
ON [dbo].[Payments]
    ([CurrencyId]);
GO

-- Creating foreign key on [UserId] in table 'Payments'
ALTER TABLE [dbo].[Payments]
ADD CONSTRAINT [FK_Payment_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Payment_User'
CREATE INDEX [IX_FK_Payment_User]
ON [dbo].[Payments]
    ([UserId]);
GO

-- Creating foreign key on [CurrencyId] in table 'CurrencyBulletins'
ALTER TABLE [dbo].[CurrencyBulletins]
ADD CONSTRAINT [FK_CurrencyBulletin_Currency]
    FOREIGN KEY ([CurrencyId])
    REFERENCES [dbo].[Currencies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CurrencyBulletin_Currency'
CREATE INDEX [IX_FK_CurrencyBulletin_Currency]
ON [dbo].[CurrencyBulletins]
    ([CurrencyId]);
GO

-- Creating foreign key on [CurrencyId] in table 'Prices'
ALTER TABLE [dbo].[Prices]
ADD CONSTRAINT [FK_Price_Currency]
    FOREIGN KEY ([CurrencyId])
    REFERENCES [dbo].[Currencies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Price_Currency'
CREATE INDEX [IX_FK_Price_Currency]
ON [dbo].[Prices]
    ([CurrencyId]);
GO

-- Creating foreign key on [ItemId] in table 'ItemUnits'
ALTER TABLE [dbo].[ItemUnits]
ADD CONSTRAINT [FK_ItemUnit_Item]
    FOREIGN KEY ([ItemId])
    REFERENCES [dbo].[Items]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemUnit_Item'
CREATE INDEX [IX_FK_ItemUnit_Item]
ON [dbo].[ItemUnits]
    ([ItemId]);
GO

-- Creating foreign key on [UnitId] in table 'ItemUnits'
ALTER TABLE [dbo].[ItemUnits]
ADD CONSTRAINT [FK_ItemUnit_Unit]
    FOREIGN KEY ([UnitId])
    REFERENCES [dbo].[Units]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemUnit_Unit'
CREATE INDEX [IX_FK_ItemUnit_Unit]
ON [dbo].[ItemUnits]
    ([UnitId]);
GO

-- Creating foreign key on [BaseUnitId] in table 'ItemUnits'
ALTER TABLE [dbo].[ItemUnits]
ADD CONSTRAINT [FK_ItemUnit_Unit1]
    FOREIGN KEY ([BaseUnitId])
    REFERENCES [dbo].[Units]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemUnit_Unit1'
CREATE INDEX [IX_FK_ItemUnit_Unit1]
ON [dbo].[ItemUnits]
    ([BaseUnitId]);
GO

-- Creating foreign key on [ItemUnitId] in table 'Prices'
ALTER TABLE [dbo].[Prices]
ADD CONSTRAINT [FK_Price_ItemUnit]
    FOREIGN KEY ([ItemUnitId])
    REFERENCES [dbo].[ItemUnits]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Price_ItemUnit'
CREATE INDEX [IX_FK_Price_ItemUnit]
ON [dbo].[Prices]
    ([ItemUnitId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
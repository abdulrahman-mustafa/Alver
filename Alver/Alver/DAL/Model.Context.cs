﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alver.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbEntities : DbContext
    {
        public dbEntities()
            : base("name=dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountFund> AccountFunds { get; set; }
        public virtual DbSet<AccountGroup> AccountGroups { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<AppSetting> AppSettings { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillLine> BillLines { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<CurrencyBulletin> CurrencyBulletins { get; set; }
        public virtual DbSet<CurrencyExchange> CurrencyExchanges { get; set; }
        public virtual DbSet<CurrencyExchangeOperation> CurrencyExchangeOperations { get; set; }
        public virtual DbSet<Exchange> Exchanges { get; set; }
        public virtual DbSet<ExchangeFund> ExchangeFunds { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public virtual DbSet<Fund> Funds { get; set; }
        public virtual DbSet<FundTransaction> FundTransactions { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemCategory> ItemCategories { get; set; }
        public virtual DbSet<ItemFund> ItemFunds { get; set; }
        public virtual DbSet<ItemTransaction> ItemTransactions { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<ReceiptLine> ReceiptLines { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<Transfer> Transfers { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Withdraw> Withdraws { get; set; }
        public virtual DbSet<V_CLIENTS> V_CLIENTS { get; set; }
        public virtual DbSet<V_STOCK> V_STOCK { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
    
        public virtual int CreateClientFunds(Nullable<int> clientId)
        {
            var clientIdParameter = clientId.HasValue ?
                new ObjectParameter("ClientId", clientId) :
                new ObjectParameter("ClientId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateClientFunds", clientIdParameter);
        }
    
        public virtual ObjectResult<SP_ClientGrand_Result> SP_ClientGrand(Nullable<int> clientId)
        {
            var clientIdParameter = clientId.HasValue ?
                new ObjectParameter("ClientId", clientId) :
                new ObjectParameter("ClientId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ClientGrand_Result>("SP_ClientGrand", clientIdParameter);
        }
    
        public virtual ObjectResult<SP_ItemGrand_Result> SP_ItemGrand(Nullable<int> itemId)
        {
            var itemIdParameter = itemId.HasValue ?
                new ObjectParameter("ItemId", itemId) :
                new ObjectParameter("ItemId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ItemGrand_Result>("SP_ItemGrand", itemIdParameter);
        }
    
        public virtual ObjectResult<BillSlip_Result> BillSlip(Nullable<int> billId)
        {
            var billIdParameter = billId.HasValue ?
                new ObjectParameter("BillId", billId) :
                new ObjectParameter("BillId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BillSlip_Result>("BillSlip", billIdParameter);
        }
    
        public virtual ObjectResult<ItemAvgPurchasePrice_Result> ItemAvgPurchasePrice(Nullable<int> itemId, Nullable<int> unitId)
        {
            var itemIdParameter = itemId.HasValue ?
                new ObjectParameter("ItemId", itemId) :
                new ObjectParameter("ItemId", typeof(int));
    
            var unitIdParameter = unitId.HasValue ?
                new ObjectParameter("unitId", unitId) :
                new ObjectParameter("unitId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ItemAvgPurchasePrice_Result>("ItemAvgPurchasePrice", itemIdParameter, unitIdParameter);
        }
    
        public virtual ObjectResult<ItemAvgSalePrice_Result> ItemAvgSalePrice(Nullable<int> itemId, Nullable<int> unitId)
        {
            var itemIdParameter = itemId.HasValue ?
                new ObjectParameter("ItemId", itemId) :
                new ObjectParameter("ItemId", typeof(int));
    
            var unitIdParameter = unitId.HasValue ?
                new ObjectParameter("unitId", unitId) :
                new ObjectParameter("unitId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ItemAvgSalePrice_Result>("ItemAvgSalePrice", itemIdParameter, unitIdParameter);
        }
    
        public virtual int DeleteAllData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteAllData");
        }
    
        public virtual ObjectResult<SP_FundsMovements_Result> SP_FundsMovements()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_FundsMovements_Result>("SP_FundsMovements");
        }
    }
}

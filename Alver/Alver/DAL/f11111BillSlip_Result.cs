//------------------------------------------------------------------------------
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
    
    public partial class f11111BillSlip_Result
    {
        public int Id { get; set; }
        public Nullable<int> BillId { get; set; }
        public Nullable<int> ItemId { get; set; }
        public string ItemName { get; set; }
        public Nullable<int> UnitId { get; set; }
        public string UnitName { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<bool> Exchanged { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<int> ForeginCurrencyId { get; set; }
        public string ForeginCurrencyName { get; set; }
        public Nullable<decimal> ExchangedAmount { get; set; }
        public Nullable<decimal> ExchangedTotalAmount { get; set; }
        public Nullable<int> LinesCount { get; set; }
    }
}

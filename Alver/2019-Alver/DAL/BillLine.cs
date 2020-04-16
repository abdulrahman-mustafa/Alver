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
    using System.Collections.Generic;
    
    public partial class BillLine
    {
        public int Id { get; set; }
        public Nullable<int> BillId { get; set; }
        public Nullable<int> ItemId { get; set; }
        public Nullable<int> UnitId { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<bool> Exchanged { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<int> ForeginCurrencyId { get; set; }
        public Nullable<decimal> ExchangedAmount { get; set; }
        public Nullable<decimal> ExchangedTotalAmount { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<bool> Hidden { get; set; }
        public string Flag { get; set; }
        public Nullable<System.Guid> GUID { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
        public Nullable<bool> PROTECTED { get; set; }
    
        public virtual Bill Bill { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Currency Currency1 { get; set; }
        public virtual Item Item { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual User User { get; set; }
    }
}

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
    
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            this.BillLines = new ObservableListSource<BillLine>();
        }
    
        public int Id { get; set; }
        public string BillType { get; set; }
        public Nullable<int> AccountId { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public Nullable<bool> Cashout { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<decimal> BillAmount { get; set; }
        public Nullable<decimal> DiscountAmount { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<bool> Exchanged { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<int> ForeginCurrencyId { get; set; }
        public Nullable<decimal> ExchangedAmount { get; set; }
        public string Declaration { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<bool> Hidden { get; set; }
        public string Flag { get; set; }
        public Nullable<System.Guid> GUID { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
        public Nullable<bool> PROTECTED { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Currency Currency1 { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<BillLine> BillLines { get; set; }
    }
}

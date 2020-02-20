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
    
    public partial class Unit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Unit()
        {
            this.BillLines = new ObservableListSource<BillLine>();
            this.Items = new ObservableListSource<Item>();
            this.ItemFunds = new ObservableListSource<ItemFund>();
            this.ItemTransactions = new ObservableListSource<ItemTransaction>();
            this.ReceiptLines = new ObservableListSource<ReceiptLine>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Symbol { get; set; }
        public Nullable<bool> IsDefault { get; set; }
        public string Declaration { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<bool> Hidden { get; set; }
        public string Flag { get; set; }
        public Nullable<System.Guid> GUID { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
        public Nullable<bool> PROTECTED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<BillLine> BillLines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<Item> Items { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<ItemFund> ItemFunds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<ItemTransaction> ItemTransactions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<ReceiptLine> ReceiptLines { get; set; }
        public virtual User User { get; set; }
    }
}

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
    
    public partial class Image
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Image()
        {
            this.Companies = new ObservableListSource<Company>();
        }
    
        public int Id { get; set; }
        public Nullable<int> AlbumId { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageTitle { get; set; }
        public string Notes { get; set; }
        public Nullable<System.Guid> GUID { get; set; }
        public Nullable<bool> Hidden { get; set; }
        public string Flag { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
        public Nullable<bool> PROTECTED { get; set; }
    
        public virtual Album Album { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<Company> Companies { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Warehouse
{
    using System;
    using System.Collections.Generic;
    
    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            this.Product_Transfer = new HashSet<Product_Transfer>();
            this.Supply_Quantity = new HashSet<Supply_Quantity>();
            this.Supply_Permission = new HashSet<Supply_Permission>();
        }
    
        public int S_id { get; set; }
        public string S_email { get; set; }
        public string S_name { get; set; }
        public Nullable<int> S_fax { get; set; }
        public Nullable<int> S_mob_num { get; set; }
        public Nullable<int> S_tel_num { get; set; }
        public string S_website { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Transfer> Product_Transfer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supply_Quantity> Supply_Quantity { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supply_Permission> Supply_Permission { get; set; }
    }
}

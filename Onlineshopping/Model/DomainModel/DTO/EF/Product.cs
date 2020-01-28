//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Onlineshopping.Model.DomainModel.DTO.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.ProductSupplier = new HashSet<ProductSupplier>();
        }
    
        public int Productid { get; set; }
        public string Productname { get; set; }
        public Nullable<decimal> Productunitprice { get; set; }
        public Nullable<decimal> Productdiscount { get; set; }
        public Nullable<int> Productstock { get; set; }
        public Nullable<int> Categoryid { get; set; }
        public Nullable<int> supplierid { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSupplier> ProductSupplier { get; set; }
    }
}

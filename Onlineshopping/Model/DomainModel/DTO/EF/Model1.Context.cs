﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class onlineshopingEntities : DbContext
    {
        public onlineshopingEntities()
            : base("name=onlineshopingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductSupplier> ProductSupplier { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
    
        public virtual ObjectResult<getcategory_Result> getcategory()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getcategory_Result>("getcategory");
        }
    
        public virtual ObjectResult<getproduct_Result> getproduct(Nullable<int> categoryid)
        {
            var categoryidParameter = categoryid.HasValue ?
                new ObjectParameter("Categoryid", categoryid) :
                new ObjectParameter("Categoryid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getproduct_Result>("getproduct", categoryidParameter);
        }
    
        public virtual int InsertProduct()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertProduct");
        }
    }
}
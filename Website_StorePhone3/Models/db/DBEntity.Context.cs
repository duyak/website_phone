﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Website_StorePhone3.Models.db
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class phone_storeEntities : DbContext
    {
        public phone_storeEntities()
            : base("name=phone_storeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<auth> auths { get; set; }
        public DbSet<brand> brands { get; set; }
        public DbSet<category> categories { get; set; }
        public DbSet<color> colors { get; set; }
        public DbSet<comment> comments { get; set; }
        public DbSet<discount> discounts { get; set; }
        public DbSet<importproduct> importproducts { get; set; }
        public DbSet<importproductdetail> importproductdetails { get; set; }
        public DbSet<item> items { get; set; }
        public DbSet<menu> menus { get; set; }
        public DbSet<order> orders { get; set; }
        public DbSet<orderdetail> orderdetails { get; set; }
        public DbSet<product> products { get; set; }
        public DbSet<productdetail> productdetails { get; set; }
        public DbSet<role> roles { get; set; }
        public DbSet<roleuser> roleusers { get; set; }
        public DbSet<spec> specs { get; set; }
        public DbSet<specdetail> specdetails { get; set; }
        public DbSet<supplier> suppliers { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<voucher> vouchers { get; set; }
        public DbSet<storage> storages { get; set; }
    }
}

//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class productline
    {
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> brandId { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<System.DateTime> createUpdate { get; set; }
    
        public virtual brand brand { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Website_StorePhone3.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class order
    {
        public order()
        {
            this.orderdetails = new HashSet<orderdetail>();
        }
    
        public int id { get; set; }
        public int userId { get; set; }
        public string name { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public Nullable<int> payment { get; set; }
        public int quantity { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<int> status { get; set; }
        public int activeFlag { get; set; }
        public System.DateTime createDate { get; set; }
        public System.DateTime updateDate { get; set; }
    
        public virtual user user { get; set; }
        public virtual ICollection<orderdetail> orderdetails { get; set; }
    }
}

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
    
    public partial class role
    {
        public role()
        {
            this.auths = new HashSet<auth>();
            this.roleusers = new HashSet<roleuser>();
        }
    
        public int id { get; set; }
        public string roleName { get; set; }
        public string description { get; set; }
        public int activeFlag { get; set; }
        public System.DateTime createDate { get; set; }
        public System.DateTime updateDate { get; set; }
    
        public virtual ICollection<auth> auths { get; set; }
        public virtual ICollection<roleuser> roleusers { get; set; }
    }
}

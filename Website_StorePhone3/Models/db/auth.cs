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
    
    public partial class auth
    {
        public int id { get; set; }
        public int roleId { get; set; }
        public int menuId { get; set; }
        public int Permission { get; set; }
        public int activeFlag { get; set; }
        public System.DateTime createDate { get; set; }
        public System.DateTime updateDate { get; set; }
    
        public virtual menu menu { get; set; }
        public virtual role role { get; set; }
    }
}

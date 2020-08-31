using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;
using System.Web.UI.WebControls;
using Website_StorePhone3.Models.db;

namespace Website_StorePhone3.Areas.Admin.Controllers
{
    public class Brand1Controller
    {
        private phone_storeEntities1 db = new phone_storeEntities1();

        //GET: Brand/Add
        public ActionResult addBrand()
        {
            return View();
        }
        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult addBrand([Bind(Include ="id,name,activeFlag,createDate,updateDate,status")] brand brand,HttpPostedFileBase logoBrand)
        {
            if(logoBrand !=null && logoBrand.ContentLength > 0)
            {
                string fileName = System.IO.Path.GetFileName(logoBrand.FileName);
                string urlImage = Server.MapPath("~/Image/" + fileName);
            }

        }
    }
   

}

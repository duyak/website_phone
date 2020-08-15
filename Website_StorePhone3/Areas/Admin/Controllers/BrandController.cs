using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Website_StorePhone3.Areas.Models;
using Website_StorePhone3.Models.db;
using PagedList;

namespace Website_StorePhone3.Areas.Admin.Controllers
{
    public class BrandController : Controller
    {
        phone_storeEntities1 db = new phone_storeEntities1();
        // GET: Admin/Brand
        public ActionResult Index()
        {
            List<brand> brands = db.brands.ToList();
            return View(brands);
        }
        public ActionResult saveBrand(string nameBrand,string logoBrand)
        {
            string result = "Error! brand Is Not Complete!";
            if(nameBrand != null && logoBrand != null)
            {
                brand model = new brand();
                model.name = nameBrand;
                model.logo = logoBrand;
                model.activeFlag = 1;
                model.status = 1;
                model.createDate = DateTime.Now;
                db.brands.Add(model);
                db.SaveChanges();
                result = "Success! Order Is Complete!";
            }
            return Json(result, JsonRequestBehavior.AllowGet);

        }
       
        public ActionResult addBrand()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addBrand(FormCollection fc)
        {
            string name_ = fc["name"];
            string logo = fc["logo"];

            brand brands = new brand { name = name_, logo = logo };
            brands.activeFlag = 1;
            brands.status = 1;
            brands.createDate = DateTime.Today;
            brands.updateDate = DateTime.Today;
            db.brands.Add(brands);
            db.SaveChanges();
            return RedirectToAction("Index");

            //them
           
        }
    }    
}
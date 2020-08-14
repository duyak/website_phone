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
        public ActionResult saveBrands(string name,HttpPostedFileBase logo)
        {
            brand model = new brand();
            string result = "Lỗi !Thêm không thành công!!!";
            if (name != null && logo.ContentLength > 0)
            {


                model.name = name;
                model.createDate = DateTime.Now;
                model.updateDate = DateTime.Now;
                model.activeFlag = 1;
                model.status = 1;
                string filename = System.IO.Path.GetFileName(logo.FileName);
                string urlLogo = Server.MapPath("~/Image/" + filename);
                logo.SaveAs(urlLogo);
                model.logo = "Image/" + urlLogo;
                db.brands.Add(model);
                db.SaveChanges();
                result = "Thành công !!!";
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
           
        }
    }    
}
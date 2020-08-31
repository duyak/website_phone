using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Website_StorePhone3.Models.DB;

namespace Website_StorePhone3.Areas.Models
{
    public class CategoryModel
    {
        private dotnetstorephoneEntities db;

        public CategoryModel()
        {
            db = new dotnetstorephoneEntities();
        }
        public IQueryable<category> GetCategory()
        {
            IQueryable<category> lst = db.categories;
            return lst;
        }
        internal category FindById(string id)
        {
            return db.categories.Find(id);
        }

    }
    
}
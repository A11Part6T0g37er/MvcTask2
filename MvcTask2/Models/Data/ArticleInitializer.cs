using Domain;
using MvcTask1.Models.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcTask1.Models
{
    public class ArticleInitializer : DropCreateDatabaseAlways<BlogContext>
    {
        protected override void Seed(BlogContext db)
        {
            db.Articles.Add(new Article { Title = "Лорем ипсум", Slug = "Лорем долорем", Time = DateTime.Now }); 
            db.Articles.Add(new Article { Title = "Лорем ипсум", Slug = "Лорем долорем", Time = DateTime.Now });
            db.Articles.Add(new Article { Title = "Лорем ипсум", Slug = "Дорем Долорем", Time = DateTime.Now });
            base.Seed(db);
        }
    }
}
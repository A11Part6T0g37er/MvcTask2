using Domain;
using MvcTask1.Models;
using MvcTask1.Models.Data;
using MvcTask1.Models.ViewModels.Profiles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTask1.Controllers
{
    public class HomeController : Controller
    {
        BlogContext db = new BlogContext();
        public ActionResult Index()
        {
            // получаем из бд все объекты Article
            IEnumerable<Article> articles = db.Articles;
            // передаем все объекты в динамическое свойство Articles в ViewBag
            ViewBag.Articles = articles;
            return View();
        }
        [HttpGet]
        public ActionResult Anceta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Anceta(ProfVM model)
        {
           //if (!ModelState.IsValid)
           // {
           //     return HttpNotFound();
           //}
            using (BlogContext db = new BlogContext())
            {
                string surname;

                ProfDTO dto = new ProfDTO();

                dto.Name = model.Name.ToUpper();

                if (string.IsNullOrWhiteSpace(model.Surname))
                {
                    surname = model.Surname.Replace(" ", "-").ToLower();
                }
                else
                {
                    surname = model.Surname.Replace(" ", "-").ToLower();
                }
                if (db.Profs.Any(x => x.Email == model.Email))
                {
                    ModelState.AddModelError("", "That email already exist.");
                    return View(model);
                }
                if (dto.Age < 0 || dto.Age>145)
                {
                    ModelState.AddModelError("", "That age don`t seemed to be real.");
                    return View(model);
                }
                
                dto.Surname = surname;
                
                dto.Password = model.Password;
                dto.Email = model.Email;
                dto.Age = model.Age;
                dto.Gender = model.Gender;

                db.Profs.Add(dto);
                db.SaveChanges();
            }
            return RedirectToAction("ShowAnceta");
        }
        public ActionResult ShowAnceta()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Guest()
        {
            DateTime date1 = new DateTime(2015, 7, 20);
            ViewBag.Guest = "D1mon: Шикарный блог!\n" + date1.ToShortDateString();
            return View();
        }
        [HttpPost]
        public ActionResult Guest(string name, string comm)
        {
            ViewBag.Guest = ViewBag.Guest + "\n"+ name + ": " + comm + "\n" + DateTime.Now.ToShortDateString();
            return View();
        }
      
    }
}
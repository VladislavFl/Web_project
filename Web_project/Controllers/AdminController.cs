using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web_project.Models;

namespace Web_project.Controllers
{
    public class AdminController : Controller
    {
        ApplicationContext db = new ApplicationContext();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(String Login, String Password)
        {
            if (Login == "Admin" && Password == "Admin")
            {
                return RedirectToAction("List");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public IActionResult List()
        {
            var Users = db.Users.ToList();
            return View(Users);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            User user = db.Users.FirstOrDefault(m => m.Id == id);
            return View(user);
        }
        [HttpPost]
        public IActionResult Edit(User user)
        {
            db.Users.Update(user);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int id)
        {
            db.Users.Remove(db.Users.FirstOrDefault(m => m.Id == id));
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
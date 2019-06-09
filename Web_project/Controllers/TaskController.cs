using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web_project.Models;

namespace Web_project.Controllers
{
    public class TaskController : Controller
    {
        ApplicationContext db = new ApplicationContext();
        public IActionResult Index()
        {
            var Tasks = db.Missions.ToList();
            return View(Tasks);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Mission mission)
        {
            db.Missions.Add(mission);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Mission mission = db.Missions.FirstOrDefault(m => m.Id == id);
            return View(mission);
        }
        [HttpPost]
        public IActionResult Edit(Mission mission)
        {
            db.Missions.Update(mission);
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
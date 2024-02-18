using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LNLinventory.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var list = new List<Users>();
            using (var db = new LNLinventoryEntities())
            {
                list = db.Users.ToList();
            }
            return View(list);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Users u)
        {
            using (var db = new LNLinventoryEntities())
            {
                var newUser = new Users();
                newUser.Username = u.Username;
                newUser.Password = u.Password;

                db.Users.Add(newUser);
                db.SaveChanges();

                TempData["msg"] = $"Added {newUser.Username} Successfully!";
            }
                return RedirectToAction("Index");
        }
        public ActionResult Create(int id)
        {
            var u = new Users();
            using (var db = new LNLinventoryEntities())
            {
                u = db.Users.Find(id);
            }
                return View();
        }
        public ActionResult Update(int id)
        {
            var u = new Users();
            using (var db = new LNLinventoryEntities())
            {
                u = db.Users.Find(id);
            }
            return View(u);
        }
        [HttpPost]
        public ActionResult Update(Users u)
        {
            using (var db = new LNLinventoryEntities())
            {

                var newUser = db.Users.Find(u.id);
                newUser.Username = u.Username;
                newUser.Password = u.Password;

                db.Users.Add(newUser);
                db.SaveChanges();

                TempData["msg"] = $"Updated {newUser.Username} Successfully!";
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var u = new Users();
            using (var db = new LNLinventoryEntities())
            {
                u = db.Users.Find(id);
                db.Users.Remove(u);
                db.SaveChanges();

                TempData["msg"] = $"Removed {u.Username} Successfully!";
            }
            return RedirectToAction("Index");
        }
    }
}
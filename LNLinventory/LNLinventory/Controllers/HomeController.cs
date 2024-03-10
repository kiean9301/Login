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
            List<Users> userList = _userRepo.GetAll();
            return View(userList);
        }

        public Action Create()
        {
            return View();
        }
        [HttpPost]
        public Action Create(User u)
        {
            _userRepo.Create(u);
            TempData["Msg"] = $"User {u.Username} added!";

            return RedirectToAction("Index");
        }
    }

}
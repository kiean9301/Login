using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyAppCRUD.Repository;

namespace MyAppCRUD.Controllers
{
    public class BaseController : Controller
    {
        public dbsys32Entities _db;
        public BaseRepository<User> _userRepo;
        public BaseController()
            {
            _db = new dbsys32Entities();
            _userRepo = new BaseRepository<User>();
            }
    }
}
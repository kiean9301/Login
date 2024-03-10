using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LNLinventory.Respository;

namespace LNLinventory.Controllers
{
    public class BaseController : Controller
    {
        public LNLinventoryEntities1 _db;
        public BaseRepository<Users> _useRepo;

        public BaseController()
        {
            _db = new LNLinventoryEntities1();
            _useRepo = new BaseRepository<Users>();
        }
    }
}
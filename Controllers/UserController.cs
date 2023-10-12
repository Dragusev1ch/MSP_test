using MSP_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSP_test.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            using (var db = new ApplicationDbContext())
            {
                var users = db.Users.ToList();
                return View(users);
            }
        }
    }
}
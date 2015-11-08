using EFCodeFirstApp.Models.Data.DBContext;
using EFCodeFirstApp.Models.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFCodeFirstApp.Controllers
{
    public class DbOperationsController : Controller
    {
        InternetDBContext _context;

        public DbOperationsController()
        {
            _context = new InternetDBContext();
        }
        
        public ActionResult UserList()
        {
            var users = _context.Users.OrderByDescending(u => u.Name).ToList();

            return View(users);
        }

        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(User user)
        {
            if (ModelState.IsValid)
            {
                user.RoleID = 1;
                _context.Users.Add(user);
                _context.SaveChanges();
            }
            return View();
        }
    }
}
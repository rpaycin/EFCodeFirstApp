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
            //AddUser(new User
            //{
            //    Name = "test user",
            //    IsLogin = true,
            //    RoleID=1
            //});

            var users = _context.Users.OrderByDescending(u => u.Name).ToList();

            return View(users);
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
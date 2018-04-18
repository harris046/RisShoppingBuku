using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingBukuOnline.Models;
using ShoppingBukuOnline.ViewModels;

namespace ShoppingBukuOnline.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult register()
        {
            return View();
        }

        [HttpGet]
        public ActionResult addCustomer()
        {
            return View("register");
        }
        [HttpPost]
        public ActionResult addCustomer(UserCustomer uc)
        {
            if (ModelState.IsValid)
            {
                return View(uc);
            }
            else
            {
                return View("register");
            }

        }
    }
}
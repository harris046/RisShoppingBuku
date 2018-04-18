using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingBukuOnline.Models;
using ShoppingBukuOnline.ViewModels;

namespace ShoppingBukuOnline.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: Authentication
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult logIn()
        {
            return View();
        }
        
        public ActionResult logOut()
        {
            return View();
        }

        public ActionResult updatePassword()
        {
            return View();
        }

    }
}
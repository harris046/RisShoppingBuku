using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingBukuOnline.Controllers
{
    public class ShoppingController : Controller
    {
        // GET: Shopping
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult viewCart()
        {
            return View();
        }

        public ActionResult addCart()
        {
            return View();
        }

        public ActionResult updateCart()
        {
            return View();
        }

        public ActionResult checkOut()
        {
            return View();
        }
    }
}
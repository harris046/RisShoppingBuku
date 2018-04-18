using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingBukuOnline.Models;
using ShoppingBukuOnline.ViewModels;

namespace ShoppingBukuOnline.Controllers
{
    public class BukuController : Controller
    {
        // GET: Buku
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult formBuku()
        {
            return View();
        }

        [HttpGet]
        public ActionResult addBuku()
        {
            return View("formBuku");
        }
        [HttpPost]
        public ActionResult addBuku(Buku b)
        {
            if (ModelState.IsValid)
            {
                return View(b);
            }
            else
            {
                return View("formBuku");
            }
        }

    }
}
﻿using BookingAppStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookingAppStore.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();
        public ActionResult Index()
        {
            var books = db.Books;
            ViewBag.Books = books;
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }

        [HttpPost]
        public string Buy(Purchese purchese)
        {
            purchese.Date = DateTime.Now;
            // db-um avelacnum enq vaharqi masin
            db.Purcheses.Add(purchese);
            // soxranit enq anum bolor popoxutyunnern bd-um
            db.SaveChanges();
            return "Շնորհակալություն," + purchese.Person + ",Գնումների համար!!!";
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
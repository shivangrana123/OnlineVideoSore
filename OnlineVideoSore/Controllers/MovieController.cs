using OnlineVideoSore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineVideoSore.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            var movies = new Movie() {Name="Shrek!!" };
            return View(movies);
            //return Content("Hello");
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {page=1, sortBy="name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("id: "+ id);
        }
    }
}
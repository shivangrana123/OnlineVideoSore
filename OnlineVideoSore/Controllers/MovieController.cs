using OnlineVideoSore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineVideoSore.ViewModels;

namespace OnlineVideoSore.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            var movies = new Movie() {Name="Shrek!!" };
            //ViewData["Movie"] = movies;
            //ViewBag.Movie = movies;
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };
            var viewModel = new RandomMovieViewModel();
            viewModel.Movie = movies;
            viewModel.Customers = customers;
            return View(viewModel);
            //return Content("Hello");
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {page=1, sortBy="name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("id: "+ id);
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content($"page Index={pageIndex}");
        }

        [Route("movies/release/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{year}/{month}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };


            // ViewData["Movie"] = movie;
            return View(viewModel);
            
            // return Content("Hello!");
            // return HttpNotFound();
            // return new EmptyResult();
            // return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        public ActionResult Movies()
        {
            ViewBag.Message = "Here is a list over our movies:";

            var all_movies = new List<Movie>
            {
                new Movie { Name = "Movie 1", Id = 1 },
                new Movie { Name = "Movie 2", Id = 2 },
                new Movie { Name = "Movie 3", Id = 3 }
            };

            var viewModel = new MoviesViewModel
            {
                Movie = all_movies 
            };
                
                return View(viewModel);
        }

        public ActionResult View1()
        {
            ViewBag.Message = "Here is a list over our movies:";

            var mov = new Movie() { Name = "Movie 1", Id = 1 };

            return View("View1", mov);
        }


        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

         public ActionResult Edit(int id)        {
            return Content("id=" + id);
        }

         public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
  
    }
}
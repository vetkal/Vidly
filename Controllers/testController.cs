using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class testController : Controller
    {
        public ActionResult Test()
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
        // GET: test
        public ActionResult rr()
        {
            ViewBag.Message = "This is my test page!";
            return View();
        }
    }
}
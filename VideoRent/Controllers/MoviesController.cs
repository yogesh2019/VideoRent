﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using VideoRent.Models;
using VideoRent.ViewModels;
namespace VideoRent.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            return Content("movie");
        }
        // GET: Movies/Random   
        public ActionResult Random()
        {
            var movie = new Movies() { Name = "shrek !" };
            var customers = new List<Customer>
            {
                new Customer { Id =  1},
                new Customer { Id = 2}

            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}
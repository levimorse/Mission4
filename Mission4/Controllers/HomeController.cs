using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission4.Models;

namespace Mission4.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _movieContext { get; set; }

        public HomeController(MovieContext singleMovie)
        {
            _movieContext = singleMovie;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            ViewBag.Categories = _movieContext.categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Form(MovieDatabase md)
        {
            _movieContext.Add(md);
            _movieContext.SaveChanges();
            return View("Confirmation", md);
        }

        public IActionResult MovieList()
        {
            var fullMovieList = _movieContext.info
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();

            return View(fullMovieList);
        }
    }
}

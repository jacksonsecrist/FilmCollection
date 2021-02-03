using FilmCollection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FilmCollection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddFilm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddFilm(Film newFilm)
        {
            if (ModelState.IsValid)
            {
                if(newFilm.Title != "Independence Day")
                {
                    TempStorage.AddFilm(newFilm);
                    return View("Confirmation", newFilm);
                }
                else
                {
                    return View("NotStored");
                }
            }
            else
            {
                return View();
            }
        }

        public IActionResult Collection()
        {
            return View(TempStorage.FilmCollection);
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

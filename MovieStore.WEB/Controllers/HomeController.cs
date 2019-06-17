using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Service;
using MovieStore.WEB.Models;

namespace MovieStore.WEB.Controllers
{
    public class HomeController : Controller
    {
        AppUserService appUserService;
        MovieService movieService;
        CategoryService categoryService;
        public HomeController()
        {
            categoryService = new CategoryService();
            appUserService = new AppUserService();
            movieService = new MovieService();
        }
        public IActionResult Index()
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

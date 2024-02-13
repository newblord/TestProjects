using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BrinjTheHeat.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RSVP()
        {
            return View();
        }

        public IActionResult FullGallery()
        {
            return View();
        }
    }
}
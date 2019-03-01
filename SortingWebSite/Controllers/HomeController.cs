using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SortingWebSite.Models;

namespace SortingWebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult QuickSort()
        {
            ViewData["Message"] = "Quick Sort";

            return View();
        }

        public IActionResult MergeSort()
        {
            ViewData["Message"] = "Select a button to run merge sort!";

			var model = new MergeSort();

            return View(model);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

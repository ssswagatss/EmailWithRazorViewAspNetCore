using Email.Web.Helpers;
using Email.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Email.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly RazorViewRender _razorViewRender;

        public HomeController(RazorViewRender razorViewRender)
        {
            this._razorViewRender = razorViewRender ?? throw new ArgumentNullException(nameof(razorViewRender));
        }
        public IActionResult Index()
        {
            List<Employee> employees = new List<Employee>() {
                new Employee("Swagat","Swain"),
                new Employee("Rohit","Khan"),
                new Employee("Roy","Sethy"),
                new Employee("Salman","Jena")
            };

            var viewWithViewModel = _razorViewRender.Render("~/Views/EmailTemplates/_EmployeesTemplate.cshtml", employees);
            return Ok(viewWithViewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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

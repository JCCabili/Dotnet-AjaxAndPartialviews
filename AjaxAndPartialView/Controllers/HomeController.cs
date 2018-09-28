using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AjaxAndPartialView.Models;

namespace AjaxAndPartialView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

  
        public PartialViewResult All()
        {
            var student1 = new Student { Name="Jhon Wayne",Grade = 99 , Date = DateTime.Now };
            var student2 = new Student { Name = "Christine ", Grade = 98, Date = DateTime.Now };
            var student3 = new Student { Name = "JC", Grade = 72, Date = DateTime.Now };


            var studentList = new List<Student>();
            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);

            return PartialView("_Student", studentList);
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}

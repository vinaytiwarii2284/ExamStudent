using ExamStudent.Models;
using ExamStudent.ViewModel;
using ExamStudent.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamStudent.Controllers
{
    public class HomeController : Controller
    {
        ExamStudentContext context = new ExamStudentContext();

        public ActionResult Index()
        {
           
            return View();
        }

      
      
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult PrivacyPolicy()
        {
            return View();
        }
    }
}
using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamStudent.Controllers
{
    public class StateController : Controller
    {
        ExamStudentContext context = new ExamStudentContext();
        // GET: State
        public ActionResult Index()
        {
            var list = context.States.ToList();

            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(State state)
        {
            ExamStudentContext context = new ExamStudentContext();
            context.States.Add(state);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
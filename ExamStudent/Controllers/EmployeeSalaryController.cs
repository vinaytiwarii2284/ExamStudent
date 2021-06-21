using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ExamStudent.Controllers
{
    public class EmployeeSalaryController : Controller
    {
        private readonly ExamStudentContext context = new ExamStudentContext();
        // GET: EmployeeSalary
        public ActionResult Index()
        {
            var mastersalarylist = context.MasterSalaries.ToList();

            return View(mastersalarylist);
        }

        public ActionResult Salary()
        {
            List<PostForm> postForms = context.PostForms.ToList();

            return View(postForms);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Salary([Bind(Include = "SalaryMasterID,PostID,Salary,MinRefer,Comssion")] MasterSalary masterSalary)
        {
            if (ModelState.IsValid)
            {
                context.MasterSalaries.Add(masterSalary);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(masterSalary);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MasterSalary masterSalary = context.MasterSalaries.Find(id);
            if (masterSalary == null)
            {
                return HttpNotFound();
            }
            return View(masterSalary);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SalaryMasterID,PostID,Salary,MinRefer,Comssion")] MasterSalary masterSalary)
        {
            if (ModelState.IsValid)
            {
                context.Entry(masterSalary).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(masterSalary);
        }



    }
}
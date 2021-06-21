using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExamStudent.Models;

namespace ExamStudent.Controllers
{
    public class EmployeeMasterSalariesController : Controller
    {
        private ExamStudentContext db = new ExamStudentContext();

        // GET: EmployeeMasterSalaries
        public ActionResult Index()
        {
            return View(db.MasterSalaries.ToList());
        }

        // GET: EmployeeMasterSalaries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MasterSalary masterSalary = db.MasterSalaries.Find(id);
            if (masterSalary == null)
            {
                return HttpNotFound();
            }
            return View(masterSalary);
        }

        // GET: EmployeeMasterSalaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeMasterSalaries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SalaryMasterID,PostID,Salary,MinRefer,Comssion")] MasterSalary masterSalary)
        {
            if (ModelState.IsValid)
            {
                db.MasterSalaries.Add(masterSalary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(masterSalary);
        }

        // GET: EmployeeMasterSalaries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MasterSalary masterSalary = db.MasterSalaries.Find(id);
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
                db.Entry(masterSalary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(masterSalary);
        }

        // GET: EmployeeMasterSalaries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MasterSalary masterSalary = db.MasterSalaries.Find(id);
            if (masterSalary == null)
            {
                return HttpNotFound();
            }
            return View(masterSalary);
        }

        // POST: EmployeeMasterSalaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MasterSalary masterSalary = db.MasterSalaries.Find(id);
            db.MasterSalaries.Remove(masterSalary);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

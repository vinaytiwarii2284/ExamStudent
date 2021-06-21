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
    public class FranchiesController : Controller
    {
        private ExamStudentContext db = new ExamStudentContext();

        // GET: Franchies
        public ActionResult Index()
        {
            return View(db.Franchies.ToList());
        }

        // GET: Franchies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Franchy franchy = db.Franchies.Find(id);
            if (franchy == null)
            {
                return HttpNotFound();
            }
            return View(franchy);
        }

        // GET: Franchies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Franchies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Code,Amount,gstPercentage,Transpercentage,FranchiesName")] Franchy franchy)
        {
            if (ModelState.IsValid)
            {
                db.Franchies.Add(franchy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(franchy);
        }

        // GET: Franchies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Franchy franchy = db.Franchies.Find(id);
            if (franchy == null)
            {
                return HttpNotFound();
            }
            return View(franchy);
        }

        // POST: Franchies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Code,Amount,gstPercentage,Transpercentage,FranchiesName")] Franchy franchy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(franchy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(franchy);
        }

        // GET: Franchies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Franchy franchy = db.Franchies.Find(id);
            if (franchy == null)
            {
                return HttpNotFound();
            }
            return View(franchy);
        }

        // POST: Franchies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Franchy franchy = db.Franchies.Find(id);
            db.Franchies.Remove(franchy);
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

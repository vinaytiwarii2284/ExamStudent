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
    public class EmployeeApController : Controller
    {
        private ExamStudentContext db = new ExamStudentContext();

        // GET: EmployeeAp
        public ActionResult Index()
        {
            if (Session["AdminID"] == null)
            {
                return RedirectToAction("Login" , "Admin");
            }
            var employee_Form_Temp = db.Employee_Form_Temp.Include(e => e.Emp_City).Include(e => e.EmpState).Include(e => e.PostForm).Include(e => e.ReferalForm);
            return View(employee_Form_Temp.ToList());
        }

        // GET: EmployeeAp/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_Form_Temp employee_Form_Temp = db.Employee_Form_Temp.Find(id);
            if (employee_Form_Temp == null)
            {
                return HttpNotFound();
            }
            return View(employee_Form_Temp);
        }

        // GET: EmployeeAp/Create
        public ActionResult Create()
        {
            ViewBag.Emp_CityID = new SelectList(db.Emp_City, "Emp_CityID", "Emp_CityName");
            ViewBag.EmpStateID = new SelectList(db.EmpStates, "EmpStateID", "Emp_State");
            ViewBag.PostID = new SelectList(db.PostForms, "PostID", "PostName");
            ViewBag.RefferalID = new SelectList(db.ReferalForms, "RefferalID", "ReferalName");
            return View();
        }

        // POST: EmployeeAp/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Employee_ID,Employee_Name,Emp_DOB,Emp_MobileNumber,Emp_Block,PostID,Emp_Password,Emp_ConfirmPassword,EmpStateID,Emp_CityID,Emp_EmailAddress,Emp_AppID,usercode,RefferalID,ReferlName,u_status")] Employee_Form_Temp employee_Form_Temp)
        {
            if (ModelState.IsValid)
            {
                db.Employee_Form_Temp.Add(employee_Form_Temp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Emp_CityID = new SelectList(db.Emp_City, "Emp_CityID", "Emp_CityName", employee_Form_Temp.Emp_CityID);
            ViewBag.EmpStateID = new SelectList(db.EmpStates, "EmpStateID", "Emp_State", employee_Form_Temp.EmpStateID);
            ViewBag.PostID = new SelectList(db.PostForms, "PostID", "PostName", employee_Form_Temp.PostID);
            ViewBag.RefferalID = new SelectList(db.ReferalForms, "RefferalID", "ReferalName", employee_Form_Temp.RefferalID);
            return View(employee_Form_Temp);
        }

        // GET: EmployeeAp/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_Form_Temp employee_Form_Temp = db.Employee_Form_Temp.Find(id);
            if (employee_Form_Temp == null)
            {
                return HttpNotFound();
            }
            ViewBag.Emp_CityID = new SelectList(db.Emp_City, "Emp_CityID", "Emp_CityName", employee_Form_Temp.Emp_CityID);
            ViewBag.EmpStateID = new SelectList(db.EmpStates, "EmpStateID", "Emp_State", employee_Form_Temp.EmpStateID);
            ViewBag.PostID = new SelectList(db.PostForms, "PostID", "PostName", employee_Form_Temp.PostID);
            ViewBag.RefferalID = new SelectList(db.ReferalForms, "RefferalID", "ReferalName", employee_Form_Temp.RefferalID);
            return View(employee_Form_Temp);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee_Form_Temp employee_Form_Temp)
        {
            if (ModelState.IsValid)
            {
                employee_Form_Temp.Date = employee_Form_Temp.Date;
                db.Entry(employee_Form_Temp).State = EntityState.Modified;                
                db.SaveChanges();
                return RedirectToAction("EmployeeRefer", "Admin");
            }
            ViewBag.Emp_CityID = new SelectList(db.Emp_City, "Emp_CityID", "Emp_CityName", employee_Form_Temp.Emp_CityID);
            ViewBag.EmpStateID = new SelectList(db.EmpStates, "EmpStateID", "Emp_State", employee_Form_Temp.EmpStateID);
            ViewBag.PostID = new SelectList(db.PostForms, "PostID", "PostName", employee_Form_Temp.PostID);
            ViewBag.RefferalID = new SelectList(db.ReferalForms, "RefferalID", "ReferalName", employee_Form_Temp.RefferalID);
            return View(employee_Form_Temp);
        }

        // GET: EmployeeAp/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_Form_Temp employee_Form_Temp = db.Employee_Form_Temp.Find(id);
            if (employee_Form_Temp == null)
            {
                return HttpNotFound();
            }
            return View(employee_Form_Temp);
        }

        // POST: EmployeeAp/Delete/5
        [HttpPost, ActionName("Delete")]
       
        public ActionResult DeleteConfirmed(int id)
        {
            Employee_Form_Temp employee_Form_Temp = db.Employee_Form_Temp.Find(id);
            db.Employee_Form_Temp.Remove(employee_Form_Temp);
            var referid = id.ToString();
            var deletefromrefere = db.ReferalForms.Where(x => x.Employee_ID == referid).FirstOrDefault();
            db.ReferalForms.Remove(deletefromrefere);
            db.SaveChanges();
            return RedirectToAction("EmployeeRefer", "Admin");
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

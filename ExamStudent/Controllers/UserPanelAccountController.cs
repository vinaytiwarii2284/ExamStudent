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
    public class UserPanelAccountController : Controller
    {
        private ExamStudentContext db = new ExamStudentContext();

        // GET: UserPanelAccount
        public ActionResult Index(string searchBy, string search, int? pageNumber)
        {
            
            if (searchBy == "Name")
            {
                var list = db.Tab_User_Info_Temp.ToList();
                var model = db.Tab_User_Info_Temp.Where(x => x.Name == search || search == null).ToList();
                return View(model);
            }
            else
            {
                var list = db.Tab_User_Info_Temp.ToList();
                var model = db.Tab_User_Info_Temp.Where(x => x.EmailAddress == search || search == null).ToList();
                return View(model);
            }

            
        }

        // GET: UserPanelAccount/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tab_User_Info_Temp tab_User_Info_Temp = db.Tab_User_Info_Temp.Find(id);
            if (tab_User_Info_Temp == null)
            {
                return HttpNotFound();
            }
            return View(tab_User_Info_Temp);
        }

        // GET: UserPanelAccount/Create
        public ActionResult Create()
        {
            ViewBag.BoardTypeID = new SelectList(db.BoardTypes, "BoardTypeID", "BoardTypeName");
            ViewBag.CityID = new SelectList(db.Cities, "CityID", "CityName");
            ViewBag.MediumID = new SelectList(db.Mediums, "MediumID", "MediumName");
            ViewBag.StandardID = new SelectList(db.Standards, "StandardID", "StandardName");
            ViewBag.StateID = new SelectList(db.States, "StateID", "StateName");
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ApplicationID,Name,EmailAddress,MobileNumber,DOB,ReferID,Password,IsActive,CreatedDate,ModifiedDate,ConfirmPassword,StateID,CityID,Block,usercode,ReferlName,EmpID,u_status,BoardTypeID,MediumID,StandardID")] Tab_User_Info_Temp tab_User_Info_Temp)
        {
            if (ModelState.IsValid)
            {
                db.Tab_User_Info_Temp.Add(tab_User_Info_Temp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BoardTypeID = new SelectList(db.BoardTypes, "BoardTypeID", "BoardTypeName", tab_User_Info_Temp.BoardTypeID);
            ViewBag.CityID = new SelectList(db.Cities, "CityID", "CityName", tab_User_Info_Temp.CityID);
            ViewBag.MediumID = new SelectList(db.Mediums, "MediumID", "MediumName", tab_User_Info_Temp.MediumID);
            ViewBag.StandardID = new SelectList(db.Standards, "StandardID", "StandardName", tab_User_Info_Temp.StandardID);
            ViewBag.StateID = new SelectList(db.States, "StateID", "StateName", tab_User_Info_Temp.StateID);
            return View(tab_User_Info_Temp);
        }

        // GET: UserPanelAccount/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tab_User_Info_Temp tab_User_Info_Temp = db.Tab_User_Info_Temp.Find(id);
            if (tab_User_Info_Temp == null)
            {
                return HttpNotFound();
            }
            ViewBag.BoardTypeID = new SelectList(db.BoardTypes, "BoardTypeID", "BoardTypeName", tab_User_Info_Temp.BoardTypeID);
            ViewBag.CityID = new SelectList(db.Cities, "CityID", "CityName", tab_User_Info_Temp.CityID);
            ViewBag.MediumID = new SelectList(db.Mediums, "MediumID", "MediumName", tab_User_Info_Temp.MediumID);
            ViewBag.StandardID = new SelectList(db.Standards, "StandardID", "StandardName", tab_User_Info_Temp.StandardID);
            ViewBag.StateID = new SelectList(db.States, "StateID", "StateName", tab_User_Info_Temp.StateID);
            return View(tab_User_Info_Temp);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ApplicationID,Name,EmailAddress,MobileNumber,DOB,ReferID,Password,IsActive,CreatedDate,ModifiedDate,ConfirmPassword,StateID,CityID,Block,usercode,ReferlName,EmpID,u_status,BoardTypeID,MediumID,StandardID")] Tab_User_Info_Temp tab_User_Info_Temp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tab_User_Info_Temp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BoardTypeID = new SelectList(db.BoardTypes, "BoardTypeID", "BoardTypeName", tab_User_Info_Temp.BoardTypeID);
            ViewBag.CityID = new SelectList(db.Cities, "CityID", "CityName", tab_User_Info_Temp.CityID);
            ViewBag.MediumID = new SelectList(db.Mediums, "MediumID", "MediumName", tab_User_Info_Temp.MediumID);
            ViewBag.StandardID = new SelectList(db.Standards, "StandardID", "StandardName", tab_User_Info_Temp.StandardID);
            ViewBag.StateID = new SelectList(db.States, "StateID", "StateName", tab_User_Info_Temp.StateID);
            return View(tab_User_Info_Temp);
        }

        // GET: UserPanelAccount/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tab_User_Info_Temp tab_User_Info_Temp = db.Tab_User_Info_Temp.Find(id);
            if (tab_User_Info_Temp == null)
            {
                return HttpNotFound();
            }
            return View(tab_User_Info_Temp);
        }

        // POST: UserPanelAccount/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tab_User_Info_Temp tab_User_Info_Temp = db.Tab_User_Info_Temp.Find(id);
            db.Tab_User_Info_Temp.Remove(tab_User_Info_Temp);
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

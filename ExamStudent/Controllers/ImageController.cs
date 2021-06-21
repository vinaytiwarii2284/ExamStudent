using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamStudent.Controllers
{
    public class ImageController : Controller
    {
        ExamStudentContext db = new ExamStudentContext();
        // GET: Image
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(HttpPostedFileBase file, Image user)
        {
            //string filename = Path.GetFileName(file.FileName);

            string _filename = Session["Id"].ToString();
            string extension = Path.GetExtension(file.FileName);
            _filename = _filename +   extension;
            string path = Path.Combine(Server.MapPath("~/Imagess/"), _filename);

            user.ImageUpload = "/Imagess/" + _filename;
            user.Employee_ID =Convert.ToInt32(Session["Id"].ToString());
            if (extension.ToLower() == ".jpg" || extension.ToLower() == ".png" || extension.ToLower() == "jpeg")
            {
                if (file.ContentLength <= 1000000)
                {
                    db.Images.Add(user);

                    if (db.SaveChanges() > 0)
                    {
                        file.SaveAs(path);
                        ViewBag.sms = "Data Added is Successfully";
                        ModelState.Clear();
                    }
                }
                else
                {
                    ViewBag.sms = "Size is Not Found ?";
                }
            }

            return RedirectToAction("EmployeeLoggedIn", "UserAccount");
        }


    }
}
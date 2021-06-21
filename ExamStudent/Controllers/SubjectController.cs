using ExamStudent.Models;
using ExamStudent.Services;
using ExamStudent.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamStudent.Controllers
{
    public class SubjectController : Controller
    {
        ExamStudentContext context = new ExamStudentContext();

        SubjectsServices subjectsServices = new SubjectsServices();

        // GET: Subject
        public ActionResult Index()
        {

            return PartialView();
        }



        public ActionResult SubjectTable(string search, int? pageNo)
        {
            SubjectListingViewModel model = new SubjectListingViewModel();

            model.PageNo = pageNo.HasValue ? pageNo.Value > 0 ? pageNo.Value : 1 : 1;

            model.GetSubjects = subjectsServices.GetSubject(model.PageNo);

            if (string.IsNullOrEmpty(search) == false)
            {
                model.GetSubjects = context.Subjects.Where(x => x.SubjectName != null && x.SubjectName.ToLower().Contains(search.ToLower())).ToList();
            }

            return PartialView(model);
        }

        public ActionResult createSubject()
        {
            ExamStudentContext context = new ExamStudentContext();

            SubjectViewModel subjectViewModel = new SubjectViewModel();

            var boardTypeList = context.BoardTypes.OrderBy(x => x.BoardTypeID).ToList();
            subjectViewModel.BoardTypeList = boardTypeList;

            var mediumList = context.Mediums.OrderBy(x => x.MediumID).ToList();
            subjectViewModel.MediumList = mediumList;

            var standardList = context.Standards.OrderBy(x => x.StandardID).ToList();
            subjectViewModel.StandardList = standardList;

            return View(subjectViewModel);
        }
       

        //For Cascading DropDown List...
        [HttpPost]
        public ActionResult GetMediums(int BoardTypeId)
        {
            var items = context.Mediums
                          .Where(x => x.BoardTypeID == BoardTypeId)
                          .Select(x => new SelectListItem
                          {
                              Value = x.MediumID.ToString(),
                              Text = x.MediumName
                          })
                          .ToList();
            return Json(items, JsonRequestBehavior.AllowGet);
        }


        //For Cascading DropDown List...
        [HttpPost]
        public ActionResult GetStandard(int MediumId)
        {
            var items = context.Standards
                          .Where(x => x.MediumID == MediumId)
                          .Select(x => new SelectListItem
                          {
                              Value = x.StandardID.ToString(),
                              Text = x.StandardName
                          })
                          .ToList();
            return Json(items, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public ActionResult createSubject(HttpPostedFileBase CoverFile, HttpPostedFileBase MainFile,SubjectViewModel model)
        {
            ExamStudentContext context = new ExamStudentContext();
            Subject subject = new Subject();
            if (CoverFile != null)
            {
                string fname;
                string uniuquename;
                // Checking for Internet Explorer  
                if (Request.Browser.Browser.ToUpper() == "IE" || Request.Browser.Browser.ToUpper() == "INTERNETEXPLORER")
                {
                    string[] testfiles = CoverFile.FileName.Split(new char[] { '\\' });
                    fname = testfiles[testfiles.Length - 1];
                    // uniuquename = Gernel.GetRandomString(14);
                }
                else
                {
                    fname = CoverFile.FileName;
                    //  uniuquename = Gernel.GetRandomString(14);
                }
                fname = fname.Replace(" ", "-");
                var Name = fname;

                // Get the complete folder path and store the file inside it.
                string pathcheck = Server.MapPath("~/CoverDoc/");
                if (!System.IO.Directory.Exists(pathcheck))
                {
                    Directory.CreateDirectory(pathcheck);
                }
                var path = Path.Combine(pathcheck, Name);
                CoverFile.SaveAs(path);
                subject.CoverFilename = Name;
                subject.CoverFilePath = path;
            }

            if (MainFile != null)
            {
                string fname;
                string uniuquename;
                // Checking for Internet Explorer  
                if (Request.Browser.Browser.ToUpper() == "IE" || Request.Browser.Browser.ToUpper() == "INTERNETEXPLORER")
                {
                    string[] testfiles = MainFile.FileName.Split(new char[] { '\\' });
                    fname = testfiles[testfiles.Length - 1];
                    // uniuquename = Gernel.GetRandomString(14);
                }
                else
                {
                    fname = MainFile.FileName;
                    //  uniuquename = Gernel.GetRandomString(14);
                }
                fname = fname.Replace(" ", "-");
                var Name = fname;
                // Get the complete folder path and store the file inside it.
                string pathcheck = Server.MapPath("~/MainDoc/");
                if (!System.IO.Directory.Exists(pathcheck))
                {
                    Directory.CreateDirectory(pathcheck);
                }
                var path = Path.Combine(pathcheck, Name);
                MainFile.SaveAs(path);
                subject.FileName = Name;
                subject.FilePath = path;
            }

          

            
            subject.SubjectName = model.SubjectName;
            subject.BoardTypeID = model.BoardTypeID;
            subject.MediumID = model.MediumID;
            subject.StandardID = model.StandardID;
            subject.subjectDescription = model.subjectDescription;
            subject.subjectPrice = model.subjectPrice;
            subject.subjectDiscount = model.subjectDiscount;
            subject.subjectTotalHour = model.subjectTotalHour;
            //subject.ImageURL = model.ImageURL;

            //subject.PDFFile = model.PDFFile.FileName;
            subject.VideoURL = model.VideoURL;
            subject.Comment = model.Comment;

            context.Subjects.Add(subject);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var subject = context.Subjects.Where(x => x.SubjectID == id).FirstOrDefault();

            SubjectViewModel model = new SubjectViewModel();
            model.SubjectID = subject.SubjectID;
            model.SubjectName = subject.SubjectName;
            model.subjectDescription = subject.subjectDescription;
            model.subjectPrice = Convert.ToInt32(subject.subjectPrice);
            model.subjectDiscount = subject.subjectDiscount;
            model.subjectTotalHour = subject.subjectTotalHour;
            model.BoardTypeID = subject.BoardTypeID;
            model.MediumID = subject.MediumID;
            model.StandardID = subject.StandardID;
            model.ImageURL = subject.ImageURL;

            var boardTypeList = context.BoardTypes.OrderBy(x => x.BoardTypeID).ToList();
            model.BoardTypeList = boardTypeList;

            var mediumList = context.Mediums.OrderBy(x => x.MediumID).ToList();
            model.MediumList = mediumList;

            var standardList = context.Standards.OrderBy(x => x.StandardID).ToList();
            model.StandardList = standardList;

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(HttpPostedFileBase CoverFile, HttpPostedFileBase MainFile, SubjectViewModel model)
        {

            using (var context = new ExamStudentContext())
            {
                var update = context.Subjects.Where(x => x.SubjectID == model.SubjectID).FirstOrDefault();

                if (ModelState.IsValid)
                {
                    
                    Subject subject = new Subject();

                    if (CoverFile != null)
                    {
                        string fname;
                        string uniuquename;
                        // Checking for Internet Explorer  
                        if (Request.Browser.Browser.ToUpper() == "IE" || Request.Browser.Browser.ToUpper() == "INTERNETEXPLORER")
                        {
                            string[] testfiles = CoverFile.FileName.Split(new char[] { '\\' });
                            fname = testfiles[testfiles.Length - 1];
                            // uniuquename = Gernel.GetRandomString(14);
                        }
                        else
                        {
                            fname = CoverFile.FileName;
                            //  uniuquename = Gernel.GetRandomString(14);
                        }
                        fname = fname.Replace(" ", "-");
                        var Name = fname;

                        // Get the complete folder path and store the file inside it.
                        string pathcheck = Server.MapPath("~/CoverDoc/");
                        if (!System.IO.Directory.Exists(pathcheck))
                        {
                            Directory.CreateDirectory(pathcheck);
                        }
                        var path = Path.Combine(pathcheck, Name);
                        CoverFile.SaveAs(path);
                        update.CoverFilename = Name;
                        update.CoverFilePath = path;
                    }

                    if (MainFile != null)
                    {
                        string fname;
                        string uniuquename;
                        // Checking for Internet Explorer  
                        if (Request.Browser.Browser.ToUpper() == "IE" || Request.Browser.Browser.ToUpper() == "INTERNETEXPLORER")
                        {
                            string[] testfiles = MainFile.FileName.Split(new char[] { '\\' });
                            fname = testfiles[testfiles.Length - 1];
                            // uniuquename = Gernel.GetRandomString(14);
                        }
                        else
                        {
                            fname = MainFile.FileName;
                            //  uniuquename = Gernel.GetRandomString(14);
                        }
                        fname = fname.Replace(" ", "-");
                        var Name = fname;
                        // Get the complete folder path and store the file inside it.
                        string pathcheck = Server.MapPath("~/MainDoc/");
                        if (!System.IO.Directory.Exists(pathcheck))
                        {
                            Directory.CreateDirectory(pathcheck);
                        }
                        var path = Path.Combine(pathcheck, Name);
                        MainFile.SaveAs(path);
                        update.FileName = Name;
                        update.FilePath = path;
                    }


                    update.SubjectName = model.SubjectName;
                    update.BoardTypeID = model.BoardTypeID;
                    update.MediumID = model.MediumID;
                    update.StandardID = model.StandardID;

                    update.subjectDescription = model.subjectDescription;
                    update.subjectPrice = model.subjectPrice;
                    update.subjectDiscount = model.subjectDiscount;
                    update.subjectTotalHour = model.subjectTotalHour;
                    //subject.ImageURL = model.ImageURL;

                    context.SaveChanges();

                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }


        }

        public ActionResult Delete(int id)
        {
            using (var context = new ExamStudentContext())
            {
                // Teacher teacher = context.Teachers.Where(x => x.SubjectID == id).FirstOrDefault();

                Subject subject = context.Subjects.Where(x => x.SubjectID == id).FirstOrDefault();

                //context.Teachers.Remove(teacher);
                //context.SaveChanges();

                context.Subjects.Remove(subject);
                context.SaveChanges();

            }

            return RedirectToAction("Index");
        }

    }
}
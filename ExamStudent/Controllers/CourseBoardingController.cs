using ExamStudent.Models;
using ExamStudent.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamStudent.Controllers
{
    public class CourseBoardingController : Controller
    {

        ExamStudentContext context = new ExamStudentContext();

        // GET: CourseBoarding
        public ActionResult Index()
        {
            var list = context.BoardTypes.ToList();

            return View(list);
        }


        public ActionResult Control()
        {
            return View();
        }

        public ActionResult BoardType()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BoardType(BoardType boardType)
        {
            context.BoardTypes.Add(boardType);

            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult GetBoardTypeID(int id)
        {
            var getData = context.BoardTypes.Find(id);

            return View(getData);
        }

        [HttpPost]
        public ActionResult GetBoardTypeID(BoardType boardType)
        {
            context.Entry(boardType).State = System.Data.Entity.EntityState.Modified;

            context.SaveChanges();

            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            var getData = context.BoardTypes.Find(id);

            context.BoardTypes.Remove(getData);

            context.SaveChanges();

            return RedirectToAction("Index");
        }

       

        public ActionResult MediumList()
        {
            var list = context.Mediums.ToList();

            return PartialView(list);
        }

        public ActionResult Medium()
        {
            MediumViewModels mediaum = new MediumViewModels();
            var boardTypeList = context.BoardTypes.OrderByDescending(c => c.BoardTypeID).ToList();
            mediaum.BoardTypeList = boardTypeList;
            return View(mediaum);
        }

        [HttpPost]
        public ActionResult Medium(MediumViewModels model)
        {
            var mediumObj = (context.Mediums.Where(x => x.BoardTypeID == model.BoardTypeID && x.MediumName == model.MediumName)).FirstOrDefault();
            if (mediumObj == null)
            {
                Medium medium1 = new Medium();
                medium1.MediumID = model.MediumID;
                medium1.BoardTypeID = model.BoardTypeID;
               // medium1.BoardTypeList = (List<BoardTypeModel>())model.BoardTypeList;
                medium1.MediumName = model.MediumName;


                context.Mediums.Add(medium1);
                context.SaveChanges();
            }
            else
            {
                ViewBag.errormsg = "Medium already exists!";

                //Display error for already exists!
                var boardTypeList = context.BoardTypes.OrderByDescending(c => c.BoardTypeID).ToList();
                model.BoardTypeList = boardTypeList;
                return View(model);
            }
            return RedirectToAction("MediumList");
        }


        public ActionResult Edit(int id)
        {
            var data = context.Mediums.Find(id);

            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(Medium medium)
        {
            context.Entry(medium).State = System.Data.Entity.EntityState.Modified;

            context.SaveChanges();

            return RedirectToAction("MediumList");
        }

        public ActionResult DeleteMedium(int id)
        {
            var getData = context.Mediums.Find(id);

            context.Mediums.Remove(getData);

            context.SaveChanges();

            return RedirectToAction("MediumList");
        }

        public ActionResult StandardList()
        {
            var list = context.Standards.ToList();

            return PartialView(list);
        }

        public ActionResult Standard()
        {
            StandardViewModel standard = new StandardViewModel();

            var mediumList = context.Mediums.OrderByDescending(c => c.MediumID).ToList();

            standard.MediumList = mediumList;

            return View(standard);
        }

        [HttpPost]
        public ActionResult Standard(StandardViewModel model)
        {

            var standardObj = (context.Standards.Where(x => x.MediumID == model.MediumID && x.StandardName == model.StandardName)).FirstOrDefault();
            if (standardObj == null)
            {
                Standard standard = new Standard();
                standard.StandardID = model.StandardID;
                standard.MediumID = model.MediumID;
                standard.StandardName = model.StandardName;
                ///standard.MediumList = model.MediumList;

                context.Standards.Add(standard);
                context.SaveChanges();
            }
            else
            {
                ViewBag.errormsg = "Standard already exists!";

                //Display error for already exists! 
                var mediumList = context.Mediums.OrderByDescending(c => c.MediumID).ToList();
                model.MediumList = mediumList;
                return View(model);
            }

            return RedirectToAction("StandardList");
        }

        public ActionResult GetStandardByID(int id)
        {
            var data = context.Standards.Find(id);

            return View(data);
        }

        [HttpPost]
        public ActionResult GetStandardByID(Standard standard)
        {
            context.Entry(standard).State = System.Data.Entity.EntityState.Modified;

            context.SaveChanges();

            return RedirectToAction("StandardList");
        }

        public ActionResult DeleteStandard(int id)
        {
            var getData = context.Standards.Find(id);

            context.Standards.Remove(getData);

            context.SaveChanges();

            return RedirectToAction("StandardList");
        }
    }
}
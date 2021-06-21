using ExamStudent.Models;
using ExamStudent.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamStudent.Controllers
{
    public class QuizController : Controller
    {
        ExamStudentContext context = new ExamStudentContext();

        // GET: Quiz
        public ActionResult ScheduleIndex()
        {
            var scheduleExam = context.ScheduleExams.ToList();

            return View(scheduleExam);
        }

       
        public ActionResult ScheduleEdit(int id)
        {
            var schedule = context.ScheduleExams.Where(x => x.ExamScheduleID == id).FirstOrDefault();

            ScheduleVM model = new ScheduleVM();
            model.ScheduleDateTime = schedule.ScheduleDateTime;
            model.BoardTypeID = Convert.ToInt32(schedule.BoardTypeID);
            model.MediumID = schedule.MediumID;
            model.StandardID = schedule.StandardID;

            var boardTypeList = context.BoardTypes.OrderBy(x => x.BoardTypeID).ToList();
            model.BoardTypeList = boardTypeList;

            var mediumList = context.Mediums.OrderBy(x => x.MediumID).ToList();
            model.MediumList = mediumList;

            var standardList = context.Standards.OrderBy(x => x.StandardID).ToList();
            model.StandardList = standardList;
          
            return View(model);
        }

        [HttpPost]
        public ActionResult GetMediumsss(int BoardTypeId)
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
        public ActionResult GetStandarddd(int MediumId)
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
        public ActionResult ScheduleEdit(ScheduleVM model)
        {

            using (var context = new ExamStudentContext())
            {                          
                if (ModelState.IsValid)
                {
                    var exsmSchedule = context.ScheduleExams.Where(s => s.ExamScheduleID == model.ExamScheduleID).FirstOrDefault();

                    

                    exsmSchedule.BoardTypeID = model.BoardTypeID;
                    exsmSchedule.MediumID = Convert.ToInt32(model.MediumID);
                    exsmSchedule.StandardID = Convert.ToInt32(model.StandardID);
                    exsmSchedule.ScheduleDateTime = model.ScheduleDateTime;
                    context.SaveChanges();
                }
            }

            TempData["Message"] = "Schedule Exam DateTime UpDated is SuccessFuly...";

                return RedirectToAction("ScheduleIndex");

        }
    }
}
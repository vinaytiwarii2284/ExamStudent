using ExamStudent.Models;
using ExamStudent.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamStudent.Controllers
{
    public class TeacherController : Controller
    {
        ExamStudentContext context = new ExamStudentContext();

        // GET: Teacher
        public ActionResult Index()
        {
            TeacherListing model = new TeacherListing();

            model.TeachersList = context.Teachers.ToList();

            return View(model);
        }

        public ActionResult create()
        {
            ExamStudentContext context = new ExamStudentContext();

            TeacherViewModel teacherViewModel = new TeacherViewModel();

            var boardTypeList = context.BoardTypes.OrderBy(x => x.BoardTypeID).ToList();
            teacherViewModel.BoardTypeList = boardTypeList;

            var mediumList = context.Mediums.OrderBy(x => x.MediumID).ToList();
            teacherViewModel.MediumList = mediumList;

            var subjectList = context.Subjects.OrderBy(x => x.SubjectID).ToList();
            teacherViewModel.SubjectList = subjectList;

            return View(teacherViewModel);
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
            var items = context.Subjects
                          .Where(x => x.MediumID == MediumId)
                          .Select(x => new SelectListItem
                          {
                              Value = x.SubjectID.ToString(),
                              Text = x.SubjectName
                          })
                          .ToList();
            return Json(items, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public ActionResult create(TeacherViewModel model)
        {
            ExamStudentContext context = new ExamStudentContext();

            Teacher teacher = new Teacher();
            teacher.TeacherName = model.TeacherName;
            teacher.BoardTypeID = model.BoardTypeID;
            teacher.MediumID = model.MediumID;
            teacher.SubjectID = model.SubjectID;
          
            context.Teachers.Add(teacher);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            ExamStudentContext context = new ExamStudentContext();

            var getteacher =   context.Teachers.Find(id);

            return View(getteacher);
        }

        public ActionResult Delete(int ID)
        {
            using (var context = new ExamStudentContext())
            {
                Teacher teacher = context.Teachers.Where(x => x.TeacherId == ID).FirstOrDefault();

                context.Teachers.Remove(teacher);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
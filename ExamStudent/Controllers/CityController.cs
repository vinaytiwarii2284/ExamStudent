using ExamStudent.Models;
using ExamStudent.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamStudent.Controllers
{
    public class CityController : Controller
    {
        ExamStudentContext context = new ExamStudentContext();

        // GET: City
        public ActionResult Index()
        {
            var list = context.Cities.ToList();

            return View(list);

           
        }

        public ActionResult Create()
        {
            ExamStudentContext context = new ExamStudentContext();



            CityViewModel cityViewModel = new CityViewModel();

            cityViewModel.StatesSelectListItems = (from objCat in context.States
                                                        select new SelectListItem()
                                                        {
                                                            Text = objCat.StateName,
                                                            Value = objCat.StateID.ToString(),
                                                            Selected = true
                                                        });
            return View(cityViewModel);         
        }

        [HttpPost]
        public JsonResult Create(CityViewModel model)
        {
            ExamStudentContext context = new ExamStudentContext();
           
                var city = new City();
                city.CityID = model.CityID;
                city.StateID = model.StateID;
                city.CityName = model.CityName;
                context.Cities.Add(city);
                context.SaveChanges();

            return Json(new { Success = true, Message = "Item is Added Successfully." }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Delete(int id)
        {
            var getData = context.Cities.Find(id);

            context.Cities.Remove(getData);

            context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
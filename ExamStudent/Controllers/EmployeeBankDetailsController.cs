using ExamStudent.Models;
using ExamStudent.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamStudent.Controllers
{
    public class EmployeeBankDetailsController : Controller
    {
        ExamStudentContext context = new ExamStudentContext();
        // GET: EmployeeBankDetails
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BankDetails()
        {
            ExamStudentContext context = new ExamStudentContext();

            var empid = Convert.ToInt32(Session["Id"]);
            var postId = Convert.ToInt32(Session["PostId"]);
                       
            var list = context.EmpBankDetails.Where(x => (x.EmpBankDetailsID) == empid);


            

            List<EmpBankDetail> bankDetails = context.EmpBankDetails.Where(x => x.Employee_ID == empid).ToList();
            ViewData["list"] = bankDetails;

            return View();
        }

        [HttpPost]
        public ActionResult BankDetails(EmpBankDetail emp)
        {
            try
            {     
                emp.Employee_ID = Convert.ToInt32(Session["Id"]);
                context.EmpBankDetails.Add(emp);
                context.SaveChanges();
             
                return RedirectToAction("BankDetails");
            }
            catch (Exception)
            {

                throw;
            }

        }

        public ActionResult StudentBankDetailsEdit(int id)
        {
            var details = context.EmpBankDetails.Find(id);

            return View(details);
        }

        [HttpPost]
        public ActionResult StudentBankDetailsEdit(EmpBankDetail bankDetail)
        {
            context.Entry(bankDetail).State = EntityState.Modified;
            bankDetail.Employee_ID = Convert.ToInt32(Session["Id"]);
            context.SaveChanges();
            return RedirectToAction("BankDetails");
        }
    }
}
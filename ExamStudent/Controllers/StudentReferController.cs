using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamStudent.Controllers
{
    public class StudentReferController : Controller
    {
        // GET: StudentRefer
        public ActionResult Index()
        {

            int userId = Convert.ToInt32(Session["Id"]);

            ExamStudentContext context = new ExamStudentContext();

            var list = context.Refers.Where( x => Convert.ToInt32(x.RefferLid) == userId).Select(x => Convert.ToInt32(x.UserID)).ToList();


            var users = context.Tab_User_Info_Temp.Where(x => list.Contains( x.Id ));


            return View(list);
        }
    }
}
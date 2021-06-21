using ExamStudent.Models;
using ExamStudent.Services;
using ExamStudent.ViewModel;
using ExamStudent.ViewModel.Models;
using ExamStudent.ViewModels;
using ExamStudents.Business;
using ExamStudents.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ExamStudent.Controllers
{
    public class AdminController : Controller
    {
        ExamStudentContext context = new ExamStudentContext();

        SubjectsServices subjectsServices = new SubjectsServices();

        // GET: Admin
        public ActionResult Index()
        {         
           var adminlist = context.Admins.ToList();
            return View(adminlist);
        }

        public ActionResult IsPaidStudent()
        {
            
            var studentList = context.Tab_User_Info_Temp.Where(x=>x.IsPaid==true).ToList();
           
            return View(studentList);
           
        }

        public ActionResult IsPaidEmployee()
        {
            var empList = context.Employee_Form_Temp.Where(x => x.IsPaid == true).ToList();
            return View(empList);
        }

        public ActionResult EmployeeRefer()
        {

            if (Session["AdminID"] == null)
            {
                return RedirectToAction("Login");
            }

            //EmployeeSearchViewModel model = new EmployeeSearchViewModel();

           var employeesList = context.Employee_Form_Temp.ToList();

            return View(employeesList);

        }

        [HttpGet]
        public ActionResult UserStatus(int checkid, bool status)
        {
            var User_status = context.Employee_Form_Temp.Where(x => x.Employee_ID == checkid).FirstOrDefault();
            if (User_status != null)
            {
                User_status.IsApproved = status;
                context.SaveChanges();
            }

            return RedirectToAction("EmployeeRefer", "Admin");
        }

        [HttpGet]
        public ActionResult UserStatuStudent(int checkid, bool status)
        {
            var User_status = context.Tab_User_Info_Temp.Where(x => x.Id == checkid).FirstOrDefault();
            if (User_status != null)
            {
                User_status.IsApproved = status;
                context.SaveChanges();
            }

            return RedirectToAction("EmployeeRefer", "Admin");
        }

        public ActionResult EmpList(string startdate, string enddate)
        {
            if (Session["AdminID"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            EmployeeViewModel model = new EmployeeViewModel();
            List<EmployeeViewModel> employeeViewModels = new List<EmployeeViewModel>();

            var emplist = context.Employee_Form_Temp.ToList();

            foreach (var emp in emplist)
            {
                var comm = context.AdminEmployeeReferSettings.FirstOrDefault();
                var refers = context.ReferalForms.Where(x => x.RefferLid == emp.Employee_ID.ToString());

                DateTime stdate = Convert.ToDateTime(startdate);

                DateTime endate = Convert.ToDateTime(enddate);

                var grouped = context.ReferalForms.Where(x => x.RefferLid == emp.Employee_ID.ToString() && x.Date >= stdate && x.Date <= endate);

                ViewBag.counter1 = grouped.Count();

                var comission = 0;
                if (refers == null)
                {
                    comission = refers.Count() * Convert.ToInt32(comm.ReferComision);
                }

                employeeViewModels.Add(new EmployeeViewModel
                {
                    Employee_Name = emp.Employee_Name,
                    Emp_DOB = emp.Emp_DOB,
                    Emp_MobileNumber = emp.Emp_MobileNumber,
                    Emp_Block = emp.Emp_Block,
                    PostID = emp.PostID,
                    Emp_Password = emp.Emp_Password,
                    Emp_ConfirmPassword = emp.Emp_ConfirmPassword,
                    EmpStateID = emp.EmpStateID,
                    Emp_CityID = emp.Emp_CityID,
                    Emp_EmailAddress = emp.Emp_EmailAddress,
                    Emp_AppID = emp.Emp_AppID,
                    usercode = emp.usercode,
                    RefferalID = emp.RefferalID,
                    ReferlName = emp.ReferlName,
                    refers = refers != null ? refers.Count().ToString() : "",
                    comission = comission.ToString(),
                });
            }

            return View(employeeViewModels);
        }

       
        public ActionResult SuccessPay()
        {
            var list = context.TabPayumoneyTransectionLogs.ToList();
            return View(list);
        }


        public ActionResult StudentReferist()
        {
            if (Session["AdminID"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }

            StudentReferViewModel model = new StudentReferViewModel();
            List<StudentReferViewModel> studentReferViewModels = new List<StudentReferViewModel>(); 

            var stdList = context.Tab_User_Info_Temp.ToList();

            foreach (var user in stdList)
            {
                var comm = context.AdminRefers.FirstOrDefault();
                var refers = context.Refers.Where(x => x.RefferLid == user.Id.ToString());
                var comission = 0;
                if (refers != null) 
                { 
                    comission=refers.Count() * Convert.ToInt32(comm.ReferComision);
                }

                studentReferViewModels.Add(new StudentReferViewModel
                {
                    Name = user.Name,
                    EmailAddress = user.EmailAddress,
                    MobileNumber = user.MobileNumber,
                    DOB = user.DOB,
                    ReferID = user.ReferID,
                    BoardTypeID = user.BoardTypeID,
                    MediumID = user.MediumID,
                    StandardID = user.StandardID,
                    Password = user.Password,
                    IsActive = user.IsActive,
                    CreatedDate = user.CreatedDate,
                    ModifiedDate = user.ModifiedDate,
                    ConfirmPassword = user.ConfirmPassword,
                    StateID = user.StateID,
                    CityID = user.CityID,
                    Block = user.Block,
                    EmpID = user.EmpID,
                    usercode = user.usercode,
                    ReferlName = user.ReferlName,
                    refers = refers != null ? refers.Count().ToString() : "",
                    comission = comission.ToString(),

                }) ; 


            }

            return View(studentReferViewModels);
        }

        public ActionResult GetAllStudent()
        {
            if (Session["AdminID"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }

            var stdList = context.Tab_User_Info_Temp.ToList();

            return View(stdList);

        }

        public ActionResult EmpBankList()
        {
            if (Session["AdminID"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            var emplist = context.EmpBankDetails.ToList();

            return View(emplist);
        }


        public ActionResult Login()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            ExamStudentContext context = new ExamStudentContext();

            Admin admin1 = context.Admins.Where(X => X.Name == admin.Name && X.Password == admin.Password).FirstOrDefault();

            if (admin1 != null)
            {
                Session["AdminID"] = admin1.AdminID;
                return RedirectToAction("ControlPanel");
            }
            else
            {
                ViewBag.msg = "Invalid UserName or Password..";
            }
            

            return View();
        }


        public ActionResult LogOut()
        {
            Session.Abandon();
            Session.RemoveAll();

            return RedirectToAction("Login");
        }

        public ActionResult DashBoard()
        {
           

            return View();
        }

        public ActionResult Category(bool isSuccess  = false)
        {
            QuizCategoryViewModel model = new QuizCategoryViewModel();

            var boardTypeList = context.BoardTypes.OrderBy(x => x.BoardTypeID).ToList();
            model.BoardTypeList = boardTypeList;

            var mediumList = context.Mediums.OrderBy(x => x.MediumID).ToList();
            model.MediumList = mediumList;

            var standardList = context.Standards.OrderBy(x => x.StandardID).ToList();
            model.StandardList = standardList;


            ViewBag.IsSuccess = isSuccess;

           // Session["AdminID"] = 1; //we will remove it's soon...

            int adId = Convert.ToInt32(Session["AdminID"].ToString());

            List <Category> li = context.Categories.Where(x => x.AdminID == adId).OrderByDescending(x => x.Category_ID).ToList();

            ViewData["list"] = li;

            return View(model);
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
        public ActionResult Category(QuizCategoryViewModel model)
        {
           

            List<Category> li = context.Categories.OrderByDescending(x => x.Category_ID).ToList();
            ViewData["list"] = li;

            Category c = new Category();
            c.Category_Name = model.Category_Name;
            c.BoardTypeID = model.BoardTypeID;
            c.MediumID = model.MediumID;
            c.StandardID = model.StandardID;

            c.AdminID = Convert.ToInt32(Session["AdminID"].ToString());

            context.Categories.Add(c);
            context.SaveChanges();
            return RedirectToAction("Category", new { isSuccess = true });
        }


        public ActionResult AddQuestion()
        {
            QuizQuestionViewModel model = new QuizQuestionViewModel();

            var boardTypeList = context.BoardTypes.OrderBy(x => x.BoardTypeID).ToList();
            model.BoardTypeList = boardTypeList;

            var mediumList = context.Mediums.OrderBy(x => x.MediumID).ToList();
            model.MediumList = mediumList;

            var standardList = context.Standards.OrderBy(x => x.StandardID).ToList();
            model.StandardList = standardList;


            var categoryList = context.Categories.OrderBy(x => x.Category_ID).ToList();
            model.CategoryList = categoryList;

            //int sid = Convert.ToInt32(Session["AdminID"]);
            //List<Category> li = context.Categories.Where(x => x.AdminID == sid).ToList();
            //ViewBag.list = new SelectList(li, "Category_ID", "Category_Name");

            List<Question> questions = context.Questions.OrderByDescending(x => x.Question_Id).ToList();
            ViewData["Questons"] = questions;

            return View(model);
        }


        [HttpPost]
        public ActionResult GetMediumss(int BoardTypeId)
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
        public ActionResult GetStandardd(int MediumId)
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
        public ActionResult GetCategory(int StandardId)
        {
            var items = context.Categories
                          .Where(x => x.StandardID == StandardId)
                          .Select(x => new SelectListItem
                          {
                              Value = x.Category_ID.ToString(),
                              Text = x.Category_Name
                          })
                          .ToList();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult AddQuestion(QuizQuestionViewModel model)
        {
            //int sid = Convert.ToInt32(Session["AdminID"]);
            //List<Category> li = context.Categories.Where(x => x.AdminID == sid).ToList();
            //ViewBag.list = new SelectList(li, "Category_ID", "Category_Name");

            List<Question> questions = context.Questions.OrderByDescending(x => x.Question_Id).ToList();
            ViewData["Questons"] = questions;


            Question question = new Question();
            question.Question1 = model.Question1;
           
            question.CorrectOptionId = model.CorrectOptionId;

            question.BoardTypeID = model.BoardTypeID;
            question.MediumID = model.MediumID;
            question.StandardID = model.StandardID;
            question.Category_ID = model.Category_ID;

            context.Questions.Add(question);
            context.SaveChanges();

           TempData["Message"] = "Question Added is SuccessFuly...";

            return RedirectToAction("AddQuestion");
        }

        public ActionResult AddAnswer()
        {
            AnswerViewModel usrVwModel = new AnswerViewModel();

            var questionList  = context.Questions.OrderByDescending(c => c.Question1).ToList();
            usrVwModel.QuestionsList = questionList;

            List<Answer> questions = context.Answers.OrderByDescending(x => x.AnswerID).ToList();
            ViewData["Answer"] = questions;

            return View(usrVwModel);
        }

        [HttpPost]
        public ActionResult AddAnswer(AnswerViewModel model)
        {           
            List<Answer> questions = context.Answers.OrderByDescending(x => x.AnswerID).ToList();
            ViewData["Answer"] = questions;

            Answer answer = new Answer();
            answer.AnswerText = model.AnswerText;
            answer.Question_Id = model.Question_Id;

            context.Answers.Add(answer);
            context.SaveChanges();

            return RedirectToAction("AddAnswer"); 
        }


        public ActionResult AddChoice()
        {
            ChoiceViewModel model = new ChoiceViewModel();

            var questionList = context.Questions.OrderByDescending(c => c.Question1).ToList();
            model.QuestionsList = questionList;



            List<Choice> choices = context.Choices.OrderByDescending(x => x.ChoiceID).ToList();
            ViewData["Choices"] = choices;


            return View(model);
        }

        [HttpPost]
        public ActionResult AddChoice(ChoiceViewModel model)
        {
            Choice choice = new Choice();
            choice.ChoiceText = model.ChoiceText;
            choice.Question_Id = model.Question_Id;

            context.Choices.Add(choice);
            context.SaveChanges();

            return RedirectToAction("AddChoice");

            
        }

        public ActionResult ScheduleExam()
        {
            ScheduleExamViewModel model = new ScheduleExamViewModel();

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
        public ActionResult ScheduleExam(ScheduleExamViewModel model)
        {
            ScheduleExam exam = new ScheduleExam();

            exam.ScheduleDateTime = model.ScheduleDateTime;

            exam.BoardTypeID = model.BoardTypeID;
            exam.MediumID = model.MediumID;
            exam.StandardID = model.StandardID;
           

            context.ScheduleExams.Add(exam);
            context.SaveChanges();

            TempData["Message"] = "Schedule Exam DateTime Added is SuccessFuly...";

            return RedirectToAction("ScheduleExam");
        }

        public ActionResult ExamResult()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ExamResult(ExamResult examResult)
        {
            return View();
        }

        public ActionResult ReferListing()
        {
            ExamStudentContext context = new ExamStudentContext();
            var list = context.Refers.ToList();
            return View(list);
        }


        public ActionResult Refer()
        {
            UserBusiness userBis = new UserBusiness();
            UserViewModel userVM = new UserViewModel();
            CountryViewModel countryViewModel = new CountryViewModel();

            countryViewModel = userBis.GetActiveCountries();
            string SelectedValue = "US";
            ViewBag.Countries = new SelectList(countryViewModel.CountryList, "Value", "Text", SelectedValue);

            return View(countryViewModel);
        }

        [HttpPost]
        public ActionResult Refer(CountryViewModel model)
        {            
            ExamStudentContext context = new ExamStudentContext();

            if (ModelState.IsValid)
            {
                Refer refer = new Refer();
                refer.ReferalName = model.ReferName;
                //refer.EmailAddress = model.EmailAddress;
                //refer.ContectNumber = model.CountryCode + model.ContectNumber;
                //refer.VoucherRefer = model.VoucherRefer;
                
                context.Refers.Add(refer);
                context.SaveChanges();

                return RedirectToAction("ReferListing");
            }
            else
            {
                return View();
            }


        }

        public ActionResult GetReferByID(int id)
        {
            ExamStudentContext context = new ExamStudentContext();

            var getRefer = context.Refers.Find(id);


            return View(getRefer);
        }

        [HttpPost]
        public ActionResult GetReferByID(Refer refer)
        {
            ExamStudentContext context = new ExamStudentContext();

            context.Entry(refer).State = System.Data.Entity.EntityState.Modified;

            context.SaveChanges();


            return RedirectToAction("ReferListing");
        }


        public ActionResult ControlPanel()
        {

            if (Session["AdminID"] == null)
            {
                return RedirectToAction("Login");
            }

            DashBoardServices services = new DashBoardServices();
            ExamStudentContext context = new ExamStudentContext();
            AdminDashBoardViewModel model = new AdminDashBoardViewModel();

            model.UserCount = services.GetUserCount();
            model.TotalStudent = services.GetTotalStudents();
           
            return View(model);
        }

        public ActionResult StudentBankDetails()
        {
             var list = context.StudentBankDetails.ToList();

            return View(list);
        }

    }
}
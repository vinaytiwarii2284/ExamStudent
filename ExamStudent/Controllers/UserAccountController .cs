using Digiphoto.iMix.ClaimPortal.Common;
using ExamStudent.Models;
using ExamStudent.Services;
using ExamStudent.ViewModel;
using ExamStudent.ViewModel.Models;
using ExamStudent.ViewModels;
using ExamStudents.Business;
using ExamStudents.DataAccess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Security.Cryptography;
using System.Text;
using System.EnterpriseServices.Internal;
using ExamStudent.Utility;
using System.Web.Helpers;
using System.Net.Mail;
using System.Globalization;

namespace ExamStudent.Controllers
{
    public class UserAccountController : Controller
    {
        ExamStudentContext context = new ExamStudentContext();

        OnlineExamServices services = new OnlineExamServices();

        productsServices productsServices = new productsServices();

        private ExamStudentContext db = new ExamStudentContext();

        public ActionResult Index()
        {

            return View();
        }

        //User Register Form
        public ActionResult Register()
        {
            //Cascading DropDown List...
            ExamStudentContext context = new ExamStudentContext();

            UserViewModels usrVwModel = new UserViewModels();
            if (Session["emailexist"] != null)
            {
                var getmessage = Session["emailexist"].ToString();
                ViewBag.Showmessage = getmessage;

            }
            if (Session["emailexist"] == null)
            {
                ViewBag.Showmessage = "";
            }
             var boardTypeList = context.BoardTypes.OrderBy(c => c.BoardTypeID).ToList();
            usrVwModel.BoardTypeList = boardTypeList;

            var mediumList = context.Mediums.Where(c => c.MediumID == 0).ToList();
            usrVwModel.MediumList = mediumList;

            var standardList = context.Standards.Where(c => c.StandardID == 0).ToList();
            usrVwModel.StandardList = standardList;

            var ReferList = context.Refers.OrderByDescending(c => c.ReferalName).ToList();
            usrVwModel.ReferList = ReferList;

            var stateList = context.States.OrderBy(c => c.StateName).ToList();
            usrVwModel.StatesList = stateList;

            var cityList = context.Cities.Where(c => c.CityName == "no").ToList();
            usrVwModel.CitiesList = cityList;
            ViewBag.FranchiesList = context.Franchies.ToList();


            //var cityList = context.Cities.OrderBy(c => c.CityName).ToList();
            //usrVwModel.CitiesList = cityList;

            var courseList = context.EmpCourses.OrderBy(c => c.Course).ToList();
            usrVwModel.EmpCoursesList = courseList;

            //Employee Form new Added
            var postlist = context.PostForms.OrderBy(p => p.PostName).ToList();
            usrVwModel.PostFormsList = postlist;

            //var referal = context.ReferalForms.OrderBy(r => r.ReferalName).ToList();
            //usrVwModel.ReferalFormsList = referal;

            var empStateList = context.EmpStates.OrderBy(r => r.Emp_State).ToList();
            usrVwModel.EmpStateList = empStateList;


            var empcityList = context.Emp_City.Where(r => r.Emp_CityName == "No").ToList();
            usrVwModel.Emp_CityList = empcityList;

            //new Work
            var subjectlist = context.UserSubjects.Where(s => s.SubjectName == "No").ToList();
            usrVwModel.UserSubjectsList = subjectlist;

            var boardTypeSecond = context.BoardTypeSeconds.OrderBy(s => s.BoardName).ToList();
            usrVwModel.BoardTypeSecondsList = boardTypeSecond;

            var mediumSecond = context.MediumSeconds.Where(x => x.MediumName == "No").ToList();
            usrVwModel.MediumSecondsList = mediumSecond;

            var standardSecond = context.StandardSeconds.Where(x => x.StandardName == "No").ToList();
            usrVwModel.StandardSecondsList = standardSecond;

           
            return View(usrVwModel);
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
            var board = context.BoardTypes.FirstOrDefault(x => x.BoardTypeID == BoardTypeId);
            return Json(new { items, amount = board.Amount });
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
        public ActionResult GetStandardAmount(int StandardId)
        {
            var items = context.Standards
                          .Where(x => x.StandardID == StandardId)
                          .Select(x => new SelectListItem
                          {
                              Value = x.StandardID.ToString(),
                              Text = x.StandardName
                          })
                          .ToList();
            var board = context.Standards.FirstOrDefault(x => x.StandardID == StandardId);
            return Json(new { items, amount = board.Amount });
        }

        //New

        //For Cascading DropDown List...

        [HttpPost]
        public ActionResult GetMediumsSecond(int BoardTypeId)
        {
            var items = context.MediumSeconds
                          .Where(x => x.BoardSecondID == BoardTypeId)
                          .Select(x => new SelectListItem
                          {
                              Value = x.MediumSecondID.ToString(),
                              Text = x.MediumName
                          })
                          .ToList();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        //For Cascading DropDown List...
        [HttpPost]
        public ActionResult GetStandardSecond(int MediumId)
        {
            var items = context.StandardSeconds
                          .Where(x => x.MediumSecondID == MediumId)
                          .Select(x => new SelectListItem
                          {
                              Value = x.StandardSecondID.ToString(),
                              Text = x.StandardName
                          })
                          .ToList();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Get Franchies Amount
        /// </summary>
        public JsonResult FranchiesAmount(string Code)
        {
            var getAmount = context.Franchies.Where(x => x.Code == Code).FirstOrDefault();
            decimal? Amount = getAmount.Amount;
            return Json(Amount, JsonRequestBehavior.AllowGet);
        }
        public class dropdown
        {
            public string Value { get; set; }
            public string Text { get; set; }
            public decimal Amount { get; set; }
        }
        public ActionResult GetSubject(int StandardId)
        {
            var items = context.UserSubjects
                          .Where(x => x.StandardSecondID == StandardId)
                          .Select(x => new dropdown()
                          {
                              Value = x.UserSubjectID.ToString(),
                              Text = x.SubjectName,
                              Amount = x.Amount.Value,
                          })
                          .ToList();
            var board = context.UserSubjects.FirstOrDefault(x => x.UserSubjectID == StandardId);
            return Json(new { items, amount = board.Amount });
        }

        [HttpGet]
        public dynamic GetAmount(int UserSubjectId)
        {
            var items = context.UserSubjects
                          .Where(x => x.UserSubjectID == UserSubjectId)
                          .Select(x => new SelectListItem
                          {
                              Value = x.UserSubjectID.ToString(),
                              Text = x.SubjectName
                          })
                          .ToList();
            var board = context.UserSubjects.FirstOrDefault(x => x.UserSubjectID == UserSubjectId);
            return board != null ? board.Amount : 0;
        }

        public ActionResult GetEmpAmount(int EmployeeAmountId)
        {
            var items = context.EmpCourses
                          .Where(x => x.EmpID == EmployeeAmountId)
                          .Select(x => new SelectListItem
                          {
                              Value = x.EmpID.ToString(),
                              Text = x.Course
                          })
                          .ToList();
            var board = context.EmpCourses.FirstOrDefault(x => x.EmpID == EmployeeAmountId);
            return Json(new { items, amount = board.Amount });
        }
        //New End
        [HttpPost]
        public ActionResult GetState(int StateId)
        {
            var items = context.Cities
                          .Where(x => x.StateID == StateId)
                          .Select(x => new SelectListItem
                          {
                              Value = x.CityID.ToString(),
                              Text = x.CityName
                          })
                          .ToList();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult GetEmpState(int StateId)
        {
            var items = context.Emp_City
                          .Where(x => x.EmpStateID == StateId)
                          .Select(x => new SelectListItem
                          {
                              Value = x.Emp_CityID.ToString(),
                              Text = x.Emp_CityName
                          })
                          .ToList();
            return Json(items, JsonRequestBehavior.AllowGet);
        }


        //User Register Form Post method..
        [HttpPost]
        public ActionResult Register(UserViewModels model, int[] UserSubjectIDs, string CaptchaValue, int id = 0)
        {
            bool cv = false;
            ViewBag.ErrorCaptcha = "1";
          
            UserViewModels usrVwModel = new UserViewModels();

            ViewBag.FranchiesList = context.Franchies.ToList();

            var boardTypeList1 = context.BoardTypes.OrderByDescending(c => c.BoardTypeID).ToList();
            usrVwModel.BoardTypeList = boardTypeList1;

            var mediumList1 = context.Mediums.OrderByDescending(c => c.MediumID).ToList();
            usrVwModel.MediumList = mediumList1;

            var standardList1 = context.Standards.OrderByDescending(c => c.StandardID).ToList();
            usrVwModel.StandardList = standardList1;

            var ReferList1 = context.Refers.OrderByDescending(c => c.ReferalName).ToList();
            usrVwModel.ReferList = ReferList1;

            var stateList = context.States.OrderBy(c => c.StateName).ToList();
            usrVwModel.StatesList = stateList;

            var cityList = context.Cities.OrderBy(c => c.CityName).ToList();
            usrVwModel.CitiesList = cityList;


            var courseList = context.EmpCourses.OrderBy(c => c.Course).ToList();
            usrVwModel.EmpCoursesList = courseList;

            //Employee Form new Added
            var postlist = context.PostForms.OrderBy(p => p.PostName).ToList();
            usrVwModel.PostFormsList = postlist;

            var referal = context.ReferalForms.OrderBy(r => r.ReferalName).ToList();
            usrVwModel.ReferalFormsList = referal;

            var empStateList = context.EmpStates.OrderBy(r => r.Emp_State).ToList();
            usrVwModel.EmpStateList = empStateList;


            var empcityList = context.Emp_City.OrderBy(r => r.Emp_CityName).ToList();
            usrVwModel.Emp_CityList = empcityList;

            var subjectlist = context.UserSubjects.Where(s => s.SubjectName == "No").ToList();
            usrVwModel.UserSubjectsList = subjectlist;

            var boardTypeSecond = context.BoardTypeSeconds.OrderBy(s => s.BoardName).ToList();
            usrVwModel.BoardTypeSecondsList = boardTypeSecond;

            var mediumSecond = context.MediumSeconds.Where(x => x.MediumName == "No").ToList();
            usrVwModel.MediumSecondsList = mediumSecond;

            var standardSecond = context.StandardSeconds.Where(x => x.StandardName == "No").ToList();
            usrVwModel.StandardSecondsList = standardSecond;

            if (ModelState.IsValid)
            {
                var getemail = context.Tab_User_Info_Temp.Where(x => x.EmailAddress == model.EmailAddress).FirstOrDefault();
                if (getemail != null)
                {

                    ViewBag.Showmessage = "Email already exist";
                    return View(usrVwModel);
                }
                if (getemail == null)
                {
                    ViewBag.Showmessage = "";
                    Session["emailexist"] = null;
                }
                if (Session["Captcha"] == null || Session["Captcha"].ToString() != CaptchaValue)
                {
                    if (string.IsNullOrEmpty(CaptchaValue))
                    {
                        ModelState.AddModelError("Captcha", "Captcha is mandatory.");
                    }
                    else
                    {

                        model.Captcha = "";
                        //_captcha.CaptchaValue = "";
                        //  userVM.CaptchaDetails = _captcha;
                        ViewBag.ErrorCaptcha = "0";

                    }
                    //dispay error and generate a new captcha 
                    //    return View(userVM);
                    cv = false;
                }
                else
                {
                    cv = true;
                }
                //end
                if (cv == true)
                {
                    //make viewbag.Message null since it is used to display capcha error message
                    ViewBag.Message = null;
                }

                if (cv == false)
                {
                    ViewBag.ExamStudent = Digiphoto.iMix.ClaimPortal.Common.Resources.en_US.LayoutPartialViewRegisterButtonText;

                    var boardTypeList = context.BoardTypes.OrderByDescending(c => c.BoardTypeID).ToList();
                    model.BoardTypeList = boardTypeList;

                    var mediumList = context.Mediums.OrderByDescending(c => c.MediumID).ToList();
                    model.MediumList = mediumList;

                    var standardList = context.Standards.OrderByDescending(c => c.StandardID).ToList();
                    model.StandardList = standardList;

                    var ReferList = context.Refers.OrderByDescending(c => c.ReferalName).ToList();
                    model.ReferList = ReferList;



                    return View("Register", model);
                    //ModelState.AddModelError("ValidateCaptcha", "Captcha is mandatory");
                }


                if (model.Password == model.ConfirmPassword)
                {
                    var referral = GenerateNumner.Gen();

                    //var valid = context.Tab_User_Info_Temp.FirstOrDefault(x => x.usercode == model.usercode);

                    var valid = context.Employee_Form_Temp.FirstOrDefault(x => x.usercode == model.usercode);

                    string AppID = Guid.NewGuid().ToString();
                    Session["FirstName"] = model.FirstName;
                    Session["PhoneNumber"] = model.MobileNumber;
                    Session["EmailAddress"] = model.EmailAddress;
                    Session["Amount"] = model.Amount;
                    Session["ProductInfo"] = model.ProductInfo;

                    var detail = new Tab_User_Info_Temp();

                    detail.Name = model.FirstName + " " + model.MiddleName + " " + model.LastName;
                    detail.ApplicationID = AppID;
                    detail.EmailAddress = model.EmailAddress;
                    detail.MobileNumber = model.MobileNumber;
                    detail.DOB = model.DOB;
                    detail.ReferID = model.ReferID;
                    detail.Amount = model.Amount;
                    detail.IsPaid = false;
                    detail.BoardTypeID = model.BoardTypeID;
                    detail.MediumID = model.MediumID;
                    detail.StandardID = model.StandardID;
                    detail.Password = model.Password;
                    detail.ConfirmPassword = model.ConfirmPassword;
                    detail.CityID = model.CityID;
                    detail.StateID = model.StateID;
                    //detail.u_status = 0;
                    detail.EmpID = model.EmpID;
                    detail.Block = model.Block;
                    detail.IsActive = true;
                    detail.CreatedDate = DateTime.Now;
                    detail.Date = DateTime.Now;
                    detail.BoardSecondID = model.BoardSecondID;
                    detail.MediumSecondID = model.MediumSecondID;
                    detail.StandardSecondID = model.StandardSecondID;
                    detail.UserSubjectID = model.UserSubjectID;
                    detail.IsApproved = true;

                    detail.usercode = referral;
                    if (valid != null)
                        detail.ReferlName = valid.Employee_Name;

                    context.Tab_User_Info_Temp.Add(detail);
                    context.SaveChanges();

                    //Subject Store in db
                    var usublist = new List<UserSubjectSelection>();
                    if (UserSubjectIDs != null)
                    {
                        foreach (var item in UserSubjectIDs)
                        {
                            var ExistingObj = context.UserSubjects.Where(x => x.UserSubjectID == item).DefaultIfEmpty(null).FirstOrDefault();
                            if (ExistingObj != null)
                            {
                                UserSubjectSelection userselectedSubject = new UserSubjectSelection()
                                {
                                    UserSubjectID = ExistingObj.UserSubjectID,

                                    UserTempId = detail.Id,
                                };
                                usublist.Add(userselectedSubject);
                            }
                        }

                        context.UserSubjectSelections.AddRange(usublist);
                        context.SaveChanges();
                    }


                    if (valid != null)
                    {
                        var reffer = new Refer
                        {
                            usercode = model.usercode,
                            RefferLid = valid.Employee_ID.ToString(),
                            UserID = detail.Id.ToString(),
                            ReferalName = detail.Name
                        };

                        context.Refers.Add(reffer);
                        context.SaveChanges();
                    }


                    @ViewBag.Message = "Thanks for accepting term and condition.";

                    //return Redirect("http://localhost:51985/Demo/Demo/" + AppID);

                    // return RedirectToAction("Pay","Demo");
                    if (Session["Amount"] != null)
                    {

                        // return RedirectToAction("Pay/" + AppID);
                        return RedirectToAction("Index", "Bill", new { id = AppID });
                    }
                    else
                    {
                        return RedirectToAction("Thanku");
                    }
                }
                else
                {
                    Session["username"] = "Password and Confirm Password Does't match ";
                }
            }

            return View(usrVwModel);
        }

        public ActionResult Thanku()
        {
            return View();
        }

        public ActionResult Emp(UserViewModels model)
        {
            
            var referral = GenerateNumner.Gen();

            var valid = context.Employee_Form_Temp.FirstOrDefault(x => x.usercode == model.usercode);
          
            //Email Is Already Exist
            var IsExist = IsEmailExist(model.Emp_EmailAddress);
            if (IsExist==true)
            {
                Session["emailexist"] = "Email Already exist";
                // Mo,delState.AddModelError("EmailExist", "Email already exist");
                return RedirectToAction("Register", "UserAccount");
            }
            if (IsExist == false)
            {
                Session["emailexist"] = null;
            }


            string AppID = Guid.NewGuid().ToString();
            Session["FirstName"] = model.Employee_Name;
            Session["PhoneNumber"] = model.Emp_MobileNumber;
            Session["EmailAddress"] = model.Emp_EmailAddress;
            Session["Amount"] = model.EmpAmount;
            Session["FranchiesCode"] = model.FranchiesCode;//new work
            Session["ProductInfo"] = "0";


            Employee_Form_Temp employee = new Employee_Form_Temp();
            employee.Emp_AppID = AppID;
            employee.Employee_Name = model.Employee_Name;
            employee.Emp_DOB = model.Emp_DOB;
            employee.Emp_MobileNumber = model.Emp_MobileNumber;
            employee.Emp_EmailAddress = model.Emp_EmailAddress;
            employee.IsPaid = false;
            employee.Amount = model.Amount;
            employee.Emp_Block = model.Emp_Block;
            employee.EmpStateID = model.EmpStateID;
            employee.Emp_CityID = model.Emp_CityID;
            //employee.RefferalID = model.RefferalID;

            employee.PostID = model.PostID;
            employee.Emp_Password = model.Emp_Password;
            employee.Emp_ConfirmPassword = model.Emp_ConfirmPassword;
            employee.Date = DateTime.Now;
            employee.usercode = referral;
            employee.CreatedDate = DateTime.Now;
            employee.isFeatured = model.isFeatured;
            employee.FranchiesCode = model.FranchiesCode;
            employee.IsApproved = true;

            //employee.u_status = 0;

            if (valid != null)
                employee.ReferlName = valid.Employee_Name;

            if (employee.EmpStateID != 0 && employee.Emp_CityID != 0)
            {
                context.Employee_Form_Temp.Add(employee);
                context.SaveChanges();

               
            }
            else
            {
            }

            if (valid != null)
            {
                //employee.usercode = referral;
                var refer = new ReferalForm
                {
                    usercode = model.usercode,
                    RefferLid = valid.Employee_ID.ToString(),
                    Employee_ID = employee.Employee_ID.ToString(),
                   
                    ReferalName = employee.Employee_Name,
                    ReferEmpID = employee.Employee_ID,
                    RefereEmpState=employee.EmpStateID,
                    ReferEmpCity=employee.Emp_CityID,
                    Date = DateTime.Now

                };
                context.ReferalForms.Add(refer);
                context.SaveChanges();
            }



            ReferalForm reffer = new ReferalForm();
            reffer.usercode = model.usercode;
            reffer.Employee_ID = Convert.ToInt32(model.Employee_ID).ToString();

            //return RedirectToAction("Pay/" + AppID); //for Payment

            Session["Success"] = "Your Registration Successfully!";

            // return RedirectToAction("Pay/" + AppID); //for Payment
            if (model.EmpAmount == 0)
            {
                return RedirectToAction("Login", "UserAccount");
            }
            else
            {
                return RedirectToAction("Index", "Bill", new { id = AppID });
            }
          
        }

        //Is Email Exist
        [NonAction]
        private bool IsEmailExist(string emp_EmailAddress)
        {
            using (ExamStudentContext context = new ExamStudentContext())
            {
                var user = context.Employee_Form_Temp.Where(x => x.Emp_EmailAddress == emp_EmailAddress).FirstOrDefault();
                if (user!=null){
                    return true;
                }
                else
                {
                    return false;
                }
               
            }
        }


       

        public ActionResult Pay(string id = null)
        {
            try
            {
                string firstName = Session["FirstName"].ToString();
                string amount = Session["Amount"] != null ? Session["Amount"].ToString() : string.Empty;
                string productInfo = Session["productInfo"].ToString();
                string email = Session["EmailAddress"].ToString();
                string phone = Session["PhoneNumber"].ToString();
                //string surl = "http://localhost:51988/Return/Return";  
                //string furl = "http://localhost:51988/Return/Return";  

                string surl = "http://edualphabet.com/Return/Return";  //Change the success url here depending upon the port number of your local system.
                string furl = "http://edualphabet.com/Return/Return";  //Change the failure url here depending upon the port number of your local system.

                //Add Pay Functionality..
                Session["AppId"] = id;
                TabPayumoneyTransectionLog obj = new TabPayumoneyTransectionLog();



                RemotePost myremotepost = new RemotePost();
                //Add your MarchantID;  
                string key = "0K1KWLkn";
                //Add your SaltID;  
                string salt = "Rga2Dm3Q6g";

                string udf1 = id;

                //posting all the parameters required for integration.  

                myremotepost.Url = "https://secure.payu.in/_payment";
                myremotepost.Add("key", "0K1KWLkn");
                string txnid = Generatetxnid();
                myremotepost.Add("txnid", txnid);
                myremotepost.Add("amount", amount);
                myremotepost.Add("productinfo", productInfo);
                myremotepost.Add("firstname", firstName);
                myremotepost.Add("phone", phone);
                myremotepost.Add("email", email);
                //myremotepost.Add("surl", "http://localhost:51989/Return/Return");//Change the success url here depending upon the port number of your local system.  
                //myremotepost.Add("furl", "http://localhost:51989/Return/Return");//Change the failure url here depending upon the port number of your local system.  

                myremotepost.Add("surl", "http://edualphabet.com/Return/Return");
                myremotepost.Add("furl", "http://edualphabet.com/Return/Return");

                myremotepost.Add("service_provider", "payu_paisa");
                myremotepost.Add("udf1", udf1);
                string hashString = key + "|" + txnid + "|" + amount + "|" + productInfo + "|" + firstName + "|" + email + "|" + udf1 + "||||||||||" + salt;
                string hash = Generatehash512(hashString);
                myremotepost.Add("hash", hash);

                //Add Pay Functionality..
                obj.Amount = !string.IsNullOrEmpty(amount) ? Convert.ToDecimal(amount) : 0;
                obj.FirstName = firstName;
                obj.ApplicationID = id;
                obj.EmailAddress = email;
                obj.PhoneNumber = phone;
                obj.productInfo = productInfo;
                obj.Date = DateTime.Now;
                obj.IsPaid = false;
                obj.TransectionID = txnid;
                context.TabPayumoneyTransectionLogs.Add(obj);
                context.SaveChanges();

                myremotepost.Post();
            }
            catch (Exception exp)
            {
                throw;
            }

            return View();
        }

        private string Generatetxnid()
        {
            Random rnd = new Random();
            string strHash = Generatehash512(rnd.ToString() + DateTime.Now);
            string txnid1 = strHash.ToString().Substring(0, 20);

            return txnid1;
        }

        private string Generatehash512(string text)
        {
            byte[] message = Encoding.UTF8.GetBytes(text);

            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] hashValue;
            SHA512Managed hashString = new SHA512Managed();
            string hex = "";
            hashValue = hashString.ComputeHash(message);
            foreach (byte x in hashValue)
            {
                hex += String.Format("{0:x2}", x);
            }
            return hex;
        }
        public class RemotePost
        {
            private System.Collections.Specialized.NameValueCollection Inputs = new System.Collections.Specialized.NameValueCollection();


            public string Url = "";
            public string Method = "post";
            public string FormName = "form1";

            public void Add(string name, string value)
            {
                Inputs.Add(name, value);
            }

            public void Post()
            {
                System.Web.HttpContext.Current.Response.Clear();

                System.Web.HttpContext.Current.Response.Write("<html><head>");

                System.Web.HttpContext.Current.Response.Write(string.Format("</head><body onload=\"document.{0}.submit()\">", FormName));
                System.Web.HttpContext.Current.Response.Write(string.Format("<form name=\"{0}\" method=\"{1}\" action=\"{2}\" >", FormName, Method, Url));
                for (int i = 0; i < Inputs.Keys.Count; i++)
                {
                    System.Web.HttpContext.Current.Response.Write(string.Format("<input name=\"{0}\" type=\"hidden\" value=\"{1}\">", Inputs.Keys[i], Inputs[Inputs.Keys[i]]));
                }
                System.Web.HttpContext.Current.Response.Write("</form>");
                System.Web.HttpContext.Current.Response.Write("</body></html>");

                System.Web.HttpContext.Current.Response.End();
            }
        }

        [HttpPost]
        // public ActionResult ValidateCaptcha()
        public bool ValidateCaptcha()
        {
            var response = Request["g-recaptcha-response"];
            //secret that was generated in key value pair
            //const string secret = "6LfIZiwUAAAAABkqU2KvdWXr5d6sWREGPPXKfVns";
            //const string secret = "6LfIZiwUAAAAAMadJPbXxVZLJg5XoOedvJLpoXG-";

            string secret = ConfigurationManager.AppSettings["CaptchaSecretKey"].ToString();

            //const string secret = "6Le6aywUAAAAAJyBeK82XIX5zz7dMHotD4mKCMh0"; //Staging api key

            var client = new WebClient();
            var reply =
                client.DownloadString(
                    string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}",
                secret, response));

            var captchaResponse = JsonConvert.DeserializeObject<CaptchaResponse>(reply);

            //when response is false check for the error message
            if (captchaResponse.Success.ToString() != "True")
            {
                if (captchaResponse.ErrorCodes.Count <= 0) return true; // View();

                var error = captchaResponse.ErrorCodes[0].ToLower();
                switch (error)
                {
                    case ("missing-input-secret"):
                        ViewBag.Message = "The secret parameter is missing in Captcha.";
                        break;
                    case ("invalid-input-secret"):
                        ViewBag.Message = "The secret parameter is invalid or malformed in Captcha.";
                        break;
                    case ("missing-input-response"):
                        //ViewBag.Message = "The response parameter is missing.";
                        ViewBag.Message = "Captcha is mandatory";
                        break;
                    case ("invalid-input-response"):
                        ViewBag.Message = "The response parameter is invalid or malformed in Captcha.";
                        break;

                    default:
                        ViewBag.Message = "Error occured in Captcha. Please try again";
                        break;
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        public class CaptchaResponse
        {
            //[Required(ErrorMessage = "Please, enter proper Captcha Value")]
            //[Display(Name = "CaptchaErrorMsg", ResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
            [JsonProperty("success")]

            public string Success { get; set; }

            [JsonProperty("error-codes")]
            public List<string> ErrorCodes { get; set; }
        }

        //student Edit
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
                return RedirectToAction("MyAccount");
            }
            ViewBag.BoardTypeID = new SelectList(db.BoardTypes, "BoardTypeID", "BoardTypeName", tab_User_Info_Temp.BoardTypeID);
            ViewBag.CityID = new SelectList(db.Cities, "CityID", "CityName", tab_User_Info_Temp.CityID);
            ViewBag.MediumID = new SelectList(db.Mediums, "MediumID", "MediumName", tab_User_Info_Temp.MediumID);
            ViewBag.StandardID = new SelectList(db.Standards, "StandardID", "StandardName", tab_User_Info_Temp.StandardID);
            ViewBag.StateID = new SelectList(db.States, "StateID", "StateName", tab_User_Info_Temp.StateID);
            return View(tab_User_Info_Temp);
        }


        // GET: EmployeeAp/Edit/5
        public ActionResult EmpEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_Form_Temp employee_Form_Temp = db.Employee_Form_Temp.Find(id);
            if (employee_Form_Temp == null)
            {
                return HttpNotFound();
            }
            ViewBag.Emp_CityID = new SelectList(db.Emp_City, "Emp_CityID", "Emp_CityName", employee_Form_Temp.Emp_CityID);
            ViewBag.EmpStateID = new SelectList(db.EmpStates, "EmpStateID", "Emp_State", employee_Form_Temp.EmpStateID);
            ViewBag.PostID = new SelectList(db.PostForms, "PostID", "PostName", employee_Form_Temp.PostID);
            ViewBag.RefferalID = new SelectList(db.ReferalForms, "RefferalID", "ReferalName", employee_Form_Temp.RefferalID);
            return View(employee_Form_Temp);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmpEdit([Bind(Include = "Employee_ID,Employee_Name,Emp_DOB,Emp_MobileNumber,Emp_Block,PostID,Emp_Password,Emp_ConfirmPassword,EmpStateID,Emp_CityID,Emp_EmailAddress,Emp_AppID,usercode,RefferalID,ReferlName,u_status")] Employee_Form_Temp employee_Form_Temp)
        {
            if (ModelState.IsValid)
            {
                employee_Form_Temp.Date = employee_Form_Temp.Date;
                db.Entry(employee_Form_Temp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("EmployeeAccount");
            }
            ViewBag.Emp_CityID = new SelectList(db.Emp_City, "Emp_CityID", "Emp_CityName", employee_Form_Temp.Emp_CityID);
            ViewBag.EmpStateID = new SelectList(db.EmpStates, "EmpStateID", "Emp_State", employee_Form_Temp.EmpStateID);
            ViewBag.PostID = new SelectList(db.PostForms, "PostID", "PostName", employee_Form_Temp.PostID);
            ViewBag.RefferalID = new SelectList(db.ReferalForms, "RefferalID", "ReferalName", employee_Form_Temp.RefferalID);
            return View(employee_Form_Temp);
        }

        public ActionResult DeleteUser(int id)
        {
            //var deleteUser = model.Users.Where(s => s.UserDetailId == id).FirstOrDefault();

            using (var context = new ExamStudentContext())
            {
                UserDetail deleteuserDtl = context.UserDetails.Where(x => x.UserDetailId == id).FirstOrDefault();
                User deleteuser = context.Users.Where(x => x.UserDetailId == id).FirstOrDefault();

                context.Users.Remove(deleteuser);
                context.SaveChanges();

                context.UserDetails.Remove(deleteuserDtl);
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        // GET: AdminAp/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tab_User_Info_Temp tab_User_Info_Temp = context.Tab_User_Info_Temp.Find(id);
            if (tab_User_Info_Temp == null)
            {
                return HttpNotFound();
            }
            return View(tab_User_Info_Temp);
        }

        public ActionResult EmployeeDetails(int id)
        {
            ExamStudentContext context = new ExamStudentContext();

            var empDetails = context.Employee_Form_Temp.Find(id);

            return View(empDetails);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserViewModel user)
        {
            Tab_User_Info_Temp user1 = context.Tab_User_Info_Temp.Where(x => x.EmailAddress == user.EmailAddress && x.Password == user.Password).FirstOrDefault();

            Employee_Form_Temp employee = context.Employee_Form_Temp.Where(e => e.Emp_EmailAddress == user.EmailAddress && e.Emp_Password == user.Password).FirstOrDefault();


            //if email is worng
            if (user1 == null)
            {
                ViewBag.MSG = "Your Account has not been verify yet....!";
            }
            else
            {
                if (user1.IsApproved == true)
                {
                    if (user1 != null)
                    {
                        Session[SessionConstants.SESSION_USERID] = user1.Id.ToString();
                        Session["Id"] = user1.Id.ToString();
                        Session["UserName"] = user1.Name.ToString();
                        Session["email"] = user1.EmailAddress.ToString();
                        Session["MobileNumber"] = user1.MobileNumber.ToString();
                        //Session["Block"] = user1.Block.ToString();
                        Session["ReferlNumber"] = user1.usercode.ToString();

                        //New working..
                        Session["State"] = user1.State.StateName.ToString();
                        Session["CityName"] = user1.City.CityName.ToString();
                        //Session["BoardType"] = user1.BoardType.BoardTypeName.ToString();
                        //Session["Medium"] = user1.Medium.MediumName.ToString();
                        //Session["standerd"] = user1.Standard.StandardName.ToString();
                        Session["Password"] = user1.Password.ToString();
                        //Session["ReferName"] = user1.ReferlName.ToString();

                        var comm = context.AdminRefers.FirstOrDefault();
                        var refers = context.Refers.Where(x => x.RefferLid == user1.Id.ToString());
                        var comission = 0;
                        if (refers != null)
                        {
                            comission = refers.Count() * Convert.ToInt32(comm.ReferComision);
                        }

                        Session["ReferlCount"] = refers != null ? refers.Count().ToString() : "";

                        Session["comission"] = comission;

                        return RedirectToAction("LoggedIn");

                    }
                }
                //else if (user1.u_status == 1)
                //{
                //    ViewBag.MSG = "Your Account has not been verify yet....!";
                //}
                else
                {
                    ViewBag.MSG = "Your Account Has been Blocked....!";
                }
            }


            if (employee == null)
            {
                ViewBag.MSG = "Your Account has not been verify yet....!";
            }
            else
            {
                if (employee.IsApproved == true)
                {
                    if (employee != null)
                    {
                        Session[SessionConstants.SESSION_USERID] = employee.Employee_ID.ToString();
                        Session["Id"] = employee.Employee_ID.ToString();
                        Session["UserName"] = employee.Employee_Name.ToString();
                        Session["DOB"] = employee.Emp_DOB.ToString();
                        Session["email"] = employee.Emp_EmailAddress.ToString();
                        Session["MobileNumber"] = employee.Emp_MobileNumber.ToString();
                        Session["PostName"] = employee.PostForm.PostName.ToString();
                        Session["Emp_StateName"] = employee.EmpState.Emp_State.ToString();
                        Session["Emp_CityName"] = employee.Emp_City.Emp_CityName.ToString();
                        //Session["Emp_Block"] = employee.Emp_Block.ToString();
                        Session["ReferlNumber"] = employee.usercode.ToString();
                        Session["PostId"] = employee.PostID.ToString();
                        Session["MenueChecker"] = employee.FranchiesCode;
                       
                        var imgpathh = db.Images.Where(e => e.Employee_ID == employee.Employee_ID).FirstOrDefault();
                        if(imgpathh is null )
                        { }
                        else
                        {

                        Session["ImgPath"] = imgpathh.ImageUpload;
                        }
                        
                        return RedirectToAction("EmployeeLoggedIn");

                    }
                }
                //else if (employee.u_status == 1)
                //{
                //    ViewBag.MSG = "your Account Has not  been verified yet....!";
                //}
                else
                {
                    ViewBag.MSG = "your Account Has been Blocked....!";
                }
            }


            return View();
        }

        /// <summary>
        /// refer by head
        /// </summary>
        /// <param name="startdate"></param>
        /// <param name="enddate"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult ReferByHead()
        {
            if (Session["ReferlNumber"] != null)
            {
                //
                var getstate = context.EmpStates.ToList();
                ViewBag.state = getstate;
                //end
                var CurrentUser = Session["ReferlNumber"].ToString();
                var getHeader = (from e in context.Employee_Form_Temp
                                 join f in context.ReferalForms on e.usercode equals f.usercode
                                 where e.usercode == CurrentUser
                                 select new ReferelViewModel
                                 {
                                     ReferalName = f.ReferalName,
                                     Date = f.Date,
                                     usercode = context.Employee_Form_Temp.Where(x => x.Employee_ID == f.ReferEmpID).FirstOrDefault().usercode,
                                     State = context.EmpStates.Where(x => x.EmpStateID == f.RefereEmpState).FirstOrDefault().Emp_State,
                                     City = context.Emp_City.Where(x => x.Emp_CityID == f.ReferEmpCity).FirstOrDefault().Emp_CityName,
                                     ReferPosID = context.Employee_Form_Temp.Where(x => x.Employee_ID == f.ReferEmpID).FirstOrDefault().PostID,
                                 }).ToList();
                var getbyhead = getHeader.Where(x => x.ReferPosID == 4).ToList();
                var getheadCount = getbyhead.Count();
                //var getheadComssion= getheadCount*///
                return View(getbyhead);
            }
            else
            {
               return RedirectToAction("Login", "UserAccount");
            }
           
        }
        /// <summary>
        /// get state city
        /// </summary>
        /// <param name="cityName"></param>
        /// <returns></returns>
        [HttpGet]
        public JsonResult GetAllStateCity(int?StateID)
        {
            var getcity = (from st in context.Emp_City
                           where st.EmpStateID == StateID
                           select new EmpstateCityViewModel
                           {
                               Emp_CityID = st.Emp_CityID,
                               Emp_CityName = st.Emp_CityName

                           }).ToList();
            return Json(getcity, JsonRequestBehavior.AllowGet);


        }
        [HttpPost]
  
        public ActionResult ReferByHead(int cityName,int stateName)
        {
           
            if (Session["ReferlNumber"] != null)
            {
                var citynameget = context.Emp_City.Where(x => x.Emp_CityID == cityName).FirstOrDefault();
                var getstate = context.EmpStates.Where(x => x.EmpStateID == stateName).FirstOrDefault();
                var CityName = "";
                var StateName = "";
                if (citynameget != null)
                {
                    CityName = citynameget.Emp_CityName;
                }
                if (getstate != null)
                {
                    StateName = getstate.Emp_State;
                }
                var getstate1 = context.EmpStates.ToList();
                ViewBag.state = getstate1;//copy

                var CurrentUser = Session["ReferlNumber"].ToString();
                var getHeader = (from e in context.Employee_Form_Temp
                                 join f in context.ReferalForms on e.usercode equals f.usercode
                                 where e.usercode == CurrentUser
                                 select new ReferelViewModel
                                 {
                                     ReferalName = f.ReferalName,
                                     Date = f.Date,
                                     usercode = context.Employee_Form_Temp.Where(x => x.Employee_ID == f.ReferEmpID).FirstOrDefault().usercode,
                                     State = context.EmpStates.Where(x => x.EmpStateID == f.RefereEmpState).FirstOrDefault().Emp_State,
                                     City = context.Emp_City.Where(x => x.Emp_CityID == f.ReferEmpCity).FirstOrDefault().Emp_CityName,
                                     ReferPosID = context.Employee_Form_Temp.Where(x => x.Employee_ID == f.ReferEmpID).FirstOrDefault().PostID,
                                 }).ToList();
                var getbyhead = getHeader.Where(x => x.ReferPosID == 4 && x.City == CityName&&x.State== StateName).ToList();
                var getheadCount = getbyhead.Count();
                //var getheadComssion= getheadCount*///
                return View(getbyhead);
            }
            else
            {
                return RedirectToAction("Login", "UserAccount");
            }

        }
        //////
        ///referel view details
        //
        [HttpGet]
        public ActionResult ReferelViewDetails(string usercode)
        {
            if (Session["ReferlNumber"] != null)
            {
                var getstate = context.EmpStates.ToList();
                ViewBag.state = getstate;
                ViewBag.code = usercode;
                var CurrentUser = Session["ReferlNumber"].ToString();
                var getHeader = (from e in context.Employee_Form_Temp
                                 join f in context.ReferalForms on e.usercode equals f.usercode
                                 where e.usercode == usercode
                                 select new ReferelViewModel
                                 {
                                     ReferalName = f.ReferalName,
                                     Date = f.Date,
                                     usercode = context.Employee_Form_Temp.Where(x => x.Employee_ID == f.ReferEmpID).FirstOrDefault().usercode,
                                     State = context.EmpStates.Where(x => x.EmpStateID == f.RefereEmpState).FirstOrDefault().Emp_State,
                                     City = context.Emp_City.Where(x => x.Emp_CityID == f.ReferEmpCity).FirstOrDefault().Emp_CityName,
                                     ReferPosIDName = context.Employee_Form_Temp.Where(x => x.Employee_ID == f.ReferEmpID).FirstOrDefault().PostForm.PostName,
                                 }).ToList();
                //var getbyhead = getHeader.Where(x => x.ReferPosID == 1).ToList();
                var getheadCount = getHeader.Count();

                //var getheadComssion= getheadCount*///
                return View(getHeader);
            }
            else
            {
                return RedirectToAction("Login", "UserAccount");
            }

        }
        /////refer view Detail filter
        [HttpPost]
        public ActionResult ReferelViewDetails(string usercode, int cityName, int stateName)
        {
            if (Session["ReferlNumber"] != null)
            {
                var citynameget = context.Emp_City.Where(x => x.Emp_CityID == cityName).FirstOrDefault();
                var getstate = context.EmpStates.Where(x => x.EmpStateID == stateName).FirstOrDefault();
                var CityName = "";
                var StateName = "";
                if (citynameget != null)
                {
                    CityName = citynameget.Emp_CityName;
                }
                if (getstate != null)
                {
                    StateName = getstate.Emp_State;
                }
                var getstate1 = context.EmpStates.ToList();
                ViewBag.state = getstate1;//copy
                ViewBag.code = usercode;
                var CurrentUser = Session["ReferlNumber"].ToString();
                var getHeader = (from e in context.Employee_Form_Temp
                                 join f in context.ReferalForms on e.usercode equals f.usercode
                                 where e.usercode == usercode
                                 select new ReferelViewModel
                                 {
                                     ReferalName = f.ReferalName,
                                     Date = f.Date,
                                     usercode = context.Employee_Form_Temp.Where(x => x.Employee_ID == f.ReferEmpID).FirstOrDefault().usercode,
                                     State = context.EmpStates.Where(x => x.EmpStateID == f.RefereEmpState).FirstOrDefault().Emp_State,
                                     City = context.Emp_City.Where(x => x.Emp_CityID == f.ReferEmpCity).FirstOrDefault().Emp_CityName,
                                     ReferPosIDName = context.Employee_Form_Temp.Where(x => x.Employee_ID == f.ReferEmpID).FirstOrDefault().PostForm.PostName,
                                 }).ToList();
                var getbyhead = getHeader.Where(x => x.City ==CityName&&x.State==StateName).ToList();
                var getheadCount = getbyhead.Count();

                //var getheadComssion= getheadCount*///
                return View(getbyhead);
            }
            else
            {
                return RedirectToAction("Login", "UserAccount");
            }

        }
        /// <summary>
        /// /refer by dc
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult ReferByDC()
        {
            if (Session["ReferlNumber"] != null)
            {
                var getstate = context.EmpStates.ToList();
                ViewBag.state = getstate;

                var CurrentUser = Session["ReferlNumber"].ToString();
                var getHeader = (from e in context.Employee_Form_Temp
                                 join f in context.ReferalForms on e.usercode equals f.usercode
                                 where e.usercode == CurrentUser
                                 select new ReferelViewModel
                                 {
                                     ReferalName = f.ReferalName,
                                     Date = f.Date,
                                     usercode = context.Employee_Form_Temp.Where(x => x.Employee_ID == f.ReferEmpID).FirstOrDefault().usercode,
                                     State = context.EmpStates.Where(x => x.EmpStateID == f.RefereEmpState).FirstOrDefault().Emp_State,
                                     City = context.Emp_City.Where(x => x.Emp_CityID == f.ReferEmpCity).FirstOrDefault().Emp_CityName,
                                     ReferPosID = context.Employee_Form_Temp.Where(x => x.Employee_ID == f.ReferEmpID).FirstOrDefault().PostID,
                                 }).ToList();
                var getbyhead = getHeader.Where(x => x.ReferPosID == 1).ToList();
                var getheadCount = getbyhead.Count();
               
                //var getheadComssion= getheadCount*///
                return View(getbyhead);
            }
            else
            {
                return RedirectToAction("Login", "UserAccount");
            }

        }

        [HttpPost]
        public ActionResult ReferByDC(int cityName, int stateName)
        {
            if (Session["ReferlNumber"] != null)
            {
                var citynameget = context.Emp_City.Where(x => x.Emp_CityID == cityName).FirstOrDefault();
                var getstate = context.EmpStates.Where(x => x.EmpStateID == stateName).FirstOrDefault();
                var CityName = "";
                var StateName = "";
                if (citynameget != null)
                {
                    CityName = citynameget.Emp_CityName;
                }
                if (getstate != null)
                {
                    StateName = getstate.Emp_State;
                }
                var getstate1 = context.EmpStates.ToList();
                ViewBag.state = getstate1;//copy

                var CurrentUser = Session["ReferlNumber"].ToString();
                var getHeader = (from e in context.Employee_Form_Temp
                                 join f in context.ReferalForms on e.usercode equals f.usercode
                                 where e.usercode == CurrentUser
                                 select new ReferelViewModel
                                 {
                                     ReferalName = f.ReferalName,
                                     Date = f.Date,
                                     usercode = context.Employee_Form_Temp.Where(x => x.Employee_ID == f.ReferEmpID).FirstOrDefault().usercode,
                                     State = context.EmpStates.Where(x => x.EmpStateID == f.RefereEmpState).FirstOrDefault().Emp_State,
                                     City = context.Emp_City.Where(x => x.Emp_CityID == f.ReferEmpCity).FirstOrDefault().Emp_CityName,
                                     ReferPosID = context.Employee_Form_Temp.Where(x => x.Employee_ID == f.ReferEmpID).FirstOrDefault().PostID,
                                 }).ToList();
                var getbyhead = getHeader.Where(x => x.ReferPosID == 1 && x.City == CityName && x.State == StateName).ToList();
                var getheadCount = getbyhead.Count();

                //var getheadComssion= getheadCount*///
                return View(getbyhead);
            }
            else
            {
                return RedirectToAction("Login", "UserAccount");
            }

        }

        //Refer By BC
        [HttpGet]
        public ActionResult ReferByBC()
        {
            if (Session["ReferlNumber"] != null)
            {
                var getstate = context.EmpStates.ToList();
                ViewBag.state = getstate;

                var CurrentUser = Session["ReferlNumber"].ToString();
                var getHeader = (from e in context.Employee_Form_Temp
                                 join f in context.ReferalForms on e.usercode equals f.usercode
                                 where e.usercode == CurrentUser
                                 select new ReferelViewModel
                                 {
                                     ReferalName = f.ReferalName,
                                     Date = f.Date,
                                     usercode = context.Employee_Form_Temp.Where(x => x.Employee_ID == f.ReferEmpID).FirstOrDefault().usercode,
                                     State = context.EmpStates.Where(x => x.EmpStateID == f.RefereEmpState).FirstOrDefault().Emp_State,
                                     City = context.Emp_City.Where(x => x.Emp_CityID == f.ReferEmpCity).FirstOrDefault().Emp_CityName,
                                     ReferPosID = context.Employee_Form_Temp.Where(x => x.Employee_ID == f.ReferEmpID).FirstOrDefault().PostID,
                                 }).ToList();
                var getbyhead = getHeader.Where(x => x.ReferPosID == 2).ToList();
                var getheadCount = getbyhead.Count();

                //var getheadComssion= getheadCount*///
                return View(getbyhead);
            }
            else
            {
                return RedirectToAction("Login", "UserAccount");
            }

        }

        [HttpPost]
        public ActionResult ReferByBC(int cityName, int stateName)
        {
            if (Session["ReferlNumber"] != null)
            {
                var citynameget = context.Emp_City.Where(x => x.Emp_CityID == cityName).FirstOrDefault();
                var getstate = context.EmpStates.Where(x => x.EmpStateID == stateName).FirstOrDefault();
                var CityName = "";
                var StateName = "";
                if (citynameget != null)
                {
                    CityName = citynameget.Emp_CityName;
                }
                if (getstate != null)
                {
                    StateName = getstate.Emp_State;
                }
                var getstate1 = context.EmpStates.ToList();
                ViewBag.state = getstate1;//copy

                var CurrentUser = Session["ReferlNumber"].ToString();
                var getHeader = (from e in context.Employee_Form_Temp
                                 join f in context.ReferalForms on e.usercode equals f.usercode
                                 where e.usercode == CurrentUser
                                 select new ReferelViewModel
                                 {
                                     ReferalName = f.ReferalName,
                                     Date = f.Date,
                                     usercode = context.Employee_Form_Temp.Where(x => x.Employee_ID == f.ReferEmpID).FirstOrDefault().usercode,
                                     State = context.EmpStates.Where(x => x.EmpStateID == f.RefereEmpState).FirstOrDefault().Emp_State,
                                     City = context.Emp_City.Where(x => x.Emp_CityID == f.ReferEmpCity).FirstOrDefault().Emp_CityName,
                                     ReferPosID = context.Employee_Form_Temp.Where(x => x.Employee_ID == f.ReferEmpID).FirstOrDefault().PostID,
                                 }).ToList();
                var getbyhead = getHeader.Where(x => x.ReferPosID == 2 && x.City == CityName && x.State == StateName).ToList();
                var getheadCount = getbyhead.Count();

                //var getheadComssion= getheadCount*///
                return View(getbyhead);
            }
            else
            {
                return RedirectToAction("Login", "UserAccount");
            }

        }

        //Refer By Teacher
        [HttpGet]
        public ActionResult ReferByTeacher()
        {
            if (Session["ReferlNumber"] != null)
            {
                var getstate = context.EmpStates.ToList();
                ViewBag.state = getstate;

                var CurrentUser = Session["ReferlNumber"].ToString();
                var getHeader = (from e in context.Employee_Form_Temp
                                 join f in context.ReferalForms on e.usercode equals f.usercode
                                 where e.usercode == CurrentUser
                                 select new ReferelViewModel
                                 {
                                     ReferalName = f.ReferalName,
                                     Date = f.Date,
                                     usercode = context.Employee_Form_Temp.Where(x => x.Employee_ID == f.ReferEmpID).FirstOrDefault().usercode,
                                     State = context.EmpStates.Where(x => x.EmpStateID == f.RefereEmpState).FirstOrDefault().Emp_State,
                                     City = context.Emp_City.Where(x => x.Emp_CityID == f.ReferEmpCity).FirstOrDefault().Emp_CityName,
                                     ReferPosID = context.Employee_Form_Temp.Where(x => x.Employee_ID == f.ReferEmpID).FirstOrDefault().PostID,
                                 }).ToList();
                var getbyhead = getHeader.Where(x => x.ReferPosID == 3).ToList();
                var getheadCount = getbyhead.Count();

                //var getheadComssion= getheadCount*///
                return View(getbyhead);
            }
            else
            {
                return RedirectToAction("Login", "UserAccount");
            }

        }

        [HttpPost]
        public ActionResult ReferByTeacher(int cityName, int stateName)
        {
            if (Session["ReferlNumber"] != null)
            {
                var citynameget = context.Emp_City.Where(x => x.Emp_CityID == cityName).FirstOrDefault();
                var getstate = context.EmpStates.Where(x => x.EmpStateID == stateName).FirstOrDefault();
                var CityName = "";
                var StateName = "";
                if (citynameget != null)
                {
                    CityName = citynameget.Emp_CityName;
                }
                if (getstate != null)
                {
                    StateName = getstate.Emp_State;
                }
                var getstate1 = context.EmpStates.ToList();
                ViewBag.state = getstate1;//copy

                var CurrentUser = Session["ReferlNumber"].ToString();
                var getHeader = (from e in context.Employee_Form_Temp
                                 join f in context.ReferalForms on e.usercode equals f.usercode
                                 where e.usercode == CurrentUser
                                 select new ReferelViewModel
                                 {
                                     ReferalName = f.ReferalName,
                                     Date = f.Date,
                                     usercode = context.Employee_Form_Temp.Where(x => x.Employee_ID == f.ReferEmpID).FirstOrDefault().usercode,
                                     State = context.EmpStates.Where(x => x.EmpStateID == f.RefereEmpState).FirstOrDefault().Emp_State,
                                     City = context.Emp_City.Where(x => x.Emp_CityID == f.ReferEmpCity).FirstOrDefault().Emp_CityName,
                                     ReferPosID = context.Employee_Form_Temp.Where(x => x.Employee_ID == f.ReferEmpID).FirstOrDefault().PostID,
                                 }).ToList();
                var getbyhead = getHeader.Where(x => x.ReferPosID == 3 && x.City == CityName && x.State == StateName).ToList();
                var getheadCount = getbyhead.Count();

                //var getheadComssion= getheadCount*///
                return View(getbyhead);
            }
            else
            {
                return RedirectToAction("Login", "UserAccount");
            }

        }


        //Refer By Franchies
        [HttpGet]
        public ActionResult ReferByFranchies()
        {
            if (Session["ReferlNumber"] != null)
            {

                var CurrentUser = Session["ReferlNumber"].ToString();
                var getHeader = (from e in context.Employee_Form_Temp
                                 join f in context.ReferalForms on e.usercode equals f.usercode
                                 where e.usercode == CurrentUser
                                 select new ReferelViewModel
                                 {
                                     ReferalName = f.ReferalName,
                                     Date = f.Date,
                                     usercode = context.Employee_Form_Temp.Where(x => x.Employee_ID == f.ReferEmpID).FirstOrDefault().usercode,
                                     State = context.EmpStates.Where(x => x.EmpStateID == f.RefereEmpState).FirstOrDefault().Emp_State,
                                     City = context.Emp_City.Where(x => x.Emp_CityID == f.ReferEmpCity).FirstOrDefault().Emp_CityName,
                                     ReferPosID = context.Employee_Form_Temp.Where(x => x.Employee_ID == f.ReferEmpID).FirstOrDefault().PostID,
                                     FranchiesName = context.Employee_Form_Temp.Where(x => x.Employee_ID == f.ReferEmpID).FirstOrDefault().FranchiesCode,
                                 FranchiesModel = context.Franchies.ToList()
                                 }).ToList();
                var getbyhead = getHeader.Where(x => x.ReferPosID == 0).ToList();
                var getheadCount = getbyhead.Count();

                //var getheadComssion= getheadCount*///
                return View(getbyhead);
            }
            else
            {
                return RedirectToAction("Login", "UserAccount");
            }

        }

        //Employee Refer && Comssion Functionalty
        public ActionResult EmpReferListing(string startdate, string enddate)
        {
            int empid = Convert.ToInt32(Session["Id"]);
            int postId = Convert.ToInt32(Session["PostId"]);
          
            var comm = context.AdminEmployeeReferSettings.FirstOrDefault();
            var refers = context.ReferalForms.Where(x => x.RefferLid == empid.ToString());

            DateTime stdate = Convert.ToDateTime(startdate);

            DateTime endate = Convert.ToDateTime(enddate);

            var grouped = context.ReferalForms.Where(x => x.RefferLid == empid.ToString() && x.Date.Value.Month >= DateTime.Now.Month && x.Date.Value.Month <= DateTime.Now.Month);

            ViewBag.counter1 = grouped.Count();

           

            var masterSalary = context.MasterSalaries.FirstOrDefault(x => x.PostID == postId);

            if (masterSalary.PostID == 0)
            {
                ViewBag.comssion = masterSalary.Comssion / 100;
            }
            else
            {
                //Target
                ViewBag.Target = masterSalary.MinRefer;

                if (ViewBag.counter1 >= masterSalary.MinRefer)
                {
                    ViewBag.Salary = masterSalary.Salary;
                }

                var extraRefer = ViewBag.counter1 - masterSalary.MinRefer;

                if (ViewBag.counter1 > masterSalary.MinRefer)
                {
                    if (extraRefer > 0)
                    {
                        ViewBag.comssion = masterSalary.Comssion / 100 * masterSalary.Salary * extraRefer;

                        //Achievemeent
                        //ViewBag.Achievement = ViewBag.counter1 - masterSalary.MinRefer;
                    }

                }
            }
          
            double comission = 0;
            if (refers != null && postId == 1)
            {
                comission = refers.Count() * 1;
            }
            else if (refers != null && postId == 2)
            {
                comission = refers.Count() * 5;
            }
            else if (refers != null && postId == 3)
            {
                comission = refers.Count() * 40;
            }
            else if (refers != null && postId == 4)
            {
                comission = refers.Count() * 0.1;
            }

            Session["ReferlCount"] = refers != null ? refers.Count().ToString() : "";

            Session["comission"] = comission;


            var list = context.ReferalForms.Where(x => (x.RefferLid) == empid.ToString()).Select(x => (x.Employee_ID)).ToList();


            var users = context.Employee_Form_Temp.Where(x => list.Contains(x.Employee_ID.ToString())).ToList();

            Session["users"] = users;
                     
            return View();
        }

        public ActionResult EmpReferStudent()
        {
            int empid = Convert.ToInt32(Session["Id"]);
            int postId = Convert.ToInt32(Session["PostId"]);

            var teacherRefer = context.Refers.Where(x => x.RefferLid == empid.ToString()).Select(x => (x.UserID)).ToList();
            var student = context.Tab_User_Info_Temp.Where(x => teacherRefer.Contains(x.Id.ToString())).ToList();
            Session["Teacher"] = student;

            //if (student.Count > 0)
            //{
            //    Session["users"] = null;
            //}

            return View();
        }


        //For Student ReferListing..
        public ActionResult ReferListing(UserViewModel user)
        {
            int userId = Convert.ToInt32(Session["Id"]);

            ExamStudentContext context = new ExamStudentContext();

            var list = context.Refers.Where(x => (x.RefferLid) == userId.ToString()).Select(x => (x.UserID)).ToList();


            var users = context.Tab_User_Info_Temp.Where(x => list.Contains(x.Id.ToString())).ToList();

            Session["users"] = users;

            return View();

        }


        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session["Id"] = null;
            Session.Abandon(); // it will clear the session at the end of request

            return RedirectToAction("Login");
        }


        public ActionResult LoggedIn(User user)
        {

            DashBoardServices services = new DashBoardServices();

            AdminDashBoardViewModel model = new AdminDashBoardViewModel();

            model.UserSubject = services.GetUserSubjectCount();

            model.UserTeacher = services.GetUserTeacherCount();

            return View(model);

        }

        public ActionResult EmployeeLoggedIn(string startdate, string enddate)
        {
            int empid = Convert.ToInt32(Session["Id"]);
            int postId = Convert.ToInt32(Session["PostId"]);
            var comm = context.AdminEmployeeReferSettings.FirstOrDefault();
            var refers = context.ReferalForms.Where(x => x.RefferLid == empid.ToString());

            DateTime stdate = Convert.ToDateTime(startdate);

            DateTime endate = Convert.ToDateTime(enddate);

            var grouped = context.ReferalForms.Where(x => x.RefferLid == empid.ToString() && x.Date.Value.Month >= DateTime.Now.Month && x.Date.Value.Month <= DateTime.Now.Month);

            ViewBag.counter1 = grouped.Count();


            var masterSalary = context.MasterSalaries.FirstOrDefault(x => x.PostID == postId);

            //Target
            ViewBag.Target = masterSalary.MinRefer;

            if (ViewBag.counter1 >= masterSalary.MinRefer)
            {
                ViewBag.Salary = masterSalary.Salary;


            }

            var extraRefer = ViewBag.counter1 - masterSalary.MinRefer;

            if (ViewBag.counter1 > masterSalary.MinRefer)
            {
                if (extraRefer > 0)
                {
                    ViewBag.comssion = masterSalary.Comssion / 100 * masterSalary.Salary * extraRefer;

                    //Achievemeent
                    //ViewBag.Achievement = ViewBag.counter1 - masterSalary.MinRefer;
                }

            }

            double comission = 0;
            if (refers != null && postId == 1)
            {
                comission = refers.Count() * 1;
            }
            else if (refers != null && postId == 2)
            {
                comission = refers.Count() * 5;
            }
            else if (refers != null && postId == 3)
            {
                comission = refers.Count() * 40;
            }
            else if (refers != null && postId == 4)
            {
                comission = refers.Count() * 0.1;
            }

            Session["ReferlCount"] = refers != null ? refers.Count().ToString() : "";

            Session["comission"] = comission;


            var list = context.ReferalForms.Where(x => (x.RefferLid) == empid.ToString()).Select(x => (x.Employee_ID)).ToList();


            var users = context.Employee_Form_Temp.Where(x => list.Contains(x.Employee_ID.ToString())).ToList();

            Session["users"] = users;

            Image img = new Image();
            using (ExamStudentContext db = new ExamStudentContext())
            {
                int empidd = Convert.ToInt32(Session["Id"]);
                img = db.Images.Where(c=> c.Employee_ID == empidd).FirstOrDefault();              
            }

           
                return View();

        }

        public ActionResult UserSubject(string SearchTrem, int? minimumPrice, int? maximumPrice, int? subjectID, int? sortBy)
        {
            //Current User
            int userId = Convert.ToInt32(Session["Id"]);

            var user = context.Tab_User_Info_Temp.Where(x => x.Id == userId);

            int boardtypeId = user.Select(x => x.BoardType.BoardTypeID).FirstOrDefault();
            int BoardID = Convert.ToInt32(boardtypeId);

            int mediumID = user.Select(x => x.Medium.MediumID).FirstOrDefault();
            int mediumIntID = Convert.ToInt32(mediumID);

            int standardID = user.Select(x => x.Standard.StandardID).FirstOrDefault();
            int standID = Convert.ToInt32(standardID);


            UserListingViewModel model = new UserListingViewModel();
            model.Ispaids= (bool)user.Select(x=>x.IsPaid).FirstOrDefault();

            //model.Subjects = context.Subjects.Where(x => x.BoardTypeID == BoardID && x.MediumID == mediumIntID && x.StandardID == standID).ToList();

            ViewBag.SubjectList = model.Subjects;//Store data into the viewbag to display on student master layout page

            model.MaximumPrice = productsServices.GetMaximumPrice();

            model.Subjects = productsServices.SearchProducts(SearchTrem, minimumPrice, maximumPrice, subjectID, sortBy);//.Where(x => x.BoardTypeID == BoardID && x.MediumID == mediumIntID && x.StandardID == standID).ToList();

            model.SortBy = sortBy;

            model.Teachers = context.Teachers.ToList();

            return View(model);

        }


        public FileResult DownloadFile(string fileName)
        {
            var name = fileName;
            //Build the File Path.
            string path = Server.MapPath("~/MainDoc/") + name;

            //Read the File data into Byte Array.
            byte[] bytes = System.IO.File.ReadAllBytes(path);

            //Send the File to Download.
            return File(bytes, "application/octet-stream", fileName);
        }


        [NonAction]
        public FileStreamResult GetPDF()
        {
            FileStream fs = new FileStream(@"E:\Online Exam Protal ASP.NET MVC 5 Project\ExamStudent\ExamStudent\SubjectPDFNotes\test.pdf", FileMode.Open, FileAccess.Read);
            return File(fs, "application/pdf");
        }


        public ActionResult EmployeeAccount()
        {
            var empid = Convert.ToInt32(Session["Id"]);
            var postId = Convert.ToInt32(Session["PostId"]);

            var list = context.Employee_Form_Temp.Where(x =>x.Employee_ID == empid);

            List<Employee_Form_Temp> emplist = context.Employee_Form_Temp.Where(x => x.Employee_ID == empid).ToList();
            ViewData["list"] = emplist;

            return View();
        }

        public ActionResult MyAccount(Tab_User_Info_Temp user)
        {
            if (Session["Id"] != null)
            {
                return PartialView(user);
            }
            else
            {
                return RedirectToAction("Login");
            }


        }

        [NonAction]
        public void SendEmailVerificationLink(string emailaddress, string activationcode, string emailFor = "VerifyAccount")
        {
            //var verifyUrl = "/Account/VerifyAccount" + activationcode;

            var verifyUrl = "/UserAccount/" + emailFor + "/" + activationcode;
            var link = Request.Url.AbsoluteUri.Replace(Request.Url.PathAndQuery, verifyUrl);

            var fromEmail = new MailAddress("vinaytiwari264@gmail.com", "DotNet Awesome");
            var toEmail = new MailAddress(emailaddress);

            var fromEmailPassword = "31513162120518"; //Replace with actual Password

            //User Registration time Email Verification && //Reset Password time In User Email  :
            string subject = "";

            string body = "";

            if (emailFor == "VerifyAccount")
            {
                subject = "Your account is successfully created!";

                body = "<br/><br/> we are excuted totell you that Dotnet Awesome" +
                   "SuccessFully Created. Please click on the link below link to verify your account" +
                   "<br/><br/><a href='" + link + "'>" + link + "</a>";
            }
            else if (emailFor == "ResetPassword") //Reset Password time In User Email  :
            {
                subject = "Reset Password";
                body = "Hi, <br/><br/>we got request for reset your account Password.Please Check On the below link to reset your Password" +
                    "<br /><br /><a href=" + link + ">Reset Password link</a>";
            }

            //User Registration time Email Verification :

            //string subject = "Your account is successfully created!";

            //string body = "<br/><br/> we are excuted totell you that Dotnet Awesome" + 
            //    "SuccessFully Created. Please click on the link below link to verify your account" +
            //    "<br/><br/><a href='" + link + "'>"+link+"</a>";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromEmail.Address, fromEmailPassword)
            };

            using (var Message = new MailMessage(fromEmail, toEmail)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            })
                smtp.Send(Message);
        }


        public ActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ForgotPassword(string Emp_EmailAddress, string EmailAddress)
        {
            bool Status = false;
            string message = "";

            using (ExamStudentContext db = new ExamStudentContext())
            {
                var account = db.Employee_Form_Temp.Where(x => x.Emp_EmailAddress == Emp_EmailAddress).FirstOrDefault();
                //var useraccount = db.Tab_User_Info_Temp.Where(x => x.EmailAddress == EmailAddress).FirstOrDefault();
                if (account != null)
                {
                    //Send Email Reset Password Link :
                    string resetcode = Guid.NewGuid().ToString();

                    SendEmailVerificationLink(account.Emp_EmailAddress, resetcode, "ResetPassword");

                    account.ResetPasswordCode = resetcode;

                    //This line I have added here to avoid Confirm Password does't match issue , as we hed added a confirm Password property
                    //in our model class part 1
                    db.Configuration.ValidateOnSaveEnabled = false;

                    db.SaveChanges();

                    message = "Reset Password link has beeb send your Email ID";
                }

                else
                {
                    message = "Account Not Found";
                }

                ViewBag.Message = message;
            }

            return View();
        }

        public ActionResult ResetPassword(string id)
        {

            //Verify reset Password link
            //Find account associted with this link
            //redirect to reset password page

            using (ExamStudentContext db = new ExamStudentContext())
            {
                var user = db.Employee_Form_Temp.Where(x => x.ResetPasswordCode == id).FirstOrDefault();

                if (User != null)
                {
                    ForgotPassword model = new ForgotPassword();
                    model.ResetCode = id;
                    return View(model);
                }
                else
                {
                    return HttpNotFound();
                }
            }


        }

        [HttpPost]
        public ActionResult ResetPassword(ForgotPassword model)
        {
            var message = "";
            if (ModelState.IsValid)
            {
                using (ExamStudentContext db = new ExamStudentContext())
                {
                    var user = db.Employee_Form_Temp.Where(x => x.ResetPasswordCode == model.ResetCode).FirstOrDefault();
                    if (user != null)
                    {
                        user.Emp_Password = model.NewPassword;
                        user.Emp_ConfirmPassword = model.ConfirmPassword;
                        user.ResetPasswordCode = "";
                        db.Configuration.ValidateOnSaveEnabled = false;
                        db.SaveChanges();

                        message = "New Password is SuccessFully!";
                    }
                    else
                    {
                        message = "Something Invalid";
                    }

                    ViewBag.Message = message;
                }
            }
            return View(model);
        }


        public ActionResult IndexUserPanel()
        {
            return View();
        }

        public ActionResult SetExam()
        {
            int userId = Convert.ToInt32(Session["Id"]);

            var user = context.Users.Where(b => b.UserId == userId);

            string boardtypeID = user.Select(x => x.BoardType).FirstOrDefault();
            int BoardID = Convert.ToInt32(boardtypeID);

            string mediumID = user.Select(x => x.Medium).FirstOrDefault();
            int mediumIntID = Convert.ToInt32(mediumID);

            string standardID = user.Select(x => x.Standard).FirstOrDefault();
            int standID = Convert.ToInt32(standardID);

            SetExamCategoryViewModel model = new SetExamCategoryViewModel();

            var categoryList = context.Categories.OrderBy(x => x.Category_ID).Where(x => x.BoardTypeID == BoardID && x.MediumID == mediumIntID && x.StandardID == standID).ToList();
            model.CategoriesList = categoryList;

            return View(model);
        }

        [HttpGet]
        public ActionResult GetUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetUser(UserVM user)
        {
            UserVM userConnected = context.UserDetails.Where(u => u.FirstName == user.FirstName)
                                         .Select(u => new UserVM
                                         {
                                             UserDetailId = u.UserDetailId,
                                             FirstName = u.FirstName,


                                         }).FirstOrDefault();

            if (userConnected != null)
            {
                Session["UserConnected"] = userConnected;
                return RedirectToAction("SelectQuizz");
            }
            else
            {
                ViewBag.Msg = "Sorry : user is not found !!";
                return View();
            }

        }

        [HttpGet]
        public ActionResult SelectQuizz()
        {
            int userId = Convert.ToInt32(Session["Id"]);

            var user = context.Users.Where(b => b.UserId == userId);

            string boardtypeID = user.Select(x => x.BoardType).FirstOrDefault();
            int BoardID = Convert.ToInt32(boardtypeID);

            string mediumID = user.Select(x => x.Medium).FirstOrDefault();
            int mediumIntID = Convert.ToInt32(mediumID);

            string standardID = user.Select(x => x.Standard).FirstOrDefault();
            int standID = Convert.ToInt32(standardID);

            var scheduledExamTime = context.ScheduleExams.OrderBy(x => x.ExamScheduleID).Where(x => x.BoardTypeID == BoardID && x.MediumID == mediumIntID && x.StandardID == standID).ToList();

            SetExamCategoryViewModel model = new SetExamCategoryViewModel();

            DateTime? scheduledDatetime;

            if (scheduledExamTime != null && scheduledExamTime.Count > 0)
            {
                scheduledDatetime = scheduledExamTime[0].ScheduleDateTime;

                if (DateTime.Now >= scheduledDatetime)//check current time with scheduled exam datetime. if it's greater than current time then exam is valid
                {
                    ViewBag.examStatus = "Exam scheduled at " + scheduledDatetime.ToString();

                    var categoryList = context.Categories.OrderBy(x => x.Category_ID).Where(x => x.BoardTypeID == BoardID && x.MediumID == mediumIntID && x.StandardID == standID).ToList();

                    model.CategoriesList = categoryList;
                }
                else
                {
                    ViewBag.examStatus = "Your exam not scheduled now, please check schedule exam then proceed!";

                    View(model);
                }
            }


            //SELECT DISTINCT C.Category_Name,SE.ScheduleDateTime FROM  Category C INNER JOIN  ScheduleExam SE
            //ON C.BoardTypeID = SE.BoardTypeID AND C.StandardID = SE.StandardID AND C.MediumID = SE.MediumID
            //WHERE SE.ScheduleDateTime >= GETDATE()

            //var employeeRecord = from c in context.Categories
            //                     join s in context.ScheduleExams on c.BoardTypeID equals s.BoardTypeID
            //                     where c.BoardTypeID == s.BoardTypeID && c.StandardID==s.StandardID 
            //                     && c.MediumID==s.MediumID                                 
            //                     select new Category
            //                     {
            //                         Category_Name = c.Category_Name,
            //                         Category_ID = c.Category_ID                                     
            //                     };


            return View(model);
        }

        [HttpPost]
        public ActionResult SelectQuizz(SetExamCategoryViewModel quiz)
        {
            SetExamCategoryViewModel quizSelected = context.Categories.Where(q => q.Category_ID == quiz.Category_ID).Select(q => new SetExamCategoryViewModel
            {
                Category_ID = q.Category_ID,
                Category_Name = q.Category_Name,

            }).FirstOrDefault();

            if (quizSelected != null)
            {
                Session["SelectedQuiz"] = quizSelected;

                return RedirectToAction("QuizTest");
            }

            return View();
        }


        [HttpGet]
        public ActionResult QuizTest()
        {
            SetExamCategoryViewModel quizSelected = Session["SelectedQuiz"] as SetExamCategoryViewModel;
            IQueryable<QuestionVM> questions = null;

            if (quizSelected != null)
            {
                questions = context.Questions.Where(q => q.Category.Category_ID == quizSelected.Category_ID)
                   .Select(q => new QuestionVM
                   {
                       Question_Id = q.Question_Id,
                       Question1 = q.Question1,
                       Choices = q.Choices.Select(c => new ChoiceVM
                       {
                           ChoiceID = c.ChoiceID,
                           ChoiceText = c.ChoiceText
                       }).ToList()

                   }).AsQueryable();


            }

            return View(questions);
        }

        [HttpPost]
        public ActionResult QuizTest(List<QuizAnswersVM> resultQuiz)
        {
            List<QuizAnswersVM> finalResultQuiz = new List<QuizAnswersVM>();

            foreach (QuizAnswersVM answser in resultQuiz)
            {
                QuizAnswersVM result = context.Answers.Where(a => a.Question_Id == answser.Question_Id).Select(a => new QuizAnswersVM
                {
                    Question_Id = a.Question_Id.Value,
                    AnswerQ = a.AnswerText,

                    isCorrect = (answser.AnswerQ.ToLower().Equals(a.AnswerText.ToLower()))

                }).FirstOrDefault();



                finalResultQuiz.Add(result);
            }

            return Json(new { result = finalResultQuiz }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult BillingAddress()
        {
            return View();
        }

        public ActionResult BankDetails()
        {
            int userId = Convert.ToInt32(Session["Id"]);

            var list = context.StudentBankDetails.Where(x => (x.StudentBankID) == userId);

            List<StudentBankDetail> bankDetails = context.StudentBankDetails.Where(x => x.Id == userId).ToList();
            ViewData["list"] = bankDetails;

            return View();
        }

        [HttpPost]
        public ActionResult BankDetails(StudentBankDetail studentBankDetail)
        {
            try
            {
                ExamStudentContext context = new ExamStudentContext();

                studentBankDetail.Id = Convert.ToInt32(Session["Id"]);
                context.StudentBankDetails.Add(studentBankDetail);
                context.SaveChanges();

                //List<StudentBankDetail> bankDetails = context.StudentBankDetails.OrderBy(x => x.StudentBankID).ToList();
                //ViewData["list"] = bankDetails;

                return RedirectToAction("BankDetails");
            }
            catch (Exception)
            {

                throw;
            }

        }

        public ActionResult StudentBankDetailsEdit(int id)
        {
            var details = context.StudentBankDetails.Find(id);

            return View(details);
        }

        [HttpPost]
        public ActionResult StudentBankDetailsEdit(StudentBankDetail bankDetail)
        {
            context.Entry(bankDetail).State = EntityState.Modified;
            bankDetail.Id = Convert.ToInt32(Session["Id"]);
            context.SaveChanges();
            return RedirectToAction("BankDetails");
        }

       
    }
}
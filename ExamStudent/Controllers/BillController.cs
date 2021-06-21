using ExamStudent.Models;
using ExamStudent.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamStudent.Controllers
{
    public class BillController : Controller
    {
        // GET: Bill
        ExamStudentContext context = new ExamStudentContext();
        public ActionResult Index(string id)
        {
            string amount = Session["Amount"].ToString();
            if (Session["FranchiesCode"] != null)
            {
                string franciescode = Session["FranchiesCode"].ToString();
                var getvalue = context.Franchies.Where(x => x.Code == franciescode).FirstOrDefault();
                var getuser = context.Employee_Form_Temp.Where(x => x.Emp_AppID == id).FirstOrDefault();
                double Amount = (double)getvalue.Amount;
                //Convert.ToDouble(amount);

                double gst = (double)getvalue.gstPercentage;
                double gstpercentage = (gst) / 100f;
                double gstAmount = Math.Round(Amount * gstpercentage, 2);
                double transactrioncharge = (double)getvalue.Transpercentage;
                double tranpercentage = (transactrioncharge) / 100f;
                double transactionamount = Math.Round(Amount * tranpercentage, 2);
                double Total = Amount + gstAmount + transactionamount;
                Session["Amount"] = Total;
                BillViewmodel bilvm = new BillViewmodel();
                bilvm.Amount = Amount;
                bilvm.gst = gstAmount;
                bilvm.tramt = transactionamount;
                bilvm.Total = Total;
                bilvm.APPID = id;
                bilvm.email = getuser.Emp_EmailAddress;
                bilvm.Mobile = getuser.Emp_MobileNumber;
                bilvm.CustomerName = getuser.Employee_Name;
                bilvm.UserName = "Employee";
                return View(bilvm);
            }
            else
            {
               // string franciescode = Session["FranchiesCode"].ToString();
               // var getvalue = context.Franchies.Where(x => x.Code == franciescode).FirstOrDefault();
                double Amount = Convert.ToDouble(amount);
                //(double)getvalue.Amount;
                //Convert.ToDouble(amount);
                var getuser = context.Tab_User_Info_Temp.Where(x => x.ApplicationID == id).FirstOrDefault();

                double gst = (double)18;
                double gstpercentage = (gst) / 100f;
                double gstAmount = Math.Round(Amount * gstpercentage, 2);
                double transactrioncharge = (double)3;
                double tranpercentage = (transactrioncharge) / 100f;
                double transactionamount = Math.Round(Amount * tranpercentage, 2);
                double Total = Amount + gstAmount + transactionamount;
                Session["Amount"] = Total;
                BillViewmodel bilvm = new BillViewmodel();
                bilvm.Amount = Amount;
                bilvm.gst = gstAmount;
                bilvm.tramt = transactionamount;
                bilvm.Total = Total;
                bilvm.APPID = id;
                bilvm.email = getuser.EmailAddress;
                bilvm.Mobile = getuser.MobileNumber;
                bilvm.CustomerName = getuser.Name;
                bilvm.UserName = "Student";
                return View(bilvm);
            }
        }

        public ActionResult ShowBill()
        {
            string amount = Session["Amount"].ToString();
            string getType = Session["UserType"].ToString();
            string id = Session["AppID"].ToString();
            double Amount = Convert.ToDouble(amount);
            if(getType== "Employee")
            {
                var getuser = context.Employee_Form_Temp.Where(x => x.Emp_AppID == id).FirstOrDefault();

                BillViewmodel bilvm = new BillViewmodel();
                bilvm.Amount = Amount;
                bilvm.email = getuser.Emp_EmailAddress;
                bilvm.Mobile = getuser.Emp_MobileNumber;
                bilvm.CustomerName = getuser.Employee_Name;
                bilvm.UserName = "Employee";
                return View(bilvm);
            }
            else
            {
                var getuser = context.Tab_User_Info_Temp.Where(x => x.ApplicationID == id).FirstOrDefault();

                BillViewmodel bilvm = new BillViewmodel();
                bilvm.Amount = Amount;
                bilvm.email = getuser.EmailAddress;
                bilvm.Mobile = getuser.MobileNumber;
                bilvm.CustomerName = getuser.Name;
                bilvm.UserName = "Student";
                return View(bilvm);
            }
            
            
           
        }
    }
}
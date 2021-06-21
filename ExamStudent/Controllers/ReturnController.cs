using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;


namespace PayUmoneytry.Controllers
{
    public class ReturnController : Controller
    {
        private string strConnectionString = "";
        ConnectionStringSettings objConnectionStringSettings = ConfigurationManager.ConnectionStrings["ExamStudentConnection"];
        //strConnectionString = objConnectionStringSettings.ConnectionString;

        ExamStudentContext context = new ExamStudentContext();

        // GET: Return
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Return(FormCollection form)
        {
            string udf1 = Request.Form["udf1"]; // "735a2caf-bf5a-40c6-82e2-28c5cb91136b";
            string sql = "";
            Session["AppID"] = udf1;
            //string amount = Session["Amount"].ToString();
            string amount = Request.Form["amount"];
            decimal totalamount = Convert.ToDecimal(amount);
            try
            {
                Session["Amount"] = amount;
                string[] merc_hash_vars_seq;
                string merc_hash_string = string.Empty;
                string merc_hash = string.Empty;
                string order_id = string.Empty;
                string hash_seq = "key|txnid|amount|productinfo|firstname|email|udf1|udf2|udf3|udf4|udf5|udf6|udf7|udf8|udf9|udf10";

                if (form["status"].ToString() == "success")
                {
                    sql = "Update TabPayumoneyTransectionLog set Ispaid=1 where ApplicationID='"+ udf1 +"'";
                    CreateCommand(sql, objConnectionStringSettings.ConnectionString);

                    sql = "Insert into Tab_User_Info select ApplicationID, Name, EmailAddress, MobileNumber, DOB, ReferID, BoardType, Medium, Standard, Password, IsActive, CreatedDate, ModifiedDate, ConfirmPassword, StateID, CityID,Block, EmpID from Tab_User_Info_Temp where ApplicationID='" + udf1 + "'";
                    CreateCommand(sql, objConnectionStringSettings.ConnectionString);

                    sql = "Delete from Tab_User_Info_Temp where ApplicationID='" + udf1 + "'";
                    CreateCommand(sql, objConnectionStringSettings.ConnectionString);

                    sql = "Insert into Employee_Form select  Employee_Name, Emp_DOB, Emp_MobileNumber, Emp_Block, PostID, Emp_Password, Emp_ConfirmPassword, EmpStateID, Emp_CityID, Emp_EmailAddress, Emp_AppID, usercode, RefferalID FROM Employee_Form_Temp where Emp_AppID='" + udf1 + "'";
                    CreateCommand(sql, objConnectionStringSettings.ConnectionString);

                    sql = "Delete from Employee_Form_Temp where Emp_AppID='" + udf1 + "'";
                    CreateCommand(sql, objConnectionStringSettings.ConnectionString);


                    merc_hash_vars_seq = hash_seq.Split('|');
                    Array.Reverse(merc_hash_vars_seq);
                    merc_hash_string = ConfigurationManager.AppSettings["SALT"] + "|" + form["status"].ToString();


                    foreach (string merc_hash_var in merc_hash_vars_seq)
                    {
                        merc_hash_string += "|";
                        merc_hash_string = merc_hash_string + (form[merc_hash_var] != null ? form[merc_hash_var] : "");

                    }
                    Response.Write(merc_hash_string);
                    merc_hash = Generatehash512(merc_hash_string).ToLower();



                    if (merc_hash != form["hash"])
                    {
                        Response.Write("Hash value did not matched");

                    }
                    else
                    {
                        order_id = Request.Form["txnid"];

                        ViewData["Message"] = "Status is successful. Hash value is matched";
                       
                        Response.Write("<br/>Payment successful");  

                        //Hash value did not matched  
                    }

                    Session["username"] = "You are registered successfully, please continue to Sign-In";
                    var checkstudid1 = context.Tab_User_Info_Temp.Where(x => x.ApplicationID == udf1).FirstOrDefault();
                    if (checkstudid1 != null)
                    {
                        Session["UserType"] = "Employee";
                        checkstudid1.Amount= totalamount;
                        checkstudid1.IsPaid = true;
                        context.SaveChanges();

                    }
                    var checkempid1 = context.Employee_Form_Temp.Where(x => x.Emp_AppID == udf1).FirstOrDefault();
                    if (checkempid1 != null)
                    {
                        Session["UserType"] = "Student";
                        checkempid1.Amount = totalamount;
                        checkempid1.IsPaid = true;
                        context.SaveChanges();

                    }
                    return RedirectToAction("ShowBill", "Bill");

                }
                else
                {

                    Response.Write("Hash value did not matched");
                    // osc_redirect(osc_href_link(FILENAME_CHECKOUT, 'payment' , 'SSL', null, null,true));  

                }
            }

            catch (Exception ex)
            {
                Response.Write("<span style='color:red'>" + ex.Message + "</span>");

            }

            Session["username"] = "You are registered successfully, please continue to Sign-In!";
            var checkstudid = context.Tab_User_Info_Temp.Where(x => x.ApplicationID == udf1).FirstOrDefault();
            if (checkstudid != null)
            {
                Session["UserType"] = "Student";
                checkstudid.Amount = totalamount;
                checkstudid.IsPaid = true;
                context.SaveChanges();

            }
            var checkempid = context.Employee_Form_Temp.Where(x => x.Emp_AppID == udf1).FirstOrDefault();
            if (checkempid != null)
            {
                Session["UserType"] = "Employee";
                checkempid.Amount = totalamount;
                checkempid.IsPaid = true;
                context.SaveChanges();

            }
            return RedirectToAction("ShowBill", "Bill");
        }

        public string Generatehash512(string text)
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

       
            

        private static void CreateCommand(string queryString,
    string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(
                       connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
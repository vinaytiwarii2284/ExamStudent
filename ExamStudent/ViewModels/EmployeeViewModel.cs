using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamStudent.ViewModels
{
    public class EmployeeViewModel
    {
        public int Employee_ID { get; set; }
        public string Employee_Name { get; set; }
        public System.DateTime Emp_DOB { get; set; }
        public string Emp_MobileNumber { get; set; }
        public string Emp_Block { get; set; }
        public int? PostID { get; set; }
        public string Emp_Password { get; set; }
        public string Emp_ConfirmPassword { get; set; }
        public int EmpStateID { get; set; }
        public int Emp_CityID { get; set; }
        public string Emp_EmailAddress { get; set; }
        public string Emp_AppID { get; set; }
        public string usercode { get; set; }
        public Nullable<int> RefferalID { get; set; }
        public string ReferlName { get; set; }
        public Nullable<System.DateTime> Date { get; set; }


        public string refers { get; set; }
        public string comission { get; set; }

        public List<Emp_City> Emp_City { get; set; }
        public List<EmpState> EmpState { get; set; }
        public List<PostForm> PostForm { get; set; }
        public List<ReferalForm> ReferalForm { get; set; }
    }
}
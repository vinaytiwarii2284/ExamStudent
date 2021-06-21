using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamStudent.ViewModels
{
    public class UserIUnfoTempViewModel
    {
        public int Id { get; set; }
        public string ApplicationID { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<int> ReferID { get; set; }
        public string Password { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ConfirmPassword { get; set; }
        public string StateName { get; set; }
        public string CityName { get; set; }
        public string Block { get; set; }
        public string usercode { get; set; }
        public string ReferlName { get; set; }
        public Nullable<int> EmpID { get; set; }
        public string BoardTypeName { get; set; }
        public string MediumName { get; set; }
        public string StandardName { get; set; }
        public string ResetPasswordCode { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> BoardSecondID { get; set; }
        public Nullable<int> MediumSecondID { get; set; }
        public Nullable<int> StandardSecondID { get; set; }
        public Nullable<int> UserSubjectID { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<bool> IsPaid { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public List<Tab_User_Info_Temp> userinfo { get; set; }
        public List<BoardTypeSecond> Boardtype2 { get; set; }
        public List<StandardSecond> stander2 { get; set; }
        public List<MediumSecond> medaim2 { get; set; }

        public List<EmpCourse> EmpCourses { get; set; }

        public List<Subject> SelectSubject { get; set; }
        public List<UserSubjectSelection> SelectSubjectList { get; set; }
    }
}
using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamStudent.ViewModels
{
    public class UserDetailsViewModel
    {
        public int Id { get; set; }
        public string ApplicationID { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<int> ReferID { get; set; }
        public string BoardType { get; set; }
        public string Medium { get; set; }
        public string Standard { get; set; }
        public string Password { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ConfirmPassword { get; set; }
        public Nullable<int> StateID { get; set; }
        public Nullable<int> CityID { get; set; }
        public string Block { get; set; }
        public Nullable<int> EmpID { get; set; }
        public string usercode { get; set; }
        public string ReferlName { get; set; }
        public Nullable<int> u_status { get; set; }
        public Nullable<int> BoardTypeID { get; set; }
        public Nullable<int> MediumID { get; set; }
        public Nullable<int> StandardID { get; set; }

        public virtual City City { get; set; }
        public virtual EmpCourse EmpCourse { get; set; }
        public virtual State State { get; set; }
       
        public List<BoardType> BoardTypeList { get; set; }
        public List<Medium> MediumList { get; set; }
        public List<Standard> StandardList { get; set; }
    }
}
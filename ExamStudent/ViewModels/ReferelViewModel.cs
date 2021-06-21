using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamStudent.ViewModels
{
    public class ReferelViewModel
    {
        public int RefferalID { get; set; }
        public string ReferalName { get; set; }
        public int RefferLid { get; set; }
        public string Employee_ID { get; set; }
        public string usercode { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string City  { get; set; }
        public string State { get; set; }
        public int? ReferPosID { get; set; }

        public string ReferPosIDName { get; set; }
        public string franchiesName { get; set; }
        public List<Franchy> FranchiesModel { get; set; }
        //new work 
        public string FranchiesName { get; set; }

    }
}
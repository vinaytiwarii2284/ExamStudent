using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamStudent.ViewModels
{
    public class getAllStudentViewModel
    {
        public List<Tab_User_Info_Temp> userinfo { get; set; }
        public List<BoardTypeSecond> Boardtype2 { get; set; }
        public List<StandardSecond> stander2 { get; set; }
        public List<MediumSecond>medaim2 { get; set; }
        public List<Subject> SelectSubject { get; set; }
        public List<UserSubjectSelection> SelectSubjectList { get; set; }
    }
}
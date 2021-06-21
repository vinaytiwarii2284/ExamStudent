using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

namespace ExamStudent.ViewModels
{
    public class AdminDashBoardViewModel
    {
        public int UserSubject { get; set; }
        public int UserTeacher { get; set; }
        public int UserCount { get; set; }
        public int TotalStudent { get; set; }
        public string ImageUpload { get; set; }
    }
}
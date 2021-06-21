using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamStudent.ViewModels
{
    public class StandardViewModel
    {
        public int StandardID { get; set; }
        public int MediumID { get; set; }
        public string StandardName { get; set; }

        public List<Medium> MediumList { get; set; }
    }
}
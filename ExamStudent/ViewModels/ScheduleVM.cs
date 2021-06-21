using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamStudent.ViewModels
{
    public class ScheduleVM
    {
        public int ExamScheduleID { get; set; }
        public Nullable<System.DateTime> ScheduleDateTime { get; set; }
        public int BoardTypeID { get; set; }
        public string BoardTypeName { get; set; }


        public Nullable<int> MediumID { get; set; }
        public string MediumName { get; set; }

        public Nullable<int> StandardID { get; set; }
        public string StandardName { get; set; }

        public List<BoardType> BoardTypeList { get; set; }
        public List<Medium> MediumList { get; set; }
        public List<Standard> StandardList { get; set; }
    }
}
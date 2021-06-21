using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamStudent.ViewModels
{
    public class QuizCategoryViewModel
    {
        public int Category_ID { get; set; }

        public string Category_Name { get; set; }

        public int AdminID { get; set; }

        public int BoardTypeID { get; set; }

        public int MediumID { get; set; }

        public int StandardID { get; set; }

        public List<BoardType> BoardTypeList { get; set; }
        public List<Medium> MediumList { get; set; }

        public List<Standard> StandardList { get; set; }
    }
}
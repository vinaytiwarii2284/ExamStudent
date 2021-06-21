using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamStudent.ViewModels
{
    public class MediumViewModels
    {
        public int MediumID { get; set; }
        public int BoardTypeID { get; set; }
        public string MediumName { get; set; }


        public List<BoardType> BoardTypeList { get; set; }
    }
}
using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ExamStudent.Entity
{
    public class Medium
    {
        public int MediumID { get; set; }
        public int BoardTypeID { get; set; }
        public string MediumName { get; set; }

        public List<BoardType> BoardTypeList { get; set; }
    }

   

}
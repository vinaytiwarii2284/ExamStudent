using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamStudent.ViewModels
{
    public class TeacherViewModel
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }

        public int BoardTypeID { get; set; }
        public int MediumID { get; set; }
        public int SubjectID { get; set; }

        public string SubjectName { get; set; }


        public List<BoardType> BoardTypeList { get; set; }
        public List<Medium> MediumList { get; set; }

        public List<Subject> SubjectList { get; set; }
    }

    public class TeacherListing
    {
        public List<Teacher> TeachersList { get; set; }
    }

}
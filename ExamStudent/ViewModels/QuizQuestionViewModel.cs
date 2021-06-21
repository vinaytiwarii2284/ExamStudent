using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamStudent.ViewModels
{
    public class QuizQuestionViewModel
    {
        public int Question_Id { get; set; }

        [Display(Name ="Question-Text")]
        public string Question1 { get; set; }

        [Display(Name = "Correct Option")]
        public string CorrectOptionId { get; set; }

        [Display(Name = "Category Name")]
        public int Category_ID { get; set; }

        [Display(Name = "Board Name")]
        public int BoardTypeID { get; set; }

        [Display(Name = "Medium Name")]
        public int MediumID { get; set; }

        [Display(Name = "Standard Name")]
        public int StandardID { get; set; }

        public List<BoardType> BoardTypeList { get; set; }
        public List<Medium> MediumList { get; set; }

        public List<Standard> StandardList { get; set; }

        public List<Category> CategoryList { get; set; }

    }

    public class ScheduleExamViewModel
    {
        public int ExamScheduleID { get; set; }
        public DateTime ScheduleDateTime { get; set; }


        public int BoardTypeID { get; set; }

     
        public int MediumID { get; set; }

      
        public int StandardID { get; set; }

        public List<BoardType> BoardTypeList { get; set; }
        public List<Medium> MediumList { get; set; }

        public List<Standard> StandardList { get; set; }
    }
}
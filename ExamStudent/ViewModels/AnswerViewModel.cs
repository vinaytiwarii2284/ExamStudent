using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamStudent.ViewModels
{
    public class AnswerViewModel
    {
        public int AnswerID { get; set; }
        public string AnswerText { get; set; }
        public Nullable<int> Question_Id { get; set; }

        public List<Question> QuestionsList { get; set; }

    }

    public class ChoiceViewModel
    {
        public int ChoiceID { get; set; }
        public string ChoiceText { get; set; }
        public Nullable<int> Question_Id { get; set; }

        public List<Question> QuestionsList { get; set; }
    }
}
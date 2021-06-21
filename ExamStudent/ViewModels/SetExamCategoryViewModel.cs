using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamStudent.ViewModels
{


    public class UserVM
    {
        public int UserId { get; set; }
        public long UserDetailId { get; set; }
        public string BoardTypeName { get; set; }
        public int BoardTypeID { get; set; }
        public string Mediumname { get; set; }
        public int MediumID { get; set; }
        public string Standardname { get; set; }

        public int StandardID { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }


       
        public List<BoardTypeModel> BoardTypeList { get; set; }
        public List<MediumModel> MediumList { get; set; }

        public List<StandardModel> StandardList { get; set; }

      
    }


    public class SetExamCategoryViewModel
    {
        public int Category_ID { get; set; }

        public string Category_Name { get; set; }

        public int AdminID { get; set; }

        public int BoardTypeID { get; set; }

        public int MediumID { get; set; }

        public int StandardID { get; set; }


      

        public List<Category> CategoriesList { get; set; }

        public List<Question> QuestionsList { get; set; }

        public List<BoardType> BoardTypeList { get; set; }
        public List<Medium> MediumList { get; set; }

        public List<Standard> StandardList { get; set; }
    }


    public class QuestionVM
    {
        public int Question_Id { get; set; }

        public string Question1 { get; set; }

        public string QuestionType { get; set; }
        public string Anwser { get; set; }

        public string CorrectOptionId { get; set; }

        public Nullable<int> Category_ID { get; set; }

        public Nullable<int> BoardTypeID { get; set; }
        public Nullable<int> MediumID { get; set; }
        public Nullable<int> StandardID { get; set; }

        public List<Category> CategoriesList { get; set; }
        public List<BoardType> BoardTypesList { get; set; }
        public List<Medium> MediumList { get; set; }
        public List<Standard> StandardsList { get; set; }


        public ICollection<ChoiceVM> Choices { get; set; }
    }


    public class ChoiceVM
    {
        public int ChoiceID { get; set; }
        public string ChoiceText { get; set; }
    }

    public class QuizAnswersVM
    {
        public int Question_Id { get; set; }
        public string Question1 { get; set; }
        public string AnswerQ { get; set; }
        public bool isCorrect { get; set; }
        public string AnswerText { get; set; }

    }
}
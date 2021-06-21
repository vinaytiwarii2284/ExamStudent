using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamStudent.Services
{
    public class DashBoardServices
    {
        public List<Image> GetImages()
        {
            ExamStudentContext context = new ExamStudentContext();

            return context.Images.ToList();
        }

        public int GetUserCount()
        {
            ExamStudentContext context = new ExamStudentContext();

            return context.Employee_Form_Temp.Count();
        }

        public int GetTotalStudents()
        {
            ExamStudentContext context = new ExamStudentContext();
            return context.Tab_User_Info_Temp.Count();
        }

        public int GetUserSubjectCount()
        {
            ExamStudentContext context = new ExamStudentContext();

            return context.Subjects.Count();
        }

        public int GetUserTeacherCount()
        {
            ExamStudentContext context = new ExamStudentContext();

            return context.Teachers.Count();
        }
    }
}
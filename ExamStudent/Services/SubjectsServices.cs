using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamStudent.Services
{
    public class SubjectsServices
    {
        // All Product list Functionality..
        public List<Subject> GetSubject(int pageNo)
        {
            int pageSize = 5;

            ExamStudentContext context = new ExamStudentContext();

            return context.Subjects.OrderBy(x => x.SubjectID).Skip((pageNo - 1) * pageSize).Take(pageSize).ToList();
        }



        public List<TabPayumoneyTransectionLog> GettabPayumoneyTransectionLogs()
        {
            //int pageSize = 100;

            ExamStudentContext context = new ExamStudentContext();

            return context.TabPayumoneyTransectionLogs.ToList();
        }



        // All Product list Functionality..
        public List<ScheduleExam> GetScheduleExams(int pageNo)
        {
            int pageSize = 5;

            ExamStudentContext context = new ExamStudentContext();

            return context.ScheduleExams.OrderBy(x => x.ExamScheduleID).Skip((pageNo - 1) * pageSize).Take(pageSize).ToList();
        }

        public Subject GetProductById(int id)
        {
            ExamStudentContext context = new ExamStudentContext();

            return context.Subjects.Find(id);
        }

        public void UpdateProduct(Subject subject)
        {
            ExamStudentContext context = new ExamStudentContext();

            context.Entry(subject).State = System.Data.Entity.EntityState.Modified;

            context.SaveChanges();
        }


        public Subject DetalisProduct(int id)
        {
            ExamStudentContext context = new ExamStudentContext();


            return context.Subjects.Find(id);
        }


        public void DeleteProduct(int id)
        {
            ExamStudentContext context = new ExamStudentContext();

            var product = context.Subjects.Find(id);

            context.Subjects.Remove(product);

            context.SaveChanges();
        }

    }
}
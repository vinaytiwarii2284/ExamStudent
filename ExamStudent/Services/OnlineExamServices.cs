using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExamStudent.Services
{
    public class OnlineExamServices
    {
        public User GetUserById(int id)
        {
            ExamStudentContext context = new ExamStudentContext();

            return context.Users.Find(id) ;
        }

        public void UpdateUsers(User user)
        {
            ExamStudentContext context = new ExamStudentContext();

            context.Entry(user).State = System.Data.Entity.EntityState.Modified;

            context.SaveChanges();
        }

        public void DeleteAuction(User user)
        {
            ExamStudentContext context = new ExamStudentContext();

            context.Entry(user).State = System.Data.Entity.EntityState.Deleted;

            context.SaveChanges();
        }
    }
}
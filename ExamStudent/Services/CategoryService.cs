using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamStudent.Services
{
    public class CategoryService
    {
        private ExamStudentContext db = new ExamStudentContext();
        public void Save(Employee_Form_Temp category)
        {
            db.Employee_Form_Temp.Add(category);
            db.SaveChanges();
        }

        public List<Employee_Form_Temp> GetAllCategories()
        {
            return db.Employee_Form_Temp.ToList();
        }

        public Employee_Form_Temp GetCategoryByID(int ID)
        {
            return db.Employee_Form_Temp.Find(ID);
        }

        public bool UpdateCategory(Employee_Form_Temp category)
        {
            var dbcategory = db.Employee_Form_Temp.Find(category.Employee_ID);

            if (dbcategory != null)
            {
                dbcategory.Employee_Name = category.Employee_Name;
                dbcategory.Emp_DOB = category.Emp_DOB;

                dbcategory.Emp_MobileNumber = category.Emp_MobileNumber;
                dbcategory.Emp_Block = category.Emp_Block;
                dbcategory.PostID = category.PostID;
                dbcategory.Emp_Password = category.Emp_Password;
                dbcategory.Emp_ConfirmPassword = category.Emp_ConfirmPassword;
                dbcategory.EmpStateID = category.EmpStateID;
                dbcategory.Emp_CityID = category.Emp_CityID;
                dbcategory.Emp_EmailAddress = category.Emp_EmailAddress;
               
            }


            db.Entry(dbcategory).State = System.Data.Entity.EntityState.Modified;

            return db.SaveChanges() > 0;

        }
    }
}
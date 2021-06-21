using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamStudent.ViewModels
{
    public class EmployeeSearchViewModel
    {
        public List<Employee_Form_Temp> employeesList { get; set; }
        public string SearchTerm { get; set; }
        public Pager Pager { get; set; }
    }
}
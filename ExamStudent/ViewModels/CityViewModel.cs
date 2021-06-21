using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamStudent.ViewModels
{
    public class CityViewModel
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        public Nullable<int> StateID { get; set; }

        public IEnumerable<SelectListItem> StatesSelectListItems { get; set; }

        public List<State> StatesList { get; set; }
    }

    public class EmpCityViewModel
    {
        public int Emp_CityID { get; set; }
        public string Emp_CityName { get; set; }
        public int EmpStateID { get; set; }

        public IEnumerable<SelectListItem> StatesSelectListItems { get; set; }

        public List<EmpState> EmpStatesList { get; set; }
    }
}
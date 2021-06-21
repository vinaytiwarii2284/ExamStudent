using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamStudent.ViewModels
{
    public class EmpReferalViewModel
    {
       public List<Employee_Form_Temp> employees { get; set; }

      public  List<ReferalForm> referalForms  { get; set; }
    }

    public class EmpBankDetails
    {
        public List<EmpBankDetail> bankDetails { get; set; }
    }
}
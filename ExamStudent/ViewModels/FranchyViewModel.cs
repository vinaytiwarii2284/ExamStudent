using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamStudent.ViewModels
{
    public class FranchyViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> gstPercentage { get; set; }
        public Nullable<decimal> Transpercentage { get; set; }
        public string FranchiesName { get; set; }

        public List<Franchy> Franchies { get; set; }
    }
}
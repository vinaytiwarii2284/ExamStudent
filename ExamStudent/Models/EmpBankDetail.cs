//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamStudent.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmpBankDetail
    {
        public int EmpBankDetailsID { get; set; }
        public string AccountNumber { get; set; }
        public string IFSCCode { get; set; }
        public string BankName { get; set; }
        public string AccountHolderName { get; set; }
        public string Address { get; set; }
        public Nullable<int> Employee_ID { get; set; }
    }
}

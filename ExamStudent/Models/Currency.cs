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
    
    public partial class Currency
    {
        public int CurrencyId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double Rate { get; set; }
        public string Symbol { get; set; }
        public bool IsDefault { get; set; }
        public string CurrencyIcon { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public string SyncCode { get; set; }
        public bool IsSynced { get; set; }
    }
}
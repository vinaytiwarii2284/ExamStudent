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
    
    public partial class Emp_City
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Emp_City()
        {
            this.Employee_Form = new HashSet<Employee_Form>();
            this.Employee_Form_Temp = new HashSet<Employee_Form_Temp>();
        }
    
        public int Emp_CityID { get; set; }
        public string Emp_CityName { get; set; }
        public int EmpStateID { get; set; }
    
        public virtual EmpState EmpState { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Form> Employee_Form { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Form_Temp> Employee_Form_Temp { get; set; }
    }
}

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
    
    public partial class StandardSecond
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StandardSecond()
        {
            this.UserSubjects = new HashSet<UserSubject>();
        }
    
        public int StandardSecondID { get; set; }
        public Nullable<int> MediumSecondID { get; set; }
        public string StandardName { get; set; }
    
        public virtual MediumSecond MediumSecond { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserSubject> UserSubjects { get; set; }
    }
}

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
    
    public partial class MediumSecond
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MediumSecond()
        {
            this.StandardSeconds = new HashSet<StandardSecond>();
        }
    
        public int MediumSecondID { get; set; }
        public string MediumName { get; set; }
        public Nullable<int> BoardSecondID { get; set; }
    
        public virtual BoardTypeSecond BoardTypeSecond { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StandardSecond> StandardSeconds { get; set; }
    }
}
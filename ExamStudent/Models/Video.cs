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
    
    public partial class Video
    {
        public int VideoID { get; set; }
        public string Title { get; set; }
        public string UploadVideo { get; set; }
        public Nullable<int> BoardTypeID { get; set; }
        public Nullable<int> MediumID { get; set; }
        public Nullable<int> StandardID { get; set; }
    
        public virtual BoardType BoardType { get; set; }
        public virtual Medium Medium { get; set; }
        public virtual Standard Standard { get; set; }
    }
}

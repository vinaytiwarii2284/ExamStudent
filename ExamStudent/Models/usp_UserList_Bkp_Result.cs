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
    
    public partial class usp_UserList_Bkp_Result
    {
        public int UserId { get; set; }
        public long UserDetailId { get; set; }
        public string BoardType { get; set; }
        public string Medium { get; set; }
        public string Standard { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
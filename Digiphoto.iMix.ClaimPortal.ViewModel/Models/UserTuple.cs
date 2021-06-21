using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamStudent.ViewModel.Models
{
    public class UserTuple
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public long UserDetailId { get; set; }
        public string BoardType { get; set; }
        public string Medium { get; set; }
        public string Standard { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }

        public string Name { get; set; }

        //public long UserDetailId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<int> ReferID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Digiphoto.iMix.ClaimPortal.Model
{
    public class UserDetail
    {
        public long UserDetailsId { get; set; }

         [Required(ErrorMessage = "First name required."), Display(Name = "First Name"),StringLength(50,ErrorMessage="Maximum of 50 characters allowed.")]
        public string FirstName { get; set; }
         [Display(Name = "Last Name"), Required(ErrorMessage = "Last name required."),StringLength(50, ErrorMessage = "Maximum of 50 characters allowed.")]
        public string LastName { get; set; }
         [Display(Name = "Middle Name"), StringLength(50, ErrorMessage = "Maximum of 50 characters allowed.")]
        public string MiddleName { get; set; }
         [Required(ErrorMessage = "EmailAddress is required."),
         Display(Name = "Email"), StringLength(100, ErrorMessage = "Maximum of 100 characters allowed."),
        RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Invalid email id.")]
          public string EmailAddress { get; set; }

           [Display(Name = "Phone"), StringLength(20,  ErrorMessage = "Maximum of 20 characters allowed."),
        RegularExpression(@"^[0-9]*$", ErrorMessage = "Numeric value is allowed.")]

        public string PhoneNumber { get; set; }
         [Required(ErrorMessage = "Mobile number is required."), Display(Name = "Mobile"), StringLength(20, MinimumLength = 10, ErrorMessage = "length minimum 10 characters allowed."),
        RegularExpression(@"^[0-9]*$", ErrorMessage = "Numeric value is allowed.")]
        public string MobileNumber { get; set; }

         [Required(ErrorMessage = "Date of Birth(DOB) is required.")]
         [Range(typeof(DateTime),
          "1/1/1902", "1/1/2100", ErrorMessage = "Value for {0} must be between {1} and {2}")]        
        public Nullable<System.DateTime> DOB { get; set; }
    }
}

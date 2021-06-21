using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamStudent.ViewModels
{
    public class ForgotPassword
    {
        [Required(ErrorMessage = "New Password Required")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }


        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "New Password and Confirm Password Does't match")]
        public string ConfirmPassword { get; set; }


        public string ResetCode { get; set; }
    }
}
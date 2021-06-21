using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel;

namespace ExamStudent.Controllers
{
    public class Captcha
    {
        [Display(Name = "Captcha", Order = 20)]
        //[Remote("ValidateCaptcha", "Captcha", "", ErrorMessageResourceName = "CaptchaModelValidationMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        [Required(ErrorMessageResourceName = "CaptchaModelRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public virtual string CaptchaValue { get; set; }       
    }

    public class InvisibleCaptcha
    {
        [Display(Name = "InvisibleCaptcha", Order = 20)]
        [Remote("ValidateInvisibleCaptcha", "Captcha", "", ErrorMessage = "ErrorMessage")]
        public virtual string InvisibleCaptchaValue { get; set; }
        
    }
}
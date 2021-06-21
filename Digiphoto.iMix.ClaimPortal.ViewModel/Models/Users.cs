using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages.Html;

namespace ExamStudent.ViewModel
{
    public class Users
    {

        public long PartnerUserId { get; set; }

        public int PartnerId { get; set; }
        
        //[StringLength(50, MinimumLength = 3,ErrorMessage="Username length minimum 3 and maximum 50. "), Required(ErrorMessage = "Please enter the Username"), Display(Name = "Username")]
        public string Username { get; set; }

        [StringLength(50)]
        [Display(Name = "UserEmailText", ResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        [Required(ErrorMessageResourceName = "UserEmailRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                            ErrorMessageResourceName = "UserEmailValidationMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public string Email { get; set; }

        
        [StringLength(50)]
        [Display(Name = "UserFirstNameText", ResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        [Required(ErrorMessageResourceName = "UserFirstNameRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        [RegularExpression("^[a-zA-Z\\s]+", ErrorMessageResourceName = "UserFirstNameValidationMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public string FirstName { get; set; }
        
        [StringLength(50)]
        [Display(Name = "UserLastNameText", ResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        [Required(ErrorMessageResourceName = "UserLastNameRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        [RegularExpression("^[a-zA-Z\\s]+", ErrorMessageResourceName = "UserLastNameValidationMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public string LastName { get; set; }

        [Display(Name = "UserPasswordText", ResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        [RegularExpression(@"^\S{8,50}$", ErrorMessageResourceName = "UserPasswordValidationMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        [StringLength(50, MinimumLength = 8, ErrorMessageResourceName = "UserPasswordValidationMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US)), Required(ErrorMessageResourceName = "UserPasswordRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public string Password { get; set; }

        //[Required(ErrorMessage = " ")]
        [Display(Name = "UserGenderText", ResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public string Gender { get; set; }

        //[Required(ErrorMessage = " ")]

        [Display(Name = "UserNationalityText", ResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public string Nationality { get; set; }

        [Compare("Password", ErrorMessageResourceName = "UserConfirmPasswordValidationMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US)), Required(ErrorMessageResourceName = "UserConfirmPasswordRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        [Display(Name = "UserConfirmPasswordText", ResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public string ConfirmPassword { get; set; }
        public string PasswordSalt { get; set; }
        public int UserType { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }

       [Required(ErrorMessageResourceName = "UserAddressRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public string Address { get; set; }
        public string Address2 { get; set; }

       [Required(ErrorMessageResourceName = "UserCityRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
       [RegularExpression("^[a-zA-Z\\s]+", ErrorMessage = "City can only contain letters")]
        public string City { get; set; }
        public string State { get; set; }

        [Required(ErrorMessageResourceName = "UserCountryRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public string Country { get; set; }

       [Required(ErrorMessageResourceName = "UserZipCodeRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
       [RegularExpression(@"^[0-9]*$", ErrorMessage = "Numeric value is allowed.")]
        public string ZipCode { get; set; }

       [Required(ErrorMessageResourceName = "UserPhoneNumberRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
       [RegularExpression(@"^[0-9]*$", ErrorMessage = "Numeric value is allowed.")]
        public string Phone { get; set; }
        public bool UseBillingAsShipping { get; set; }

        public bool EmailSubscription { get; set; }

        public string Suggestions { get; set; }

        //[Required]
        [Display(Name = "DateOfBirthText", ResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public DateTime? DateOfBirth { get; set; }

        public List<SelectListItem> Countrylist { get; set; }

        //[Required(ErrorMessageResourceName = "UserDOBRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        [Display(Name = "Date")]
        public int Dob_date { get; set; }

        [Display(Name = "Month")]
        public int Dob_month { get; set; }

        [Display(Name = "Year")]
        public int Dob_year { get; set; }
        //By KCB on 19 FEB 2019 for replace captcha
        [Required(ErrorMessageResourceName = "RegistrationCaptchaRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public string Captcha { get; set; }
    }
}

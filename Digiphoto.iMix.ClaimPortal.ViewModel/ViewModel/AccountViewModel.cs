using Digiphoto.iMix.ClaimPortal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace ExamStudent.ViewModel
{
    public class AccountViewModel : ErrorModel
    {
        public AccountViewModel()
        {
            UserDetails = new UserDetail();
            //    AuthorizedModules = new List<Module>();
            //    AssignedRoles = new List<Role>();
        }
        public long UserId { get; set; }
        public long LevelId { get; set; }
        public long UserTypeCodeId { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public bool IsValidated { get; set; }
        public UserDetail UserDetails { get; set; }
        //public ICollection<Module> AuthorizedModules { get; set; }
        //public ICollection<Role> AssignedRoles { get; set; }
    }

    public class LoginViewModel:ErrorModel
    {
        public long UserId { get; set; }
        [Required(ErrorMessageResourceName = "LoginViewModelEmailRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US)), Display(Name = "Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                           ErrorMessageResourceName="LoginViewModelEmailValidationMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public string Email { get; set; }

        //[RegularExpression(@"^[A-Za-z0-9]*$", ErrorMessage = "Password should contain alphanumeric only without spaces.")]        
        [RegularExpression(@"^\S{8,50}$", ErrorMessageResourceName = "LoginViewModelPasswordValidationMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Password length minimum 8 and maximum 50 without spaces."), Required(ErrorMessageResourceName = "LoginViewModelPasswordRequiredMessage",ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US)), Display(Name = "Password")]
        public string PasswordHash { get; set; }
        public bool RememberMe { get; set; }        
    }

    public class ForgotPasswordViewModel
    {
        public long UserId { get; set; }

        [Required(ErrorMessageResourceName = "ForgotPasswordViewModelEmailRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US)), Display(Name = "ForgotPasswordViewEmailText", ResourceType= typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                            ErrorMessageResourceName = "ForgotPasswordViewModelEmailValidationMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public string EmailID { get; set; }
    }

    public class UserAuthorizationViewModel : ErrorModel
    {
        public UserAuthorizationViewModel()
        {
            AuthorizationCollection = new List<UserAuthorizationViewModel>();
        }
        public long DigiMasterLocationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public long ParentDigiMasterLocationId { get; set; }
        public int DisplayOrder { get; set; }
        public int Level { get; set; }
        public bool ShowChecked { get; set; }
        public bool IsChecked { get; set; }

        public List<UserAuthorizationViewModel> AuthorizationCollection { get; set; }
    }

    public class UserAuthorizationCollection
    {
        public UserAuthorizationCollection()
        {
            AuthorizationCollection = new List<UserAuthorizationViewModel>();
        }
        public List<UserAuthorizationViewModel> AuthorizationCollection { get; set; }
    }
    public class AccountUserViewModel
    {
        public long UserId { get; set; }
        [Required(ErrorMessageResourceName = "AccountUserViewModelFirstNameRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US)), Display(Name = "AccountUserViewModelFirstNameText", ResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US)), StringLength(50, ErrorMessageResourceName = "AccountUserViewModelNameLengthValidationMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US)), RegularExpression("^[a-zA-Z\\s]+", ErrorMessageResourceName = "AccountUserViewModelFirstNameValidationMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public string FirstName { get; set; }
        [Display(Name = "AccountUserViewModelLastNameText", ResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US)), Required(ErrorMessageResourceName = "AccountUserViewModelLastNameRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US)), StringLength(50, ErrorMessageResourceName = "AccountUserViewModelNameLengthValidationMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US)), RegularExpression("^[a-zA-Z\\s]+", ErrorMessageResourceName = "AccountUserViewModelLastNameValidationMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public string LastName { get; set; }
      
        
        //[Required(ErrorMessage = "Please enter the Email Address"),
        // Display(Name = "EmailAddress"), StringLength(100, ErrorMessage = "Maximum of 100 characters allowed."),
        //RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Invalid email id")]
        [Required(ErrorMessageResourceName = "AccountUserViewModelEmailRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                            ErrorMessageResourceName = "AccountUserViewModelEmailValidationMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public string EmailAddress { get; set; }

        [RegularExpression(@"^\S{8,50}$", ErrorMessageResourceName = "AccountUserViewModelPasswordValidationMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        [StringLength(50, MinimumLength = 8, ErrorMessageResourceName = "AccountUserViewModelPasswordValidationMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US)), Required(ErrorMessageResourceName = "AccountUserViewModelPasswordRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US)), Display(Name = "AccountUserViewModelPasswordText", ResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public string Password { get; set; }

        [Compare("Password", ErrorMessageResourceName = "AccountUserViewModelConfirmPasswordValidationMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US)), Required(ErrorMessageResourceName = "AccountUserViewModelConfirmPasswordRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        [Display(Name = "AccountUserViewModelConfirmPasswordText", ResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public string ConfirmPassword { get; set; }
        public bool EmailSubscription { get; set; }

        public string Suggestions { get; set; }
    }

}

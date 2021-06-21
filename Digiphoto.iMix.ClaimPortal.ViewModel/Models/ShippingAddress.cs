using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamStudent.ViewModel
{
    public class ShippingAddress
    {
        public long PartnerUserId { get; set; }

        [Required(ErrorMessageResourceName = "ShippingAddressFirstNameRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        [RegularExpression("^[a-zA-Z\\s]+", ErrorMessageResourceName = "ShippingAddressFirstNameValidationMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public string FirstName { get; set; }

        [Required(ErrorMessageResourceName = "ShippingAddressLastNameRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        [RegularExpression("^[a-zA-Z\\s]+", ErrorMessageResourceName = "ShippingAddressLastNameValidationMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public string LastName { get; set; }

        [Required(ErrorMessageResourceName = "ShippingAddressAddressRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public string Address { get; set; }


        public string Address2 { get; set; }

        [Required(ErrorMessageResourceName = "ShippingAddressCityRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        [RegularExpression("^[a-zA-Z\\s]+", ErrorMessage = "City can only contain letters")]
        public string City { get; set; }


        public string State { get; set; }


        public string Country { get; set; }

        [Required(ErrorMessageResourceName = "ShippingAddressZipCodeRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Numeric value is allowed.")]
        public string ZipCode { get; set; }

        [Required(ErrorMessageResourceName = "ShippingAddressPhoneNumberRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Numeric value is allowed.")]
        public string Phone { get; set; }

        [Required(ErrorMessageResourceName = "ShippingAddressEmailRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                            ErrorMessageResourceName = "ShippingAddressEmailValidationMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public string Email { get; set; }


        public string Company { get; set; }
    }
}

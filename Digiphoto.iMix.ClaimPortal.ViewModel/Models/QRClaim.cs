using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Digiphoto.iMix.ClaimPortal.Model
{
    public class QRClaim
    {       
        public int CustomerQRCodeId { get; set;}

        [Required(ErrorMessageResourceName = "QRClaimRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        [MaxLengthAttribute(4, ErrorMessageResourceName = "QRClaimValidationMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        
        public string IdentificationCodeFirst { get; set; }

        [Required(ErrorMessageResourceName = "QRClaimRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        [MaxLengthAttribute(4, ErrorMessageResourceName = "QRClaimValidationMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public string IdentificationCodeSecond { get; set; }
        public bool ScanHit { get; set; }
    }
}

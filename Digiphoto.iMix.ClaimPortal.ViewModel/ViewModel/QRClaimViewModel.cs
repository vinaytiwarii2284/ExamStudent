using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digiphoto.iMix.ClaimPortal.Model;
namespace ExamStudent.ViewModel
{
    public class QRClaimViewModel : QRClaim
    {
        public ICollection<QRClaimViewModel> QRClaimList { get; set; }
        public DateTime OrderDate { get; set; }

        public Int64 PartnerUserId { get; set; }
        public int CustomerQRCodeId { get; set; }
        public string QRCode { get; set; }
    }
}

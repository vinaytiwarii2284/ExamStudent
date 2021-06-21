using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiphoto.iMix.ClaimPortal.Model
{
    public class CustomerSupportTicketInfo
    {
        public int SupportTicketHistoryID { get; set; }
        public DateTime HistoryDate { get; set; }
        public Int64 SupportTicketID { get; set; }

        [Display(Name = "Support Ticket Number")]
        [Required(ErrorMessageResourceName = "CustomerSupportTicketInfoSupportTicketRequiredMessage", ErrorMessageResourceType = typeof(Digiphoto.iMix.ClaimPortal.Common.Resources.en_US))]
        public Int64? SupportTicketNumber { get; set; }
        public string LocationName { get; set; }
        public string StatusName { get; set; }
        public string AssignedTo { get; set; }
        public DateTime AssignedDate { get; set; }
        public string Comments { get; set; }
        public DateTime StatusDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }


    }
}

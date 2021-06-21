using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiphoto.iMix.ClaimPortal.Model
{
    public class SupportTicketAttributeDetail
    {
        public int SupportTicketAttributeID { get; set; }
        public long TicketAttributeId { get; set; }
        public string Comments { get; set; }
        public string IssueDescription { get; set; }
    }
}

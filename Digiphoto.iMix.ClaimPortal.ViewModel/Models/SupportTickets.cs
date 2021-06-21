using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiphoto.iMix.ClaimPortal.Model
{
    public class SupportTickets
    {
        public SupportTickets()
        {
            if (TicketAttributeValues == null)
                this.TicketAttributeValues = new List<TicketAttributeValue>();
        }

        public string SupportTicketsNumber { get; set; }
        public string AssigneeTo { get; set; }
        public DateTime AssignmentDate { get; set; }
        public string AssignedBy { get; set; }
        public string Comments { get; set; }
        public int Status { get; set; }
        public int PartnerId { get; set; }
        public DateTime CloseDate { get; set; }
        public DateTime ResolveDate { get; set; }
        public List<TicketAttributeValue> TicketAttributeValues { get; set; }

    }
}

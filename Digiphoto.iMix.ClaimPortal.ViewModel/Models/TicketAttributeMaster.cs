using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiphoto.iMix.ClaimPortal.Model
{
   public  class TicketAttributeMaster
    {
       public TicketAttributeMaster()
       {
           if (this.TicketAttributeMasterDetails == null)
          this.TicketAttributeMasterDetails = new List<TicketAttributeMasterDetail>();
       }
        public long  AttributeMasterId { get; set; }
        public string AttributeName{ get; set; }
        public string AttributeDisplayLabel{ get; set; }
        public bool AttributeIsActive { get; set; }
        public string AttributeControlType { get; set; }
        public  List<TicketAttributeMasterDetail> TicketAttributeMasterDetails { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiphoto.iMix.ClaimPortal.Model
{
   public  class TicketAttributeValue
    {
       public TicketAttributeValue()
       {
           if (this.TicketAttributeValuelist == null)
               this.TicketAttributeValuelist = new List<TicketAttributeValue>();
       }
        public long  AttributeMasterId { get; set; }
        public string AttributeName{ get; set; }
        public string AttributeValue { get; set; }
        public string AttributeMasterValue { get; set; }
        public string AttributeDisplayLabel{ get; set; }
        public bool AttributeIsActive { get; set; }
        public bool IsRequired { get; set; }
        public Dictionary<int, string> venue { get; set; }
        public Dictionary<string, string> CaptureTime { get; set; }
        public Dictionary<int, string> Person { get; set; }
        public int AttributeControlType { get; set; }
        public TicketAttributeValue objTicketAttributeMaster { get; set; }
        public List<TicketAttributeValue> TicketAttributeValuelist { get; set; }
        public int SortBy { get; set; }
        public long StoreId { get; set; }
        public long SubstoreId { get; set; }
        public string EncryptedStoreId { get; set; }
        public string EncryptedSubstoreId { get; set; }
        public string SubStoreName { get; set; }
        public string StoreName { get; set; }
        public int PartnerId { get; set; }
        public string URL { get; set; }
    }
}

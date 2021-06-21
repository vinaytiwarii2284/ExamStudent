using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiphoto.iMix.ClaimPortal.Model
{
    public class ConfigurationValueInfo
    {
        public int ConfigurationMasterID { get; set; }
        public string ConfigurationValue { get; set; }
        public int PartnerID { get; set; }
        public long StoreID { get; set; }
        public long SubStoreID { get; set; }
    }
}

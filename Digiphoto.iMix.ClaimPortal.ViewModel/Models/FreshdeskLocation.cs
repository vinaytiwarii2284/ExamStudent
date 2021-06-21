using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiphoto.iMix.ClaimPortal.Model
{
   public class FreshdeskLocation
    {
        public string SubLocation { get; set; }
        public string Location { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public long ClaimPortalID { get; set; }
        public long GroupID { get; set; }
        public string Portal { get; set; }
    }
}

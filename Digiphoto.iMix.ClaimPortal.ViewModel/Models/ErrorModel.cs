using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiphoto.iMix.ClaimPortal.Model
{
    public class ErrorModel
    {
        public long ErrorId { get; set; }

        public string ErrorCode { get; set; }

        public string ErrorMessage { get; set; }
    }
}

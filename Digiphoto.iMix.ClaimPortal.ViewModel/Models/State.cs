using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiphoto.iMix.ClaimPortal.Model
{
  public  class State
    {
      public string StateCode { get; set; }
      public string StateName { get; set; }
      public ICollection<State> StateList { get; set; }
    }
}

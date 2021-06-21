﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiphoto.iMix.ClaimPortal.Model
{
  public  class Category
    {
      public int CategoryID { get; set; }
      public string CategoryName { get; set; }
      public string Description { get; set; }
      public int ParentCategoryId { get; set; }
      public bool IsActive { get; set; }
    }
}

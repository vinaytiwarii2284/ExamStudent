using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digiphoto.iMix.ClaimPortal.Model;

namespace ExamStudent.ViewModel
{
  public  class CustomerSupportModel: SupportTickets 
    {
      public CustomerSupportModel()
      {
          
      }
      public ICollection<CustomerSupportModel> CustomerSupportModelList { get; set; }
      public long StoreId { get; set; }
      public string StoreName { get; set; }
      //public string URL { get; set; }
     
    }
}

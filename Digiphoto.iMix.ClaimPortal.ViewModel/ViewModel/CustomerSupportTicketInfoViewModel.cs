using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digiphoto.iMix.ClaimPortal.Model;

namespace ExamStudent.ViewModel
{
    public class CustomerSupportTicketInfoViewModel : CustomerSupportTicketInfo
    {
        public ICollection<CustomerSupportTicketInfoViewModel> CustomerSupportTicketInfoList { get; set; }
        public ICollection<SupportTicketAttributeDetail> SupportTicketAttributeDetail { get; set; }
        public SupportTicketAttributeDetail SupportTicketAttribute { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
        public int TotalCount { get; set; }
        public int Count { get; set; }
       
    }
}

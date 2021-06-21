using Digiphoto.iMix.ClaimPortal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamStudent.ViewModel
{
    public class OrderHistoryViewModel : OrderHistory
    {
        public int page { get; set; }
        public int pageSize { get; set; }
        public int TotalCount { get; set; }
        public int Count { get; set; }
    }
}

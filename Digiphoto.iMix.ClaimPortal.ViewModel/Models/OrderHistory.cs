using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamStudent.ViewModel
{
    public class OrderHistory
    {
        public List<Order> UserOrders { get; set; } 

        public long? OrderID { get; set; }
        public DateTime? OrderDate { get; set; }
        public string FirstName { get; set; }
        public bool PaymentComplete { get; set; }
        public bool Processed { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Tax { get; set; }
        public decimal ShippingCost { get; set; }
        public decimal Total { get; set; }        
        public IEnumerable<OrderHistory> OrderHistoryList { get; set; }

        
    }
}

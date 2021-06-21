using Digiphoto.iMix.ClaimPortal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExamStudent.ViewModel
{

    public class OrderItem
    {
        public string ProductName { get; set; }
        public int ProductID { get; set; }

        public int Quantity { get; set; }
        public string TotalWithCurrency
        {
            get
            {
                return Currency + (Quantity * UnitPrice).ToString("0.00");
            }
        }

        public decimal UnitPrice { get; set; }
        public string UnitPriceWithCurrency
        {
            get
            {
                return Currency + UnitPrice.ToString("0.00");
            }
        }
        public long PhotoID { get; set; }
        public string Currency
        {
            get
            {
                return CommonFunctions.SetCurrency();
            }
        }
    }
}

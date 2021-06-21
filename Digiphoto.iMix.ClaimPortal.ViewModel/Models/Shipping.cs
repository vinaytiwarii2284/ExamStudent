using Digiphoto.iMix.ClaimPortal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamStudent.ViewModel
{
    public class Shipping
    {
        public int ShippingID { get; set; }
        public string ShippingName { get; set; }
        public decimal ShippingCost { get; set; }

        public string ShippingCostPrice
        {
            get { return Currency + ShippingCostPriceWithCurrency; } 

        }
        public string ShippingCostPriceWithCurrency
        {
            get;
            set;

        }
        public string Currency
        {

            get
            {
                return CommonFunctions.SetCurrency();
            }
        }

    }
}

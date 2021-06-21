using Digiphoto.iMix.ClaimPortal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamStudent.ViewModel
{
    public class Cart
    {
        public List<CartLineItem> CartLineItems { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int CartID { get; set; }
        public string Total(List<CartLineItem> CartLineItem)
        {
            return Currency + CartLineItem.Sum(p => (p.Product.UnitPrice * p.Quantity)).ToString("0.00");
        }
        public decimal TotalAmount(List<CartLineItem> CartLineItem)
        {
            return CartLineItem.Sum(p => (p.Product.UnitPrice * p.Quantity));
        }
        public string TotalCurrentValue
        {
            get;
            set;

        }
        public int PhotoId { get; set; }
        public int ProductId { get; set; }
        public string Currency
        {

            get
            {
                return CommonFunctions.SetCurrency();
            }
        }
    }
}

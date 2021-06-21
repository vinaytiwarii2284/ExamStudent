using Digiphoto.iMix.ClaimPortal.Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamStudent.ViewModel
{
    public class CartLineItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public int CartID { get; set; }
        public int CartItemID { get; set; }
        public string PhotoFilePath { get; set; }
        public int PhotoId { get; set; }
        public string Subtotal
        {
            get
            {
                return Currency + (Product.UnitPrice * Quantity).ToString("0.00");
            }
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

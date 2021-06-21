using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using Digiphoto.iMix.ClaimPortal.Common;

namespace ExamStudent.ViewModel
{

    public class Order
    {
        public int PartnerId { get; set; }

        public int CategoryId { get; set; }
        public long PartnerUserId { get; set; }

        public long OrderId { get; set; }

        public string OrderNumber { get; set; }

        public DateTime OrderDate { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }

        public string ShippingFirstName { get; set; }

        public string ShippingLastName { get; set; }

        public string ShippingCompany { get; set; }

        public string ShippingAddress1 { get; set; }

        public string ShippingAddress2 { get; set; }

        public string ShippingCity { get; set; }

        public string ShippingState { get; set; }

        public string ShippingZip { get; set; }

        public string ShippingCountry { get; set; }

        public string ShippingPhone { get; set; }

        public string ShippingFax { get; set; }

        public DateTime? ShippedDate { get; set; }

        public string ShippingMethod { get; set; }

        public string PaymentMethod { get; set; }
       
        public bool Cancelled { get; set; }

        public decimal Subtotal { get; set; }
        public string SubtotalWithCurrency
        {
            get
            {
                if (!string.IsNullOrEmpty(Currency))
                    return Currency + Subtotal.ToString("0.00").Replace(',', '.');
                return Currency + Subtotal.ToString("0.00").Replace(',', '.');
            }
        }
        public string TaxWithCurrency
        {
            get
            {
                if (!string.IsNullOrEmpty(Currency))
                    return Currency + Tax.ToString("0.00").Replace(',', '.');
                return Currency + Tax.ToString("0.00").Replace(',', '.');
            }
        }

        public decimal Tax { get; set; }
        public decimal Total { get; set; }

        public string TotalWithCurrency
        {
            get
            {
                if (!string.IsNullOrEmpty(Currency))
                    return Currency + Total.ToString("0.00").Replace(',', '.');
                return Currency + Total.ToString("0.00").Replace(',', '.');
            }

        }
        public decimal ShippingCost { get; set; }
        public string ShippingCostWithCurrency
        {
            get
            {
                if (!string.IsNullOrEmpty(Currency))
                    return Currency + ShippingCost.ToString("0.00").Replace(',', '.');
                return Currency + ShippingCost.ToString("0.00").Replace(',', '.');
            }
        }

        public string PayableAmount
        {
            get
            {
                if (!string.IsNullOrEmpty(Currency))
                    return Currency + (Subtotal + Tax + ShippingCost).ToString("0.00").Replace(',','.');
                return Currency + (Subtotal + Tax + ShippingCost).ToString("0.00").Replace(',', '.');
            }
        }

        //Order status messages used in Payment gatway receipt
        public List<OrderItem> OrderItems { get; set; }

        //Required feilds for thankyou and payment receipt view
        public int OrderStatus { get; set; }
        public string OrderStatusMsg { get; set; }       
        public string transaction_id { get; set; }
        public string PaymentStatus { get; set; }
        public decimal auth_amount { get; set; }
        public string decision { get; set; }

        //public IEnumerable<Order> OrderList { get; set; }
        public string Currency
        {
            get
            {
                return CommonFunctions.SetCurrency();
            }
        }
    }
}
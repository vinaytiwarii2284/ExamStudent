using Digiphoto.iMix.ClaimPortal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace ExamStudent.ViewModel
{
    public class CheckoutViewModel
    {
        public Users User { get; set; }
        public ShippingAddress ShippingAddress { get; set; }   
        }
}

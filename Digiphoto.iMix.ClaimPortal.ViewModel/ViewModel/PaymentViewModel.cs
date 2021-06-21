using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digiphoto.iMix.ClaimPortal.Model;
using Digiphoto.iMix.ClaimPortal.Common;
namespace ExamStudent.ViewModel
{
    [Serializable()]
    public class PaymentViewModel
    {
        public Users User { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
        public Cart Cart { get; set; }
        public Shipping Shipping { get; set; }
        public ICollection<Shipping> ShippingList { get; set; }
      //  public Payment PaymentDetails { get; set; }
        public decimal ShippingCost { get; set; }
        public decimal Tax { get; set; }
        public long OrderId { get; set; }
        public bool IsImageUnlock { get; set; }
        public string ErrorLog { get; set; }
        //paymentgateway feilds naming conventions are same as required for payment gateway
        public string access_key { get; set; }
        public string profile_id { get; set; }
        public string transaction_uuid { get; set; }
        public string signed_field_names { get; set; }
        public string unsigned_field_names { get; set; }
        public string signed_date_time { get; set; }
        public string locale { get; set; }
        public string payment_method { get; set; }
        public string bill_to_address_country { get; set; }
        public string bill_to_address_line1 { get; set; }
        public string bill_to_address_city { get; set; }
        public string bill_to_email { get; set; }
        public string bill_to_forename { get; set; }
        public string bill_to_surname { get; set; }
        public string bill_to_address_state { get; set; }
        public string bill_to_address_postal_code { get; set; }
        public string transaction_type { get; set; }
        public string reference_number { get; set; }
        public string amount { get; set; }
        public string currency { get; set; }
        public string signature { get; set; }
        public string merchant_defined_data1 { get; set; }
        //user id
        public string merchant_defined_data2 { get; set; }
        //Device type(browser or mobile)
        public string merchant_defined_data3 { get; set; }
        public string auth_avs_code { get; set; }
        public string req_card_number { get; set; }
        public string req_card_expiry_date { get; set; }
        public string bill_trans_ref_no { get; set; }
        public string decision { get; set; }
        public string payer_authentication_proof_xml { get; set; }
        public string auth_code { get; set; }
        public int reason_code { get; set; }
        public int req_card_type { get; set; }
        public decimal auth_amount { get; set; }
        public string auth_cv_result_raw { get; set; }
        public string auth_cv_result { get; set; }
        public string auth_avs_code_raw { get; set; }
        public string transaction_id { get; set; }
        public string  auth_time { get; set; }
        public string message { get; set; }
        public string auth_response { get; set; }
        public string auth_trans_ref_no { get; set; }
        public bool SignatureVerified { get; set; }
        public string GatewayURL { get; set; }
        public string ProdCurrency
        {

            get
            {
                return CommonFunctions.SetCurrency();
            }
        }
    }
}

using Digiphoto.iMix.ClaimPortal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using Digiphoto.iMix.ClaimPortal.Common;
namespace ExamStudent.ViewModel
{
    public class EditPhotoViewModel : EditPhoto
    {

        public ICollection<EditPhotoViewModel> ImageList { get; set; }
        public ICollection<EditPhotoViewModel> SubStoresImages { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
        public int TotalCount { get; set; }
        public int Count { get; set; }
        public string NewSubStoreId { get; set; }
        public String Comments { get; set; }
        public String path { get; set; }
        public String User { get; set; }       
        public String Password { get; set; }
        [Required]
        public String Email { get; set; }
        public String Subject { get; set; }

        private string i_ImageDimention;

        public string ImageDimention
        {
            get
            {
                if (string.IsNullOrEmpty(i_ImageDimention))
                {
                    i_ImageDimention = ThumbnailDimension;
                }
                return i_ImageDimention;
            }
            set { i_ImageDimention = value; }
        }

        public string hdnLinkedinVerifier { get; set; }
        public string FbHidden { get; set; }
        public String ErrorMessage { get; set; }
        public ICollection<EditPhotoViewModel> BorderImages { get; set; }
        public ICollection<EditPhotoViewModel> StickerImages { get; set; }
        public string CanvasFilePath
        {
            get
            {
                //string[] arrdimension = ImageDimention.Split(',');
                // return ConfigurationManager.AppSettings["ServerImagePath"] + "w_" + arrdimension[1].ToString() + ",h_" + arrdimension[0].ToString() + ",c_fit" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + Country + "/" + Store + "/" + SubStoreName + "/" + OrderDate.ToString("yyyyMMdd") + "/" + OrderId + "/" + IdentificationCode + "/" + FileName;

                if (IsPaidImage)
                   // return ConfigurationManager.AppSettings["ServerImagePath"] + "f_auto,fl_lossy" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + Country + "/" + Store + "/" + SubStoreName + "/" + OrderDate.ToString("yyyyMMdd") + "/" + OrderId + "/" + IdentificationCode + "/" + FileName;
                    return ConfigurationManager.AppSettings["ServerImagePath"] + "f_auto,fl_lossy" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + CloudSourceImagePath;
                else
                {
                    if (!string.IsNullOrEmpty(CloudinaryWatermarkImagePublicId))
                       // return ConfigurationManager.AppSettings["ServerImagePath"] + "f_auto,fl_lossy" + "/w_1000,l_" + CloudinaryWatermarkImagePublicId + "/" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + Country + "/" + Store + "/" + SubStoreName + "/" + OrderDate.ToString("yyyyMMdd") + "/" + OrderId + "/" + IdentificationCode + "/" + FileName;
                        return ConfigurationManager.AppSettings["ServerImagePath"] + "f_auto,fl_lossy" + "/w_" + Width + ",h_" + Height + ",l_" + CloudinaryWatermarkImagePublicId + "/" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + CloudSourceImagePath;
                    else
                        //return ConfigurationManager.AppSettings["ServerImagePath"] + "f_auto,fl_lossy" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + Country + "/" + Store + "/" + SubStoreName + "/" + OrderDate.ToString("yyyyMMdd") + "/" + OrderId + "/" + IdentificationCode + "/" + FileName;
                        return ConfigurationManager.AppSettings["ServerImagePath"] + "f_auto,fl_lossy" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + CloudSourceImagePath;
                }
            }
        }
		public int VideoCount { get; set; }
		


        // add some field of payment view model
        public long PackageOrderId { get; set; }
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
        //user id
        public string merchant_defined_data2 { get; set; }
        //Device type(browser or mobile)
        public string merchant_defined_data3 { get; set; }
        public string merchant_defined_data1 { get; set; }
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
        public string auth_time { get; set; }
        public string message { get; set; }
        public string auth_response { get; set; }
        public string auth_trans_ref_no { get; set; }
        public bool SignatureVerified { get; set; }
        public string GatewayURL { get; set; }
        public bool? IsBorder { get; set; }
        public bool? IsGraphics { get; set; }
        public bool? IsBackground { get; set; }

        public string ProdCurrency
        {
            get
            {
                return CommonFunctions.SetCurrency();
            }
        }
    }
}

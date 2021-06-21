using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiphoto.iMix.ClaimPortal.Common
{
    public enum UserType
    {
        Administrator = 101,
        Partner = 102,
        Customer = 103
    }
    public enum PlatformType
    {
        WebApplication = 601,
        MobileApplication = 602
    }

    public class SessionConstants
    {
        public const string SESSION_USER_TYPE = "UserType";
        public const string SESSION_USER_NAME = "UserName";
        public const string SESSION_USER_EMAIL = "UserEmail";
        public const string SESSION_USERID = "UserId";
        public const string SESSION_USER_LEVEL = "LevelId";
        public const string SESSION_AUTHORIZED_MODULE = "AuthorizedModules";
        public const string SESSION_AUTHORIZED_ROLES = "AuthorizedRoles";
        public const string SESSION_LOGGEDIN_ROLE_ID = "RoleId";
        public const string SESSION_LOGGEDIN_MODULE_ID = "Module";
        public const string SESSION_CONFIGURATIONS = "PartnerConfigurations";
        public const string SESSION_CONFIGURATIONS_PARTNER_LEVEL = "PartnerConfigurationsPartnerLevel";
        public const string SESSION_BORDER_LIST = "BorderList";
        public const string SESSION_GRAPHICS_LIST = "GraphicsList";
        public const string SESSION_CURRENCY = "Currency";
    }
    public class ResponseCode
    {
        public const string SUCCESS = "000";
        public const string Error = "111";
        public const string Unauthorized_Request = "101";
        public const string Registration_Failed = "102";
        public const string Unauthorized_User = "103";
        public const string QRCode_Not_Exits = "104";
        public const string QRCode_Expired = "105";
        public const string QRCode_AlreadyClaimed = "106";
        public const string Invalid_PhotoID = "107";
        public const string No_Access_Token = "108";
        public const string Invalid_OAuth_Access_Token = "109";
        public const string QRCode_Order_Cancelled = "110";
    }

    public class ResponseMessage
    {
        public const string SUCCESS = "Success";
        public const string Error = "Error";
        public const string Unauthorized_Request = "Unauthorized Request. Please try again later.";
        public const string Registration_Failed = "Unable to register your details. Please try again later.";
        public const string Registration_Failed_Duplicate_EmailId = "Your email is already registered, Please use Forgot password to retrieve your password.";
        public const string Unauthorized_User = "Please check your Username and Password.";
        //public const string QRCode_Not_Exits = "QRCode Not Exist";
        public const string QRCode_Not_Exits = "There are no snapps associated with this code.";
        public const string QRCode_Expired = "Your Code has expired.";
        public const string QRCode_AlreadyClaimed = "The snapps associated with this code have already been claimed.";
        public const string Invalid_PhotoID = "Invalid PhotoID";
        public const string No_Access_Token = "No access token";
        public const string Invalid_OAuth_Access_Token = "Invalid OAuth access token";
        public const string QRCode_Order_Cancelled = "The Order associated with  this code has been Cancelled.";
    }

    public class QRCodeError
    {
        public const Int32 QRCode_Not_Exists = -1;
        public const Int32 QRCode_Expired = -2;
        public const Int32 QRCode_AlreadyClaimed = -3;
        public const Int32 QRCode_User_Not_Exists = -4;
        public const Int32 QRCode_Order_Cancelled = -5;
    }

    public enum FeedbackPlatform
    {
        Android = 301,
        IOS = 302
    }

    public enum ConfigurationMaster
    {
        QRCodeClaimExpiryDays = 1,
        ImageRedemptionDays = 2,
        QRCodeExpiryDaysEmail = 3,
        PGCurrency = 4,
        PGAccesskey = 5,
        PGProfileId = 6,
        PGLocale = 7,
        PGURL = 8,
        SkipLocationView=9,
        EnableEcommerce=10,
        ShowWatermarkedImage=16,
        SkipStoresView=17,
        FacebookHashTag = 18
    }
    public enum ProductCategory
    {
        PrintProducts=1,
        GiftProducts=2,
        OnlineProducts=3        
    }

    public class GateWayResponse
    {
        public const int ACCEPT = 1;
        public const int REJECT = 2;
        public const int ERROR = 3;
        public const int REVIEW = 4;
        public const int CANCEL = 5;
    }

    public class GateWayResponseMsg
    {
        static GateWayResponseMsg instance;
        public static GateWayResponseMsg CurrentInstance
        {
            get
            {
                if (instance == null)
                    instance = new GateWayResponseMsg();

                return instance;
            }
        }
        public string ACCEPT
        {
            get
            {
                return Resources.en_US.ThankYouViewResponseMessage;
            }
        }
        public string REJECT
        {
            get
            {
                return Resources.en_US.PaymentGateWayResponseErrorMsg;
            }
        }
        public string ERROR
        {
            get
            {
                return Resources.en_US.PaymentGateWayResponseErrorMsg;
            }
        }
        public string REVIEW
        {
            get
            {
                return Resources.en_US.PaymentGateWayResponseReviewMsg;
            }
        }
        public string CANCEL
        {
            get
            {
                return Resources.en_US.PaymentGateWayResponseCancelMsg;
            }
        }
        // public const string ACCEPT = "Your order has been received. Thank you for your purchase!";
        //public static string ACCEPT = Resources.en_US.ThankYouViewResponseMessage;
        //public const string REJECT = "We faced a technical issue while processing your payment.\n Please contact helpdesk@digiphotoglobal.com if this issue persists";
        // public static string REJECT = Resources.en_US.PaymentGateWayResponseErrorMsg;
        //public const string ERROR = "We faced a technical issue while processing your payment.\n Please contact helpdesk@digiphotoglobal.com if this issue persists";
        //public static string ERROR = Resources.en_US.PaymentGateWayResponseErrorMsg;
        //public const string REVIEW = "Your order has been canceled";
        //public static string REVIEW = Resources.en_US.PaymentGateWayResponseReviewMsg;
        //public const string CANCEL = "Your have canceled the Order";
        //public static string CANCEL = Resources.en_US.PaymentGateWayResponseCancelMsg;
    }
    //public class GateWayResponseMsg
    //{
    //    public const string ACCEPT = "Your order has been received. Thank you for your purchase!";
    //    public const string REJECT = "We faced a technical issue while processing your payment.\n Please contact helpdesk@digiphotoglobal.com if this issue persists";
    //    public const string ERROR = "We faced a technical issue while processing your payment.\n Please contact helpdesk@digiphotoglobal.com if this issue persists";
    //    public const string REVIEW = "Your order has been canceled";
    //    public const string CANCEL = "Your have canceled the Order";
    //}

    public class PaymentStatusMsg
    {

        static PaymentStatusMsg instance;
        public static PaymentStatusMsg CurrentInstance
        {
            get
            {
                if (instance == null)
                    instance = new PaymentStatusMsg();

                return instance;
            }
        }
        public string SUCCESS
        {
            get
            {
                return Resources.en_US.PaymentStatusSuccessMsg;
            }
        }
        public string FAILED
        {
            get
            {
                return Resources.en_US.PaymentStatusFailedMsg;
            }
        }
        public string MONEY
        {
            get
            {
                return Resources.en_US.PaymentMoneyText;
            }
        }
        //public const string SUCCESS = "Payment of {money} is received !";
        //public static string SUCCESS = Resources.en_US.PaymentStatusSuccessMsg;
        //public const string FAILED = "Payment of {money} failed !";
        // public static string FAILED = Resources.en_US.PaymentStatusFailedMsg;
    }
    //public class PaymentStatusMsg
    //{
    //    public const string SUCCESS = "Payment of {money} is received !";
    //    public const string FAILED = "Payment of {money} failed !";
    //}

    public class PaymentDecision
    {
        public const string Accept = "ACCEPT";
        public const string Reject = "REJECT";
        public const string Error = "ERROR";
        public const string Review = "REVIEW";
        public const string Cancel = "CANCEL";
    }
    public enum DeviceType
    {
        WebBrowser = 1,
        MobileApp = 2
    }
    /// <summary>
    /// By KCB on 30 JAN 2019 to store Fresh desk config settings.
    /// </summary>
    public class FreshDesk
    {
        public static readonly string DomainName;
        public static readonly string APIKey;
        public static readonly string APIPath;
        public static bool DisplayFreshdeskNo { get; set; }
        static FreshDesk()
        {
            DomainName = System.Configuration.ConfigurationManager.AppSettings["FreshdeskDomainName"];
            APIKey = System.Configuration.ConfigurationManager.AppSettings["FreshdeskAPIKey"];
            APIPath = System.Configuration.ConfigurationManager.AppSettings["FreshdeskAPIPath"];
            DisplayFreshdeskNo = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["DisplayFreshdeskNo"]);
        }
    }
}

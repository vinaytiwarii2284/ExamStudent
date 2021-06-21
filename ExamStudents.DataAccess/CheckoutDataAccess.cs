using Digiphoto.iMix.ClaimPortal.Model;
using ExamStudent.Models;
using ExamStudent.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamStudents.DataAccess
{
    public class CheckoutDataAccess : BaseDataAccess
    {
        #region Constructor
        public CheckoutDataAccess(BaseDataAccess baseaccess)
            : base(baseaccess)
        {
        }
        public CheckoutDataAccess()
        {
        }
        #endregion
        public CheckoutViewModel GetUserAddress(Int64 userId)
        {
            DBParameters.Clear();
            AddParameter("@UserID", userId);
            IDataReader sqlReader = ExecuteReader("[Partner].[uspGetBillingUserDetail]");
            CheckoutViewModel checkoutViewModel = new CheckoutViewModel();
            checkoutViewModel.User = GetUserBillingAddress(sqlReader);
            sqlReader.Close();
            DBParameters.Clear();
            AddParameter("@PartnerUserID", userId);
            sqlReader = ExecuteReader("[Partner].[uspGetUserShippingAddress]");
            checkoutViewModel.ShippingAddress = GetUserShippingAddress(sqlReader);
            sqlReader.Close();

            return checkoutViewModel;
        }
        private ShippingAddress GetUserShippingAddress(IDataReader sqlReader)
        {

            ShippingAddress shippingAddress = new ShippingAddress();
            while (sqlReader.Read())
            {
                shippingAddress.PartnerUserId = GetFieldValue(sqlReader, "PartnerUserId", 0L);
                shippingAddress.Email = GetFieldValue(sqlReader, "ShippingEmail", string.Empty);
                shippingAddress.FirstName = GetFieldValue(sqlReader, "ShippingFirstName", string.Empty);
                shippingAddress.LastName = GetFieldValue(sqlReader, "ShippingLastName", string.Empty);
                shippingAddress.Address = GetFieldValue(sqlReader, "ShippingAddress1", string.Empty);
                shippingAddress.Address2 = GetFieldValue(sqlReader, "ShippingAddress2", string.Empty);
                shippingAddress.City = GetFieldValue(sqlReader, "ShippingCity", string.Empty);
                shippingAddress.State = GetFieldValue(sqlReader, "ShippingState", string.Empty);
                shippingAddress.ZipCode = GetFieldValue(sqlReader, "ShippingZip", string.Empty);
                shippingAddress.Country = GetFieldValue(sqlReader, "ShippingCountry", string.Empty);
                shippingAddress.Phone = GetFieldValue(sqlReader, "ShippingPhone", string.Empty);
            }
            return shippingAddress;
        }
        private Users GetUserBillingAddress(IDataReader sqlReader)
        {

            Users Users = new Users();
            while (sqlReader.Read())
            {
                Users.PartnerUserId = GetFieldValue(sqlReader, "PartnerUserId", 0L);
                Users.Email = GetFieldValue(sqlReader, "BillingEmail", string.Empty);
                Users.FirstName = GetFieldValue(sqlReader, "BillingFirstName", string.Empty);
                Users.LastName = GetFieldValue(sqlReader, "BillingLastName", string.Empty);
                Users.Address = GetFieldValue(sqlReader, "BillingAddress1", string.Empty);
                Users.Address2 = GetFieldValue(sqlReader, "BillingAddress2", string.Empty);
                Users.City = GetFieldValue(sqlReader, "BillingCity", string.Empty);
                Users.State = GetFieldValue(sqlReader, "BillingState", string.Empty);
                Users.ZipCode = GetFieldValue(sqlReader, "BillingZip", string.Empty);
                Users.Country = GetFieldValue(sqlReader, "BillingCountry", string.Empty);
                Users.Phone = GetFieldValue(sqlReader, "BillingPhone", string.Empty);
                Users.UseBillingAsShipping = GetFieldValue(sqlReader, "UseBillingAsShipping", false);
            }
            return Users;
        }


        public void SaveUserAddress(CheckoutViewModel checkoutViewModel)
        {
            DBParameters.Clear();
            AddParameter("@ShippingFirstName", checkoutViewModel.ShippingAddress.FirstName);
            AddParameter("@ShippingLastName", checkoutViewModel.ShippingAddress.LastName);
            AddParameter("@ShippingCompany", "null");
            AddParameter("@ShippingAddress1", checkoutViewModel.ShippingAddress.Address);
            AddParameter("@ShippingAddress2", checkoutViewModel.ShippingAddress.Address2);
            AddParameter("@ShippingCity", checkoutViewModel.ShippingAddress.City);
            AddParameter("@ShippingState", checkoutViewModel.ShippingAddress.State);
            AddParameter("@ShippingZip", checkoutViewModel.ShippingAddress.ZipCode);
            AddParameter("@ShippingCountry", checkoutViewModel.ShippingAddress.Country);
            AddParameter("@ShippingPhone", checkoutViewModel.ShippingAddress.Phone);
            AddParameter("@ShippingEmail", checkoutViewModel.ShippingAddress.Email);
            AddParameter("@UseBillingAsShipping", checkoutViewModel.User.UseBillingAsShipping);
            if (checkoutViewModel.User.UseBillingAsShipping == true)
            {
                AddParameter("@PartnerUserID", checkoutViewModel.ShippingAddress.PartnerUserId);
                AddParameter("@FirstName", checkoutViewModel.ShippingAddress.FirstName);
                AddParameter("@LastName", checkoutViewModel.ShippingAddress.LastName);
                AddParameter("@Address1", checkoutViewModel.ShippingAddress.Address);
                AddParameter("@Address2", checkoutViewModel.ShippingAddress.Address2);
                AddParameter("@City", checkoutViewModel.ShippingAddress.City);
                AddParameter("@State", checkoutViewModel.ShippingAddress.State);
                AddParameter("@Country", checkoutViewModel.ShippingAddress.Country);
                AddParameter("@ZipCode", checkoutViewModel.ShippingAddress.ZipCode);
                AddParameter("@Phone", checkoutViewModel.ShippingAddress.Phone);
                AddParameter("@Email", checkoutViewModel.ShippingAddress.Email);
            }
            else
            {
                AddParameter("@PartnerUserID", checkoutViewModel.User.PartnerUserId);
                AddParameter("@FirstName", checkoutViewModel.User.FirstName);
                AddParameter("@LastName", checkoutViewModel.User.LastName);
                AddParameter("@Address1", checkoutViewModel.User.Address);
                AddParameter("@Address2", checkoutViewModel.User.Address2);
                AddParameter("@City", checkoutViewModel.User.City);
                AddParameter("@State", checkoutViewModel.User.State);
                AddParameter("@Country", checkoutViewModel.User.Country);
                AddParameter("@ZipCode", checkoutViewModel.User.ZipCode);
                AddParameter("@Phone", checkoutViewModel.User.Phone);
                AddParameter("@Email", checkoutViewModel.User.Email);
            }
            SaveData("[Partner].[uspAddUserAddress]");
        }

        public ICollection<Country> GetCountry()
        {
            IDataReader sqlReader = ExecuteReader("[dbo].[uspGetCountry]");
            Country country = new Country();
            ICollection<Country> CountryList = GetCountryList(sqlReader);
            sqlReader.Close();
            return CountryList;
        }
        public ICollection<Country> GetCountryList(IDataReader sqlReader)
        {
            List<Country> countryList = new List<Country>();
            Country country = null;
            while (sqlReader.Read())
            {
                country = new Country();
                country.CountryCode = GetFieldValue(sqlReader, "CountryCode", string.Empty);
                country.CommonName = GetFieldValue(sqlReader, "CommonName", string.Empty);
                countryList.Add(country);
            }
            return countryList;
        }


        public ICollection<State> GetState(string CountryCode)
        {
            DBParameters.Clear();
            AddParameter("@CommonName", CountryCode);
            IDataReader sqlReader = ExecuteReader("[dbo].[uspGetState]");
            State state = new State();
            ICollection<State> StateList = GetStateList(sqlReader);
            sqlReader.Close();
            return StateList;
        }
        public ICollection<State> GetStateList(IDataReader sqlReader)
        {
            List<State> stateList = new List<State>();
            State state = null;
            while (sqlReader.Read())
            {
                state = new State();
                state.StateCode = GetFieldValue(sqlReader, "StateCode", string.Empty);
                state.StateName = GetFieldValue(sqlReader, "StateName", string.Empty);
                stateList.Add(state);
            }
            return stateList;
        }

        public PaymentViewModel GetUserBillingAndShippingAddress(Int64 userId)
        {
            DBParameters.Clear();
            AddParameter("@UserID", userId);
            IDataReader sqlReader = ExecuteReader("[Partner].[uspGetBillingUserDetail]");
            PaymentViewModel paymentViewModel = new PaymentViewModel();
            paymentViewModel.User = GetUserBillingAddress(sqlReader);
            sqlReader.Close();
            DBParameters.Clear();
            AddParameter("@PartnerUserID", userId);
            sqlReader = ExecuteReader("[Partner].[uspGetUserShippingAddress]");
            paymentViewModel.ShippingAddress = GetUserShippingAddress(sqlReader);
            sqlReader.Close();

            return paymentViewModel;
        }

        public ICollection<Shipping> GetShippingDetails(int LCID)
        {
            // Shipping shipping = new Shipping();
            DBParameters.Clear();
            AddParameter("@LCID", LCID);
            //AddParameter("@ShippingName", shippingName);
            IDataReader sqlReader = ExecuteReader("[Partner].[uspGetShippingDetails]");
            ICollection<Shipping> shipping = GetShippingList(sqlReader);
            return shipping;
        }
        public ICollection<Shipping> GetShippingList(IDataReader sqlReader)
        {
            List<Shipping> shippingList = new List<Shipping>();
            Shipping shipping = null;

            while (sqlReader.Read())
            {
                shipping = new Shipping();
                shipping.ShippingName = GetFieldValue(sqlReader, "ShippingName", string.Empty);
                shipping.ShippingCostPriceWithCurrency = (GetFieldValue(sqlReader, "FixedShippingCost", 0.0M)).ToString("0.00");
                shippingList.Add(shipping);
            }
            return shippingList;
        }

        public Int64 SaveOrder(string orderXML, int PartnerId)
        {
            AddParameter("@orderXML", orderXML);
            AddParameter("@PartnerID", PartnerId);
            Order order = new Order();
            IDataReader sqlReader = ExecuteReader("[Partner].[uspSaveOrder]");
            Int64 OrderId = 0;
            while (sqlReader.Read())
            {
                OrderId = GetFieldValue(sqlReader, "OrderID", 0L);
            }
            return OrderId;
        }


        public Order GetOrderById(Int64 orderId)
        {
            DBParameters.Clear();
            AddParameter("@OrderId", orderId);
            IDataReader sqlReader = ExecuteReader("Partner.usp_GetOrderDetails");
            Order order = PopulatePartnerOrdersDetails(sqlReader);
            sqlReader.Close();
            DBParameters.Clear();
            return order;
        }
        public Order PopulatePartnerOrdersDetails(IDataReader sqlReader)
        {
            Order order = new Order();
            OrderItem orderItem = null;

            List<OrderItem> orderItemsList = new List<OrderItem>();
            while (sqlReader.Read())
            {

                orderItem = new OrderItem();
                order.OrderId = GetFieldValue(sqlReader, "OrderID", 0L);
                order.OrderNumber = GetFieldValue(sqlReader, "OrderNumber", string.Empty);
                order.PartnerId = GetFieldValue(sqlReader, "PartnerId", 0);
                order.PartnerUserId = GetFieldValue(sqlReader, "PartnerUserId", 0L);
                order.OrderDate = GetFieldValue(sqlReader, "OrderDate", DateTime.Now);
                //order.UserName = GetFieldValue(sqlReader, "Username", string.Empty);
                order.FirstName = GetFieldValue(sqlReader, "FirstName", string.Empty);
                order.LastName = GetFieldValue(sqlReader, "LastName", string.Empty);
                order.Address1 = GetFieldValue(sqlReader, "Address1", string.Empty);
                order.Address2 = GetFieldValue(sqlReader, "Address2", string.Empty);
                order.City = GetFieldValue(sqlReader, "City", string.Empty);
                order.State = GetFieldValue(sqlReader, "State", string.Empty);
                order.Zip = GetFieldValue(sqlReader, "Zip", string.Empty);
                order.Country = GetFieldValue(sqlReader, "Country", string.Empty);
                order.Phone = GetFieldValue(sqlReader, "Phone", string.Empty);
                // order.Fax = GetFieldValue(sqlReader, "Fax", string.Empty);
                order.Email = GetFieldValue(sqlReader, "Email", string.Empty);
                order.ShippingFirstName = GetFieldValue(sqlReader, "ShippingFirstName", string.Empty);
                order.ShippingLastName = GetFieldValue(sqlReader, "ShippingLastName", string.Empty);
                //order.ShippingCompany = GetFieldValue(sqlReader, "ShippingCompany", string.Empty);
                order.ShippingAddress1 = GetFieldValue(sqlReader, "ShippingAddress1", string.Empty);
                order.ShippingAddress2 = GetFieldValue(sqlReader, "ShippingAddress2", string.Empty);
                order.ShippingCity = GetFieldValue(sqlReader, "ShippingCity", string.Empty);
                order.ShippingState = GetFieldValue(sqlReader, "ShippingState", string.Empty);
                order.ShippingZip = GetFieldValue(sqlReader, "ShippingZip", string.Empty);
                order.ShippingCountry = GetFieldValue(sqlReader, "ShippingCountry", string.Empty);
                order.ShippingPhone = GetFieldValue(sqlReader, "ShippingPhone", string.Empty);
                // order.ShippingFax = GetFieldValue(sqlReader, "ShippingFax", string.Empty);
                order.ShippedDate = GetFieldValue(sqlReader, "ShippedDate", DateTime.Now);
                // order.ShippingMethod = GetFieldValue(sqlReader, "ShippingMethod", string.Empty);
                order.PaymentMethod = GetFieldValue(sqlReader, "PaymentMethod", string.Empty);
                //order.Currency = GetFieldValue(sqlReader, "OrderCurrency", string.Empty);
                order.Subtotal = GetFieldValue(sqlReader, "Subtotal", 0.0M);
                order.Tax = GetFieldValue(sqlReader, "Tax", 0.0M);
                order.ShippingCost = GetFieldValue(sqlReader, "ShippingCost", 0.0M);
                order.Total = order.ShippingCost + order.Tax + order.Subtotal;
                order.transaction_id = GetFieldValue(sqlReader, "TransactionId", string.Empty);
                order.auth_amount = GetFieldValue(sqlReader, "AuthAmount", 0.0M);
                order.decision = GetFieldValue(sqlReader, "Decision", string.Empty);
                order.CategoryId = GetFieldValue(sqlReader, "CategoryID", 0);
                //parntnerOrderItem
                //orderItem.Currency = GetFieldValue(sqlReader, "OrderCurrency", string.Empty);
                orderItem.ProductID = GetFieldValue(sqlReader, "OrderItemID", 0);
                orderItem.Quantity = GetFieldValue(sqlReader, "Quantity", 0);
                orderItem.UnitPrice = GetFieldValue(sqlReader, "UnitPrice", 0.0M);
                // orderItem.PhotoID = GetFieldValue(sqlReader, "PhotoID", 0);
                //parntnerProduct
                orderItem.ProductID = GetFieldValue(sqlReader, "ProductID", 0);
                orderItem.ProductName = GetFieldValue(sqlReader, "ProductName", string.Empty);

                orderItem.UnitPrice = GetFieldValue(sqlReader, "UnitPrice", 0.0M);


                orderItemsList.Add(orderItem);
            }
            order.OrderItems = orderItemsList;
            return order;
        }

        public bool UpdateOrderDetails(PaymentViewModel paymentmodel)
        {
            try
            {
                DBParameters.Clear();
                AddParameter("@OrderId", paymentmodel.OrderId);
                //INPUT PARAMETERS-7           
                AddParameter("@ReqProfileId", paymentmodel.profile_id);
                AddParameter("@ReqTransactionUuid", paymentmodel.transaction_uuid);
                AddParameter("@ReqLocale", paymentmodel.locale);
                AddParameter("@ReqCurrency", paymentmodel.currency);
                AddParameter("@ReqReferenceNumber", paymentmodel.reference_number);
                AddParameter("@ReqAmount", paymentmodel.amount);
                AddParameter("@ReqAccessKey", paymentmodel.access_key);

                //RETURN PARAMENTRS-23
                AddParameter("@AuthAvsCode", paymentmodel.auth_avs_code);
                AddParameter("@ReqCardNumber", paymentmodel.req_card_number);
                AddParameter("@ReqCardExpiryDate", paymentmodel.req_card_expiry_date);
                AddParameter("@BillTransRefNo", paymentmodel.auth_trans_ref_no);
                AddParameter("@Decision", paymentmodel.decision);
                AddParameter("@SignedFieldNames", paymentmodel.signed_field_names);
                AddParameter("@ReqTransactionType", paymentmodel.req_card_type);
                AddParameter("@PayerAuthenticationProofXml", paymentmodel.payer_authentication_proof_xml);
                AddParameter("@AuthCode", paymentmodel.auth_code);
                AddParameter("@Signature", paymentmodel.signature);
                AddParameter("@ReasonCode", paymentmodel.reason_code);
                AddParameter("@ReqCardType", paymentmodel.req_card_type);
                AddParameter("@AuthAmount", paymentmodel.auth_amount);
                AddParameter("@AuthCvResultRaw", paymentmodel.auth_cv_result_raw);
                AddParameter("@SignedDateTime", paymentmodel.signed_date_time);
                AddParameter("@AuthCvResult", paymentmodel.auth_cv_result);
                AddParameter("@AuthAvsCodeRaw", paymentmodel.auth_avs_code_raw);
                AddParameter("@TransactionId", paymentmodel.transaction_id);
                AddParameter("@AuthTime", paymentmodel.auth_time);
                AddParameter("@Message", paymentmodel.message);
                AddParameter("@AuthTransRefNo", paymentmodel.auth_trans_ref_no);
                AddParameter("@SignatureVerified", paymentmodel.SignatureVerified);
                AddParameter("@AuthResponse", paymentmodel.auth_response);
                AddParameter("@PaymentMethod", paymentmodel.payment_method);
                AddParameter("@IsImageUnlock", paymentmodel.IsImageUnlock);
                AddParameter("@ErrorLog", paymentmodel.ErrorLog);
                AddParameter("@OrderSourceTypeId", paymentmodel.merchant_defined_data3);
                SaveData("[Partner].[uspUpdateOrderPaymentGatewayDetails]");
                return true;
            }
            catch { return false; }

        }
        public PaymentViewModel GetUserDetailsForPayment(long userId)
        {
            DBParameters.Clear();
            AddParameter("@UserID", userId);
            IDataReader sqlReader = ExecuteReader("[Partner].[uspGetPaymentUserDetail]");
            PaymentViewModel paymentViewModel = new PaymentViewModel();
            paymentViewModel.User = GetUserDetailsForPayment(sqlReader);
            sqlReader.Close();
            return paymentViewModel;
        }

        private Users GetUserDetailsForPayment(IDataReader sqlReader)
        {
            Users Users = new Users();
            while (sqlReader.Read())
            {
                Users.PartnerUserId = GetFieldValue(sqlReader, "PartnerUserId", 0L);
                Users.Email = GetFieldValue(sqlReader, "UserName", string.Empty);
                Users.FirstName = GetFieldValue(sqlReader, "FirstName", string.Empty);
                Users.LastName = GetFieldValue(sqlReader, "LastName", string.Empty);
                Users.Address = GetFieldValue(sqlReader, "Address1", string.Empty);
                Users.City = GetFieldValue(sqlReader, "City", string.Empty);
                Users.State = GetFieldValue(sqlReader, "State", string.Empty);
                Users.ZipCode = GetFieldValue(sqlReader, "Zip", string.Empty);
                Users.Country = GetFieldValue(sqlReader, "Country", string.Empty);
            }
            return Users;
        }

        public bool MarkedImageAsPaid(int WebPhotoID, long PartnerUserID, int SubStoreId)
        {
            try
            {
                DBParameters.Clear();
                AddParameter("@WebPhotoID", WebPhotoID);
                AddParameter("@PartnerUserId", PartnerUserID);
                AddParameter("@SubStoreId", SubStoreId);
                SaveData("[Partner].[usp_upd_MarkImageAsPaid]");
                return true;
            }
            catch { return false; }
        }
    }
}

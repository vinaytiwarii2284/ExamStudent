using Digiphoto.iMix.ClaimPortal.Common;
using Digiphoto.iMix.ClaimPortal.Model;
using ExamStudent.Filters;
using ExamStudent.Models;
using ExamStudent.ViewModel;
using ExamStudents.Business;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using State = Digiphoto.iMix.ClaimPortal.Model.State;

namespace ExamStudent.Controllers
{
    public class CheckoutController : BaseController
    {
        //
        // GET: /Checkout/
        //[Authorize]
        //[CustomFilter]
        [HttpGet]
        public ActionResult Index()
        {
            Cart cart = new Cart();
            CartBusiness cartBusiness = new CartBusiness();
            long PartnerUserID = Convert.ToInt64(Session[SessionConstants.SESSION_USERID]);
            cart = cartBusiness.GetCart(PartnerUserID);
            cart.CartLineItems = cartBusiness.GetCartItems(cart.CartID);
            if (cart.CartLineItems.Count > 0)
            {
                return RedirectToAction("Payment");
                //CheckoutViewModel checkoutViewModel = GetUserAddress(PartnerUserID);
                //return View("Index", checkoutViewModel);
            }
            return RedirectToAction("Index", "Cart");
        }
        [CustomFilter]
        public CheckoutViewModel GetUserAddress(Int64 userId)
        {
            CheckoutBusiness checkoutBusiness = new CheckoutBusiness();
            CheckoutViewModel checkoutViewModel = checkoutBusiness.GetUserAddress(userId);
            GetCountry();
            if (checkoutViewModel.ShippingAddress.Country != null)
            {
                GetState(checkoutViewModel.ShippingAddress.Country, checkoutViewModel.ShippingAddress.State);
            }
            return checkoutViewModel;
        }
        //[CustomFilter]
        [HttpPost, ValidateInput(false)]
        public ActionResult SaveUserAddress(CheckoutViewModel checkoutViewModel)
        {
            ModelState.Remove("User.Password");
            ModelState.Remove("User.ConfirmPassword");

            if (checkoutViewModel.User.UseBillingAsShipping == true)
            {
                ModelState.Remove("User.FirstName");
                ModelState.Remove("User.LastName");
                ModelState.Remove("User.Address");
                ModelState.Remove("User.City");
                ModelState.Remove("User.ZipCode");
                ModelState.Remove("User.Phone");
                ModelState.Remove("User.Email");
                ModelState.Remove("User.Gender");
                ModelState.Remove("User.Nationality");
                ModelState.Remove("User.Country");
                ModelState.Remove("User.DateOfBirth");
            }
            else
            {
                if (ModelState["User.Address"].Value.AttemptedValue == "")
                {
                    ModelState.AddModelError("User.Address", "Enter Address");
                }
                if (ModelState["User.City"].Value.AttemptedValue == "")
                {
                    ModelState.AddModelError("User.City", "Enter City");
                }
                if (ModelState["User.ZipCode"].Value.AttemptedValue == "")
                {
                    ModelState.AddModelError("User.ZipCode", "Enter ZipCode");
                }
                if (ModelState["User.Phone"].Value.AttemptedValue == "")
                {
                    ModelState.AddModelError("User.Phone", "Enter Phone Number");
                }
                ModelState.Remove("User.Gender");
                ModelState.Remove("User.Nationality");
                ModelState.Remove("User.Country");
                ModelState.Remove("User.DateOfBirth");
            }
            //  PaymentViewModel paymentViewModel = new PaymentViewModel();
            if (ModelState.IsValid)
            {
                CheckoutBusiness checkoutBusiness = new CheckoutBusiness();
                long PartnerUserID = Convert.ToInt64(Session[SessionConstants.SESSION_USERID]);
                checkoutViewModel.ShippingAddress.PartnerUserId = PartnerUserID;
                checkoutViewModel.User.PartnerUserId = PartnerUserID;
                checkoutBusiness.SaveUserAddress(checkoutViewModel);
                return RedirectToAction("Payment");
                // paymentViewModel = Payment();
            }
            else
            {
                GetCountry();
                return View("Index");
            }

            //return View("Payment");
        }
        //[CustomFilter]
        [HttpGet]
        public ActionResult GetCountry()
        {
            CheckoutBusiness checkoutBusiness = new CheckoutBusiness();
            ViewBag.CountryList = new SelectList(checkoutBusiness.GetCountryList(), "CommonName", "CommonName", "United Arab Emirates");
            ViewBag.StateList = new SelectList(string.Empty, "StateCode", "StateName");
            return View();
        }
        //[CustomFilter]
        [HttpPost]
        public ActionResult GetState(string CountryName, string StateName)
        {
            State state = new State();
            CheckoutBusiness checkoutBusiness = new CheckoutBusiness();
            SelectList StateList = new SelectList(checkoutBusiness.GetStatetList(CountryName), "StateName", "StateName", StateName);
            ViewBag.StateList = StateList;
            return Json(StateList);
        }
        //[CustomFilter]
        [HttpGet]
        public ActionResult Payment()
        {
            var LCID = System.Threading.Thread.CurrentThread.CurrentUICulture.LCID;
            long PartnerUserID = Convert.ToInt64(Session[SessionConstants.SESSION_USERID]);
            PaymentViewModel paymentViewModel = new PaymentViewModel();
            CheckoutBusiness checkoutBusiness = new CheckoutBusiness();
            CartBusiness cartBusiness = new CartBusiness();
            //paymentViewModel = checkoutBusiness.GetUserBillingAndShippingAddress(PartnerUserID);
            paymentViewModel.Cart = cartBusiness.GetCart(PartnerUserID);
            paymentViewModel.Cart.CartLineItems = cartBusiness.GetCartItems(paymentViewModel.Cart.CartID);
            //To get the shipping details
            //SelectList shippingList = new SelectList(checkoutBusiness.GetShippingDetails(LCID), "ShippingCostPrice", "ShippingName");
            //Payment payment = new Payment();
            //paymentViewModel.PaymentDetails = payment;

            List<Shipping> shippingList = new List<Shipping>();
            Shipping shipping = null;


            shipping = new Shipping();
            shipping.ShippingName = "Alahabad";
            shipping.ShippingCostPriceWithCurrency = "100INR";
            shippingList.Add(shipping);


            
            ViewBag.shipping = shippingList;
            return View("Payment", paymentViewModel);
        }
        //[CustomFilter]
        [HttpPost, ValidateInput(false)]
        public ActionResult PlaceOrder(PaymentViewModel paymentViewModel)
        {
            PaymentViewModel paymentViewModel1 = new PaymentViewModel();
            try
            {
                int PartnerId = Convert.ToInt32(ConfigurationManager.AppSettings["PartnerId"].ToString());
                //string substoreid = Session["SubStoreId"].ToString();
                //bool IsInt = substoreid.All(char.IsDigit);
                int subStoreId = Convert.ToInt32(Session["SubStoreId"]);//Convert.ToInt32(CommonUtility.DecryptQueryString(Session["SubStoreId"].ToString()));
                long PartnerUserID = Convert.ToInt64(Session[SessionConstants.SESSION_USERID]);
                Users user = new Users();
                user.PartnerUserId = PartnerUserID;

                CheckoutBusiness checkoutBusiness = new CheckoutBusiness();
                paymentViewModel1 = checkoutBusiness.GetUserBillingAndShippingAddress(PartnerUserID);

                CartBusiness cartBusiness = new CartBusiness();
                paymentViewModel.Cart = cartBusiness.GetCart(PartnerUserID);
                paymentViewModel.Cart.CartLineItems = cartBusiness.GetCartItems(paymentViewModel.Cart.CartID);
                paymentViewModel.Cart.Total(paymentViewModel.Cart.CartLineItems);
                List<OrderItem> orderItems = new List<OrderItem>();
                foreach (var item in paymentViewModel.Cart.CartLineItems)
                {
                    orderItems.Add(new OrderItem() { ProductID = item.Product.ProductID, ProductName = item.Product.ProductName, Quantity = item.Quantity, UnitPrice = item.Product.UnitPrice, PhotoID = item.PhotoId });
                }
                Order order = new Order()
                {
                    FirstName = paymentViewModel1.User.FirstName,
                    LastName = paymentViewModel1.User.LastName,
                    Address1 = paymentViewModel1.User.Address,
                    Address2 = paymentViewModel1.User.Address2,
                    City = paymentViewModel1.User.City,
                    State = paymentViewModel1.User.State,
                    Zip = paymentViewModel1.User.ZipCode,
                    Country = paymentViewModel1.User.Country,
                    Phone = paymentViewModel1.User.Phone,
                    //Fax =paymentViewModel1.User.Fax,
                    Email = paymentViewModel1.User.Email,

                    ShippingFirstName = paymentViewModel1.ShippingAddress.FirstName,
                    ShippingLastName = paymentViewModel1.ShippingAddress.LastName,
                    ShippingAddress1 = paymentViewModel1.ShippingAddress.Address,
                    ShippingAddress2 = paymentViewModel1.ShippingAddress.Address2,
                    ShippingCity = paymentViewModel1.ShippingAddress.City,
                    ShippingState = paymentViewModel1.ShippingAddress.State,
                    ShippingZip = paymentViewModel1.ShippingAddress.ZipCode,
                    ShippingCountry = paymentViewModel1.ShippingAddress.Country,
                    ShippingPhone = paymentViewModel1.ShippingAddress.Phone,
                    //Fax =paymentViewModel1.User.Fax,
                    //ShippingEmail =paymentViewModel1.ShippingAddress.Email
                    //ShippedDate
                    ShippingMethod = paymentViewModel.Shipping.ShippingName.Replace(',', '.'),
                    Cancelled = false,
                    Subtotal = paymentViewModel.Cart.TotalAmount(paymentViewModel.Cart.CartLineItems),
                    Tax = paymentViewModel.Tax,
                    ShippingCost = paymentViewModel.ShippingCost,
                    OrderItems = orderItems,
                    PartnerUserId = user.PartnerUserId
                };
                Int64 OrderId = checkoutBusiness.placeOrder(order, PartnerId);
                order.OrderId = OrderId;
                //if (order != null)
                //{
                //    SendOrderEmail(order);
                //}
                string strOrderId = OrderId.ToString();
                string EOrderId = CommonUtility.EncryptQueryString(strOrderId);
                //ViewBag.OrderId = strOrderId;
                paymentViewModel1.OrderId = OrderId;
                string CountryCode = "";// ((Country)(checkoutBusiness.GetCountryList().ToList().Where(o => o.CommonName == paymentViewModel1.User.Country)).FirstOrDefault()).CountryCode;
                ConfigurationBusiness configuration = new ConfigurationBusiness();
                Dictionary<int, ConfigurationValueInfo> configurationValues = configuration.ConfigurationValues(0, subStoreId, string.Empty);
                ConfigurationValueInfo configurationValue = configurationValues[Convert.ToInt32(ConfigurationMaster.PGCurrency)];

                paymentViewModel1.currency = (configurationValues[Convert.ToInt32(ConfigurationMaster.PGCurrency)]).ConfigurationValue;
                paymentViewModel1.locale = (configurationValues[Convert.ToInt32(ConfigurationMaster.PGLocale)]).ConfigurationValue;
                paymentViewModel1.access_key = (configurationValues[Convert.ToInt32(ConfigurationMaster.PGAccesskey)]).ConfigurationValue;
                paymentViewModel1.profile_id = (configurationValues[Convert.ToInt32(ConfigurationMaster.PGProfileId)]).ConfigurationValue;

                #region Setting For Live Account
                //paymentViewModel1.currency = "AED";
                //paymentViewModel1.access_key = "4b05f13e9dc23ddbb7a953837a6bb644";
                //paymentViewModel1.profile_id = "469E85E1-0E98-459D-BFB7-899102907EFE";

                #endregion
                paymentViewModel1.transaction_uuid = System.Guid.NewGuid().ToString();
                DateTime time = DateTime.Now.ToUniversalTime();
                paymentViewModel1.signed_date_time = time.ToString("yyyy-MM-dd'T'HH:mm:ss'Z'");
                if (order.Subtotal != 0)
                {
                    paymentViewModel1.amount = (order.Subtotal + order.Tax + order.ShippingCost).ToString();
                    if (paymentViewModel1.amount.Contains(','))
                        paymentViewModel1.amount = paymentViewModel1.amount.Replace(',', '.');
                }
                //paymentViewModel1.signed_field_names = "access_key,profile_id,transaction_uuid,signed_field_names,unsigned_field_names,signed_date_time,locale,payment_method,bill_to_address_country,bill_to_address_line1,bill_to_address_city,bill_to_email,bill_to_forename,bill_to_surname,bill_to_address_postal_code,transaction_type,reference_number,amount,currency,merchant_defined_data1";
                paymentViewModel1.signed_field_names = "access_key,profile_id,transaction_uuid,signed_field_names,unsigned_field_names,signed_date_time,locale,payment_method,bill_to_address_country,bill_to_address_line1,bill_to_address_city,bill_to_email,bill_to_forename,bill_to_surname,bill_to_address_postal_code,transaction_type,reference_number,amount,currency,merchant_defined_data1,merchant_defined_data2,merchant_defined_data3";
                paymentViewModel1.payment_method = "card";
                paymentViewModel1.transaction_type = "sale";
                //paymentViewModel1.access_key = "61f6ccd8ba563634a8be58aa23daa577";
                //paymentViewModel1.profile_id = "B29C6A04-B15F-4064-8A99-9648B2C66971";
                //paymentViewModel1.locale = "en";
                // paymentViewModel1.currency = "AED";
                paymentViewModel1.bill_to_forename = paymentViewModel1.User.FirstName;
                paymentViewModel1.bill_to_surname = paymentViewModel1.User.LastName;
                paymentViewModel1.bill_to_email = paymentViewModel1.User.Email;
                paymentViewModel1.bill_to_address_line1 = paymentViewModel1.User.Address;
                paymentViewModel1.bill_to_address_country = CountryCode;
                paymentViewModel1.bill_to_address_city = paymentViewModel1.User.City;
                paymentViewModel1.bill_to_address_state = paymentViewModel1.User.State;
                paymentViewModel1.bill_to_address_postal_code = paymentViewModel1.User.ZipCode;
                paymentViewModel1.unsigned_field_names = "";
                paymentViewModel1.merchant_defined_data1 = OrderId.ToString();
                paymentViewModel1.merchant_defined_data2 = paymentViewModel1.User.PartnerUserId.ToString();
                paymentViewModel1.merchant_defined_data3 = Convert.ToInt32(DeviceType.WebBrowser).ToString();
                paymentViewModel1.reference_number = GenerateRandomNumber(20, OrderId);
                paymentViewModel1.signature = GenerateSingnature(paymentViewModel1);

            }
            catch { }
            return View("Payment", paymentViewModel1);
        }
        private void SendOrderEmail(Order orderData)
        {
            /*
            var currCulture = System.Threading.Thread.CurrentThread.CurrentUICulture.Name.ToLowerInvariant();
            var LCID = System.Threading.Thread.CurrentThread.CurrentUICulture.LCID;
            Commdel.EmailUtility.Model.ViewModel.OrderDetailsViewModel orderdetail = new Commdel.EmailUtility.Model.ViewModel.OrderDetailsViewModel();
            orderdetail.ApplicationId = Convert.ToInt32(Commdel.EmailUtility.EmailApplication.DigiphotoApplication);
            orderdetail.TemplateType = Commdel.EmailUtility.EmailTemplate.OrderSummary;
            orderdetail.LanguageId = LCID;
            Commdel.EmailUtility.Model.DataModel.Order emailOrder = new Commdel.EmailUtility.Model.DataModel.Order();
            emailOrder.OrderId = orderData.OrderId;

            emailOrder.Currency = orderData.Currency;
            emailOrder.CategoryId = orderData.CategoryId;
            emailOrder.OrderDate = orderData.OrderDate;
            emailOrder.OrderNumber = orderData.OrderNumber;
            emailOrder.OrderStatus = orderData.OrderStatus;
            emailOrder.OrderStatusMsg = orderData.OrderStatusMsg;
            emailOrder.PaymentStatus = orderData.PaymentStatus;
            emailOrder.transaction_id = orderData.transaction_id;

            emailOrder.FirstName = orderData.FirstName;
            emailOrder.LastName = orderData.LastName;
            emailOrder.Address1 = orderData.Address1;
            emailOrder.Address2 = orderData.Address2;
            emailOrder.City = orderData.City;
            emailOrder.State = orderData.State;
            emailOrder.Zip = orderData.Zip;
            emailOrder.Country = orderData.Country;
            emailOrder.Phone = orderData.Phone;
            emailOrder.Email = orderData.Email;

            #region MultilangualTextChangeForMailBody
            emailOrder.Order_No = Common.Resources.en_US.PaymentReceiptViewOrderNo;
            emailOrder.Order_Date = Common.Resources.en_US.PaymentReceiptViewOrderDate;
            emailOrder.Payment_Information = Common.Resources.en_US.PaymentReceiptViewpaymentInformation;
            emailOrder.Payment_status = Common.Resources.en_US.ThankYouViewPaymentStatusText;
            emailOrder.Transaction_RefNo = Common.Resources.en_US.PaymentReceiptViewTrackingNumber;
            emailOrder.Product_ID = Common.Resources.en_US.EditPhoto1ViewProducts + "ID";
            emailOrder.Product_Name = Common.Resources.en_US.PaymentReceiptViewProductName;
            emailOrder.Unit_Price = Common.Resources.en_US.PaymentReceiptViewUnitPrice;
            emailOrder.Quantity = Common.Resources.en_US.CartViewQuantityText;
            emailOrder.Total_Text = Common.Resources.en_US.PaymentReceiptViewTotal;
            emailOrder.Inclusive_all_taxes_Msg = Common.Resources.en_US.InclusiveAllTaxesMsg;
            emailOrder.Address_details = Common.Resources.en_US.Addressdetails;
            emailOrder.Shipping_Information = Common.Resources.en_US.ThankYouViewShippingInformation;
            emailOrder.Billing_Information = Common.Resources.en_US.ThankYouViewFaxBillingInformation;
            emailOrder.First_Name = Common.Resources.en_US.UserDetailModelFirstNameText;
            emailOrder.Last_Name = Common.Resources.en_US.UserDetailModelLastNameText;
            emailOrder.Address = Common.Resources.en_US.IndexViewAddress;
            emailOrder.Address2_Text = Common.Resources.en_US.IndexViewAddress2;
            emailOrder.City_Text = Common.Resources.en_US.IndexViewCity;
            emailOrder.State_Text = Common.Resources.en_US.IndexViewState;
            emailOrder.Country_Text = Common.Resources.en_US.IndexViewCountry;
            emailOrder.Zip_Code = Common.Resources.en_US.IndexViewZipCode;
            emailOrder.Email_Text = Common.Resources.en_US.IndexViewEmail;
            emailOrder.Phone_Text = Common.Resources.en_US.IndexViewPhone;
            emailOrder.Dear_Text = Common.Resources.en_US.DearText;
            emailOrder.Regards = Common.Resources.en_US.KindRegards;
            emailOrder.PartnerName = Common.Resources.en_US.mySnapps;
            #endregion

            emailOrder.ShippingFirstName = orderData.ShippingFirstName;
            emailOrder.ShippingLastName = orderData.ShippingLastName;
            emailOrder.ShippingAddress1 = orderData.ShippingAddress1;
            emailOrder.ShippingAddress2 = orderData.ShippingAddress2;
            emailOrder.ShippingCity = orderData.ShippingCity;
            emailOrder.ShippingState = orderData.ShippingState;
            emailOrder.ShippingZip = orderData.ShippingZip;
            emailOrder.ShippingCountry = orderData.ShippingCountry;
            emailOrder.ShippingPhone = orderData.ShippingPhone;

            emailOrder.ShippingMethod = orderData.ShippingMethod;
            emailOrder.Tax = orderData.Tax;
            emailOrder.ShippingCost = orderData.ShippingCost;

            emailOrder.Subtotal = orderData.Subtotal;
            List<Commdel.EmailUtility.Model.DataModel.OrderItem> orderItems = new List<Commdel.EmailUtility.Model.DataModel.OrderItem>();
            foreach (OrderItem item in orderData.OrderItems)
            {
                Commdel.EmailUtility.Model.DataModel.OrderItem emailModelItem = new Commdel.EmailUtility.Model.DataModel.OrderItem();
                emailModelItem.Currency = item.Currency;
                emailModelItem.ProductID = item.ProductID;
                emailModelItem.ProductName = item.ProductName;
                emailModelItem.Quantity = item.Quantity;
                emailModelItem.UnitPrice = item.UnitPrice;
                //emailModelItem.UnitPriceWithCurrency = item.UnitPriceWithCurrency;
                orderItems.Add(emailModelItem);

            }
            emailOrder.OrderItems = orderItems;
            orderdetail.Order = emailOrder;
            string fileName = orderData.OrderId + "_" + DateTime.Now.ToString(@"dd-MMM-yyyy");
            string name = fileName + ".pdf";
            //var pdfResult = new Rotativa.PartialViewAsPdf("_PaymentDetail", orderData) { FileName = name, PageSize = Rotativa.Options.Size.A4, };
            var pdfResult = new Rotativa.PartialViewAsPdf("_PrintOrderDetails", orderData) { FileName = name, PageSize = Rotativa.Options.Size.A4, };
            var binary = pdfResult.BuildPdf(this.ControllerContext);
            //string pdfPath = ConfigurationManager.AppSettings["OrderPDFPath"].ToString();
            if (!Directory.Exists(Server.MapPath(ConfigurationManager.AppSettings["OrderPDFPath"].ToString())))
            {
                Directory.CreateDirectory(Server.MapPath(ConfigurationManager.AppSettings["OrderPDFPath"].ToString()));
            }
            string combinePath = Path.Combine(ConfigurationManager.AppSettings["OrderPDFPath"].ToString(), Path.GetFileName(name));
            string physicalPath = Server.MapPath(combinePath);

            //FileStream stream = new FileStream(physicalPath, FileMode.Create, FileAccess.ReadWrite);
            //stream.Write(binary, 0, binary.Length);
            //stream.Close();            
            System.IO.File.WriteAllBytes(physicalPath, binary);
            orderdetail.OrderPdfPath = physicalPath;
            Commdel.EmailUtility.Email.AddOrderDetailsEmail(orderdetail);
            */
        }
        //[CustomFilter]
        public ActionResult Receipt(string id)
        {
            Order order = new Order();
            try
            {
                string DOrderId = CommonUtility.DecryptQueryString(id);
                CheckoutBusiness checkoutBusiness = new CheckoutBusiness();
                order = checkoutBusiness.GetOrderById(Convert.ToInt64(DOrderId));
                #region Set Requesting Page URL
                if (Convert.ToInt32(Session["CategoryID"]) != 0)
                    order.CategoryId = Convert.ToInt32(Session["CategoryID"]);

                if (!string.IsNullOrEmpty((string)Session["RequestedPage"]))
                {
                    if (Convert.ToString(Session["RequestedPage"]) == "ViewSubStorePhotos")
                    {
                        string substoreID = Session["SubStoreId"].ToString();
                        ViewBag.PreviousAction = "/SubStores/ViewSubStorePhotos?SubStoreId=" + CommonUtility.EncryptQueryString(substoreID);
                    }
                    else if (Convert.ToString(Session["RequestedPage"]) == "EditPhoto")
                    {
                        if (Session["PhotoId"] != null && Session["SubStoreId"] != null)
                        {
                            ViewBag.PreviousAction = "/EditPhoto/EditPhoto?PhotoId=" + Session["PhotoId"] + "&SubStoreId=" + Session["SubStoreId"];
                        }
                        else
                        {
                            if (Request.UrlReferrer != null)
                            {
                                ViewBag.PreviousAction = "/SubStores/ViewSubStores";
                            }
                        }
                    }
                    else
                    {
                        if (Request.UrlReferrer != null)
                        {
                            ViewBag.PreviousAction = "/SubStores/ViewSubStores";
                        }
                    }
                }
                else
                {
                    if (Request.UrlReferrer != null)
                    {
                        ViewBag.PreviousAction = "/SubStores/ViewSubStores";

                    }
                }
                #endregion
                if (order.decision.ToUpper() == PaymentDecision.Accept)
                {
                    order.OrderStatus = GateWayResponse.ACCEPT;
                    order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.ACCEPT;
                    //order.PaymentStatus = PaymentStatusMsg.SUCCESS.Replace("{money}", order.auth_amount.ToString("c"));
                    order.PaymentStatus = PaymentStatusMsg.CurrentInstance.SUCCESS.Replace("{money}", Convert.ToString(order.auth_amount.ToString("0.00") + " " + order.Currency));
                }
                else if (order.decision.ToUpper() == PaymentDecision.Reject)
                {
                    order.OrderStatus = GateWayResponse.REJECT; ;
                    order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.REJECT;
                    order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
                }
                else if (order.decision.ToUpper() == PaymentDecision.Error)
                {
                    order.OrderStatus = GateWayResponse.ERROR;
                    order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.ERROR;
                    order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
                }
                else if (order.decision.ToUpper() == PaymentDecision.Review)
                {
                    order.OrderStatus = GateWayResponse.REVIEW;
                    order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.REVIEW;
                    order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
                }
                else if (order.decision.ToUpper() == PaymentDecision.Cancel)
                {
                    order.OrderStatus = GateWayResponse.CANCEL;
                    order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.CANCEL;
                    order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
                }
                else
                {
                    order.OrderStatus = GateWayResponse.ERROR;
                    order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.ERROR;
                    order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
                }
                if (order != null)
                {
                    SendOrderEmail(order);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("because it is being used by another process"))
                {
                    //throw ex;
                }
                else
                {
                    order.OrderStatus = GateWayResponse.ERROR;
                    order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.ERROR;
                    order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
                }
            }
            return View("ThankYou", order);
        }
        //[CustomFilter]
        public ActionResult Receipts(string id)
        {
            Order order = new Order();
            try
            {
                string DOrderId = CommonUtility.DecryptQueryString(id);
                CheckoutBusiness checkoutBusiness = new CheckoutBusiness();
                order = checkoutBusiness.GetOrderById(Convert.ToInt64(DOrderId));
                #region Set Requesting Page URL
                ViewBag.PreviousAction = "/SubStores/ViewSubStores";
                //if (Convert.ToInt32(Session["CategoryID"]) != 0)
                //    order.CategoryId = Convert.ToInt32(Session["CategoryID"]);
                #endregion
                if (order.decision.ToUpper() == PaymentDecision.Accept)
                {
                    order.OrderStatus = GateWayResponse.ACCEPT;
                    order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.ACCEPT;
                    //order.PaymentStatus = PaymentStatusMsg.SUCCESS.Replace("{money}", order.auth_amount.ToString("c"));
                    order.PaymentStatus = PaymentStatusMsg.CurrentInstance.SUCCESS.Replace("{money}", Convert.ToString(order.auth_amount.ToString("0.00") + " " + order.Currency));
                }
                else if (order.decision.ToUpper() == PaymentDecision.Reject)
                {
                    order.OrderStatus = GateWayResponse.REJECT; ;
                    order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.REJECT;
                    order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
                }
                else if (order.decision.ToUpper() == PaymentDecision.Error)
                {
                    order.OrderStatus = GateWayResponse.ERROR;
                    order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.ERROR;
                    order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
                }
                else if (order.decision.ToUpper() == PaymentDecision.Review)
                {
                    order.OrderStatus = GateWayResponse.REVIEW;
                    order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.REVIEW;
                    order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
                }
                else if (order.decision.ToUpper() == PaymentDecision.Cancel)
                {
                    order.OrderStatus = GateWayResponse.CANCEL;
                    order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.CANCEL;
                    order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
                }
                else
                {
                    order.OrderStatus = GateWayResponse.ERROR;
                    order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.ERROR;
                    order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
                }
            }
            catch (Exception ex)
            {
                order.OrderStatus = GateWayResponse.ERROR;
                order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.ERROR;
                order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
            }
            return View("ThankYou", order);
        }
        [AllowAnonymous]
        public ActionResult MobileReceipt(string id)
        {
            Order order = new Order();
            try
            {
                string DOrderId = CommonUtility.DecryptQueryString(id);
                ViewBag.CloseMobileReceiptPath = ConfigurationManager.AppSettings["CloseMobileReceiptPath"].ToString();
                CheckoutBusiness checkoutBusiness = new CheckoutBusiness();
                order = checkoutBusiness.GetOrderById(Convert.ToInt64(DOrderId));
                #region Set Requesting Page URL
                //if (Convert.ToInt32(Session["CategoryID"]) != 0)
                //    order.CategoryId = Convert.ToInt32(Session["CategoryID"]);

                //if (!string.IsNullOrEmpty((string)Session["RequestedPage"]))
                //{
                //    if (Convert.ToString(Session["RequestedPage"]) == "ViewSubStorePhotos")
                //    {
                //        string substoreID = Session["SubStoreId"].ToString();
                //        ViewBag.PreviousAction = "/SubStores/ViewSubStorePhotos?SubStoreId=" + substoreID;
                //    }
                //    else if (Convert.ToString(Session["RequestedPage"]) == "EditPhoto")
                //    {
                //        if (Session["PhotoId"] != null && Session["SubStoreId"] != null)
                //        {
                //            ViewBag.PreviousAction = "/EditPhoto/EditPhoto?PhotoId=" + Session["PhotoId"] + "&SubStoreId=" + Session["SubStoreId"];
                //        }
                //        else
                //        {
                //            if (Request.UrlReferrer != null)
                //            {
                //                ViewBag.PreviousAction = "/SubStores/ViewSubStores";
                //            }
                //        }
                //    }
                //    else
                //    {
                //        if (Request.UrlReferrer != null)
                //        {
                //            ViewBag.PreviousAction = "/SubStores/ViewSubStores";
                //        }
                //    }
                //}
                //else
                //{
                //    if (Request.UrlReferrer != null)
                //    {
                //        ViewBag.PreviousAction = "/SubStores/ViewSubStores";

                //    }
                //}
                #endregion
                if (order.decision == PaymentDecision.Accept)
                {
                    order.OrderStatus = GateWayResponse.ACCEPT;
                    order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.ACCEPT;
                    //order.PaymentStatus = PaymentStatusMsg.SUCCESS.Replace("{money}", order.Currency + order.auth_amount.ToString());
                    order.PaymentStatus = PaymentStatusMsg.CurrentInstance.SUCCESS.Replace("{money}", Convert.ToString(order.auth_amount.ToString("0.00") + " " + order.Currency));
                }
                else if (order.decision == PaymentDecision.Reject)
                {
                    order.OrderStatus = GateWayResponse.REJECT; ;
                    order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.REJECT;
                    order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
                }
                else if (order.decision == PaymentDecision.Error)
                {
                    order.OrderStatus = GateWayResponse.ERROR;
                    order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.ERROR;
                    order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
                }
                else if (order.decision == PaymentDecision.Review)
                {
                    order.OrderStatus = GateWayResponse.REVIEW;
                    order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.REVIEW;
                    order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
                }
                else if (order.decision == PaymentDecision.Cancel)
                {
                    order.OrderStatus = GateWayResponse.CANCEL;
                    order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.CANCEL;
                    order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
                }
                else
                {
                    order.OrderStatus = GateWayResponse.ERROR;
                    order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.ERROR;
                    order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
                }
                if (order != null)
                {
                    SendOrderEmail(order);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("because it is being used by another process"))
                {
                    //throw ex;
                }
                else
                {
                    order.OrderStatus = GateWayResponse.ERROR;
                    order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.ERROR;
                    order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
                }
                //throw ex;
            }
            return View("ThankYouMobile", order);
        }
        //[CustomFilter]
        [HttpGet]
        public ActionResult Result(string ProductID, string requestedPage, string msg)
        {
            if (requestedPage == "ViewSubStorePhotos")
            {
                string substoreID = Session["SubStoreId"].ToString();
                ViewBag.PreviousAction = "/SubStores/ViewSubStorePhotos?SubStoreId=" + substoreID;
            }
            else
            {
                string[] str = ProductID.Split('^');
                string photoid = str[1];
                string substoreID = Session["SubStoreId"].ToString();
                if (Session["PhotoId"] != null && Session["SubStoreId"] != null)
                {
                    ViewBag.PreviousAction = "/EditPhoto/EditPhoto?PhotoId=" + photoid + "&SubStoreId=" + Session["SubStoreId"];
                    // ViewBag.PreviousAction = Request.UrlReferrer.AbsoluteUri.Replace(Request.UrlReferrer.PathAndQuery, "/EditPhoto/EditPhoto?PhotoId=" + Session["PhotoId"] + "&SubStoreId=" + Session["SubStoreId"]);
                }
                else
                {
                    if (Request.UrlReferrer != null)
                    {
                        ViewBag.PreviousAction = "/SubStores/ViewSubStores";
                        //ViewBag.PreviousAction = Request.UrlReferrer.AbsoluteUri.Replace(Request.UrlReferrer.PathAndQuery, "/SubStores/ViewSubStores");
                    }
                }

            }
            //ViewBag.ProductID = ProductID;
            //ViewBag.RequestedPage = requestedPage;
            ViewBag.Message = msg;
            return View();
        }
        //[CustomFilter]
        [HttpGet]
        public ActionResult PaymentReceipt(string id)
        {

            Order order = new Order();
            Int64 iOrderId = 0;
            CheckoutBusiness checkoutBusiness = new CheckoutBusiness();
            if (!string.IsNullOrEmpty(id))
                iOrderId = Convert.ToInt64(CommonUtility.DecryptQueryString(id));
            order = checkoutBusiness.GetOrderById(iOrderId);
            if (Convert.ToInt32(Session["CategoryID"]) != 0)
                order.CategoryId = Convert.ToInt32(Session["CategoryID"]);
            if (order.decision == PaymentDecision.Accept)
            {
                order.OrderStatus = GateWayResponse.ACCEPT;
                order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.ACCEPT;
                //order.PaymentStatus = PaymentStatusMsg.SUCCESS.Replace("{money}", order.auth_amount.ToString("c"));
                order.PaymentStatus = PaymentStatusMsg.CurrentInstance.SUCCESS.Replace("{money}", Convert.ToString(order.auth_amount.ToString("0.00") + " " + order.Currency));
            }
            else if (order.decision == PaymentDecision.Reject)
            {
                order.OrderStatus = GateWayResponse.REJECT; ;
                order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.REJECT;
                order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
            }
            else if (order.decision == PaymentDecision.Error)
            {
                order.OrderStatus = GateWayResponse.ERROR;
                order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.ERROR;
                order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
            }
            else if (order.decision == PaymentDecision.Review)
            {
                order.OrderStatus = GateWayResponse.REVIEW;
                order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.REVIEW;
                order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
            }
            else if (order.decision == PaymentDecision.Cancel)
            {
                order.OrderStatus = GateWayResponse.CANCEL;
                order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.CANCEL;
                order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
            }
            return View("PaymentReceipt", order);
        }
        //[CustomFilter]
        public ActionResult PrintOrder(string id)
        {

            Order order = new Order();
            Int64 iOrderId = 0;
            CheckoutBusiness checkoutBusiness = new CheckoutBusiness();
            if (!string.IsNullOrEmpty(id))
                iOrderId = Convert.ToInt64(CommonUtility.DecryptQueryString(id));
            order = checkoutBusiness.GetOrderById(iOrderId);
            if (Convert.ToInt32(Session["CategoryID"]) != 0)
                order.CategoryId = Convert.ToInt32(Session["CategoryID"]);
            if (order.decision == PaymentDecision.Accept)
            {
                order.OrderStatus = GateWayResponse.ACCEPT;
                order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.ACCEPT;
                //order.PaymentStatus = PaymentStatusMsg.SUCCESS.Replace("{money}", order.auth_amount.ToString("c"));
                order.PaymentStatus = PaymentStatusMsg.CurrentInstance.SUCCESS.Replace("{money}", Convert.ToString(order.auth_amount.ToString("0.00") + " " + order.Currency));
            }
            else if (order.decision == PaymentDecision.Reject)
            {
                order.OrderStatus = GateWayResponse.REJECT; ;
                order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.REJECT;
                order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
            }
            else if (order.decision == PaymentDecision.Error)
            {
                order.OrderStatus = GateWayResponse.ERROR;
                order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.ERROR;
                order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
            }
            else if (order.decision == PaymentDecision.Review)
            {
                order.OrderStatus = GateWayResponse.REVIEW;
                order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.REVIEW;
                order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
            }
            else if (order.decision == PaymentDecision.Cancel)
            {
                order.OrderStatus = GateWayResponse.CANCEL;
                order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.CANCEL;
                order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
            }
            else
            {
                order.OrderStatus = GateWayResponse.ERROR;
                order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.ERROR;
                order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
            }
            return View("PrintOrder", order);
        }

        private string GenerateSingnature(PaymentViewModel paymentmodel)
        {
            string signature = string.Empty;
            IList<string> dataToSign = new List<string>();
            dataToSign.Add("access_key" + "=" + paymentmodel.access_key);
            dataToSign.Add("profile_id" + "=" + paymentmodel.profile_id);
            dataToSign.Add("transaction_uuid" + "=" + paymentmodel.transaction_uuid);
            dataToSign.Add("signed_field_names" + "=" + paymentmodel.signed_field_names);
            dataToSign.Add("unsigned_field_names" + "=" + paymentmodel.unsigned_field_names);
            dataToSign.Add("signed_date_time" + "=" + paymentmodel.signed_date_time);
            dataToSign.Add("locale" + "=" + paymentmodel.locale);
            dataToSign.Add("payment_method" + "=" + paymentmodel.payment_method);
            dataToSign.Add("bill_to_address_country" + "=" + paymentmodel.bill_to_address_country);
            dataToSign.Add("bill_to_address_line1" + "=" + paymentmodel.bill_to_address_line1);
            dataToSign.Add("bill_to_address_city" + "=" + paymentmodel.bill_to_address_city);
            dataToSign.Add("bill_to_email" + "=" + paymentmodel.bill_to_email);
            dataToSign.Add("bill_to_forename" + "=" + paymentmodel.bill_to_forename);
            dataToSign.Add("bill_to_surname" + "=" + paymentmodel.bill_to_surname);
            dataToSign.Add("bill_to_address_postal_code" + "=" + paymentmodel.bill_to_address_postal_code);
            dataToSign.Add("transaction_type" + "=" + paymentmodel.transaction_type);
            dataToSign.Add("reference_number" + "=" + paymentmodel.reference_number);
            dataToSign.Add("amount" + "=" + paymentmodel.amount);
            dataToSign.Add("currency" + "=" + paymentmodel.currency);
            dataToSign.Add("merchant_defined_data1" + "=" + paymentmodel.merchant_defined_data1);
            dataToSign.Add("merchant_defined_data2" + "=" + paymentmodel.merchant_defined_data2);
            dataToSign.Add("merchant_defined_data3" + "=" + paymentmodel.merchant_defined_data3);
            signature = Security.sign(dataToSign);
            return signature;
        }
        private string GenerateRandomNumber(int length, long orderId)
        {
            string newPwd = string.Empty;
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            string result = new string(
                Enumerable.Repeat(chars, length)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result + "-" + orderId;
        }
        [AllowAnonymous]
        public ActionResult CapturePaymentGatewayResponse()
        {
            Order order = new Order();
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            PaymentViewModel paymentview = new PaymentViewModel();
            CheckoutBusiness checkoutBusiness = new CheckoutBusiness();
            //Request.Form.AllKeys received data from payment gateway
            try
            {
                foreach (var key in Request.Form.AllKeys)
                {
                    parameters.Add(key, Request.Params[key]);
                }
                paymentview.transaction_type = parameters["req_transaction_type"];
                paymentview.transaction_uuid = parameters["req_transaction_uuid"];
                paymentview.signed_field_names = parameters["signed_field_names"];
                paymentview.access_key = parameters["req_access_key"];
                paymentview.locale = parameters["req_locale"];
                paymentview.amount = parameters["req_amount"];
                paymentview.profile_id = parameters["req_profile_id"];
                paymentview.reference_number = parameters["req_reference_number"];
                paymentview.signed_date_time = parameters["signed_date_time"];
                paymentview.currency = parameters["req_currency"];
                paymentview.decision = parameters["decision"];
                paymentview.message = parameters["message"];
                paymentview.merchant_defined_data1 = parameters["req_merchant_defined_data1"];
                paymentview.merchant_defined_data2 = parameters["req_merchant_defined_data2"];
                paymentview.merchant_defined_data3 = parameters["req_merchant_defined_data3"];
                paymentview.payment_method = parameters["req_payment_method"];
                if (paymentview.decision != "CANCEL" && paymentview.decision != "ERROR" && paymentview.decision != "DECLINE")
                {
                    paymentview.auth_avs_code = parameters["auth_avs_code"];
                    paymentview.req_card_number = parameters["req_card_number"];
                    paymentview.req_card_expiry_date = parameters["req_card_expiry_date"];
                    paymentview.bill_trans_ref_no = parameters["bill_trans_ref_no"];
                    paymentview.payer_authentication_proof_xml = parameters["payer_authentication_proof_xml"];
                    paymentview.auth_code = parameters["auth_code"];
                    paymentview.reason_code = Convert.ToInt32(parameters["reason_code"]);
                    paymentview.req_card_type = Convert.ToInt32(parameters["req_card_type"]);
                    paymentview.auth_amount = Convert.ToDecimal(parameters["auth_amount"], CultureInfo.InvariantCulture);
                    paymentview.auth_cv_result_raw = parameters["auth_cv_result_raw"];
                    paymentview.auth_cv_result = parameters["auth_cv_result"];
                    paymentview.auth_avs_code_raw = parameters["auth_avs_code_raw"];
                    paymentview.transaction_id = parameters["transaction_id"];
                    paymentview.auth_time = parameters["auth_time"];
                    paymentview.auth_response = parameters["auth_response"];
                    paymentview.auth_trans_ref_no = parameters["auth_trans_ref_no"];

                }
                //code to filter orderID
                if (paymentview.merchant_defined_data1.Contains("ViewSubStorePhotos"))
                {
                    string[] str = paymentview.merchant_defined_data1.Split('^');
                    paymentview.OrderId = Convert.ToInt64(str[0]);
                    Session["RequestedPage"] = "ViewSubStorePhotos";
                }
                else if (paymentview.merchant_defined_data1.Contains("EditPhoto"))
                {
                    string[] str = paymentview.merchant_defined_data1.Split('^');
                    paymentview.OrderId = Convert.ToInt64(str[0]);
                    Session["RequestedPage"] = "EditPhoto";
                    Session["PhotoId"] = str[1];
                }
                else
                {
                    paymentview.OrderId = Convert.ToInt64(paymentview.merchant_defined_data1);
                }
                //endcode below code comment on 22/2/2016 for above code
                //paymentview.OrderId = Convert.ToInt64(paymentview.merchant_defined_data1);
                paymentview.signature = parameters["signature"];
                paymentview.SignatureVerified = Request.Params["signature"].Equals(Security.sign(parameters));
                //Update all feilds returned from payment gateway to Digiphoto Database.          
                try
                {
                    if (paymentview.decision == PaymentDecision.Accept)
                    {
                        long PartnerUserID = Convert.ToInt64(Session[SessionConstants.SESSION_USERID]);
                        if (Convert.ToInt16(ProductCategory.OnlineProducts) == Convert.ToInt16(Session["CategoryID"]) && Convert.ToInt32(Session["MaxImageCount"]) == 1)
                        {
                            paymentview.IsImageUnlock = checkoutBusiness.MarkedImageAsPaid(Convert.ToInt32(Session["PhotoId"]), PartnerUserID, Convert.ToInt32(Session["SubStoreId"]));
                        }
                        else if (Convert.ToInt16(ProductCategory.OnlineProducts) == Convert.ToInt16(Session["CategoryID"]) && Convert.ToInt32(Session["MaxImageCount"]) > 1)
                        {
                            if (Convert.ToString(Session["RequestedPage"]) == "ViewSubStorePhotos")
                            {
                                paymentview.IsImageUnlock = checkoutBusiness.MarkedImageAsPaid(0, PartnerUserID, Convert.ToInt32(Session["SubStoreId"].ToString()));
                            }
                            else
                            {
                                paymentview.IsImageUnlock = checkoutBusiness.MarkedImageAsPaid(0, PartnerUserID, Convert.ToInt32(Session["SubStoreId"].ToString()));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    #region Update [IsPaidImage] & [IsImageUnlock] even if any exception has been occured and decision==true
                    paymentview.IsImageUnlock = false;
                    paymentview.ErrorLog = ex.Message;
                    #endregion
                }
            }
            catch (Exception ex)
            {
                #region Update [IsPaidImage] & [IsImageUnlock] even if any exception has been occured and decision==true
                paymentview.IsImageUnlock = false;
                paymentview.ErrorLog = ex.Message;
                #endregion
            }
            checkoutBusiness.UpdateOrderDetails(paymentview);
            string EOrderId = CommonUtility.EncryptQueryString(paymentview.OrderId.ToString());
            if (paymentview.merchant_defined_data3 == ((int)DeviceType.MobileApp).ToString())
            {
                TempData["EmailSendMobile"] = true;
                Session[SessionConstants.SESSION_CURRENCY] = paymentview.currency;
                return this.RedirectToAction("MobileReceipt", new { Id = EOrderId });
            }
            else
            {
                TempData["EmailSendWeb"] = true;
                return this.RedirectToAction("Receipt", new { Id = EOrderId });
            }

        }

        //public ActionResult GeneratePdf(Order order)
        //{
        //    string fileName = order.OrderId + "_" + DateTime.Now.ToString(@"dd-MMM-yyyy");
        //    string name = fileName + ".pdf";
        //    return new Rotativa.PartialViewAsPdf("_PaymentDetail", order) { FileName = name, PageSize = Rotativa.Options.Size.A4, };
        //}
        //[CustomFilter]
        public ActionResult GeneratePdf(Order order)
        {
            CheckoutBusiness checkoutBusiness = new CheckoutBusiness();
            if (order.OrderId != 0)
                order = checkoutBusiness.GetOrderById(order.OrderId);
            if (Convert.ToInt32(Session["CategoryID"]) != 0)
                order.CategoryId = Convert.ToInt32(Session["CategoryID"]);
            if (order.decision == PaymentDecision.Accept)
            {
                order.OrderStatus = GateWayResponse.ACCEPT;
                order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.ACCEPT;
                //order.PaymentStatus = PaymentStatusMsg.SUCCESS.Replace("{money}", order.auth_amount.ToString("c"));
                order.PaymentStatus = PaymentStatusMsg.CurrentInstance.SUCCESS.Replace("{money}", Convert.ToString(order.auth_amount.ToString("0.00") + " " + order.Currency));
            }
            else if (order.decision == PaymentDecision.Reject)
            {
                order.OrderStatus = GateWayResponse.REJECT; ;
                order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.REJECT;
                order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
            }
            else if (order.decision == PaymentDecision.Error)
            {
                order.OrderStatus = GateWayResponse.ERROR;
                order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.ERROR;
                order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
            }
            else if (order.decision == PaymentDecision.Review)
            {
                order.OrderStatus = GateWayResponse.REVIEW;
                order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.REVIEW;
                order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
            }
            else if (order.decision == PaymentDecision.Cancel)
            {
                order.OrderStatus = GateWayResponse.CANCEL;
                order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.CANCEL;
                order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
            }
            //else
            //{
            //    order.OrderStatus = GateWayResponse.ERROR;
            //    order.OrderStatusMsg = GateWayResponseMsg.ERROR;
            //    order.PaymentStatus = PaymentStatusMsg.FAILED.Replace("{money}", order.PayableAmount);
            //}
            string fileName = order.OrderId + "_" + DateTime.Now.ToString(@"dd-MMM-yyyy");
            string name = fileName + ".pdf";
            //return new Rotativa.PartialViewAsPdf("_PaymentDetail", order) { FileName = name, PageSize = Rotativa.Options.Size.A4, };
            return new Rotativa.PartialViewAsPdf("_PrintOrderDetails", order) { FileName = name, PageSize = Rotativa.Options.Size.A4, };
        }

        [AllowAnonymous]
        public ActionResult GeneratePdfMobile(Order order)
        {
            CheckoutBusiness checkoutBusiness = new CheckoutBusiness();
            ViewBag.CloseMobileReceiptPath = ConfigurationManager.AppSettings["CloseMobileReceiptPath"].ToString();
            if (order.OrderId != 0)
                order = checkoutBusiness.GetOrderById(order.OrderId);
            //if (Convert.ToInt32(Session["CategoryID"]) != 0)
            //    order.CategoryId = Convert.ToInt32(Session["CategoryID"]);
            if (order.decision == PaymentDecision.Accept)
            {
                order.OrderStatus = GateWayResponse.ACCEPT;
                order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.ACCEPT;
                //order.PaymentStatus = PaymentStatusMsg.SUCCESS.Replace("{money}", order.Currency + order.auth_amount.ToString());
                order.PaymentStatus = PaymentStatusMsg.CurrentInstance.SUCCESS.Replace("{money}", Convert.ToString(order.auth_amount.ToString("0.00") + " " + order.Currency));
            }
            else if (order.decision == PaymentDecision.Reject)
            {
                order.OrderStatus = GateWayResponse.REJECT; ;
                order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.REJECT;
                order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
            }
            else if (order.decision == PaymentDecision.Error)
            {
                order.OrderStatus = GateWayResponse.ERROR;
                order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.ERROR;
                order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
            }
            else if (order.decision == PaymentDecision.Review)
            {
                order.OrderStatus = GateWayResponse.REVIEW;
                order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.REVIEW;
                order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
            }
            else if (order.decision == PaymentDecision.Cancel)
            {
                order.OrderStatus = GateWayResponse.CANCEL;
                order.OrderStatusMsg = GateWayResponseMsg.CurrentInstance.CANCEL;
                order.PaymentStatus = PaymentStatusMsg.CurrentInstance.FAILED.Replace("{money}", order.PayableAmount);
            }
            string fileName = order.OrderId + "_" + DateTime.Now.ToString(@"dd-MMM-yyyy");
            string name = fileName + ".pdf";
            //return new Rotativa.PartialViewAsPdf("_PaymentDetail", order) { FileName = name, PageSize = Rotativa.Options.Size.A4, };
            return new Rotativa.PartialViewAsPdf("_PrintOrderDetails", order) { FileName = name, PageSize = Rotativa.Options.Size.A4, };
        }

    }
}
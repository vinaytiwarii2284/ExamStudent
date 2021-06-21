using Digiphoto.iMix.ClaimPortal.Common;
using Digiphoto.iMix.ClaimPortal.Model;
using ExamStudent.Models;
using ExamStudent.ViewModel;
using ExamStudents.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamStudents.Business
{
    public class CheckoutBusiness : BaseBusiness
    {
        public CheckoutViewModel GetUserAddress(Int64 userId)
        {
            CheckoutViewModel checkoutViewModel = null;
            this.operation = () =>
            {
                CheckoutDataAccess access = new CheckoutDataAccess(this.Transaction);
                checkoutViewModel = access.GetUserAddress(userId);
            };
            this.Start(false);
            return checkoutViewModel;
        }

        public void SaveUserAddress(CheckoutViewModel checkoutViewModel)
        {
            this.operation = () =>
            {
                CheckoutDataAccess access = new CheckoutDataAccess(this.Transaction);
                access.SaveUserAddress(checkoutViewModel);
            };
            this.Start(false);
        }
        public ICollection<Country> GetCountryList()
        {
            Country c = new Country();
            this.operation = () =>
            {
                CheckoutDataAccess access = new CheckoutDataAccess(this.Transaction);
                c.CountryList = access.GetCountry();
            };
            this.Start(false);
            return c.CountryList;
        }

        public ICollection<State> GetStatetList(string CommonName)
        {
            State state = new State();
            this.operation = () =>
            {
                CheckoutDataAccess access = new CheckoutDataAccess(this.Transaction);
                state.StateList = access.GetState(CommonName);
            };
            this.Start(false);
            return state.StateList;
        }

        public PaymentViewModel GetUserBillingAndShippingAddress(Int64 userId)
        {
            PaymentViewModel paymentViewModel = null;
            this.operation = () =>
            {
                CheckoutDataAccess access = new CheckoutDataAccess(this.Transaction);
                paymentViewModel = access.GetUserBillingAndShippingAddress(userId);
            };
            this.Start(false);
            return paymentViewModel;
        }

        public PaymentViewModel GetUserDetailsForPayment(Int64 userId)
        {
            PaymentViewModel paymentViewModel = null;
            this.operation = () =>
            {
                CheckoutDataAccess access = new CheckoutDataAccess(this.Transaction);
                paymentViewModel = access.GetUserDetailsForPayment(userId);
            };
            this.Start(false);
            return paymentViewModel;
        }

        public ICollection<Shipping> GetShippingDetails(int LCID)
        {
            ICollection<Shipping> shipping = null;
            this.operation = () =>
            {
                CheckoutDataAccess access = new CheckoutDataAccess(this.Transaction);
                shipping = access.GetShippingDetails(LCID);
            };
            this.Start(false);
            return shipping;
        }

        public Int64 placeOrder(Order order, int PartnerId)
        {
            ICollection<Shipping> shipping = null;
            Int64 OrderId = 0;
            this.operation = () =>
            {
                CheckoutDataAccess access = new CheckoutDataAccess(this.Transaction);

                string orderXML = CommonUtility.SerializeObject<Order>(order);
                string orderXML1 = CommonUtility.SerializeObject<Order>(order);
                OrderId = access.SaveOrder(orderXML, PartnerId);

            };
            this.Start(false);
            return OrderId;
        }
        public Order GetOrderById(Int64 OrderId)
        {
            Order order = null;
            this.operation = () =>
            {
                CheckoutDataAccess access = new CheckoutDataAccess(this.Transaction);
                order = access.GetOrderById(OrderId);
            };
            this.Start(false);
            return order;
        }
        public bool UpdateOrderDetails(PaymentViewModel paymentmodel)
        {
            bool success = false;
            this.operation = () =>
            {
                CheckoutDataAccess access = new CheckoutDataAccess(this.Transaction);
                success = access.UpdateOrderDetails(paymentmodel);
            };
            this.Start(false);
            return success; ;
        }

        public bool MarkedImageAsPaid(int WebPhotoID, long PartnerUserID, int SubStoreId)
        {
            bool success = false;
            this.operation = () =>
            {
                CheckoutDataAccess access = new CheckoutDataAccess(this.Transaction);
                success = access.MarkedImageAsPaid(WebPhotoID, PartnerUserID, SubStoreId);
            };
            this.Start(false);
            return success;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamStudents.DataAccess;
using Digiphoto.iMix.ClaimPortal.Model;
using ExamStudent.ViewModel;

namespace ExamStudents.Business
{
    public class CartBusiness : BaseBusiness
    {
        public void AddProductToUserCart(Int64 userId, int productId, int quantity,double productPrice)
        {         
            this.operation = () =>
            {
                CartDataAccess access = new CartDataAccess(this.Transaction);
                access.AddProductToUserCart(userId, productId, quantity, productPrice);
            };
            this.Start(false);

        }

        public Cart GetCart(Int64 userId)
        {
            Cart cart = null;
            this.operation = () =>
            {
                CartDataAccess access = new CartDataAccess(this.Transaction);
                cart = access.GetCart(userId);
            };
            this.Start(false);
            return cart;
        }


        public List<CartLineItem> GetCartItems(int cartId)
        {

            List<CartLineItem> cartLineItem = null;
            this.operation = () =>
            {
                CartDataAccess access = new CartDataAccess(this.Transaction);
                cartLineItem = access.GetCartItems(cartId);
            };
            this.Start(false);
            return cartLineItem;
        }

        public void RemoveProductFromCart(Int64 userId, int productId, int? quantity, int PhotoId)
        {

            this.operation = () =>
            {
                CartDataAccess access = new CartDataAccess(this.Transaction);
                access.removeCartLineItem(userId, productId, quantity, PhotoId);
            };
            this.Start(false);

        }

        public void ClearCart(Int64 userId)
        {
            this.operation = () =>
            {
                CartDataAccess access = new CartDataAccess(this.Transaction);
                access.ClearCart(userId);
            };
            this.Start(false);
        }
    }
}

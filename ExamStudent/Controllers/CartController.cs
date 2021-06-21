using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Digiphoto.iMix.ClaimPortal.Common;
using ExamStudent.Controllers;
using ExamStudent.ViewModel;
using ExamStudents.Business;

namespace ExamStudent.Controllers
{

    //[Authorize]
    //[CustomFilter]
    public class CartController : BaseController
    {
        
        public ActionResult AddProductToCartIndex(int productId=0, int quantity=0, double productPrice=0)
        {
            //if (Session["PhotoId"] != null && Session["SubStoreId"] != null)
            //{
            //    ViewBag.PreviousAction = Request.UrlReferrer.AbsoluteUri.Replace(Request.UrlReferrer.PathAndQuery, "/EditPhoto/EditPhoto?PhotoId=" + Session["PhotoId"] + "&SubStoreId=" + Session["SubStoreId"]);
            //}
            //else
            //{
            //    if (Request.UrlReferrer != null)
            //    {
            //        ViewBag.PreviousAction = Request.UrlReferrer.AbsoluteUri.Replace(Request.UrlReferrer.PathAndQuery, "/SubStores/ViewSubStores");
            //    }
            ////}
            //long PartnerUserID = Convert.ToInt64(Session[SessionConstants.SESSION_USERID]);
            //Cart cart = new Cart();
            //CartBusiness cartBusiness = new CartBusiness();
            //cart = cartBusiness.GetCart(PartnerUserID);
            //cart.CartLineItems = cartBusiness.GetCartItems(cart.CartID);
            //return View("Cart", cart);

            //int productId=0; int quantity=0; double productPrice=0;

            long PartnerUserID = Convert.ToInt64(Session[SessionConstants.SESSION_USERID]);
            CartBusiness cartBusiness = new CartBusiness();
            cartBusiness.AddProductToUserCart(PartnerUserID, productId, quantity, productPrice);

            //After inserting products into cart..get the cart and cartitems
            //Cart cart = new Cart();
            //cart = cartBusiness.GetCart(PartnerUserID);
            //cart.CartLineItems = cartBusiness.GetCartItems(cart.CartID);

            return View();
        }

        public ActionResult Cart()
        {
            long PartnerUserID = Convert.ToInt64(Session[SessionConstants.SESSION_USERID]);            
            CartBusiness cartBusiness = new CartBusiness();
            Cart cart = new Cart();
            cart = cartBusiness.GetCart(PartnerUserID);
            cart.CartLineItems = cartBusiness.GetCartItems(cart.CartID);
            return PartialView("Cart", cart);
        }

        public ActionResult CheckOut()
        {
           
            return View();
        }



        //public ActionResult CartItem()
        //{
        //    long PartnerUserID = Convert.ToInt64(Session[SessionConstants.SESSION_USERID]);
        //    CartBusiness cartBusiness = new CartBusiness();
        //    Cart cart = new Cart();
        //    cart = cartBusiness.GetCart(PartnerUserID);
        //    cart.CartLineItems = cartBusiness.GetCartItems(cart.CartID);
        //    return PartialView("Cart", cart);
        //}


        [HttpPost]
        public ActionResult AddProductToCart(int productId, int quantity, double productPrice)
        {            
            long PartnerUserID = Convert.ToInt64(Session[SessionConstants.SESSION_USERID]);
            CartBusiness cartBusiness = new CartBusiness();
            cartBusiness.AddProductToUserCart(PartnerUserID, productId, quantity, productPrice);
            //After inserting products into cart..get the cart and cartitems
            Cart cart = new Cart();
            cart = cartBusiness.GetCart(PartnerUserID);
            cart.CartLineItems = cartBusiness.GetCartItems(cart.CartID);
            return View("Cart", cart);
        }

        public JsonResult AddProductToCart1(int productId, int quantity, int PhotoId)
        {
            long PartnerUserID = Convert.ToInt64(Session[SessionConstants.SESSION_USERID]);
            CartBusiness cartBusiness = new CartBusiness();
            cartBusiness.AddProductToUserCart(PartnerUserID, productId, quantity, PhotoId);
            Cart cart = new Cart();
            cart = cartBusiness.GetCart(PartnerUserID);
            cart.CartLineItems = cartBusiness.GetCartItems(cart.CartID);
            cart.TotalCurrentValue = cart.Total(cart.CartLineItems);
            return Json(cart);
        }

        public ActionResult RemoveProductFromCart(Int32 PhotoId, Int32 ProductId)
        {

            if (Session["PhotoId"] != null && Session["SubStoreId"] != null)
            {
                ViewBag.PreviousAction = Request.UrlReferrer.AbsoluteUri.Replace(Request.UrlReferrer.PathAndQuery, "/EditPhoto/EditPhoto?PhotoId=" + Session["PhotoId"] + "&SubStoreId=" + Session["SubStoreId"]);
            }
            else
            {
                ViewBag.PreviousAction = Request.UrlReferrer.AbsoluteUri.Replace(Request.UrlReferrer.PathAndQuery, "/SubStores/ViewSubStores");
            }
            Cart cart = new Cart();
            long PartnerUserID = Convert.ToInt64(Session[SessionConstants.SESSION_USERID]);
            CartBusiness cartBusiness = new CartBusiness();
            cartBusiness.RemoveProductFromCart(PartnerUserID, ProductId, null, PhotoId);

            cart = cartBusiness.GetCart(PartnerUserID);
            cart.CartLineItems = cartBusiness.GetCartItems(cart.CartID);
            return View("Cart", cart);
        }


        public JsonResult RemoveProductFromCart1(int productId, int? quantity, int PhotoId)
        {
            long PartnerUserID = Convert.ToInt64(Session[SessionConstants.SESSION_USERID]);
            CartBusiness cartBusiness = new CartBusiness();
            Cart cart = new Cart();
            cartBusiness.RemoveProductFromCart(PartnerUserID, productId, quantity, PhotoId);
            cart = cartBusiness.GetCart(PartnerUserID);
            cart.CartLineItems = cartBusiness.GetCartItems(cart.CartID);
            cart.TotalCurrentValue = cart.Total(cart.CartLineItems);
            return Json(cart);
        }
        [HttpPost]
        public ActionResult ClearCart()
        {
            if (Session["PhotoId"] != null && Session["SubStoreId"] != null)
            {
                ViewBag.PreviousAction = Request.UrlReferrer.AbsoluteUri.Replace(Request.UrlReferrer.PathAndQuery, "/EditPhoto/EditPhoto?PhotoId=" + Session["PhotoId"] + "&SubStoreId=" + Session["SubStoreId"]);
            }
            else
            {
                ViewBag.PreviousAction = Request.UrlReferrer.AbsoluteUri.Replace(Request.UrlReferrer.PathAndQuery, "/SubStores/ViewSubStores");
            }
            long PartnerUserID = Convert.ToInt64(Session[SessionConstants.SESSION_USERID]);
            CartBusiness cartBusiness = new CartBusiness();
            Cart cart = new Cart();
            cartBusiness.ClearCart(PartnerUserID);
            cart = cartBusiness.GetCart(PartnerUserID);
            cart.CartLineItems = cartBusiness.GetCartItems(cart.CartID);
            return View("Cart", cart);
        }

        public ActionResult CartSummary()
        {
            ViewBag.RockCityTittle = Digiphoto.iMix.ClaimPortal.Common.Resources.en_US.CartViewShoppingCartText;
            Cart cart = new Cart();
            CartBusiness cartBusiness = new CartBusiness();
            long PartnerUserID = Convert.ToInt64(Session[SessionConstants.SESSION_USERID]);
            cart = cartBusiness.GetCart(PartnerUserID);
            cart.CartLineItems = cartBusiness.GetCartItems(cart.CartID);
            return PartialView("CartSummary", cart);
        }

    }
}
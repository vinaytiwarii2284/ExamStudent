using ExamStudent.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamStudents.DataAccess
{
    public class CartDataAccess : BaseDataAccess
    {
        #region Constructor
        public CartDataAccess(BaseDataAccess baseaccess)
            : base(baseaccess)
        {

        }
        public CartDataAccess()
        {

        }
        #endregion
        public void AddProductToUserCart(Int64 userId, int productId, int quantity, double productPrice)
        {
            DBParameters.Clear();

            AddParameter("@PartnerUserID", userId);
            AddParameter("@ProductID", productId);
            AddParameter("@Quantity", quantity);
            AddParameter("@ProductPrice", productPrice);
            SaveData("uspAddProductToCart");
        }

        public Cart GetCart(Int64 userId)
        {
            DBParameters.Clear();
            AddParameter("@UserID", userId);
            IDataReader sqlReader = ExecuteReader("PartnerGetCart");
            Cart cart = GetCartDetails(sqlReader);
            sqlReader.Close();
            return cart;
        }

        private Cart GetCartDetails(IDataReader sqlReader)
        {
            Cart cart = new Cart();
            while (sqlReader.Read())
            {
                cart.CartID = GetFieldValue(sqlReader, "CartID", 0);
                cart.CreatedOn = GetFieldValue(sqlReader, "CreatedOn", DateTime.Now);
            }
            return cart;
        }

        public List<CartLineItem> GetCartItems(int cartId)
        {
            DBParameters.Clear();
            AddParameter("@CartID", cartId);
            IDataReader sqlReader = ExecuteReader("PartnerGetCartItems");
            List<CartLineItem> cartLineItem = GetCartItemsDetails(sqlReader);
            sqlReader.Close();
            return cartLineItem;
        }

        private List<CartLineItem> GetCartItemsDetails(IDataReader sqlReader)
        {
            List<CartLineItem> cartLineItemList = new List<CartLineItem>();
            while (sqlReader.Read())
            {
                CartLineItem cartLineItem = new CartLineItem();
                List<Product> productList = new List<Product>();

                Product product = new Product();
                cartLineItem.CartItemID = GetFieldValue(sqlReader, "CartItemID", 0);
                cartLineItem.CartID = GetFieldValue(sqlReader, "CartID", 0);
                product.ProductID = GetFieldValue(sqlReader, "ProductID", 0);
                product.UnitPrice = GetFieldValue(sqlReader, "ProductPrice", 0.0M);
                cartLineItem.Quantity = GetFieldValue(sqlReader, "Quantity", 0);
                product.ProductName= GetFieldValue(sqlReader, "ProductName", "");

                DBParameters.Clear();
                //AddParameter("@WebPhotoId", WebPhotoId);
                //IDataReader sqlReader1 = ExecuteReader("[Partner].[uspGetWebPhotoFileDetails]");
                //string PhotoFilePath = GetCartPhotoImagePath(sqlReader1);
                //cartLineItem.PhotoFilePath = PhotoFilePath;
                //cartLineItem.PhotoId = WebPhotoId;
                cartLineItem.Product = product;
                cartLineItemList.Add(cartLineItem);
                //DBParameters.Clear();
                //AddParameter("@ProductID", product.ProductID);
                //IDataReader sqlReader2 = ExecuteReader("[Partner].[uspGetProductCoordinates]");

                //product.placeHolderCoordinatesList = GetplaceHolderCoordinates(sqlReader2);


            }
            return cartLineItemList;
        }

        public List<ProductPlaceHolderCoordinates> GetplaceHolderCoordinates(IDataReader sqlReader)
        {
            CartLineItem cartLineItem = new CartLineItem();
            List<ProductPlaceHolderCoordinates> ProductPlaceHolderCoordinatesList = new List<ProductPlaceHolderCoordinates>();
            ProductPlaceHolderCoordinates ProductPlaceHolderCoordinates = new ProductPlaceHolderCoordinates();
            while (sqlReader.Read())
            {
                ProductPlaceHolderCoordinates.Top = GetFieldValue(sqlReader, "Top", 0) + "px";
                ProductPlaceHolderCoordinates.Left = GetFieldValue(sqlReader, "Left", 0) + "px";
                ProductPlaceHolderCoordinates.Height = GetFieldValue(sqlReader, "Height", 0) + "px";
                ProductPlaceHolderCoordinates.Width = GetFieldValue(sqlReader, "Width", 0) + "px";

                ProductPlaceHolderCoordinatesList.Add(ProductPlaceHolderCoordinates);
            }
            return ProductPlaceHolderCoordinatesList;
        }

        public string GetCartPhotoImagePath(IDataReader sqlReader)
        {
            string PhotoFilePath = "";
            while (sqlReader.Read())
            {
                if (GetFieldValue(sqlReader, "IsPaidImage", 0) == 0)
                {
                    Int32 Height = GetFieldValue(sqlReader, "Height", 0);
                    Int32 Width = GetFieldValue(sqlReader, "Width", 0);
                    string WatermarkImagePath = GetFieldValue(sqlReader, "WatermarkImagePath", string.Empty);
                    string publicId = string.Empty;
                    if (!string.IsNullOrEmpty(WatermarkImagePath))
                    {
                        publicId = WatermarkImagePath.Replace(System.Configuration.ConfigurationManager.AppSettings["ServerImagePath"], "");
                        string[] dirs = publicId.Split('/');
                        if (dirs.Length > 0)
                        {
                            publicId = publicId.Replace(dirs[0], "");
                        }
                        publicId = publicId.Substring(0, publicId.Length - 4).TrimStart('/').Replace('/', ':');
                    }
                    PhotoFilePath = System.Configuration.ConfigurationManager.AppSettings["ServerImagePath"] + "/w_" + Width + ",h_" + Height + ",c_fit,l_" + publicId + "/" + System.Configuration.ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + GetFieldValue(sqlReader, "CountryName", string.Empty) + "/" + GetFieldValue(sqlReader, "StoreName", string.Empty) + "/" + GetFieldValue(sqlReader, "Name", string.Empty) + "/" + GetFieldValue(sqlReader, "OrderDate", string.Empty) + "/" + GetFieldValue(sqlReader, "OrderId", string.Empty) + "/" + GetFieldValue(sqlReader, "IdentificationCode", string.Empty) + "/" + GetFieldValue(sqlReader, "FileName", string.Empty);
                }
                else
                    PhotoFilePath = System.Configuration.ConfigurationManager.AppSettings["ServerImagePath"] + "w_250,h_150,c_fit" + System.Configuration.ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + GetFieldValue(sqlReader, "CountryName", string.Empty) + "/" + GetFieldValue(sqlReader, "StoreName", string.Empty) + "/" + GetFieldValue(sqlReader, "Name", string.Empty) + "/" + GetFieldValue(sqlReader, "OrderDate", string.Empty) + "/" + GetFieldValue(sqlReader, "OrderId", string.Empty) + "/" + GetFieldValue(sqlReader, "IdentificationCode", string.Empty) + "/" + GetFieldValue(sqlReader, "FileName", string.Empty);
            }
            return PhotoFilePath;
        }

        public void removeCartLineItem(Int64 userId, int productId, int? quantity, int PhotoId)
        {
            DBParameters.Clear();
            AddParameter("@PartnerUserID", userId);
            AddParameter("@ProductID", productId);
            AddParameter("@Quantity", quantity);
            AddParameter("@PhotoId", PhotoId);

            ExecuteScalar("[Partner].[uspRemoveProductFromCart]");
        }

        public void ClearCart(Int64 userId)
        {
            DBParameters.Clear();
            AddParameter("@PartnerUserID", userId);
            ExecuteScalar("[Partner].[ClearUserCart]");
        }
    }
}

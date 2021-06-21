using Digiphoto.iMix.ClaimPortal.Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamStudent.ViewModel
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }

        public decimal UnitPrice { get; set; }
        public string UnitPriceCurrency
        {
            get
            {
                return Currency + UnitPrice;//.ToString();
            }
        }
        public int CategoryID { get; set; }
        public string ProductIconImageName { get; set; }
        public string ImagePath { get; set; }
        
        public string ProductImagePath
        {
            get
            {
                string IMIXProductImagePath = ConfigurationManager.AppSettings["ServerImagePath"].ToString() + ConfigurationManager.AppSettings["IMIXProductThumbnailPath"].ToString()  ;
                return System.IO.Path.Combine(IMIXProductImagePath, ImagePath);
            }
        }

        public string ProductIconImagePath
        {
            get
            {
                string IMIXProductImagePath = ConfigurationManager.AppSettings["ServerImagePath"].ToString() + "w_250,h_150,c_fit/"+ ConfigurationManager.AppSettings["IMIXProductThumbnailPath"].ToString();
                return System.IO.Path.Combine(IMIXProductImagePath, ImagePath);
            }
        }
       
        public string IconPath
        {
            get
            {
                string IMIXProductImagePath = ConfigurationManager.AppSettings["ServerImagePath"].ToString()  + "w_250,h_150,c_fit/" + ConfigurationManager.AppSettings["IMIXProductThumbnailPath"].ToString();
                    
               // + "w_250,h_150,c_fit" +
                if (!string.IsNullOrEmpty(ProductIconImageName))
                    return System.IO.Path.Combine(IMIXProductImagePath, ProductIconImageName);
                else
                    return null;
            }
        }

        public List<ProductPlaceHolderCoordinates> placeHolderCoordinatesList { get; set; }
        public int MaxImageCount { get; set; }
        public string Currency
        {

            get
            {
                return CommonFunctions.SetCurrency();
            }
        }
    }
}

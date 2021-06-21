using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Web;
//using Digiphoto.iMix.ClaimPortal.Business;
//using Digiphoto.iMix.ClaimPortal.Model;

namespace Digiphoto.iMix.ClaimPortal.Common
{
    public class CommonFunctions
    {
        public static string GeneratePassword(int length)
        {
            string newPwd = string.Empty;
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            string result = new string(
                Enumerable.Repeat(chars, length)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }
        //public static string GetCurrency()
        //{
        //    string _currency = string.Empty;
        //    int partnerId = Convert.ToInt32(ConfigurationManager.AppSettings["PartnerId"].ToString());
        //    ConfigurationBusiness configuration = new ConfigurationBusiness();
        //    Dictionary<int, ConfigurationValueInfo> configurationValues = configuration.ConfigurationValues(partnerId);
        //    _currency = (configurationValues[Convert.ToInt32(ConfigurationMaster.PGCurrency)]).ConfigurationValue;
        //    return _currency;
        //}

        public static string SetCurrency()
        {
            string ProdCurrency = string.Empty;
            if (HttpContext.Current.Session[SessionConstants.SESSION_CURRENCY] != null)
                ProdCurrency = HttpContext.Current.Session[SessionConstants.SESSION_CURRENCY].ToString();
            string Currency = string.Empty;
            if (ProdCurrency == "USD")
            {
                Currency = "$";
            }
            else if (ProdCurrency == "AED")
            {
                Currency = "AED";
            }
            else { Currency = "$"; }
            return Currency;
        }
    }
}

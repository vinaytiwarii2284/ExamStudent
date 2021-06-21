using Digiphoto.iMix.ClaimPortal.Common;
using Digiphoto.iMix.ClaimPortal.Model;
using ExamStudents.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ExamStudents.Business
{
    public class ConfigurationBusiness : BaseBusiness
    {
        public Dictionary<int, ConfigurationValueInfo> ConfigurationValues(int partnerId, int subStoreId, string qrCode)
        {
            Dictionary<int, ConfigurationValueInfo> configurationValues = null;
            //if (HttpContext.Current.Session[SessionConstants.SESSION_CONFIGURATIONS] != null)
            //{
            //    configurationValues = HttpContext.Current.Session[SessionConstants.SESSION_CONFIGURATIONS] as Dictionary<int, ConfigurationValueInfo>;
            //}
            //else
            //{
            //Get latest from DB
            this.operation = () =>
            {
                ConfigurationDataAccess access = new ConfigurationDataAccess(this.Transaction);
                configurationValues = access.GetPartnerConfigurationValues(partnerId, subStoreId, qrCode);
            };
            this.Start(false);
            HttpContext.Current.Session[SessionConstants.SESSION_CONFIGURATIONS] = configurationValues;
            //}
            return configurationValues;
        }

        public Dictionary<int, ConfigurationValueInfo> ConfigurationValuesPartnerLevel(int partnerId, int subStoreId, string qrCode)
        {
            Dictionary<int, ConfigurationValueInfo> configurationValues = null;
            if (HttpContext.Current.Session[SessionConstants.SESSION_CONFIGURATIONS_PARTNER_LEVEL] != null)
            {
                configurationValues = HttpContext.Current.Session[SessionConstants.SESSION_CONFIGURATIONS_PARTNER_LEVEL] as Dictionary<int, ConfigurationValueInfo>;
            }
            else
            {
                //Get latest from DB
                this.operation = () =>
                {
                    ConfigurationDataAccess access = new ConfigurationDataAccess(this.Transaction);
                    configurationValues = access.GetPartnerConfigurationValues(partnerId, subStoreId, qrCode);
                };
                this.Start(false);
                HttpContext.Current.Session[SessionConstants.SESSION_CONFIGURATIONS_PARTNER_LEVEL] = configurationValues;
            }
            return configurationValues;
        }
    }
}

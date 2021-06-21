using Digiphoto.iMix.ClaimPortal.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamStudents.DataAccess
{
    public class ConfigurationDataAccess : BaseDataAccess
    {
        #region Constructor
        public ConfigurationDataAccess(BaseDataAccess baseaccess)
            : base(baseaccess)
        {
        }
        public ConfigurationDataAccess()
        {
        }
        #endregion

        public Dictionary<int, ConfigurationValueInfo> GetPartnerConfigurationValues(int partnerId, int subStoreId, String qrCode)
        {
            Dictionary<int, ConfigurationValueInfo> ConfigurationValues = new Dictionary<int, ConfigurationValueInfo>();
            ConfigurationValueInfo configurationValue = null;
            DBParameters.Clear();
            if (String.IsNullOrEmpty(qrCode))
            {
                AddParameter("@QRCode", DBNull.Value);
            }
            else
            {
                AddParameter("@QRCode", qrCode);
            }
            if (subStoreId == 0)
            {
                AddParameter("@SubStoreId", DBNull.Value);
            }
            else
            {
                AddParameter("@SubStoreId", subStoreId);
            }
            if (partnerId == 0)
            {
                AddParameter("@PassedPartnerID", DBNull.Value);
            }
            else
            {
                AddParameter("@PassedPartnerID", partnerId);
            }
            IDataReader sqlReader = ExecuteReader("[Partner].[uspGetPartnerConfigurations_New]");
            while (sqlReader.Read())
            {
                configurationValue = new ConfigurationValueInfo();
                configurationValue.ConfigurationMasterID = GetFieldValue(sqlReader, "ConfigurationMasterID", 0);
                configurationValue.ConfigurationValue = GetFieldValue(sqlReader, "ConfigurationValue", string.Empty);
                configurationValue.PartnerID = GetFieldValue(sqlReader, "PartnerID", 0);
                configurationValue.StoreID = GetFieldValue(sqlReader, "StoreID", 0L);
                if (partnerId == 0)
                {
                    configurationValue.SubStoreID = GetFieldValue(sqlReader, "SubStoreId", 0L);
                }
                //if (!ConfigurationValues.ContainsKey(configurationValue.ConfigurationMasterID))
                ConfigurationValues.Add(configurationValue.ConfigurationMasterID, configurationValue);
            }
            sqlReader.Close();
            return ConfigurationValues;
        }
    }
}

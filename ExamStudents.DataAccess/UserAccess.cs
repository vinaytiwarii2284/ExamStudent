using Digiphoto.iMix.ClaimPortal.Model;
using ExamStudent.Models;
using ExamStudent.ViewModel;
using ExamStudent.ViewModel.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamStudents.DataAccess
{
    public class UserAccess : BaseDataAccess
    {
        #region Constrructor
        public UserAccess(BaseDataAccess baseaccess)
            : base(baseaccess)
        {

        }
        public UserAccess()
        {

        }
        #endregion

        public CountryViewModel GetActiveCountries()
        {
            DBParameters.Clear();
            IDataReader sqlReader = ExecuteReader("uspGetCountry");
            CountryViewModel obj = new CountryViewModel();
            obj.CountryList = PopulateCountryList(sqlReader);
            sqlReader.Close();
            return obj;
        }

        private List<Country> PopulateCountryList(IDataReader sqlReader)
        {
            List<Country> CountryList = new List<Country>();
            while (sqlReader.Read())
            {
                CountryViewModel _country = new CountryViewModel();
                _country.CommonName = GetFieldValue(sqlReader, "CommonName", string.Empty);
                _country.CountryCode = GetFieldValue(sqlReader, "CountryCode", string.Empty);

                CountryList.Add(_country);
            }
            return CountryList;
        }

        public List<UserTuple> GetUserDetails()
        {
            DBParameters.Clear();
            
            IDataReader sqlReader = ExecuteReader("usp_UserList");
            List<UserTuple> UserDataList = GetUserDataList(sqlReader);
            sqlReader.Close();
            return UserDataList;
        }

        public List<UserTuple> GetUserDetailss()
        {
            DBParameters.Clear();

            IDataReader sqlReader = ExecuteReader("usp_UserListRecord");
            List<UserTuple> UserDataList = GetUserDataListt(sqlReader);
            sqlReader.Close();
            return UserDataList;
        }

        public List<UserTuple> GetUserDetailsss()
        {
            DBParameters.Clear();

            IDataReader sqlReader = ExecuteReader("usp_StudentPayment");
            List<UserTuple> UserDataList = GetUserDataListtt(sqlReader);
            sqlReader.Close();
            return UserDataList;
        }

        private List<UserTuple> GetUserDataList(IDataReader sqlReader)
        {
            List<UserTuple> UserVMList = new List<UserTuple>();

            while (sqlReader.Read())
            {
                UserTuple UserVM = new UserTuple();
                UserVM.UserId = GetFieldValue(sqlReader, "UserId", 0);
                UserVM.UserDetailId = GetFieldValue(sqlReader, "UserDetailId", 0L);
                UserVM.BoardType = GetFieldValue(sqlReader, "BoardType", string.Empty);
                UserVM.Medium = GetFieldValue(sqlReader, "Medium", string.Empty);
                UserVM.Standard = GetFieldValue(sqlReader, "Standard", string.Empty);
                UserVM.Password = GetFieldValue(sqlReader, "Password", string.Empty);
                UserVM.IsActive = GetFieldValue(sqlReader, "IsActive", true);
                UserVM.CreatedDate = GetFieldValue(sqlReader, "CreatedDate", System.DateTime.Now);
                UserVM.ModifiedDate = GetFieldValue(sqlReader, "ModifiedDate", System.DateTime.Now);

                UserVM.FirstName = GetFieldValue(sqlReader, "FirstName", string.Empty);
                UserVM.LastName = GetFieldValue(sqlReader, "LastName", string.Empty);
                UserVM.MiddleName = GetFieldValue(sqlReader, "MiddleName", string.Empty);
                UserVM.EmailAddress = GetFieldValue(sqlReader, "EmailAddress", string.Empty);

                UserVM.PhoneNumber = GetFieldValue(sqlReader, "PhoneNumber", string.Empty);
                UserVM.MobileNumber = GetFieldValue(sqlReader, "MobileNumber", string.Empty);
                UserVM.DOB = GetFieldValue(sqlReader, "DOB" ,  System.DateTime.Now);
                UserVM.ReferID = GetFieldValue(sqlReader, "ReferID",0);


                UserVMList.Add(UserVM);
            }
            return UserVMList;
        }

        private List<UserTuple> GetUserDataListt(IDataReader sqlReader)
        {
            List<UserTuple> UserVMList = new List<UserTuple>();

            while (sqlReader.Read())
            {
                UserTuple UserVM = new UserTuple();
                UserVM.UserId = GetFieldValue(sqlReader, "Id", 0);
               
                UserVM.BoardType = GetFieldValue(sqlReader, "BoardType", string.Empty);
                UserVM.Medium = GetFieldValue(sqlReader, "Medium", string.Empty);
                UserVM.Standard = GetFieldValue(sqlReader, "Standard", string.Empty);
                UserVM.Password = GetFieldValue(sqlReader, "Password", string.Empty);
                UserVM.IsActive = GetFieldValue(sqlReader, "IsActive", true);
                UserVM.CreatedDate = GetFieldValue(sqlReader, "CreatedDate", System.DateTime.Now);
                UserVM.ModifiedDate = GetFieldValue(sqlReader, "ModifiedDate", System.DateTime.Now);

                UserVM.FirstName = GetFieldValue(sqlReader, "Name", string.Empty);
                
                UserVM.EmailAddress = GetFieldValue(sqlReader, "EmailAddress", string.Empty);

               
                UserVM.MobileNumber = GetFieldValue(sqlReader, "MobileNumber", string.Empty);
                UserVM.DOB = GetFieldValue(sqlReader, "DOB", System.DateTime.Now);
                UserVM.ReferID = GetFieldValue(sqlReader, "ReferID", 0);


                UserVMList.Add(UserVM);
            }
            return UserVMList;
        }

        private List<UserTuple> GetUserDataListtt(IDataReader sqlReader)
        {
            List<UserTuple> UserVMList = new List<UserTuple>();

            while (sqlReader.Read())
            {
                UserTuple UserVM = new UserTuple();
                UserVM.UserId = GetFieldValue(sqlReader, "Id", 0);

                UserVM.BoardType = GetFieldValue(sqlReader, "BoardType", string.Empty);
                UserVM.Medium = GetFieldValue(sqlReader, "Medium", string.Empty);
                UserVM.Standard = GetFieldValue(sqlReader, "Standard", string.Empty);
                UserVM.Password = GetFieldValue(sqlReader, "Password", string.Empty);
                UserVM.IsActive = GetFieldValue(sqlReader, "IsActive", true);
                UserVM.CreatedDate = GetFieldValue(sqlReader, "CreatedDate", System.DateTime.Now);
                UserVM.ModifiedDate = GetFieldValue(sqlReader, "ModifiedDate", System.DateTime.Now);

                UserVM.FirstName = GetFieldValue(sqlReader, "Name", string.Empty);

                UserVM.EmailAddress = GetFieldValue(sqlReader, "EmailAddress", string.Empty);


                UserVM.MobileNumber = GetFieldValue(sqlReader, "MobileNumber", string.Empty);
                UserVM.DOB = GetFieldValue(sqlReader, "DOB", System.DateTime.Now);
                UserVM.ReferID = GetFieldValue(sqlReader, "ReferID", 0);


                UserVMList.Add(UserVM);
            }
            return UserVMList;
        }
    }
}

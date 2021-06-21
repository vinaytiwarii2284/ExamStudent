//using Digiphoto.iMix.ClaimPortal.ViewModel;
using ExamStudent.ViewModel;
using ExamStudents.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamStudents.Business
{
    public class UserBusiness : BaseBusiness
    {

        public CountryViewModel GetActiveCountries()
        {
            CountryViewModel country = new CountryViewModel();
            country.CountryList = null;
            this.operation = () =>
            {
                UserAccess access = new UserAccess(this.Transaction);
                country.CountryList = access.GetActiveCountries().CountryList;
            };
            this.Start(false);

            return country;
        }

        //public ICollection<UserViewModel> GetUserDetails()
        //{
        //    UserViewModel country = new UserViewModel();
        //    ICollection<UserViewModel> UserDetailsList = null;
        //    this.operation = () =>
        //    {
        //        UserAccess access = new UserAccess(this.Transaction);
        //        UserDetailsList = access.GetPartnerSubStoreImages(SubStoreId, PartnerUserId, partnerId);
        //    };
        //    this.Start(false);

        //    return UserDetailsList;
        //}

    }
}

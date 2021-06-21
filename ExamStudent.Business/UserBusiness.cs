using System;

namespace ExamStudent.Business
{
    public class UserBusiness:BaseBusiness
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
    }
}

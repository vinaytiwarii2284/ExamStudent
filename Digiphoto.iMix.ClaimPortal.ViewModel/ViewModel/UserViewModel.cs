using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digiphoto.iMix.ClaimPortal.Model;
using System.Web.WebPages.Html;
using ExamStudent.Models;
using System.ComponentModel.DataAnnotations;

namespace ExamStudent.ViewModel
{
    public class UserViewModel
    {
        public void SetCountryList(ICollection<Country> countries)
        {
            List<SelectListItem> items = new List<SelectListItem>();
            countries.ToList().ForEach(s =>
            {
                items.Add(new SelectListItem()
                {
                    Text = s.CommonName.ToString(),
                    Value = s.CountryCode.ToString()
                });
            });
            this.Countrylist = items;
        }

        public string Captcha { get; set; }
        public int Id { get; set; }
        public string ApplicationID { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
       
        public Nullable<int> ReferID { get; set; }
        //public string BoardType { get; set; }
       // public string Medium { get; set; }
        //public string Standard { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ConfirmPassword { get; set; }
        public Nullable<int> StateID { get; set; }
        public Nullable<int> CityID { get; set; }
        public string Block { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> DOB { get; set; }

        public List<BoardTypeModel> BoardTypeList { get; set; }
        public List<MediumModel> MediumList { get; set; }

        public List<StandardModel> StandardList { get; set; }

        public List<SelectListItem> Countrylist { get; set; }


        public Nullable<int> BoardTypeID { get; set; }
        public Nullable<int> MediumID { get; set; }
        public Nullable<int> StandardID { get; set; }

        public List<Refeer> ReferList { get; set; }

        public string refers { get; set; }
        public string comission { get; set; }

        public Nullable<int> u_status { get; set; }
    }
}

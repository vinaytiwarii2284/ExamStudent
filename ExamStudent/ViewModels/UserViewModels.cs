using ExamStudent.Models;
using ExamStudent.ViewModels;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamStudent.ViewModel
{
    public class UserViewModels
    {
        public string Captcha { get; set; }
        public int UserId { get; set; }

        public int Id { get; set; }

        public long UserDetailId { get; set; }
       
        public int ProductInfo { get; set; }     
        public decimal? Amount { get; set; }
       
       
        public string FirstName { get; set; }
      
        public string LastName { get; set; }
       
        public string MiddleName { get; set; }
       
        public string EmailAddress { get; set; }
        public string Block { get; set; }

        //new work 
        public string FranchiesCode { get; set; }

        public string MobileNumber { get; set; }

       
        public string Password { get; set; }

      
        public string ConfirmPassword { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DOB { get; set; }

        public string BoardTypeName { get; set; }
        public int? BoardTypeID { get; set; }
        public string Mediumname { get; set; }

        public int? MediumID { get; set; }
        public int? StandardID { get; set; }
        public string Standardname { get; set; }
        public List<BoardType> BoardTypeList { get; set; }
        public List<Medium> MediumList { get; set; }

        public List<Standard> StandardList { get; set; }

        public List<SelectListItem> Countrylist { get; set; }

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

        public List<Refer> ReferList { get; set; }
        public int ReferID { get; set; }

      
        public int CityID { get; set; }
        public string CityName { get; set; }
        public List<City> CitiesList { get; set; }

       
        public int StateID { get; set; }
        public string StateName { get; set; }

        public List<State> StatesList  { get; set; }


        public int? EmpID { get; set; }
        public string Course { get; set; }
        public List<EmpCourse> EmpCoursesList { get; set; }


        public int PostID { get; set; }
        public string PostName { get; set; }
        public List<PostForm> PostFormsList  { get; set; }

        public int RefferalID { get; set; }
        public string ReferalName { get; set; }
        public List<ReferalForm> ReferalFormsList { get; set; }


        public int Employee_ID { get; set; }
        public string Employee_Name { get; set; }
        public DateTime Emp_DOB { get; set; }
        public string Emp_MobileNumber { get; set; }
        public string Emp_Block { get; set; }
        public string Emp_Password { get; set; }
        public string Emp_ConfirmPassword { get; set; }
        [Required(ErrorMessage ="State is required")]
        public int EmpStateID { get; set; }
        public int Emp_CityID { get; set; }
        public string Emp_EmailAddress { get; set; }
        public decimal EmpAmount { get; set; }

        public  List<Emp_City> Emp_CityList { get; set; }
        public  List<EmpState> EmpStateList { get; set; }

        //New Work Refferl
        public string usercode { get; set; }

        public int? u_status { get; set; }
        public string refers { get; set; }
        public string comission { get; set; }

        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public List<Subject> SubjectsList { get; set; }


        public int? BoardSecondID { get; set; }
        public int? MediumSecondID { get; set; }
        public int? StandardSecondID { get; set; }
        public int? UserSubjectID { get; set; }

        public List<BoardTypeSecond> BoardTypeSecondsList { get; set; }
        public List<MediumSecond> MediumSecondsList  { get; set; }
        public List<StandardSecond> StandardSecondsList  { get; set; }
        public List<UserSubject> UserSubjectsList  { get; set; }

        public Nullable<bool> isFeatured { get; set; }


       
    }

    public class UserListingViewModel
    {
        //public List<Tab_User_Info> UsersListing { get; set; }

        public List<Tab_User_Info_Temp> UsersListing { get; set; }

        //public List<User> Users { get; set; }

        //public List<UserDetail> userDetails { get; set; }

        public int MaximumPrice { get; set; }

        public int? SortBy { get; set; }     // yha pe new work 

        public List<SubjectViewModel> Subjects { get; set; }

        public List<Teacher> Teachers { get; set; }

        public int? BoardTypeID { get; set; }
              
        public string BoardTypeName { get; set; }
        public int? StandardID { get; set; }
        public string StandardName { get; set; }
        public int? MediumID { get; set; }
        public string MediumName { get; set; }

        public int PageNo { get; set; }
       

        public string SearchTerm { get; set; }
        public bool Ispaids { get; set; }

    }

    public class EditViewModel
    {
        public int UserId { get; set; }
        public long UserDetailId { get; set; }
        public string BoardType { get; set; }
        public string Medium { get; set; }
        public string Standard { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public DateTime? DOB { get; set; }

        public List<UserDetail> UserDetails { get; set; }
    }

    public class UserDetailsViewModel
    {
        public Tab_User_Info_Temp User { get; set; }
        public Refer Referrar { get; set; }

        public UserDetailsViewModel()
        {
            
        }    
    }
}
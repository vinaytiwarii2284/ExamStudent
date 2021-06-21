using Digiphoto.iMix.ClaimPortal.Model;
using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamStudent.ViewModel
{
    public class CountryViewModel : Country
    {
        public int ReferID { get; set; }
        public string ReferName { get; set; }
        public string VoucherRefer { get; set; }
        public string ContectNumber { get; set; }        
        public string EmailAddress { get; set; }
        public string CommonName { get; set; }
        public string CountryCode { get; set; }
        public ICollection<Country> CountryList { get; set; }
    }
}

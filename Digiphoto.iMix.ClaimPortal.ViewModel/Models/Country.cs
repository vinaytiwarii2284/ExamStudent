using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamStudent.Models
{
    public class Country
    {
        public string CommonName { get; set; }
        public string CountryCode { get; set; }
        public ICollection<Country> CountryList { get; set; }
    }
}

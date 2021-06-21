using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamStudent.Models
{
   public class StandardModel
    {
        public int StandardID { get; set; }
        public int MediumID { get; set; }
        public string StandardName { get; set; }
        public List<MediumModel> MediumList { get; set; }
    }
}

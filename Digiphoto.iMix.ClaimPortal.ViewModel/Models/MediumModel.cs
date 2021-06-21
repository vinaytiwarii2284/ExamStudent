using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamStudent.Models
{
   public class MediumModel
    {
        public int MediumID { get; set; }
        public int BoardTypeID { get; set; }
        public string MediumName { get; set; }

        public List<ExamStudent.Models.BoardTypeModel> BoardTypeList { get; set; }
    }
}

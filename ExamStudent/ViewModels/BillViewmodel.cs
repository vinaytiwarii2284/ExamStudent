using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamStudent.ViewModels
{
    public class BillViewmodel
    {
        public double? Amount { get; set; }
        public double? gst { get; set; }
        public double? tramt { get; set; }
        public double? Total { get; set; }
        public string  APPID { get; set; }
        public string UserName { get; set; }
        public string  email { get; set; }
        public string Mobile { get; set; }
        public string CustomerName { get; set; }
    }
}
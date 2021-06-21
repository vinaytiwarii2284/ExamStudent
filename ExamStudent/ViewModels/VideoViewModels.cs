using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamStudent.ViewModels
{
    public class VideoViewModel
    {
        public int VideoID { get; set; }
        public string Title { get; set; }
        public string UploadVideo { get; set; }
        public Nullable<int> BoardTypeID { get; set; }
        public Nullable<int> MediumID { get; set; }
        public Nullable<int> StandardID { get; set; }

        public List<Video> Videos { get; set; }
        public List<BoardType> BoardTypeList { get; set; }
        public List<Medium> MediumList { get; set; }
        public List<Standard> StandardList { get; set; }
    }
}
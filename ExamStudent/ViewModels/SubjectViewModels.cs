using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamStudent.ViewModels
{
    public class SubjectViewModel
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public string FileName { get; set; }

        public string CoverFilePath { get; set; }
        public string subjectDescription { get; set; }
        public decimal subjectPrice { get; set; }
        public string subjectDiscount { get; set; }
        public string subjectTotalHour { get; set; }
        public string ImageURL { get; set; }


        public string PDFFileURL { get; set; }
        public HttpPostedFileBase PDFFileCover { get; set; }

        public HttpPostedFileBase PDFFile { get; set; }

        public string VideoURL { get; set; }
        public string Comment { get; set; }

        public int StandardID { get; set; }

        public string Standardname { get; set; }

        public int BoardTypeID { get; set; }

        public string BoardTypeName { get; set; }

        public int MediumID { get; set; }

        public string Mediumname { get; set; }

        public List<BoardType> BoardTypeList { get; set; }
        public List<Medium> MediumList { get; set; }

        public List<Standard> StandardList { get; set; }

       
    }

    public class SubjectListingViewModel
    {
        public int PageNo { get; set; }
        public List<Subject> GetSubjects { get; set; }

        public List<TabPayumoneyTransectionLog> TabPayumoneyTransectionLogs { get; set; }

        public string SearchTerm { get; set; }
    }

   
}
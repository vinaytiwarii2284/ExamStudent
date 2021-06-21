using ExamStudent.Models;
using ExamStudent.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamStudent.Services
{
    public class productsServices
    {
        ExamStudentContext db = new ExamStudentContext();

        //CheckOut or Cookies
        public List<Subject> GetProducts(List<int> IDs)
        {
            return db.Subjects.Where(product => IDs.Contains(product.SubjectID)).ToList();
        }


        //Shop OF Index Filter All wise
        public List<SubjectViewModel> SearchProducts(string searchTrem, int? minimumPrice, int? maximumPrice, int? subjectID, int? sortBy)// yha pe new work int? sortBy
        {
          
            using (var context = new ExamStudentContext())
            {
                var spltmap = HttpContext.Current.Server.MapPath("~/");
                var products = (from s in context.Subjects
                                select new SubjectViewModel
                                {
                                    SubjectID = s.SubjectID,
                                    SubjectName = s.SubjectName,
                                    subjectPrice = (decimal)s.subjectPrice,
                                    CoverFilePath = s.CoverFilePath.Replace(spltmap, ""),
                                    FileName=s.FileName

                                }).ToList();
                    //context.Subjects.ToList();

                //agar category me value hai to ..category ki value return kro
                if (subjectID.HasValue)
                {
                    products = products.Where(x => x.SubjectID == subjectID.Value).ToList();
                }

                //Search functionaliti..
                if (!string.IsNullOrEmpty(searchTrem))
                {
                    products = products.Where(x => x.SubjectName.ToLower().Contains(searchTrem.ToLower())).ToList();
                }

                //agar minimum me value hai Product me se wo Consider kro jis Product ki price minimum ho
                if (minimumPrice.HasValue)
                {
                    products = products.Where(x => x.subjectPrice >= minimumPrice.Value).ToList();
                }

                //agar minimum me value hai Product me se wo Consider kro jis Product ki price Less then ho 
                if (maximumPrice.HasValue)
                {
                    products = products.Where(x => x.subjectPrice <= maximumPrice.Value).ToList();
                }

                if (sortBy.HasValue)    // yha pe new work start filter low to high int? sortBy
                {
                    switch (sortBy.Value)
                    {
                        case 2:
                            products = products.OrderByDescending(x => x.SubjectID).ToList();
                            break;

                        case 3:
                            products = products.OrderBy(x => x.subjectPrice).ToList();
                            break;


                        case 4:
                            products = products.OrderByDescending(x => x.subjectPrice).ToList();
                            break;
                    }
                }

                return products;

            }
        }


        public int GetMaximumPrice()
        {
            ExamStudentContext context = new ExamStudentContext();

            return (int)(context.Subjects.Max(x => x.subjectPrice));
        }

    }
}
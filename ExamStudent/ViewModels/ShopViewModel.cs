using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamStudent.ViewModels
{
    public class ShopViewModel
    {
        public int MaximumPrice { get; set; }
       // public List<Category> FeaturedCategories { get; set; }
        public List<Subject> Products { get; set; }


        public List<Subject> CartProducts { get; set; } // ye woo Product list h jo ki user ne buy ki h
        public List<int> CartProductsIDs { get; set; } // ye bhi importent hai 
    }

   
}
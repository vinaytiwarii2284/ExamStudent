using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digiphoto.iMix.ClaimPortal.Model;
namespace ExamStudent.ViewModel
{
  public  class ProductViewModel:Product
    {
      public int CategoryId { get; set; }
      public string CategoryName { get; set; }
      private IEnumerable<Product> products;
      public IEnumerable<Product> Products
      {
          get { return products; }
          set { products = value; }
      }

  }
    

}

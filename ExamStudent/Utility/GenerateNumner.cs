using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ExamStudent.Utility
{
    public class GenerateNumner
    {
        public static string Gen()
        {
            StringBuilder builder = new StringBuilder();
            Enumerable
                      .Range(65, 26)
              .Select(e => ((char)e).ToString())
              .Concat(Enumerable.Range(97, 26).Select(e => ((char)e).ToString()))
              .Concat(Enumerable.Range(0, 10).Select(e => e.ToString()))
              .OrderBy(e => Guid.NewGuid())
              .Take(11)
              .ToList().ForEach(e => builder.Append(e));
            string id = builder.ToString();
            return id;
        }
    }
}
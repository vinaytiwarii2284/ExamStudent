using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamStudent.Controllers
{
    public class SharedController : Controller
    {
        // GET: Shared
        [HttpPost]
        public JsonResult UploadImage()
        {
            JsonResult result = new JsonResult();

            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;

            try
            {
                var file = Request.Files[0];

                var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);

                var path = Path.Combine(Server.MapPath("~/Content/imageupload/"), fileName);

                file.SaveAs(path);

                result.Data = new { Success = true, ImageURL = string.Format("/Content/imageupload/{0}", fileName) };
            }
            catch (Exception ex)
            {

                result.Data = new { Success = false, Message = ex.Message };
            }

            return result;
        }
    }
}
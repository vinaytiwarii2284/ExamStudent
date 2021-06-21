using ExamStudent.Models;
using ExamStudent.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamStudent.Controllers
{
    public class VideoUploadController : Controller
    {
        ExamStudentContext context = new ExamStudentContext();

        // GET: VideoUpload
        public ActionResult Index()
        {
            var videolist = context.Videos.ToList();

            return View(videolist);
        }

        public ActionResult video()
        {
            VideoViewModel model = new VideoViewModel();

            var boardTypeList = context.BoardTypes.OrderBy(x => x.BoardTypeID).ToList();
            model.BoardTypeList = boardTypeList;

            var mediumList = context.Mediums.OrderBy(x => x.MediumID).ToList();
            model.MediumList = mediumList;

            var standardList = context.Standards.OrderBy(x => x.StandardID).ToList();
            model.StandardList = standardList;

            model.Videos = context.Videos.ToList();

            return View(model);
        }

        //For Cascading DropDown List...
        [HttpPost]
        public ActionResult GetMediums(int BoardTypeId)
        {
            var items = context.Mediums
                          .Where(x => x.BoardTypeID == BoardTypeId)
                          .Select(x => new SelectListItem
                          {
                              Value = x.MediumID.ToString(),
                              Text = x.MediumName
                          })
                          .ToList();
            return Json(items, JsonRequestBehavior.AllowGet);
        }


        //For Cascading DropDown List...
        [HttpPost]
        public ActionResult GetStandard(int MediumId)
        {
            var items = context.Standards
                          .Where(x => x.MediumID == MediumId)
                          .Select(x => new SelectListItem
                          {
                              Value = x.StandardID.ToString(),
                              Text = x.StandardName
                          })
                          .ToList();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult video(HttpPostedFileBase file, VideoViewModel model)
        {
            string filename = Path.GetFileName(file.FileName);
            string _filename = DateTime.Now.ToString("yyssmmfff") + filename;
            string extension = Path.GetExtension(file.FileName);
            string path = Path.Combine(Server.MapPath("~/VideoUpload/"), _filename);

            model.UploadVideo = "~/VideoUpload/" + _filename;

            if (extension.ToLower() == ".mp4" || extension.ToLower() == ".AVI")
            {
                Video video = new Video();
                video.Title = model.Title;
                video.BoardTypeID = model.BoardTypeID;
                video.MediumID = model.MediumID;
                video.StandardID = model.StandardID;
                video.UploadVideo = model.UploadVideo;

                context.Videos.Add(video);

                if (context.SaveChanges() > 0)
                {
                    file.SaveAs(path);
                    ViewBag.sms = "Data Added is Successfully";
                    ModelState.Clear();
                }
            }
            return RedirectToAction("video");
        }
        
    }
}
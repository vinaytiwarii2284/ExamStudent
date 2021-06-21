using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamStudent.ViewModel
{
    public class EditPhoto
    {

        public string CloudImageURL { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }
        public string ThumbnailDimension { get; set; }
        public int PhotoId { get; set; }
        public string ThumbnailFilePath
        {
            get
            {
                if (IsPaidImage)
                {
                    if (!string.IsNullOrEmpty(CloudImageURL))
                        return CloudImageURL.Replace(ConfigurationManager.AppSettings["ServerImagePath"], ConfigurationManager.AppSettings["ServerImagePath"] + "w_250,h_150,c_fit/");
                    else
                        //return ConfigurationManager.AppSettings["ServerImagePath"] + "w_250,h_150,c_fit" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + Country + "/" + Store + "/" + SubStoreName + "/" + OrderDate.ToString("yyyyMMdd") + "/" + OrderId + "/" + IdentificationCode + "/" + FileName;
                        return ConfigurationManager.AppSettings["ServerImagePath"] + "w_250,h_150,c_fit" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + CloudSourceImagePath;
                }
                else
                {
                    if (!string.IsNullOrEmpty(CloudinaryWatermarkImagePublicId))
                    {
                        if (!string.IsNullOrEmpty(CloudImageURL))
                            return CloudImageURL.Replace(ConfigurationManager.AppSettings["ServerImagePath"], ConfigurationManager.AppSettings["ServerImagePath"] + "w_250,h_150,c_fit/" + "w_200,l_" + CloudinaryWatermarkImagePublicId + "/");
                        else
                            //return ConfigurationManager.AppSettings["ServerImagePath"] + "w_250,h_150,c_fit" + "/w_200,l_" + CloudinaryWatermarkImagePublicId + "/" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + Country + "/" + Store + "/" + SubStoreName + "/" + OrderDate.ToString("yyyyMMdd") + "/" + OrderId + "/" + IdentificationCode + "/" + FileName;
                            return ConfigurationManager.AppSettings["ServerImagePath"] + "w_250,h_150,c_fit" + "/w_250,h_150,c_fit,l_" + CloudinaryWatermarkImagePublicId + "/" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + CloudSourceImagePath;
                    }
                    else
                    {


                        if (!string.IsNullOrEmpty(CloudImageURL))
                            return CloudImageURL.Replace(ConfigurationManager.AppSettings["ServerImagePath"], ConfigurationManager.AppSettings["ServerImagePath"] + "w_250,h_150,c_fit/");
                        else
                            // return ConfigurationManager.AppSettings["ServerImagePath"] + "w_250,h_150,c_fit" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + Country + "/" + Store + "/" + SubStoreName + "/" + OrderDate.ToString("yyyyMMdd") + "/" + OrderId + "/" + IdentificationCode + "/" + FileName;
                            return ConfigurationManager.AppSettings["ServerImagePath"] + "w_250,h_150,c_fit" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + CloudSourceImagePath;
                    }

                }
            }
        }
        public string FilePath
        {



            get
            {
                if (IsPaidImage)
                {
                    if (!string.IsNullOrEmpty(CloudImageURL))
                        return CloudImageURL;
                    else
                        //  return ConfigurationManager.AppSettings["ServerImagePath"] + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + Country + "/" + Store + "/" + SubStoreName + "/" + OrderDate.ToString("yyyyMMdd") + "/" + OrderId + "/" + IdentificationCode + "/" + FileName;
                        return ConfigurationManager.AppSettings["ServerImagePath"] + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + CloudSourceImagePath;
                }
                else
                {
                    if (!string.IsNullOrEmpty(CloudinaryWatermarkImagePublicId))
                    {
                        if (!string.IsNullOrEmpty(CloudImageURL))
                            return CloudImageURL.Replace(ConfigurationManager.AppSettings["ServerImagePath"], ConfigurationManager.AppSettings["ServerImagePath"] + "/" + "w_400,l_" + CloudinaryWatermarkImagePublicId + "/");
                        else
                            //  return ConfigurationManager.AppSettings["ServerImagePath"] + "/w_1000,l_" + CloudinaryWatermarkImagePublicId  + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + Country + "/" + Store + "/" + SubStoreName + "/" + OrderDate.ToString("yyyyMMdd") + "/" + OrderId + "/" + IdentificationCode + "/" + FileName;
                            return ConfigurationManager.AppSettings["ServerImagePath"] + "/w_" + Width + ",h_" + Height + ",c_fit,l_" + CloudinaryWatermarkImagePublicId + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + CloudSourceImagePath;
                    }
                    else
                    {

                        if (!string.IsNullOrEmpty(CloudImageURL))
                            return CloudImageURL;
                        else
                            //return ConfigurationManager.AppSettings["ServerImagePath"] + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + Country + "/" + Store + "/" + SubStoreName + "/" + OrderDate.ToString("yyyyMMdd") + "/" + OrderId + "/" + IdentificationCode + "/" + FileName;
                            return ConfigurationManager.AppSettings["ServerImagePath"] + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + CloudSourceImagePath;
                    }

                }
            }

        }

        public string ThumbnailVideoPath
        {
            get
            {
                // return ConfigurationManager.AppSettings["ServerVideoPath"] + "w_250,h_160,c_pad/l_" + ConfigurationManager.AppSettings["VideoFileOverlayImage"] + ",e_brightness:500/" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + Country + "/" + Store + "/" + SubStoreName + "/" + OrderDate.ToString("yyyyMMdd") + "/" + OrderId + "/" + IdentificationCode + "/" + FileName.Substring(0, FileName.LastIndexOf('.') + 1) + "jpg";
                return ConfigurationManager.AppSettings["ServerVideoPath"] + "w_250,h_150,c_pad/l_" + ConfigurationManager.AppSettings["VideoFileOverlayImage"] + ",e_brightness:500/" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + CloudSourceImagePath.Substring(0, CloudSourceImagePath.LastIndexOf('.') + 1) + "jpg"; ;
            }
        }

        public string VideoFilePath
        {
            get
            {
                //   return ConfigurationManager.AppSettings["ServerVideoPath"] + "q_" + ConfigurationManager.AppSettings["DeliverVideoQuality"] + "/" + "fl_attachment" + "/" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + Country + "/" + Store + "/" + SubStoreName + "/" + OrderDate.ToString("yyyyMMdd") + "/" + OrderId + "/" + IdentificationCode + "/" + FileName.Substring(0, FileName.LastIndexOf('.') + 1) + "webm";
                return ConfigurationManager.AppSettings["ServerVideoPath"] + "q_" + ConfigurationManager.AppSettings["DeliverVideoQuality"] + "/" + "fl_attachment" + "/" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + CloudSourceImagePath.Substring(0, CloudSourceImagePath.LastIndexOf('.') + 1) + "webm";
            }
        }

        public string VideoPublicId
        {
            get
            {
                //string PID = ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + Country + "/" + Store + "/" + SubStoreName + "/" + OrderDate.ToString("yyyyMMdd") + "/" + OrderId + "/" + IdentificationCode + "/" + FileName.Substring(0, FileName.LastIndexOf('.'));
                string PID = ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + CloudSourceImagePath.Substring(0, CloudSourceImagePath.LastIndexOf('.'));
                return PID = PID.Remove(0, 1);
            }
        }
        public int MediaType { get; set; }

        public string CloudinaryPublicId
        {
            get
            {
                string publicId = string.Empty;
                if (!string.IsNullOrEmpty(CloudImageURL))
                {
                    publicId = CloudImageURL.Replace(ConfigurationManager.AppSettings["ServerImagePath"], "");
                    string[] dirs = publicId.Split('/');
                    if (dirs.Length > 0)
                    {
                        publicId = publicId.Replace(dirs[0], "");
                    }
                }
                else
                {
                    //publicId = ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + Country + "/" + Store + "/" + SubStoreName + "/" + OrderDate.ToString("yyyyMMdd") + "/" + OrderId + "/" + IdentificationCode + "/" + FileName;
                    publicId = ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + CloudSourceImagePath;
                }
                return publicId.Substring(0, publicId.Length - 4).TrimStart('/');
            }
        }

        public string FileName { get; set; }
        public long CustomerQRCodeId { get; set; }
        public string IdentificationCode { get; set; }
        public string OrderId { get; set; }
        public string PackageName { get; set; }
        public string Photos { get; set; }
        public DateTime OrderDate { get; set; }
        public long SubStoreId { get; set; }
        public long digiMasterLocationId { get; set; }
        public string Name { get; set; }
        public int IMIXPhotoId { get; set; }
        public string SubStoreName { get; set; }
        public string Store { get; set; }
        public string Country { get; set; }
        public string LayeringObjects { get; set; }
        public string BorderName { get; set; }
        public string BorderDimension { get; set; }
        public string BorderImagePath { get; set; }
        public string BorderImageFullPath
        {
            get
            {
                string IMIXBordersPath = ConfigurationManager.AppSettings["ServerImagePath"].ToString() + ConfigurationManager.AppSettings["IMIXBordersPathFolder"].ToString();
                return System.IO.Path.Combine(IMIXBordersPath, BorderName);
            }
        }

        public string BorderImagePublicId
        {
            get
            {
                return ConfigurationManager.AppSettings["IMIXBordersPathFolder"] + "/" + BorderName;
            }
        }

        public string BorderImageThumbnailsFullPath
        {
            get
            {
                string IMIXBordersThumbnailPath = ConfigurationManager.AppSettings["ServerImagePath"].ToString() + "w_200,h_200,c_fit/" + ConfigurationManager.AppSettings["IMIXBordersPath"].ToString();
                return System.IO.Path.Combine(IMIXBordersThumbnailPath, BorderName);
            }
        }
        public string StickerName { get; set; }
        public string StickerImagePath { get; set; }
        public string StickerImageFullPath
        {
            get
            {
                string IMIXGraphicsPath = ConfigurationManager.AppSettings["ServerImagePath"].ToString() + ConfigurationManager.AppSettings["IMIXGraphicsPath"].ToString();
                return System.IO.Path.Combine(IMIXGraphicsPath, StickerName);
            }
        }
        public DateTime CreatedDate { get; set; }
        public DateTime ExpireyDate { get; set; }
        public int IsStockShot { get; set; }
        public bool IsPaidImage { get; set; }
        public string WatermarkImagePath { get; set; }

        public string CloudinaryWatermarkImagePublicId
        {
            get
            {
                string publicId = string.Empty;
                if (!string.IsNullOrEmpty(WatermarkImagePath))
                {
                    publicId = WatermarkImagePath.Replace(ConfigurationManager.AppSettings["ServerImagePath"], "");
                    string[] dirs = publicId.Split('/');
                    if (dirs.Length > 0)
                    {
                        publicId = publicId.Replace(dirs[0], "");
                    }
                    return publicId.Substring(0, publicId.Length - 4).TrimStart('/').Replace('/', ':');
                }
                else
                    return publicId;


            }
        }
        public long ImageLocationID { get; set; }

        private string _CloudSourceImagePath;
        public string CloudSourceImagePath
        {
            get
            {
                if (!string.IsNullOrEmpty(_CloudSourceImagePath))
                    return _CloudSourceImagePath;
                else
                    _CloudSourceImagePath = Country + "/" + Store + "/" + SubStoreName + "/" + OrderDate.ToString("yyyyMMdd") + "/" + OrderId + "/" + IdentificationCode + "/" + FileName;
                return _CloudSourceImagePath;
            }
            set
            {
                _CloudSourceImagePath = value;
            }
        }

    }
}

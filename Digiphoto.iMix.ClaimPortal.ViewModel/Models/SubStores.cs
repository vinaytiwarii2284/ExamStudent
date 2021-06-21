using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiphoto.iMix.ClaimPortal.Model
{
    public class SubStores
    {
        public string CloudImageURL { get; set; }
        public long CustomerQRCodeId { get; set; }
        public string IdentificationCode { get; set; }
        public string OrderId { get; set; }
        public string PackageName { get; set; }
        public string Photos { get; set; }
        public DateTime OrderDate { get; set; }
        public long SubStoreId { get; set; }
        public long digiMasterLocationId { get; set; }
        public string Country { get; set; }
        public string Store { get; set; }
        public string SubStoreName { get; set; }
        public string FileName { get; set; }
        public string SubStoreEncryptedId { get; set; }
        public int IMIXPhotoId { get; set; }
        //public string SubStoreName { get; set; }
        public int PhotoId { get; set; }
        public string FileThumbnailPath
        {
            get
            {
                if (IsPaidImage)
                {

                    if (!string.IsNullOrEmpty(CloudImageURL))
                        return CloudImageURL.Replace(ConfigurationManager.AppSettings["ServerImagePath"], ConfigurationManager.AppSettings["ServerImagePath"] + "w_250,h_150,c_pad/") + "?t=" + DateTime.Now.ToFileTimeUtc();
                    else
                        //return ConfigurationManager.AppSettings["ServerImagePath"] + "w_250,h_150,c_pad" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + Country + "/" + Store + "/" + SubStoreName + "/" + OrderDate.ToString("yyyyMMdd") + "/" + OrderId + "/" + IdentificationCode + "/" + FileName + "?t=" + DateTime.Now.ToFileTimeUtc();
                        return ConfigurationManager.AppSettings["ServerImagePath"] + "w_250,h_150,c_pad" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + CloudSourceImagePath + "?t=" + DateTime.Now.ToFileTimeUtc();
                }
                else
                {
                    if (!string.IsNullOrEmpty(CloudinaryWatermarkImagePublicId))
                    {
                        if (!string.IsNullOrEmpty(CloudImageURL))
                            return CloudImageURL.Replace(ConfigurationManager.AppSettings["ServerImagePath"], ConfigurationManager.AppSettings["ServerImagePath"] + "w_250,h_150,c_pad/" + "w_200,l_" + CloudinaryWatermarkImagePublicId + "/") + "?t=" + DateTime.Now.ToFileTimeUtc();
                        else
                           // return ConfigurationManager.AppSettings["ServerImagePath"] + "w_250,h_150,c_pad" + "/w_200,l_" + CloudinaryWatermarkImagePublicId + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + Country + "/" + Store + "/" + SubStoreName + "/" + OrderDate.ToString("yyyyMMdd") + "/" + OrderId + "/" + IdentificationCode + "/" + FileName + "?t=" + DateTime.Now.ToFileTimeUtc();
                            return ConfigurationManager.AppSettings["ServerImagePath"] + "w_250,h_150,c_pad" + "/w_200,l_" + CloudinaryWatermarkImagePublicId + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + CloudSourceImagePath + "?t=" + DateTime.Now.ToFileTimeUtc();
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(CloudImageURL))
                            return CloudImageURL.Replace(ConfigurationManager.AppSettings["ServerImagePath"], ConfigurationManager.AppSettings["ServerImagePath"] + "w_250,h_150,c_pad/") + "?t=" + DateTime.Now.ToFileTimeUtc();
                        else
                            //return ConfigurationManager.AppSettings["ServerImagePath"] + "w_250,h_150,c_pad" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + Country + "/" + Store + "/" + SubStoreName + "/" + OrderDate.ToString("yyyyMMdd") + "/" + OrderId + "/" + IdentificationCode + "/" + FileName + "?t=" + DateTime.Now.ToFileTimeUtc();
                            return ConfigurationManager.AppSettings["ServerImagePath"] + "w_250,h_150,c_pad" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + CloudSourceImagePath + "?t=" + DateTime.Now.ToFileTimeUtc();
                    }

                }
            }
        }
        public string FileFullPath
        {
            get
            {
                // return ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + Country + "/" + Store + "/" + SubStoreName + "/" + OrderDate.ToString("yyyyMMdd") + "/" + OrderId + "/" + IdentificationCode + "/" + FileName;
                return ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + CloudSourceImagePath;
            }
        }

        public string ThumbnailVideoPath
        {
            get
            {
                //http://res.cloudinary.com/www-commdel-net/video/upload/w_250,h_150,c_pad/l_media_player,e_brightness:500/v1443087785/OrderImages/Dubai/ATT/At%20The%20Top/20150914/DG-1131454190/BURJ1014/5016_1223.jpg
                //return ConfigurationManager.AppSettings["ServerVideoPath"] + "w_250,h_160,c_pad/l_" + ConfigurationManager.AppSettings["VideoFileOverlayImage"] + ",e_brightness:500/" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + Country + "/" + Store + "/" + SubStoreName + "/" + OrderDate.ToString("yyyyMMdd") + "/" + OrderId + "/" + IdentificationCode + "/" + FileName.Substring(0, FileName.LastIndexOf('.') + 1) + "jpg";
                return ConfigurationManager.AppSettings["ServerVideoPath"] + "w_250,h_160,c_pad/l_" + ConfigurationManager.AppSettings["VideoFileOverlayImage"] + ",e_brightness:500/" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + CloudSourceImagePath.Substring(0, CloudSourceImagePath.LastIndexOf('.') + 1) + "jpg";
            }
        }

        public string VideoFilePath
        {
            get
            {
                //http://res.cloudinary.com/www-commdel-net/video/upload/v1443087785/OrderImages/Dubai/ATT/At%20The%20Top/20150914/DG-1131454190/BURJ1014/5016_1223.mp4
               // return ConfigurationManager.AppSettings["ServerVideoPath"] + "q_" + ConfigurationManager.AppSettings["DeliverVideoQuality"] + "/" + "fl_attachment" + "/" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + Country + "/" + Store + "/" + SubStoreName + "/" + OrderDate.ToString("yyyyMMdd") + "/" + OrderId + "/" + IdentificationCode + "/" + FileName.Substring(0, FileName.LastIndexOf('.') + 1) + "webm";
                return ConfigurationManager.AppSettings["ServerVideoPath"] + "q_" + ConfigurationManager.AppSettings["DeliverVideoQuality"] + "/" + "fl_attachment" + "/" + ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + CloudSourceImagePath.Substring(0, CloudSourceImagePath.LastIndexOf('.') + 1) + "webm";
            }
        }

        public int MediaType { get; set; }


        public DateTime CreatedDate { get; set; }
        public DateTime ExpireyDate { get; set; }
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
        public string VideoPublicId
        {
            get
            {
                string PID = ConfigurationManager.AppSettings["ServerImagePathFolder"] + "/" + Country + "/" + Store + "/" + SubStoreName + "/" + OrderDate.ToString("yyyyMMdd") + "/" + OrderId + "/" + IdentificationCode + "/" + FileName.Substring(0, FileName.LastIndexOf('.'));
                return PID = PID.Remove(0, 1);
            }
        }

        public long ImageLocationID { get; set; }

        private string _CloudSourceImagePath;
        public string CloudSourceImagePath
        {
            get
            {
                //  if (!string.IsNullOrEmpty(_CloudSourceImagePath))
                return _CloudSourceImagePath;
                //else
                //    _CloudSourceImagePath = Country + "/" + Store + "/" + SubStoreName + "/" + OrderDate.ToString("yyyyMMdd") + "/" + OrderId + "/" + IdentificationCode + "/" + FileName;
                //return _CloudSourceImagePath;
            }
            set
            {
                _CloudSourceImagePath = value;
            }
        }
    }
}

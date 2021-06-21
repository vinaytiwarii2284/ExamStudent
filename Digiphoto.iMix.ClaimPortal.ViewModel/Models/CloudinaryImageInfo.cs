using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiphoto.iMix.ClaimPortal.Model
{
    public class CloudinaryImageInfo
    {
        public int PartnerID { get; set; }
        public string SourceImageID { get; set; }
        public string CloudinaryImageID { get; set; }
        public short UploadStatusID { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsNew { get; set; }
        public int WebPhotoID { get; set; }
        public string DynamicFilePath { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Dimension { get; set; }

        
    }
}

using Digiphoto.iMix.ClaimPortal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamStudent.ViewModel
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            loginViewModel = new LoginViewModel();
            qrClaim = new QRClaim();
        }
        public LoginViewModel loginViewModel { get; set; }
        public QRClaim qrClaim { get; set; }
    }
}

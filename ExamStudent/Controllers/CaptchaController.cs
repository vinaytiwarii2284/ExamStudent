using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Web.Mvc;

namespace ExamStudent.Controllers
{
    /// <summary>
    /// This class is fully self-contained. All Captcha related code including
    /// handling of session veriables, hashing, validation etc. is located here.
    /// In order to use this class include the following image tag somwhere in
    /// your view, e.g. in the view handling the registration process:
    /// <img src='/Captcha/Show' alt="" />
    /// </summary>
    public class CaptchaController : BaseController
    {
        public JsonResult ValidateCaptcha(string CaptchaValue)
        {
            bool b = IsValidCaptchaValue(CaptchaValue);
            if (!b) return Json(string.Empty, JsonRequestBehavior.AllowGet);
            else return Json(true, JsonRequestBehavior.AllowGet);
        }
        public JsonResult ValidateInvisibleCaptcha(string CaptchaValue)
        {
            bool b = CaptchaValue == "";
            if (!b) return Json(string.Empty, JsonRequestBehavior.AllowGet);
            else return Json(true, JsonRequestBehavior.AllowGet);
        }

        private const int height = 30;
        private const int width = 80;
        private const int length = 4;
        private const string chars = "ABCDEFGHIJKLMNPQRSTUVWXYZ123456789";

        public ActionResult Show2()
        {
            var randomText = GenerateRandomText(length);
            var hash = ComputeMd5Hash(randomText + GetSalt());
            Session["CaptchaHash"] = hash;

            var rnd = new Random();
            var fonts = new[] { "Verdana", "Times New Roman" };
            float orientationAngle = rnd.Next(0, 359);

            var index0 = rnd.Next(0, fonts.Length);
            var familyName = fonts[index0];

            using (var bmpOut = new Bitmap(width, height))
            {
                var g = Graphics.FromImage(bmpOut);
                var gradientBrush = new LinearGradientBrush(new Rectangle(0, 0, width, height),
                                                            Color.White, Color.DarkGray,
                                                            orientationAngle);
                g.FillRectangle(gradientBrush, 0, 0, width, height);
                DrawRandomLines(ref g, width, height);
                g.DrawString(randomText, new Font(familyName, 18), new SolidBrush(Color.Gray), 0, 2);
                var ms = new MemoryStream();
                bmpOut.Save(ms, ImageFormat.Png);
                var bmpBytes = ms.GetBuffer();
                bmpOut.Dispose();
                ms.Close();

                return new FileContentResult(bmpBytes, "image/png");
            }
        }
        [HttpGet]
        [Route("Captcha/Show")]
        public ActionResult Show()
        {
            string prefix = null;
            bool noisy = true;
            var rand = new Random((int)DateTime.Now.Ticks);
            //generate new question 
            int a = rand.Next(10, 99);
            int b = rand.Next(0, 9);
            //var captcha = string.Format("{0} + {1} = ?",  + a +"</b>", b);
            var captcha = string.Format("{0} + {1} =", a, b);


            //store answer 
            Session["Captcha" + prefix] = a + b;

            //image stream 
            FileContentResult img = null;

            using (var mem = new MemoryStream())
            //using (var bmp = new Bitmap(100, 30))
            using (var bmp = new Bitmap(75, 26))
            using (var gfx = Graphics.FromImage((Image)bmp))
            {
                gfx.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                gfx.SmoothingMode = SmoothingMode.AntiAlias;

                string hex = "#00609c";
                Color _color = System.Drawing.ColorTranslator.FromHtml(hex);
                //var brush = (Brush)converter.ConvertFromString("#143e53");

                Brush brush = new SolidBrush(_color);

                gfx.FillRectangle(brush, new Rectangle(0, 0, bmp.Width, bmp.Height));

                //add noise 
                if (noisy)
                {
                    int i, r, x, y;
                    var pen = new Pen(Color.Yellow);

                }

                //add question 
                gfx.DrawString(captcha, new Font("benguiat-medium", 13), Brushes.White, 2, 3);

                //render as Jpeg 
                bmp.Save(mem, System.Drawing.Imaging.ImageFormat.Jpeg);
                img = this.File(mem.GetBuffer(), "image/Jpeg");
            }

            //  return img;
            return File(img.FileContents, img.ContentType);
        }
        public ActionResult Show(string prefix, bool noisy = true)
        {
            var rand = new Random((int)DateTime.Now.Ticks);
            //generate new question 
            int a = rand.Next(10, 99);
            int b = rand.Next(0, 9);
            //var captcha = string.Format("{0} + {1} = ?",  + a +"</b>", b);
            var captcha = string.Format("{0} + {1} =", a, b);


            //store answer 
            Session["Captcha" + prefix] = a + b;

            //image stream 
            FileContentResult img = null;

            using (var mem = new MemoryStream())
            //using (var bmp = new Bitmap(100, 30))
            using (var bmp = new Bitmap(75, 26))
            using (var gfx = Graphics.FromImage((Image)bmp))
            {
                gfx.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                gfx.SmoothingMode = SmoothingMode.AntiAlias;

                string hex = "#00609c";
                Color _color = System.Drawing.ColorTranslator.FromHtml(hex);
                //var brush = (Brush)converter.ConvertFromString("#143e53");

                Brush brush = new SolidBrush(_color);

                gfx.FillRectangle(brush, new Rectangle(0, 0, bmp.Width, bmp.Height));

                //add noise 
                if (noisy)
                {
                    int i, r, x, y;
                    var pen = new Pen(Color.Yellow);
                    //for (i = 1; i < 10; i++)
                    //{
                    //    pen.Color = Color.FromArgb(
                    //    (rand.Next(0, 255)),
                    //    (rand.Next(0, 255)),
                    //    (rand.Next(0, 255)));

                    //    r = rand.Next(0, (130 / 3));
                    //    x = rand.Next(0, 130);
                    //    y = rand.Next(0, 30);

                    //    gfx.DrawEllipse(pen, x - r, y - r, r, r);
                    //}
                }

                //add question 
                gfx.DrawString(captcha, new Font("benguiat-medium", 13), Brushes.White, 2, 3);

                //render as Jpeg 
                bmp.Save(mem, System.Drawing.Imaging.ImageFormat.Jpeg);
                img = this.File(mem.GetBuffer(), "image/Jpeg");
            }

            //  return img;
            return File(img.FileContents, img.ContentType);
        }
        public ActionResult CaptchaImage(string prefix, bool noisy = true)
        {
            var rand = new Random((int)DateTime.Now.Ticks);
            //generate new question 
            int a = rand.Next(10, 99);
            int b = rand.Next(0, 9);
            //var captcha = string.Format("{0} + {1} = ?",  + a +"</b>", b);
            var captcha = string.Format("{0} + {1} =", a, b);


            //store answer 
            Session["Captcha" + prefix] = a + b;

            //image stream 
            FileContentResult img = null;

            using (var mem = new MemoryStream())
            //using (var bmp = new Bitmap(100, 30))
            using (var bmp = new Bitmap(75, 26))
            using (var gfx = Graphics.FromImage((Image)bmp))
            {
                gfx.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                gfx.SmoothingMode = SmoothingMode.AntiAlias;

                string hex = "#bf2236";
                Color _color = System.Drawing.ColorTranslator.FromHtml(hex);
                //var brush = (Brush)converter.ConvertFromString("#143e53");

                Brush brush = new SolidBrush(_color);

                gfx.FillRectangle(brush, new Rectangle(0, 0, bmp.Width, bmp.Height));

                //add noise 
                if (noisy)
                {
                    int i, r, x, y;
                    var pen = new Pen(Color.Yellow);
                    //for (i = 1; i < 10; i++)
                    //{
                    //    pen.Color = Color.FromArgb(
                    //    (rand.Next(0, 255)),
                    //    (rand.Next(0, 255)),
                    //    (rand.Next(0, 255)));

                    //    r = rand.Next(0, (130 / 3));
                    //    x = rand.Next(0, 130);
                    //    y = rand.Next(0, 30);

                    //    gfx.DrawEllipse(pen, x - r, y - r, r, r);
                    //}
                }

                //add question 
                gfx.DrawString(captcha, new Font("benguiat-medium", 13), Brushes.White, 2, 3);

                //render as Jpeg 
                bmp.Save(mem, System.Drawing.Imaging.ImageFormat.Jpeg);
                img = this.File(mem.GetBuffer(), "image/Jpeg");
            }

            return img;
        }

        public static bool IsValidCaptchaValue(string captchaValue)
        {
            var expectedHash = System.Web.HttpContext.Current.Session["CaptchaHash"];
            var toCheck = captchaValue + GetSalt();
            var hash = ComputeMd5Hash(toCheck);
            return hash.Equals(expectedHash);
        }

        private static void DrawRandomLines(ref Graphics g, int width, int height)
        {
            var rnd = new Random();
            var pen = new Pen(Color.Gray);
            for (var i = 0; i < 3; i++)
            {
                g.DrawLine(pen, rnd.Next(0, width), rnd.Next(0, height),
                                rnd.Next(0, width), rnd.Next(0, height));
            }
        }

        private static string GetSalt()
        {
            return typeof(CaptchaController).Assembly.FullName;
        }

        private static string ComputeMd5Hash(string input)
        {
            var encoding = new ASCIIEncoding();
            var bytes = encoding.GetBytes(input);
            HashAlgorithm md5Hasher = MD5.Create();
            return BitConverter.ToString(md5Hasher.ComputeHash(bytes));
        }

        private static string GenerateRandomText(int textLength)
        {
            var random = new Random();
            var result = new string(Enumerable.Repeat(chars, textLength)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
            return result;
        }
    }
}
﻿using ExamStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace PayUmoneytry.Controllers
{
    public class DemoController : Controller
    {
        ExamStudentContext context = new ExamStudentContext();

        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Demo(string id=null)
        {
            try
            {
                string firstName = Session["FirstName"].ToString();
                string amount = Session["Amount"].ToString();
                string productInfo = Session["productInfo"].ToString();
                string email = Session["EmailAddress"].ToString();
                string phone = Session["PhoneNumber"].ToString();
                //string surl = "http://localhost:51989/Return/Return";  //Change the success url here depending upon the port number of your local system.
                //string furl = "http://localhost:51989/Return/Return";  //Change the failure url here depending upon the port number of your local system.


                string surl = "http://edualphabet.com/Return/Return";
                string furl = "http://edualphabet.com/Return/Return";

                Session["AppId"] = id;
                TabPayumoneyTransectionLog obj = new TabPayumoneyTransectionLog();
                obj.Amount = Convert.ToDecimal(amount);
                obj.FirstName = firstName;
                obj.ApplicationID = id;
                obj.EmailAddress = email;
                obj.PhoneNumber = phone;
                obj.productInfo = productInfo;
                obj.Date = DateTime.Now;
                obj.IsPaid = false;
                context.TabPayumoneyTransectionLogs.Add(obj);
                context.SaveChanges();


                RemotePost myremotepost = new RemotePost();
                //Add your MarchantID;  
                string key = "0K1KWLkn";
                //Add your SaltID;  
                string salt = "Rga2Dm3Q6g";

                //posting all the parameters required for integration.  

                myremotepost.Url = "https://secure.payu.in/_payment";
                myremotepost.Add("key", "0K1KWLkn");
                string txnid = Generatetxnid();
                myremotepost.Add("txnid", txnid);
                myremotepost.Add("amount", amount);
                myremotepost.Add("productinfo", productInfo);
                myremotepost.Add("firstname", firstName);
                myremotepost.Add("phone", phone);
                myremotepost.Add("email", email);

                //myremotepost.Add("surl", "http://localhost:51989/Return/Return");//Change the success url here depending upon the port number of your local system.  
                //myremotepost.Add("furl", "http://localhost:51989/Return/Return");//Change the failure url here depending upon the port number of your local system.  


                myremotepost.Add("surl", "http://edualphabet.com/Return/Return");
                myremotepost.Add("furl", "http://edualphabet.com/Return/Return");

                myremotepost.Add("service_provider", "payu_paisa");
                string hashString = key + "|" + txnid + "|" + amount + "|" + productInfo + "|" + firstName + "|" + email + "|||||||||||" + salt;
                string hash = Generatehash512(hashString);
                myremotepost.Add("hash", hash);

                myremotepost.Post();
            }
            catch (Exception exp)
            {
                throw;
            }

            return View();
        }

        [HttpPost]
        public void Demo(FormCollection form)
        {
         


        }

        private string Generatetxnid()
        {
            Random rnd = new Random();
            string strHash = Generatehash512(rnd.ToString() + DateTime.Now);
            string txnid1 = strHash.ToString().Substring(0, 20);

            return txnid1;
        }

        private string Generatehash512(string text)
        {
            byte[] message = Encoding.UTF8.GetBytes(text);

            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] hashValue;
            SHA512Managed hashString = new SHA512Managed();
            string hex = "";
            hashValue = hashString.ComputeHash(message);
            foreach (byte x in hashValue)
            {
                hex += String.Format("{0:x2}", x);
            }
            return hex;
        }
        public class RemotePost
        {
            private System.Collections.Specialized.NameValueCollection Inputs = new System.Collections.Specialized.NameValueCollection();


            public string Url = "";
            public string Method = "post";
            public string FormName = "form1";

            public void Add(string name, string value)
            {
                Inputs.Add(name, value);
            }

            public void Post()
            {
                System.Web.HttpContext.Current.Response.Clear();

                System.Web.HttpContext.Current.Response.Write("<html><head>");

                System.Web.HttpContext.Current.Response.Write(string.Format("</head><body onload=\"document.{0}.submit()\">", FormName));
                System.Web.HttpContext.Current.Response.Write(string.Format("<form name=\"{0}\" method=\"{1}\" action=\"{2}\" >", FormName, Method, Url));
                for (int i = 0; i < Inputs.Keys.Count; i++)
                {
                    System.Web.HttpContext.Current.Response.Write(string.Format("<input name=\"{0}\" type=\"hidden\" value=\"{1}\">", Inputs.Keys[i], Inputs[Inputs.Keys[i]]));
                }
                System.Web.HttpContext.Current.Response.Write("</form>");
                System.Web.HttpContext.Current.Response.Write("</body></html>");

                System.Web.HttpContext.Current.Response.End();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Xml.Serialization;

namespace Digiphoto.iMix.ClaimPortal.Common
{
    public static class CommonUtility
    {
        public const string PASS_PHRASE = "Pas5pr@se";
        public const string INIT_VECTOR = "@1B2c3D4e5F6g7H8";

        public static string EncryptQueryString(string plainText)
        {
            string key = "jdsg432387#";
            byte[] EncryptKey = { };
            byte[] IV = { 55, 34, 87, 64, 87, 195, 54, 21 };
            EncryptKey = System.Text.Encoding.UTF8.GetBytes(key.Substring(0, 8));
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByte = Encoding.UTF8.GetBytes(plainText);
            MemoryStream mStream = new MemoryStream();
            CryptoStream cStream = new CryptoStream(mStream, des.CreateEncryptor(EncryptKey, IV), CryptoStreamMode.Write);
            cStream.Write(inputByte, 0, inputByte.Length);
            cStream.FlushFinalBlock();
            return HttpServerUtility.UrlTokenEncode(mStream.ToArray());
        }

        public static string DecryptQueryString(string encryptedText)
        {
            string key = "jdsg432387#";
            byte[] DecryptKey = { };
            byte[] IV = { 55, 34, 87, 64, 87, 195, 54, 21 };
            byte[] inputByte = new byte[encryptedText.Length];

            DecryptKey = System.Text.Encoding.UTF8.GetBytes(key.Substring(0, 8));
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            inputByte = HttpServerUtility.UrlTokenDecode(encryptedText);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(DecryptKey, IV), CryptoStreamMode.Write);
            cs.Write(inputByte, 0, inputByte.Length);
            cs.FlushFinalBlock();
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;
            return encoding.GetString(ms.ToArray());
        }       

        public static int GetRandomNumber(int maxNumber)
        {
            if (maxNumber < 1)
                throw new System.Exception("The maxNumber value should be greater than 1");
            byte[] b = new byte[4];
            new System.Security.Cryptography.RNGCryptoServiceProvider().GetBytes(b);
            int seed = (b[0] & 0x7f) << 24 | b[1] << 16 | b[2] << 8 | b[3];
            System.Random r = new System.Random(seed);
            return r.Next(1, maxNumber);
        }
        public static string GetRandomString(int length)
        {
            string[] array = new string[32]
	        {
		        "0","1","2","3","4","5","6","8","9","A","B","C","D","E","F","G","H","J","K","L","M","N","P","R","S","T","U","V","W","X","Y","Z"
	        };
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < length; i++) sb.Append(array[GetRandomNumber(32)]);
            return sb.ToString();
        }
        public static string SerializeObject<T>(this T toSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(toSerialize.GetType());
            StringWriter textWriter = new StringWriter();

            xmlSerializer.Serialize(textWriter, toSerialize);
            return textWriter.ToString().Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "");
        }

        //Due to change in the encryption algo in IMIX web(same as in IMIX desktop), changes has been done here also

        //public static string Encrypt(string val)
        //{
        //    // Before encrypting data, we will append plain text to a random
        //    // salt value, which will be between 4 and 8 bytes long (implicitly
        //    // used defaults).
        //    EncryptionManager encryptionManager = new EncryptionManager(PASS_PHRASE, INIT_VECTOR);

        //    //encrypt
        //    return encryptionManager.Encrypt(val);
        //}
        //public static string Decrypt(string val)
        //{
        //    // Before encrypting data, we will append plain text to a random
        //    // salt value, which will be between 4 and 8 bytes long (implicitly
        //    // used defaults).
        //    EncryptionManager rijndaelKey = new EncryptionManager(PASS_PHRASE, INIT_VECTOR);

        //    //decrypt
        //    return rijndaelKey.Decrypt(val);
        //}
       
        /// <summary>
        /// Encrypt a string using dual encryption method. Return a encrypted cipher Text
        /// </summary>
        /// <param name="toEncrypt">string to be encrypted</param>
        /// <param name="useHashing">use hashing? send to for extra secirity</param>
        /// <returns></returns>
        public static string Encrypt(string toEncrypt )
        {
            bool useHashing=true;
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            // System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();
            // Get the key from config file
            // string key = (string)settingsReader.GetValue("SecurityKey", typeof(String));
            string key = "mykey";
            //System.Windows.Forms.MessageBox.Show(key);
            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            tdes.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        /// <summary>
        /// DeCrypt a string using dual encryption method. Return a DeCrypted clear string
        /// </summary>
        /// <param name="cipherString">encrypted string</param>
        /// <param name="useHashing">Did you use hashing to encrypt this data? pass true is yes</param>
        /// <returns></returns>
        public static string Decrypt(string cipherString)
        {
            bool useHashing = true;
            byte[] keyArray;
            byte[] toEncryptArray = Convert.FromBase64String(cipherString);

            // System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();
            //Get your key from config file to open the lock!
            //string key = (string)settingsReader.GetValue("SecurityKey", typeof(String));
            string key = "mykey";
            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            tdes.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        public static string GetFbApplicationId()
        {
            return ConfigurationManager.AppSettings["FBAPPID"] as string;
        }
    }
}
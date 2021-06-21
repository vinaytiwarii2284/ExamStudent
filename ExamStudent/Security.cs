using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace ExamStudent
{
    public static class Security
    {
        //test Secret Key
        //private const String SECRET_KEY = "b851c988b11d4289b9e3f04fcb69fadb1eda0c57b3f4440a95429e71df3721ff74e27f48c2e54b1b8ec655acc2428efcbcd7820afad545a08604d11443687fc4d0f9249635fa41ce98ca94ae3ee08a513e6f318a8141464cb4a0d62d08990897c6d9b2e81066499badff86924feb50e5598dde71e30c4a5dab5278f515ffe595";
        //live Secret Key
        //private const String SECRET_KEY = "e8443e6f28e74434817b7effb15950b6c2878a8c48e84922a0b15b601c342515abcb1300da2445818ebb212a01f5153c7e7ba005781c499fa7902f8f431d4aa203729ebbfba843149fadcf20db81afea6ef73e5fe8c74c969e77f9532802f912b0dec77fb1ad4de28aaa6efb24a3dc5712dee862be1c477291bcd5abbb6016da";

        //private const String SECRET_KEY = "018aea32fb5f46078d513c114f7dbcbdfbb874bda4da474baadf20ced36c73a92809894afa6c4943aba3c3bdd9cef66e921e4de77ebc4acc98284cebd58def2ef21b8aef8ee94768b92f36c5bbc5f83532c85420f0b044ee8ffb4950a3800ab29ccf5e468c2542388b7c6e7d007ce67147ad4b5419a9442097650b86feb11172";
        //string Key = 
        private static String SECRET_KEY = Convert.ToString(ConfigurationManager.AppSettings["PaymentSecretKey"]);
        //"ca7d5280147e429a9d47fb00108cdef5fc7eef4a82b14639aac1a3550cf1ae662cfe4f58f18e4551920108f5580489862e24eb39a8a64eb29412ff604829f86b8fba41ef242e4797bbeb7b9f3f6488853c61729f562e4849aaba14f6daa3f3e6f5dbadd67c2c4a65ae3d9dc4b2d7f0612e08a959ead4446aa0f8fe2219a3ed67";
        public static String sign(IDictionary<string, string> paramsArray)
        {
            return sign(buildDataToSign(paramsArray), SECRET_KEY);
        }
        public static String sign(IList<string> dataToSign)
        {
            return sign(commaSeparate(dataToSign), SECRET_KEY);
        }
        private static String sign(String data, String secretKey)
        {
            UTF8Encoding encoding = new System.Text.UTF8Encoding();
            byte[] keyByte = encoding.GetBytes(secretKey);

            HMACSHA256 hmacsha256 = new HMACSHA256(keyByte);
            byte[] messageBytes = encoding.GetBytes(data);
            return Convert.ToBase64String(hmacsha256.ComputeHash(messageBytes));
        }

        private static String buildDataToSign(IDictionary<string, string> paramsArray)
        {
            String[] signedFieldNames = paramsArray["signed_field_names"].Split(',');
            IList<string> dataToSign = new List<string>();

            foreach (String signedFieldName in signedFieldNames)
            {
                dataToSign.Add(signedFieldName + "=" + paramsArray[signedFieldName]);
            }

            return commaSeparate(dataToSign);
        }

        private static String commaSeparate(IList<string> dataToSign)
        {
            return String.Join(",", dataToSign);
        }
    }
}
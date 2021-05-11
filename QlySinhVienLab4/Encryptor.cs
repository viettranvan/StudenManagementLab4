using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace QlySinhVienLab4
{
    class Encryptor
    {
        public static string MD5Hash(string plainText)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(plainText));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        public static string SHA1Hash(string plainText)
        {
            SHA1Managed sha1 = new SHA1Managed();

            //compute hash from the bytes of text 
            sha1.ComputeHash(ASCIIEncoding.ASCII.GetBytes(plainText));

            //get hash result after compute it  
            byte[] result = sha1.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security.Policy;

namespace HashTool
{
    internal class Hasher
    {
        public static Hasher hasher { get; private set; }
        public string base64Encode(string tohash)
        {
            try
            {
                var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(tohash);
                return System.Convert.ToBase64String(plainTextBytes);
            }
            catch (Exception e) 
            {
                return e.Message;
            }
            
        }
        public string base64Decode(string totext)
        {
            try
            {
                var base64EncodedBytes = System.Convert.FromBase64String(totext);
                return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string BytesToHex(byte[] Bytes)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                for(int i = 0; i < Bytes.Length; i++)
                {
                    sb.Append(Bytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
            catch
            (Exception e)
            {
                return e.Message;
            }
        }
        public string HexToString(string Hex)
        {
            try
            {
                byte[] bytearr = new byte[Hex.Length / 2];
                for (int i = 0; i < bytearr.Length; i++)
                {
                    bytearr[i] = Convert.ToByte(Hex.Substring(i * 2), 16);
                }
                return Encoding.UTF8.GetString(bytearr);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string MD5Encode(string toHash)
        {
            try
            {
                using(System.Security.Cryptography.MD5 MD5 = System.Security.Cryptography.MD5.Create())
                {
                    byte[] stringbytes = Encoding.UTF8.GetBytes(toHash);
                    byte[] hashedtext = MD5.ComputeHash(stringbytes);
                    return BytesToHex(hashedtext);
                }               
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}

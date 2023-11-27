using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}

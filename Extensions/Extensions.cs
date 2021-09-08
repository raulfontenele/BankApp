using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Extensions
{
    public static class Extensions
    {
        /// <summary>
        /// Converts hex string to byte array.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static byte[] HexStringToBytes(string s)
        {
            s = s.Replace(" ", "");
            int len = s.Length;
            if ((len & 0x01) != 0)
            {
                s = "0" + s;
                ++len;
            }
            byte[] data = new byte[len / 2];
            for (int i = 0; i < len; i += 2)
            {
                data[i / 2] = (byte)((Convert.ToInt32(s[i].ToString(), 16) << 4) + Convert.ToInt32(s[i + 1].ToString(), 16));
            }
            return data;
        }

        /// <summary>
        /// Converts byte array to string.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string BytesToString(byte[] data)
        {
            StringBuilder sb = new StringBuilder();
            if (data == null) { return null; }
            else
            {
                foreach (byte b in data)
                {
                    sb.Append(string.Format("{0:X2} ", b));
                }
                return sb.ToString();
            }
        }
    }
}

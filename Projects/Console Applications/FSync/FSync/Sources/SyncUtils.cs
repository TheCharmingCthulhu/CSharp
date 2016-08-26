using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSync.Sources
{
    class SyncUtils
    {
        public static string StringToHex(string text)
        {
            return BitConverter.ToString(Encoding.Default.GetBytes(text)).Replace("-", "");
        }

        public static string HexToString(string hex)
        {
            var bytes = new byte[hex.Length / 2];

            for (int i = 0; i < bytes.Length; i++)
                bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);

            return Encoding.Default.GetString(bytes);
        }
    }
}

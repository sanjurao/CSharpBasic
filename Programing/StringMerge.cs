using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class StringMerge
    {
        public void Program()
        {
            string a = "zbxnsjdns";
            string b = "idowdk";

            char[] stra = a.ToCharArray();
            char[] strb = b.ToCharArray();

            int greaterLen = a.Length > b.Length ? a.Length : b.Length;
            int lesserLen = a.Length < b.Length ? a.Length : b.Length;

            string op = string.Empty;
            for (int i = 0; i < lesserLen; i++)
            {
                op += stra[i].ToString() + strb[i].ToString();
            }
            if (b.Length == greaterLen)
            {
                op += b.Substring(lesserLen, greaterLen - lesserLen);
            }

            else if (a.Length == greaterLen)
            {
                string substring = a.Substring(lesserLen, greaterLen - lesserLen);
                op = op + substring;
            }
        }

    }
}

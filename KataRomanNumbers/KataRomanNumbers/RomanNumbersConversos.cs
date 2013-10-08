using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataRomanNumbers
{
    public class RomanNumbersConversos
    {
        public string Convert(int p)
        {
            string ret = string.Empty;
            GetSimbol(ref p, ref ret, 50, "L");
            GetSimbol(ref p, ref ret, 40, "XL");
            GetSimbol(ref p, ref ret,10,"X");
            GetSimbol(ref p, ref ret, 9, "IX");
            GetSimbol(ref p, ref ret, 5, "V");
            GetSimbol(ref p, ref ret, 4, "IV");
            GetSimbol(ref p, ref ret, 1, "I");

            return ret;
        }

        private static void GetSimbol(ref int p, ref string ret, int mod, string simbol)
        {
            if (p > 0)
            {
                var mod10 = p / mod;
                while (mod10 > 0)
                {
                    ret += simbol;
                    mod10--;
                    p = p - mod;
                }
            }
        }
    }
}

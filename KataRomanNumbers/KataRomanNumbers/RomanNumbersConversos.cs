using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataRomanNumbers
{
    public class RomanNumbersConversos
    {
        private static int[] arabicNumbers = new int[]{1,4,5,9,10,40,50,90,100};
        private static string[] romanNumbers = new string[] { "I", "IV", "V","IX","X","XL","L","XC","C" };

        public string Convert(int p)
        {
            return GetRomanNumber(p);
        }

        private static string GetRomanNumber(int arabic)
        {
            string roman = string.Empty;
            int lenght = arabicNumbers.Length - 1;
            for (int i = lenght; i >= 0; i--)
            {
                var mod = arabic / arabicNumbers[i];
                while (mod > 0)
                {
                    roman += romanNumbers[i];
                    mod--;
                    arabic = arabic - arabicNumbers[i];
                }
            }

            return roman;
        }

        public object Convert(string p)
        {
            return ConvertToArabic(p);
        }

        private object ConvertToArabic(string p)
        {
            int arabic = 0;
            int oldIndex = int.MinValue;
            int index = 0;
            for (int i =p.Length -1; i >= 0; i--)
            {
                index = Array.IndexOf(romanNumbers, p[i].ToString());

                if (oldIndex > index)
                {
                    arabic -= arabicNumbers[index];
                }
                else
                {
                    arabic += arabicNumbers[index];
                }

                oldIndex = index;
                
                
            }
            
            return arabic;
        }
    }
}

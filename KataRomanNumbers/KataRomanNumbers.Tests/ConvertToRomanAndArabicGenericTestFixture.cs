using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataRomanNumbers.Tests
{
    [TestClass]
    public class ConvertToRomanAndArabicGenericTestFixture
    {
        private int[] testArabicNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 14, 19, 39, 40, 49, 50, 55, 60, 70, 90, 100 };
        private string[] testRomanNumbers = new string[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "XI", "XIV", "XIX", "XXXIX", "XL", "XLIX", "L", "LV", "LX", "LXX", "XC", "C" };
        
        [TestMethod]
        public void ConverToRoman_Parameter_testArabicNumbers_Return_testRomanNumbers()
        {
            string roman = string.Empty;
            var conversor = new RomanNumbersConverter();
            for (int i = 0; i < testArabicNumbers.Length; i++)
			{
                roman = (string)conversor.Convert(testArabicNumbers[i]);
                Assert.AreEqual(testRomanNumbers[i], roman);
			}
        }

        [TestMethod]
        public void ConverToArabic_Parameter_testRomanNumbers_Return_testArabicNumbers()
        {
            int arabic = 0;
            var conversor = new RomanNumbersConverter();
            for (int i = 0; i < testRomanNumbers.Length; i++)
            {
                arabic = (int)conversor.Convert(testRomanNumbers[i]);
                Assert.AreEqual(testArabicNumbers[i], arabic);
            }
        }
    }
}

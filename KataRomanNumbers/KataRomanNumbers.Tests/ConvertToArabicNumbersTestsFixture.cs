using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataRomanNumbers.Tests
{
    [TestClass]
    public class ConvertToArabicNumbersTestsFixture
    {
        [TestMethod]
        public void ConverToArabic_ParameterI_Return1()
        {
            var conversor = new RomanNumbersConverter();
            var arabicNumber = conversor.Convert("I");
            Assert.AreEqual(1, arabicNumber);
        }

        [TestMethod]
        public void ConverToArabic_ParameterII_Return2()
        {
            var conversor = new RomanNumbersConverter();
            var arabicNumber = conversor.Convert("II");
            Assert.AreEqual(2, arabicNumber);
        }

        [TestMethod]
        public void ConverToArabic_ParameterIV_Return4()
        {
            var conversor = new RomanNumbersConverter();
            var arabicNumber = conversor.Convert("IV");
            Assert.AreEqual(4, arabicNumber);
        }

        [TestMethod]
        public void ConverToArabic_ParameterV_Return5()
        {
            var conversor = new RomanNumbersConverter();
            var arabicNumber = conversor.Convert("V");
            Assert.AreEqual(5, arabicNumber);
        }

        [TestMethod]
        public void ConverToArabic_ParameterVI_Return6()
        {
            var conversor = new RomanNumbersConverter();
            var arabicNumber = conversor.Convert("VI");
            Assert.AreEqual(6, arabicNumber);
        }

        [TestMethod]
        public void ConverToArabic_ParameterCX_Return110()
        {
            var conversor = new RomanNumbersConverter();
            var arabicNumber = conversor.Convert("CX");
            Assert.AreEqual(110, arabicNumber);
        }

        [TestMethod]
        public void ConverToArabic_ParameterXC_Return90()
        {
            var conversor = new RomanNumbersConverter();
            var arabicNumber = conversor.Convert("XC");
            Assert.AreEqual(90, arabicNumber);
        }

    }
}

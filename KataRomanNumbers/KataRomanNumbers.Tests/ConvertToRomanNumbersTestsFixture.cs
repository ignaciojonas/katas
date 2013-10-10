using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataRomanNumbers;

namespace KataRomanNumbers.Tests
{
    [TestClass]
    public class ConvertToRomanNumbersTestsFixture
    {
        [TestMethod]
        public void ConverToRoman_Parameter1_ReturnI()
        {
            var conversor = new RomanNumbersConversos();
            var romanNumber = conversor.Convert(1);
            Assert.AreEqual("I", romanNumber);
        }

        [TestMethod]
        public void ConverToRoman_Parameter10_ReturnX()
        {
            var conversor = new RomanNumbersConversos();
            var romanNumber = conversor.Convert(10);
            Assert.AreEqual("X", romanNumber);
        }

        [TestMethod]
        public void ConverToRoman_Parameter7_ReturnVII()
        {
            var conversor = new RomanNumbersConversos();
            var romanNumber = conversor.Convert(7);
            Assert.AreEqual("VII", romanNumber);
        }

        [TestMethod]
        public void ConverToRoman_Parameter5_ReturnV()
        {
            var conversor = new RomanNumbersConversos();
            var romanNumber = conversor.Convert(5);
            Assert.AreEqual("V", romanNumber);
        }

        [TestMethod]
        public void ConverToRoman_Parameter11_ReturnXI()
        {
            var conversor = new RomanNumbersConversos();
            var romanNumber = conversor.Convert(11);
            Assert.AreEqual("XI", romanNumber);
        }

        [TestMethod]
        public void ConverToRoman_Parameter4_ReturnIV()
        {
            var conversor = new RomanNumbersConversos();
            var romanNumber = conversor.Convert(4);
            Assert.AreEqual("IV", romanNumber);
        }

        [TestMethod]
        public void ConverToRoman_Parameter9_ReturnIX()
        {
            var conversor = new RomanNumbersConversos();
            var romanNumber = conversor.Convert(9);
            Assert.AreEqual("IX", romanNumber);
        }

        [TestMethod]
        public void ConverToRoman_Parameter14_ReturnXIV()
        {
            var conversor = new RomanNumbersConversos();
            var romanNumber = conversor.Convert(14);
            Assert.AreEqual("XIV", romanNumber);
        }
        
        [TestMethod]
        public void ConverToRoman_Parameter49_ReturnXLIX()
        {
            var conversor = new RomanNumbersConversos();
            var romanNumber = conversor.Convert(49);
            Assert.AreEqual("XLIX", romanNumber);
        }

        [TestMethod]
        public void ConverToRoman_Parameter60_ReturnLX()
        {
            var conversor = new RomanNumbersConversos();
            var romanNumber = conversor.Convert(60);
            Assert.AreEqual("LX", romanNumber);
        }

        [TestMethod]
        public void ConverToRoman_Parameter70_ReturnLXX()
        {
            var conversor = new RomanNumbersConversos();
            var romanNumber = conversor.Convert(70);
            Assert.AreEqual("LXX", romanNumber);
        }

        [TestMethod]
        public void ConverToRoman_Parameter79_ReturnLXXIX()
        {
            var conversor = new RomanNumbersConversos();
            var romanNumber = conversor.Convert(79);
            Assert.AreEqual("LXXIX", romanNumber);
        }

        [TestMethod]
        public void ConverToRoman_Parameter90_ReturnC()
        {
            var conversor = new RomanNumbersConversos();
            var romanNumber = conversor.Convert(90);
            Assert.AreEqual("XC", romanNumber);
        }

        [TestMethod]
        public void ConverToRoman_Parameter100_ReturnC()
        {
            var conversor = new RomanNumbersConversos();
            var romanNumber = conversor.Convert(100);
            Assert.AreEqual("C", romanNumber);
        }
    }
}

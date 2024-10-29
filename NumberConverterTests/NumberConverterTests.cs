using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NumberConverterApp;

namespace NumberConverterTests
{
    [TestClass]
    public class NumberConverterTests
    {
        [TestMethod]
        public void TestConvertFromPToDecimal_ValidInput()
        {
            Assert.AreEqual(123, NumberConverter.ConvertFromPToDecimal("123", 4));
            Assert.AreEqual(27, NumberConverter.ConvertFromPToDecimal("30", 9));
            Assert.AreEqual(10, NumberConverter.ConvertFromPToDecimal("1010", 2));
            Assert.AreEqual(255, NumberConverter.ConvertFromPToDecimal("333", 8));
        }

        [TestMethod]
        public void TestConvertFromPToDecimal_InvalidBase()
        {
            Assert.ThrowsException<ArgumentException>(() => NumberConverter.ConvertFromPToDecimal("123", 1));
            Assert.ThrowsException<ArgumentException>(() => NumberConverter.ConvertFromPToDecimal("123", 10));
        }

        [TestMethod]
        public void TestConvertFromPToDecimal_InvalidDigit()
        {
            Assert.ThrowsException<ArgumentException>(() => NumberConverter.ConvertFromPToDecimal("12A", 4));
            Assert.ThrowsException<ArgumentException>(() => NumberConverter.ConvertFromPToDecimal("123", 2));
        }
    }
}
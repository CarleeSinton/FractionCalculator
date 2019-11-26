using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;


namespace OneLogin_CodingChallenge.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        // Main method tests
        public void MainTest(string equation, string expected)
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                OneLogin_CodingChallenge.Program.Calculator();
                var result = sw.ToString().Trim();
                Assert.AreEqual(expected, result);
            }
        }
        [TestMethod()]
        public void MultiplyMainTest()
        {
            string equation = "? 1/2 * 3_3/4";
            string expected = "= 1_7/8";
            MainTest(equation, expected);
        }
        [TestMethod()]
        public void DivideMainTest()
        {
            string equation = "? 1/2 / 3_3/4";
            string expected = "= 4/30";
            MainTest(equation, expected);
        }
        [TestMethod()]
        public void AddMainTest()
        {
            string equation = "? 2_3/8 * 9/8";
            string expected = "= 3_1/2";
            MainTest(equation, expected);
        }
        [TestMethod()]
        public void SubtractMainTest()
        {
            string equation = "? 2_3/8 - 9/8";
            string expected = "= 1_1/4";
            MainTest(equation, expected);
        }

        //Multiplication method tests
        public void MultiplyMethodTest(int numerator1, int numerator2, int denominator1, int denominator2, string expected)
        {
            string result = OneLogin_CodingChallenge.Program.Multiply(numerator1, numerator2, denominator1, denominator2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void MultiplyMethodTest1()
        {
            int numerator1 = 1;
            int denominator1 = 2;
            int numerator2 = 15;
            int denominator2 = 4;
            string expected = "1_7/8";
            MultiplyMethodTest(numerator1, numerator2, denominator1, denominator2, expected);
        }

        // Division method tests
        public void DivideMethodTest(int numerator1, int numerator2, int denominator1, int denominator2, string expected)
        {
            string result = OneLogin_CodingChallenge.Program.Divide(numerator1, numerator2, denominator1, denominator2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void DivideMethodTest1()
        {
            int numerator1 = 1;
            int denominator1 = 2;
            int numerator2 = 15;
            int denominator2 = 4;
            string expected = "4/30";
            DivideMethodTest(numerator1, numerator2, denominator1, denominator2, expected);
        }

        // Addition method tests
        public void AddMethodTest(int numerator1, int numerator2, int denominator1, int denominator2, string expected)
        {
            string result = OneLogin_CodingChallenge.Program.Add(numerator1, numerator2, denominator1, denominator2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void AddMethodTest1()
        {
            int numerator1 = 19;
            int denominator1 = 8;
            int numerator2 = 9;
            int denominator2 = 8;
            string expected = "3_1/2";
            AddMethodTest(numerator1, numerator2, denominator1, denominator2, expected);
        }

        // Subtraction method tests
        public void SubtractMethodTest(int numerator1, int numerator2, int denominator1, int denominator2, string expected)
        {
            string result = OneLogin_CodingChallenge.Program.Subtract(numerator1, numerator2, denominator1, denominator2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void SubtractMethodTest1()
        {
            int numerator1 = 19;
            int denominator1 = 8;
            int numerator2 = 9;
            int denominator2 = 8;
            string expected = "1_1/4";
            SubtractMethodTest(numerator1, numerator2, denominator1, denominator2, expected);
        }
    }
}
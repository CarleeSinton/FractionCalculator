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
            string result = OneLogin_CodingChallenge.Program.Calculator(equation);
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void MultiplyMainTest()
        {
            string equation = "1/2 * 3_3/4";
            string expected = "= 1_7/8";
            MainTest(equation, expected);
        }
        [TestMethod()]
        public void MultiplyMainTest2()
        {
            string equation = "-1/2 * 3_3/4";
            string expected = "= -1_7/8";
            MainTest(equation, expected);
        }
        [TestMethod()]
        public void MultiplyMainTest3()
        {
            string equation = "-1/2 * -3_3/4";
            string expected = "= 1_7/8";
            MainTest(equation, expected);
        }
        [TestMethod()]
        public void DivideMainTest()
        {
            string equation = "1/2 / 3_3/4";
            string expected = "= 2/15";
            MainTest(equation, expected);
        }
        [TestMethod()]
        public void DivideMainTest2()
        {
            string equation = "-1/2 / 3_3/4";
            string expected = "= -2/15";
            MainTest(equation, expected);
        }
        [TestMethod()]
        public void DivideMainTest3()
        {
            string equation = "-1/2 / -3_3/4";
            string expected = "= 2/15";
            MainTest(equation, expected);
        }
        [TestMethod()]
        public void AddMainTest()
        {
            string equation = "2_3/8 + 9/8";
            string expected = "= 3_1/2";
            MainTest(equation, expected);
        }
        [TestMethod()]
        public void AddMainTest2()
        {
            string equation = "-2_3/8 + 9/8";
            string expected = "= -1_1/4";
            MainTest(equation, expected);
        }
        [TestMethod()]
        public void AddMainTest3()
        {
            string equation = "-2_3/8 + -9/8";
            string expected = "= -3_1/2";
            MainTest(equation, expected);
        }
        [TestMethod()]
        public void AddMainTest4()
        {
            string equation = "2_3/8 + -9/8";
            string expected = "= 1_1/4";
            MainTest(equation, expected);
        }
        [TestMethod()]
        public void SubtractMainTest()
        {
            string equation = "2_3/8 - 9/8";
            string expected = "= 1_1/4";
            MainTest(equation, expected);
        }
        [TestMethod()]
        public void SubtractMainTest1()
        {
            string equation = "-2_3/8 - -9/8";
            string expected = "= -1_1/4";
            MainTest(equation, expected);
        }
        [TestMethod()]
        public void SubtractMainTest2()
        {
            string equation = "-2_3/8 - 9/8";
            string expected = "= -3_1/2";
            MainTest(equation, expected);
        }
        [TestMethod()]
        public void SubtractMainTest3()
        {
            string equation = "9/8 - 2_3/8";
            string expected = "= -1_1/4";
            MainTest(equation, expected);
        }
        [TestMethod()]
        public void SubtractMainTest4()
        {
            string equation = "9/8 - -2_3/8";
            string expected = "= 3_1/2";
            MainTest(equation, expected);
        }
        //Multiplication method tests
        public void MultiplyMethodTest(int numerator1, int numerator2, int denominator1, int denominator2, int[] expected)
        {
            int[] result = OneLogin_CodingChallenge.Program.Multiply(numerator1, numerator2, denominator1, denominator2);
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void MultiplyMethodTest1()
        {
            int numerator1 = 1;
            int denominator1 = 2;
            int numerator2 = 15;
            int denominator2 = 4;
            int[] expected = new int[] { 15, 8};
            MultiplyMethodTest(numerator1, numerator2, denominator1, denominator2, expected);
        }
        [TestMethod()]
        public void MultiplyMethodTest2()
        {
            int numerator1 = -1;
            int denominator1 = 2;
            int numerator2 = 15;
            int denominator2 = 4;
            int[] expected = new int[] { -15, 8 };
            MultiplyMethodTest(numerator1, numerator2, denominator1, denominator2, expected);
        }
        [TestMethod()]
        public void MultiplyMethodTest3()
        {
            int numerator1 = -1;
            int denominator1 = 2;
            int numerator2 = -15;
            int denominator2 = 4;
            int[] expected = new int[] { 15, 8 };
            MultiplyMethodTest(numerator1, numerator2, denominator1, denominator2, expected);
        }

        // Division method tests
        public void DivideMethodTest(int numerator1, int numerator2, int denominator1, int denominator2, int[] expected)
        {
            int[] result = OneLogin_CodingChallenge.Program.Divide(numerator1, numerator2, denominator1, denominator2);
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void DivideMethodTest1()
        {
            int numerator1 = 1;
            int denominator1 = 2;
            int numerator2 = 15;
            int denominator2 = 4;
            int[] expected = new int[] { 4, 30 };
            DivideMethodTest(numerator1, numerator2, denominator1, denominator2, expected);
        }
        [TestMethod()]
        public void DivideMethodTest2()
        {
            int numerator1 = 1;
            int denominator1 = 2;
            int numerator2 = -15;
            int denominator2 = 4;
            int[] expected = new int[] { -4, 30 };
            DivideMethodTest(numerator1, numerator2, denominator1, denominator2, expected);
        }
        [TestMethod()]
        public void DivideMethodTest3()
        {
            int numerator1 = -1;
            int denominator1 = 2;
            int numerator2 = -15;
            int denominator2 = 4;
            int[] expected = new int[] { 4, 30 };
            DivideMethodTest(numerator1, numerator2, denominator1, denominator2, expected);
        }
        [TestMethod]
        public void DivideMethodTest4()
        {
            int numerator1 = -1;
            int denominator1 = 2;
            int numerator2 = 0;
            int denominator2 = 4;
            int[] expected = new int[] { -4, 0};
            DivideMethodTest(numerator1, numerator2, denominator1, denominator2, expected);
        }
        // Addition method tests
        public void AddMethodTest(int numerator1, int numerator2, int denominator1, int denominator2, int[] expected)
        {
            int[] result = OneLogin_CodingChallenge.Program.Add(numerator1, numerator2, denominator1, denominator2);
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void AddMethodTest1()
        {
            int numerator1 = 1;
            int denominator1 = 2;
            int numerator2 = 3;
            int denominator2 = 4;
            int[] expected = new int[] {10, 8};
            AddMethodTest(numerator1, numerator2, denominator1, denominator2, expected);
        }
        [TestMethod()]
        public void AddMethodTest2()
        {
            int numerator1 = -1;
            int denominator1 = 2;
            int numerator2 = 3;
            int denominator2 = 4;
            int[] expected = new int[] { 2, 8 };
            AddMethodTest(numerator1, numerator2, denominator1, denominator2, expected);
        }
        [TestMethod()]
        public void AddMethodTest3()
        {
            int numerator1 = 1;
            int denominator1 = 2;
            int numerator2 = -3;
            int denominator2 = 4;
            int[] expected = new int[] { -2, 8 };
            AddMethodTest(numerator1, numerator2, denominator1, denominator2, expected);
        }
        [TestMethod()]
        public void AddMethodTest4()
        {
            int numerator1 = -1;
            int denominator1 = 2;
            int numerator2 = -3;
            int denominator2 = 4;
            int[] expected = new int[] { -10, 8 };
            AddMethodTest(numerator1, numerator2, denominator1, denominator2, expected);
        }

        // Subtraction method tests
        public void SubtractMethodTest(int numerator1, int numerator2, int denominator1, int denominator2, int[] expected)
        {
            int[] result = OneLogin_CodingChallenge.Program.Subtract(numerator1, numerator2, denominator1, denominator2);
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void SubtractMethodTest1()
        {
            int numerator1 = 3;
            int denominator1 = 4;
            int numerator2 = 1;
            int denominator2 = 2;
            int[] expected = new int[]{2, 8};
            SubtractMethodTest(numerator1, numerator2, denominator1, denominator2, expected);
        }
        [TestMethod()]
        public void SubtractMethodTest2()
        {
            int numerator1 = 1;
            int denominator1 = 2;
            int numerator2 = 3;
            int denominator2 = 4;
            int[] expected = new int[] { -2, 8 };
            SubtractMethodTest(numerator1, numerator2, denominator1, denominator2, expected);
        }
        [TestMethod()]
        public void SubtractMethodTest3()
        {
            int numerator1 = -3;
            int denominator1 = 4;
            int numerator2 = 1;
            int denominator2 = 2;
            int[] expected = new int[] { -10, 8 };
            SubtractMethodTest(numerator1, numerator2, denominator1, denominator2, expected);
        }
        [TestMethod()]
        public void SubtractMethodTest4()
        {
            int numerator1 = -1;
            int denominator1 = 2;
            int numerator2 = -3;
            int denominator2 = 4;
            int[] expected = new int[] { 2, 8 };
            SubtractMethodTest(numerator1, numerator2, denominator1, denominator2, expected);
        }
        // Operand components tests
        public void OperandComponentsTest(string operand, int[] expected)
        {
            int[] result = OneLogin_CodingChallenge.Program.OperandComponents(operand);
            CollectionAssert.AreEqual(expected, result);   
        }
        [TestMethod()]
        public void OperandComponentsTest1()
        {
            string operand = "3_1/4";
            int[] expected = new int[] { 13, 4};
            OperandComponentsTest(operand, expected);
        }
        [TestMethod()]
        public void OperandComponentsTest2()
        {
            string operand = "3";
            int[] expected = new int[] { 3,1};
            OperandComponentsTest(operand, expected);
        }
        [TestMethod()]
        public void OperandComponentsTest3()
        {
            string operand = "1/4";
            int[] expected = new int[] { 1, 4 };
            OperandComponentsTest(operand, expected);
        }
        [TestMethod()]
        public void OperandComponentsTest4()
        {
            string operand = "-1/4";
            int[] expected = new int[] { -1, 4 };
            OperandComponentsTest(operand, expected);
        }
        [TestMethod()]
        public void OperandComponentsTest5()
        {
            string operand = "-3_1/4";
            int[] expected = new int[] { -13, 4 };
            OperandComponentsTest(operand, expected);
        }
        // Fraction format tests
        public void FractionFormatTest(int numerator, int denominator, string expected)
        {
            string result = OneLogin_CodingChallenge.Program.FractionFormat(numerator, denominator);
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void FractionFormatTest1()
        {
            int numerator = 75;
            int denominator = 25;
            string expected = "= 3";
            FractionFormatTest(numerator, denominator, expected);
        }
        [TestMethod()]
        public void FractionFormatTest2()
        {
            int numerator = 34;
            int denominator = 40;
            string expected = "= 17/20";
            FractionFormatTest(numerator, denominator, expected);
        }
        [TestMethod()]
        public void FractionFormatTest3()
        {
            int numerator = 70;
            int denominator = 30;
            string expected = "= 2_1/3";
            FractionFormatTest(numerator, denominator, expected);
        }
        [TestMethod()]
        public void FractionFormatTest4()
        {
            int numerator = 1;
            int denominator = 4;
            string expected = "= 1/4";
            FractionFormatTest(numerator, denominator, expected);
        }
        [TestMethod()]
        public void FractionFormatTest5()
        {
            int numerator = -1;
            int denominator = 4;
            string expected = "= -1/4";
            FractionFormatTest(numerator, denominator, expected);
        }
        [TestMethod()]
        public void FractionFormatTest6()
        {
            int numerator = -70;
            int denominator = 30;
            string expected = "= -2_1/3";
            FractionFormatTest(numerator, denominator, expected);
        }
        [TestMethod()]
        public void FractionFormatTest7()
        {
            int numerator = -75;
            int denominator = 25;
            string expected = "= -3";
            FractionFormatTest(numerator, denominator, expected);
        }
        //Greatest Common Factor Tests
        public void GreatestCommonFactorTest(int a, int b, int expected)
        {
            int result = OneLogin_CodingChallenge.Program.GreatestCommonFactor(a, b);
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void GreatestCommonFactorTest1()
        {
            int a = 75;
            int b = 25;
            int expected = 25;
            GreatestCommonFactorTest(a, b, expected);
        }
        [TestMethod()]
        public void GreatestCommonFactorTest2()
        {
            int a = 4;
            int b = 6;
            int expected = 2;
            GreatestCommonFactorTest(a, b, expected);
        }
        [TestMethod()]
        public void GreatestCommonFactorTest3()
        {
            int a = 17;
            int b = 20;
            int expected = 1;
            GreatestCommonFactorTest(a, b, expected);
        }
    }
}
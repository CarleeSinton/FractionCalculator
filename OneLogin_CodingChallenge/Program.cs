using System;

namespace OneLogin_CodingChallenge
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello! Please enter your equation: ");
            Console.Write("? ");
            string equation = Console.ReadLine();
            Calculator(equation);
            // Things to consider: 
                // order of operations
                // negative numbers?
            
        }
        public static string Calculator(string equation)
        {
            string[] equationParts = equation.Split(' ');
            string givenOperator = equationParts[1];
            int[] operand1Parts = OperandComponents(equationParts[0]);
            int numerator1 = operand1Parts[0];
            int denominator1 = operand1Parts[1];
            int[] operand2Parts = OperandComponents(equationParts[2]);
            int numerator2 = operand2Parts[0];
            int denominator2 = operand2Parts[1];

            int[] tempResult = new int[] {2};
            switch (givenOperator)
            {
                case "*":
                    tempResult = Multiply(numerator1, numerator2, denominator1, denominator2);
                    break;
                case "/":
                    tempResult = Divide(numerator1, numerator2, denominator1, denominator2);
                    break;
                case "+":
                    tempResult = Add(numerator1, numerator2, denominator1, denominator2);
                    break;
                case "-":
                    tempResult = Subtract(numerator1, numerator2, denominator1, denominator2);
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            string result = FractionFormat(tempResult[0], tempResult[1]);
            Console.WriteLine(result);
            return result;
        }

        public static int[] Multiply(int numerator1, int numerator2, int denominator1, int denominator2)
        {
            int newNumerator = numerator1 * numerator2;
            int newDenominator = denominator1 * denominator2;
            int[] result = new int[] { newNumerator, newDenominator };
            return result;
        }

        public static int[] Divide(int numerator1, int numerator2, int denominator1, int denominator2)
        {
            int newNumerator = numerator1 * denominator2;
            int newDenominator = denominator1 * numerator2;
            int[] result = new int[] { newNumerator, newDenominator };
            return result;
        }
        public static int[] Add(int numerator1, int numerator2, int denominator1, int denominator2)
        {
            int newNumerator = (numerator1 * denominator2) + (denominator1 * numerator2);
            int newDenominator = denominator1 * denominator2;
            int[] result = new int[] { newNumerator, newDenominator };
            return result;
        }
        public static int[] Subtract(int numerator1, int numerator2, int denominator1, int denominator2)
        {
            int newNumerator = (numerator1 * denominator2) - (denominator1 * numerator2);
            int newDenominator = denominator1 * denominator2;
            int[] result = new int[] { newNumerator, newDenominator };
            return result;
        }

        public static int[] OperandComponents(string operand)
        {
            int numerator;
            int denominator;
            if (operand.Contains("_"))
            {
                string[] operandParts = operand.Split('_', '/');
                int wholeNumber = Int32.Parse(operandParts[0]);
                int tempNumerator = Int32.Parse(operandParts[1]);
                denominator = Int32.Parse(operandParts[2]);
                numerator = tempNumerator + (denominator * wholeNumber);
            }
            else if (operand.Contains("/"))
            {
                string[] operandParts = operand.Split('/');
                numerator = Int32.Parse(operandParts[0]);
                denominator = Int32.Parse(operandParts[1]);
            }
            else
            {
                numerator = Int32.Parse(operand);
                denominator = 1;
            }
            int[] fractionComponents = new int[] { numerator, denominator };
            return fractionComponents;
        }

        public static string FractionFormat(int numerator, int denominator)
        {
            if (numerator/denominator > 0)
            {
                int wholeNumber = numerator / denominator;
                if(numerator % denominator == 0)
                {
                    return $"= {wholeNumber}";
                }
                numerator = numerator % denominator;
                int gcf = GreatestCommonFactor(numerator, denominator);
                numerator = numerator / gcf;
                denominator = denominator / gcf;
                return $"= {wholeNumber}_{numerator}/{denominator}";
            }
            else
            {
                int gcf = GreatestCommonFactor(numerator, denominator);
                numerator = numerator / gcf;
                denominator = denominator / gcf;
                return $"= {numerator}/{denominator}";
            }
        }

        public static int GreatestCommonFactor(int a, int b)
        {
            int greatestCommonFactor;
            while(a != 0 && b != 0)
            {
                if (a > b){
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            if (a == 0)
            {
                greatestCommonFactor = b;
            }
            else
            {
                greatestCommonFactor = a;
            }
            return greatestCommonFactor;
        }
    }
}

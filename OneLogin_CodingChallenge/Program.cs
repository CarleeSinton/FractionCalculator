using System;

namespace OneLogin_CodingChallenge
{
    public class Program
    {
        public static void Main()
        {
            Calculator();
            // Things to consider: 
                // order of operations
                // fractions vs whole numbers
                // returning mixed numbers (9/8 -> 1_1/8) OR finalDenominator = 1
                // reducing fraction (2/8 -> 1/4)
                // negative numbers?
            
        }
        public static string Calculator()
        {
            Console.WriteLine("Hello! Please enter your equation: ");
            Console.Write("? ");
            string equation = Console.ReadLine();

            //Get parts of equation
            string[] equationParts = equation.Split(' ');
            string givenOperator = equationParts[1];
            string operand1 = equationParts[0];
            int numerator1;
            int denominator1;
            int numerator2;
            int denominator2;
            if (operand1.Contains("_"))
            {
                string[] operand1Parts = operand1.Split('_','/');
                int wholeNumber1 = Int32.Parse(operand1Parts[0]);
                int tempNumerator1 = Int32.Parse(operand1Parts[1]);
                denominator1 = Int32.Parse(operand1Parts[2]);
                numerator1 = tempNumerator1 + (denominator1 * wholeNumber1);
            }
            else if (operand1.Contains("/"))
            {
                string[] operand1Parts = operand1.Split('/');
                numerator1 = Int32.Parse(operand1Parts[0]);
                denominator1 = Int32.Parse(operand1Parts[1]);
            }
            else
            {
                numerator1 = Int32.Parse(operand1);
                denominator1 = 1;
            }

            string operand2 = equationParts[2];
            if (operand2.Contains("_"))
            {
                string[] operand2Parts = operand2.Split('_', '/');
                int wholeNumber2 = Int32.Parse(operand2Parts[0]);
                int tempNumerator2 = Int32.Parse(operand2Parts[1]);
                denominator2 = Int32.Parse(operand2Parts[2]);
                numerator2 = tempNumerator2 + (denominator2 * wholeNumber2);
            }
            else if (operand2.Contains("/"))
            {
                string[] operand2Parts = operand2.Split('/');
                numerator2 = Int32.Parse(operand2Parts[0]);
                denominator2 = Int32.Parse(operand2Parts[1]);
            }
            else
            {
                numerator2 = Int32.Parse(operand2);
                denominator2 = 1;
            }


            string result = "";
            switch (givenOperator)
            {
                case "*":
                    result = Multiply(numerator1, numerator2, denominator1, denominator2);
                    break;
                case "/":
                    result = Divide(numerator1, numerator2, denominator1, denominator2);
                    break;
                case "+":
                    result = Add(numerator1, numerator2, denominator1, denominator2);
                    break;
                case "-":
                    result = Subtract(numerator1, numerator2, denominator1, denominator2);
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            Console.WriteLine(result);
            return result;
        }

        public static string Multiply(int numerator1, int numerator2, int denominator1, int denominator2)
        {
            int newNumerator = numerator1 * numerator2;
            int newDenominator = denominator1 * denominator2;
            if (newNumerator/newDenominator > 0)
            {
                int wholeNumber = newNumerator / newDenominator;
                newNumerator = newNumerator % newDenominator;
                return $"= {wholeNumber}_{newNumerator}/{newDenominator}";
            }
            else
            {
                return $"= {newNumerator}/{newDenominator}";
            }

        }

        public static string Divide(int numerator1, int numerator2, int denominator1, int denominator2)
        {
            int newNumerator = numerator1 * denominator2;
            int newDenominator = denominator1 * numerator2;
            return ($"= {newNumerator}/{newDenominator}");
        }
        public static string Add(int numerator1, int numerator2, int denominator1, int denominator2)
        {
            int newNumerator = (numerator1 * denominator2) + (denominator1 * numerator2);
            int newDenominator = denominator1 * denominator2;
            return ($"= {newNumerator}/{newDenominator}");
        }
        public static string Subtract(int numerator1, int numerator2, int denominator1, int denominator2)
        {
            int newNumerator = (numerator1 * denominator2) - (denominator1 * numerator2);
            int newDenominator = denominator1 * denominator2;
            return ($"= {newNumerator}/{newDenominator}");
        }
    }
}

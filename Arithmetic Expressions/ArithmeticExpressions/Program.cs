using System;

namespace ArithmeticExpressions
{
    public class Program
    {
        static string EvaluateExpression(string expression)
        {
            // 1. Check for null or empty
            if (string.IsNullOrWhiteSpace(expression))
                return "Error:InvalidExpression";

            // 2. Split by spaces (spaces are required)
            string[] parts = expression.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Must be exactly: a op b
            if (parts.Length != 3)
                return "Error:InvalidExpression";

            // 3. Parse integers
            if (!int.TryParse(parts[0], out int a) ||
                !int.TryParse(parts[2], out int b))
            {
                return "Error:InvalidNumber";
            }

            string op = parts[1];

            // 4. Evaluate based on operator
            switch (op)
            {
                case "+":
                    return (a + b).ToString();

                case "-":
                    return (a - b).ToString();

                case "*":
                    return (a * b).ToString();

                case "/":
                    if (b == 0)
                        return "Error:DivideByZero";
                    return (a / b).ToString(); // integer division

                default:
                    return "Error:UnknownOperator";
            }
        }

        public static void Main()
        {
            string? expression = Console.ReadLine();

            if (expression == null)
            {
                Console.WriteLine("Error:InvalidExpression");
                return;
            }

            string result = EvaluateExpression(expression);
            Console.WriteLine(result);
        }
    }
}

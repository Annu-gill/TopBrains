using System;

namespace Programming
{
    public class Program
    {
        // Method to calculate sum of digits
        static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        // Method to check if number is prime
        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public static void Main()
        {
            // Reading Inputs
            string? line = Console.ReadLine();
            if (line == null)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            string[] input = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);

            int count = 0;
            for (int x = m; x <= n; x++)
            {
                // Checking for non-prime no.
                if (!IsPrime(x))
                {
                    int sumX = SumOfDigits(x);
                    int SquaredSumX = SumOfDigits(x * x);

                    if (SquaredSumX == sumX * sumX)
                    {
                        count++;
                    }
                }
            }
            // Printing the result
            Console.WriteLine(count);
        }
    }
}
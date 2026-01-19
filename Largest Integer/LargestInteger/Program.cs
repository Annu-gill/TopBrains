using System;

namespace LargestInteger
{
    public class Program
    {
        static int FindLargest(int a, int b, int c)
        {
            if (a >= b && a >= c)
                return a;
            else if (b >= a && b >= c)
                return b;
            else
                return c;
        }

        public static void Main()
        {
            // Read inputs
            int a = int.Parse(Console.ReadLine()!);
            int b = int.Parse(Console.ReadLine()!);
            int c = int.Parse(Console.ReadLine()!);

            int largest = FindLargest(a, b, c);

            Console.WriteLine("Largest Number: " + largest);
        }
    }
}

using System;

namespace Swapping
{
    public class Program
    {
        // Method 1: Swap using ref (no temp variable)
        public static void SwapUsingRef(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        // Method 2: Swap using out (no temp variable)
        public static void SwapUsingOut(int a, int b, out int x, out int y)
        {
            x = a + b;
            y = x - b;
            x = x - y;
        }

        public static void Main()
        {
            // Using ref 
            int m = 10;
            int n = 20;

            Console.WriteLine("Before Swap using ref:");
            Console.WriteLine("m = " + m + ", n = " + n);

            SwapUsingRef(ref m, ref n);

            Console.WriteLine("After Swap using ref:");
            Console.WriteLine("m = " + m + ", n = " + n);

            Console.WriteLine();

            // Using out 
            int a = 15;
            int b = 25;

            Console.WriteLine("Before Swap using out:");
            Console.WriteLine("a = " + a + ", b = " + b);

            SwapUsingOut(a, b, out int x, out int y);

            Console.WriteLine("After Swap using out:");
            Console.WriteLine("a = " + x + ", b = " + y);
        }
    }
}

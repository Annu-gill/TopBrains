using System;

namespace MultiplicationTable
{
    public class Program
    {
        static int[] GetMultiplicationRow(int n, int upto)
        {
            if (upto <= 0)
                return Array.Empty<int>();

            int[] result = new int[upto];

            for (int i = 1; i <= upto; i++)
            {
                result[i - 1] = n * i;
            }

            return result;
        }

        public static void Main()
        {
            // Read n
            string? nInput = Console.ReadLine();
            // Read upto
            string? uptoInput = Console.ReadLine();

            if (nInput == null || uptoInput == null)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            int n = int.Parse(nInput);
            int upto = int.Parse(uptoInput);

            int[] row = GetMultiplicationRow(n, upto);

            Console.Write("[");
            for (int i = 0; i < row.Length; i++)
            {
                Console.Write(row[i]);
                if (i < row.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("]");
        }
    }
}

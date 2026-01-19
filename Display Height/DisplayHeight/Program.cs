using System;

namespace DisplayHeight
{
    public class Program
    {
        static string GetHeightCategory(int heightCm)
        {
            if (heightCm < 150)
                return "Short";
            else if (heightCm < 180)
                return "Average";
            else
                return "Tall";
        }

        public static void Main()
        {
            // Read input
            int heightCm = int.Parse(Console.ReadLine()!);

            // Get category
            string category = GetHeightCategory(heightCm);

            // Display output
            Console.WriteLine(category);
        }
    }
}

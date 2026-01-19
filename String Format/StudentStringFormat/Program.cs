using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace StudentStringFormat
{
    // Student record
    public record Student(string Name, int Score);

    public class Program
    {
        static string BuildStudentJson(string[] items, int minScore)
        {
            List<Student> students = new();

            foreach (string item in items)
            {
                // Split "Name:Score"
                string[] parts = item.Split(':');
                if (parts.Length != 2)
                    continue;

                string name = parts[0];
                if (!int.TryParse(parts[1], out int score))
                    continue;

                students.Add(new Student(name, score));
            }

            // Filter, sort, and serialize
            var result = students
                .Where(s => s.Score >= minScore)
                .OrderByDescending(s => s.Score)
                .ThenBy(s => s.Name)
                .ToList();

            return JsonSerializer.Serialize(result);
        }

        public static void Main()
        {
            // Example input
            string[] items =
            {
                "Annu:85",
                "Rohit:92",
                "Vansh:78",
                "Harshita:75",
                "Harish:92"
            };

            int minScore = 80;

            string json = BuildStudentJson(items, minScore);

            Console.WriteLine(json);
        }
    }
}

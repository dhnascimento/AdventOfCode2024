using System;
using System.IO;

namespace AdventOfCode2024.Helpers
{
    public static class InputHelper
    {
        public static string GetInputPath(int day)
        {
            string inputDir = Path.Combine(
                AppContext.BaseDirectory, 
                "..", "..", "..", "inputs"
            );
            return Path.Combine(inputDir, $"day{day:D2}.txt");
        }

        public static string[] ReadInput(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Input file not found: {path}");
            }
            return File.ReadAllLines(path);
        }
    }
}
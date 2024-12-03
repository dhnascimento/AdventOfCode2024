using System;
using AdventOfCode2024.Solutions;
using AdventOfCode2024.Helpers;

namespace AdventOfCode2024
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide the day number.");
                return;
            }

            int day;
            if (!int.TryParse(args[0], out day) || day < 1 || day > 25)
            {
                Console.WriteLine("Invalid day. Please enter a number between 1 and 25.");
                return;
            }

            ISolution solution = day switch
            {
                1 => new Day01(),
                // 2 => new Day02(),
                // Add more days as you solve them
                _ => throw new NotImplementedException($"Solution for Day {day} not implemented.")
            };

            try 
            {
                string inputPath = InputHelper.GetInputPath(day);
                string[] input = InputHelper.ReadInput(inputPath);

                Console.WriteLine($"Day {day} - Part 1: {solution.SolvePart1(input)}");
                Console.WriteLine($"Day {day} - Part 2: {solution.SolvePart2(input)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error solving Day {day}: {ex.Message}");
            }
        }
    }

    // Interface for daily solutions
    public interface ISolution
    {
        string SolvePart1(string[] input);
        string SolvePart2(string[] input);
    }
}

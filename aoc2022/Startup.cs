using aoc2022.Utility;

namespace aoc2022
{
    internal class Startup
    {
        public static void Run(int day)
        {
            switch (day)
            {
                case 1:
                    Day1ProblemRunner("day1-calorie-counting.txt");
                    break;
                default:
                    Console.WriteLine("No data available");
                    break;
            }
        }

        private static void Day1ProblemRunner(string fileName)
        {
            var data = FileReader.GetAllLines(fileName);
            var result = new Day1CalorieCount().GetResult(data, 3);
            Console.WriteLine($"Elf carrying the most Calorie {result}");
        }
    }
}

namespace aoc2022
{
    public class Day1CalorieCount
    {
        /*
             * Algorithm:
             * - Set mostCalorie to zero, and mostCalorieElf to zero
             * - Read each line of the list and add the calories
             * - Add the values until empty line is encountered
             * - For each empty line encountered, compare the currentCount with maxCount
             * - If currentCount is max, replace both mostCalorie and mostCalorieElf
             * - At end of loop, print the max outputs
        */
        public long GetResult(IEnumerable<string> sourceData, int topElfCount = 1)
        {
            long runningCalorie = 0;
            List<long> sumOfCalories = new List<long>();
            foreach (var line in sourceData)
            {
                if (string.IsNullOrEmpty(line))
                {
                    sumOfCalories.Add(runningCalorie);
                    runningCalorie = 0;
                }
                else
                {
                    if (int.TryParse(line, out int result))
                    {
                        runningCalorie += result;
                    }
                    else
                    {
                        throw new ArgumentException($"Invalid data found in source {nameof(sourceData)}");
                    }
                }
            }
            //Add the last one(if running has some value)
            sumOfCalories.Add(runningCalorie);
            return sumOfCalories
                .OrderByDescending(x => x)
                .Take(topElfCount)
                .Sum(x => x);
        }
    }
}
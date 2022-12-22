namespace aoc2022.tests
{
    internal static class TestData
    {
        public static List<string> Day1CalorieData => new List<string>()
        {
            "1000",
            "2000",
            "3000",//6
            "",
            "4000",//4
            "",
            "5000",
            "6000",//11
            "",
            "7000",
            "8000",
            "9000",//24
            "",
            "10000"//10
        };

        public static List<string> Day1CalorieInvalidData => new List<string>()
        {
            "1000",
            "2000",
            "3000",
            "    ",
            "9000",
            "    ",
            "xyz"
        };
    }
}

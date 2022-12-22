namespace aoc2022.Utility
{
    class FileReader
    {
        static readonly string ROOT_PATH = Environment.CurrentDirectory;
        const string DATA_PATH = "data";

        public static IEnumerable<string> GetAllLines(string fileName)
        {
            var fullPath = Path.Combine(ROOT_PATH, DATA_PATH, fileName);
            return File.ReadLines(fullPath);
        }
    }
}

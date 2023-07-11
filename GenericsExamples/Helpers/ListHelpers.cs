namespace GenericsExamples.Helpers
{
    public static class ListHelpers
    {
        public static void GoThroughInts(List<int> integers) 
        {
            foreach (int number in integers)
                Console.WriteLine(number);
        }

        public static void GoThroughStrings(List<string> strings) 
        {
            foreach (string str in strings)
                Console.WriteLine(str);
        }

        public static void GoThroughDoubles(List<double> doubles) 
        {
            foreach(double number in doubles)
                Console.WriteLine(number);
        }
    }
}
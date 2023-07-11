using GenericsExamples.Helpers;

namespace GenericsExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<string> names = new List<string>() { "Almir", "Attila", "Zoran", "Vitomir", "Mirsolav", "Biljana", "Milan", "Igor" };
            List<int> numbers2 = new List<int>() { 21, 22, 32, 42, 25, 22 };
            List<string> names2 = new List<string>() { "2Almir", "2Attila", "2Zoran", "2Vitomir", "2Mirsolav", "2Biljana", "Milan", "Igor" };
            List<string> names3 = new List<string>() { "3Almir", "3Attila", "3Zoran", "3Vitomir", "3Mirsolav", "2Biljana", "Milan", "Igor" };

            List<double> doubles = new List<double>() { 2.3, 2.3, 2.5, 3.1, 24.5 };

            ListHelpers.GoThroughInts(numbers);
            ListHelpers.GoThroughInts(numbers2);

            ListHelpers.GoThroughStrings(names);
            ListHelpers.GoThroughStrings(names2);
            ListHelpers.GoThroughStrings(names3);

            ListHelpers.GoThroughDoubles(doubles);

            Console.WriteLine(".................... generic list helper:");

            GenericListHelpers<int>.GoThrough(numbers);
            GenericListHelpers<int>.GoThrough(numbers2);
            GenericListHelpers<double>.GoThrough(doubles);
            GenericListHelpers<string>.GoThrough(names);
            GenericListHelpers<string>.GoThrough(names2);
            GenericListHelpers<string>.GoThrough(names3);

            GenericListHelpers<string>.GetInfo(names);
        }
    }
}


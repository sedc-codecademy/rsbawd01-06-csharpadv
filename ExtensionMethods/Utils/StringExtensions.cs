// namespace System
namespace ExtensionMethods.Utils
{
    // 1. The class needs to be static
    public static class StringExtensions
    {
        // 2. Method needs to static
        // 3. Usage of "this" keyword
        public static string Shorten(this string str, int keepNumberOfWords) 
        {
            string result = string.Empty;

            string[] words = str.Split(' ');

            for (int i = 0; i < keepNumberOfWords; i++)
                result = result + " " + words[i];

            return result + "...";
        }

        public static int ParseToInt(this string str)
        {
            // write complex logic here
            // whatever you want
            // handle the exceptions
            // validate the data

            return int.Parse(str);
        }
    }
}

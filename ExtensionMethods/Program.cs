using ExtensionMethods.Utils;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main()
        {
            string toBeShorten = "This is the Seavus Education Center C# Advanced course";

            string shortenResult = toBeShorten.Shorten(4);
            string shortenResult5 = toBeShorten.Shorten(5);
            string shortenResult7 = toBeShorten.Shorten(7);

            string result = StringExtensions.Shorten(toBeShorten, 4);

            // Homework
            // string shortenResult15 = toBeShorten.Shorten(15);

            Console.WriteLine($"Original text: {toBeShorten}");
            Console.WriteLine($"After shorten method 4 words: {shortenResult}");
            Console.WriteLine($"After shorten method 5 words: {shortenResult5}");
            Console.WriteLine($"After shorten method 7 words: {shortenResult7}");

            // Homework
            // Console.WriteLine($"After shorten method 15 words: {shortenResult15}");

            int a = 100;

            if (a.IsGreaterThan(150))
                Console.WriteLine("greater than 150");
            else
                Console.WriteLine("not greater than 150");

            Console.WriteLine("Type any number: ");
            string userInput = Console.ReadLine();

            int x = userInput.ParseToInt();
        }
    }
}
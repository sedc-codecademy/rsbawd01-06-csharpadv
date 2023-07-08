using StaticClasses.Helpers;

namespace StaticClasses
{
    internal class Program
    {
        static void Main()
        {
            // objects of non static class
            Person almir = new Person("Almir");
            Person zoran = new Person("Zoran");
            Person vitomir = new Person("Vitomir");
            Person milan = new Person("Milan");
            Person biljna = new Person("Biljana");
            Person attila = new Person("Attila");

            // Usage of static field inside of non static class
            Console.WriteLine($"Count of person created " +
                $"is {Person.CounterOfPersonsCreated}");

            // Usage of static MathHelper class
            bool continueUserInput = true;

            while (continueUserInput)
            {
                Console.WriteLine("Unesite prvi broj: ");
                double x = double.Parse(Console.ReadLine());

                Console.WriteLine("Unesite drugi broj: ");
                double y = double.Parse(Console.ReadLine());

                Console.WriteLine("Odaberite matematicku operaciju (+,-,*,/):");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "+":
                        Console.WriteLine($"Result is: {MathHelpers.Add(x, y)}");
                        break;

                    case "-":
                        Console.WriteLine($"Result is: {MathHelpers.Subtract(x, y)}");
                        break;

                    case "*":
                        Console.WriteLine($"Result is: {MathHelpers.Multiply(x, y)}");
                        break;

                    case "/":
                        Console.WriteLine($"Result is: {MathHelpers.Divide(x, y)}");
                        break;
                }

                Console.WriteLine("Continue? Y/N");
                string contin = Console.ReadLine();

                if (contin == "N")
                    continueUserInput = false;
            }

            Console.WriteLine($"Add is : {MathHelpers.CountOfAddUsage}, times used");
            Console.WriteLine($"Multiply is : {MathHelpers.CountOfMultiplyUsage}, times used");
            Console.WriteLine($"Subtract is : {MathHelpers.CountOfSubtractUsage}, times used");
            Console.WriteLine($"Divide is : {MathHelpers.CountOfDivideUsage}, times used");
        }
    }
}
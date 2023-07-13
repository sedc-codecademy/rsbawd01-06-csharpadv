using GettersAndSetters.Models;

namespace GettersAndSetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person almir = new Person();
            Person almir2 = new Person();
            Person almir3 = new Person();
            Person almir4 = new Person();

            almir.FirstName = "Almir";
            almir.LastName = "Vuk";

            int userInput = -100;

            almir.Age = userInput;
            almir2.Age = userInput;
            almir3.Age = userInput;
            almir4.Age = userInput;

            Console.WriteLine($"{almir.FirstName} {almir.LastName} {almir.Age}");
        }
    }
}
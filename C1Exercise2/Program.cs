namespace C1Exercise2
{
    internal class Program
    {
        static void Main()
        {
            /*
            Exercise 2: Simple console exercise
            
            Write a C# program that asks the user to enter their name and age. 
            The program should then display a message with their name and age 
            in the following format:
            
            Hello [Name], you are [Age] years old. */

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello " + name + ", you are " + age + " years old.");
        }
    }
}
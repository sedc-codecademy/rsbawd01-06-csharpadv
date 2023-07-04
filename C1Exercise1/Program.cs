namespace C1Exercise1
{
    internal class Program
    {
        static void Main()
        {
            /*
            Exercise 1: Simple if/switch/loop exercise
            
            Write a C# program that takes an integer input from the user and 
            performs the following actions:
            
            If the input is less than 0, display "Negative number."
            If the input is greater than 0, display "Positive number."
            If the input is equal to 0, display "Zero."*/

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Negative number.");
            }
            else if (number > 0)
            {
                Console.WriteLine("Positive number.");
            }
            else
            {
                Console.WriteLine("Zero.");
            }
        }
    }
}
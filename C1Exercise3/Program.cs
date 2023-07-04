namespace C1Exercise3
{
    internal class Program
    {
        static void Main()
        {
            /*
            Exercise 3: Complex exercise
            
            Write a C# program that calculates the sum of all the even numbers 
            between 1 and a given number (inclusive) using a loop. Bonus: for odd numbers also.
            
            Example output:
            
            Enter a number: 10
            The sum of all even numbers between 1 and 10 is 30. */

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int sumOfEvenNumbers = 0;
            int sumOfOddNumbers = 0;

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                    sumOfEvenNumbers += i;
                else
                    sumOfOddNumbers += i;
            }

            Console.WriteLine("The sum of all even numbers between 1 and " + number + " is " + sumOfEvenNumbers + ".");
            Console.WriteLine("The sum of all odd numbers between 1 and " + number + " is " + sumOfOddNumbers + ".");
        }
    }
}
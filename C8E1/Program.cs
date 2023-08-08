namespace C8E1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = "Exercise";
            string filePath = Path.Combine(folderPath, "calculations.txt");

            // Create the folder if it doesn't exist
            Directory.CreateDirectory(folderPath);

            // Call the console 3 times and write results to the txt file
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("..............................");
                // Ask the user to enter two numbers
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                // Calculate and display the result
                string result = Calculate(num1, num2);
                Console.WriteLine(result);

                // Write the result with timestamp to the calculations.txt file
                WriteToFile(filePath, result);
            }

            Console.WriteLine("Content of the calulcation.txt file is: ");

            using (StreamReader reader = new StreamReader(filePath))
                Console.WriteLine(reader.ReadToEnd());
        }

        static string Calculate(double num1, double num2)
        {
            return $"{num1} + {num2} = {num1 + num2}";
        }

        static void WriteToFile(string filePath, string content)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}: {content}");
            }
        }
    }    
}
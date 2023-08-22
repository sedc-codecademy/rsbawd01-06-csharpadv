namespace AsyncAwait
{
    internal class Program
    {
        static void Main()
        {
            Task result = SendMessageAsync("Hi from SEDC students!");

            ShowAd("Coca Cola");
        }

        private static void ShowAd(string product)
        {
            Console.WriteLine("While you wait let us show you an ad:");
            Console.WriteLine("Buy the best product in the world ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(product);

            Console.ResetColor();

            Console.Write(" now and get ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("FREE");
            Console.ResetColor();
            Console.WriteLine(" shipping worldwide!");

            for (Int64 i = 0; i < 999; i++)
            {
                Console.WriteLine("...");
            }
            Console.ReadLine();
        }

        private static async Task SendMessageAsync(string message)
        {
            Console.WriteLine("Sending message...");

            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine($"The message was {message}...");
            });

            await AnotherAsyncMethod();

            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine($"Another The message was {message}...");
            });
        }

        private static async Task AnotherAsyncMethod()
        {
            await Task.Run(() => 
            {
                Thread.Sleep(5000);
                Console.WriteLine("Result of anothert async method");
            });
        }

    }
}
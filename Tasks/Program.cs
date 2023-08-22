namespace Tasks
{
    internal class Program
    {
        static void Main()
        {
            SendMessagesWithTasks();
        }

        private static void SendMessagesWithTasks()
        {
            Console.WriteLine("Getting Ready");

            Task task1 = new Task(Message1);
            task1.Start();

            Task task2 = new Task(Message2);
            task2.Start();

            Task task3 = new Task(Message3);
            task3.Start();

            Console.WriteLine("All messages are recieved");

            Task<int> valueTask = new Task<int>(GetMeSomeIntValue);
            valueTask.Start();

            Console.WriteLine($"The result of the value task was: {valueTask.Result}");

            Console.ReadLine();
        }

        private static int GetMeSomeIntValue()
        {
            Thread.Sleep(5000);
            Console.WriteLine("We can now get the number value...");
            return 6;
        }

        private static void Message1()
        {
            Thread.Sleep(2000);

            // go to database
            // go to web service
            // manipulate the data
            Console.WriteLine("First message arrived");
        }

        private static void Message2()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Second message arrived");
        }

        private static void Message3()
        {
            Thread.Sleep(1900);
            Console.WriteLine("Third message arrived");
        }
    }
}
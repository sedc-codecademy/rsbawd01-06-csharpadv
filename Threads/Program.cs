namespace Threads
{
    internal class Program
    {
        static void Main()
        {
            //SendMessages();
            SendMessagesWithThreads();
        }

        private static void SendMessages()
        {
            Console.WriteLine("Getting Ready");

            // Thread.Sleep we use to
            // simulate the long running operations
            Thread.Sleep(2000);

            Console.WriteLine("First message arrived");

            Thread.Sleep(2000);
            Console.WriteLine("Second message arrived");

            Thread.Sleep(2000);
            Console.WriteLine("Thrid message arrived");
            
            Console.WriteLine("All messages are recieved");

            Console.ReadLine();
        }
    
        private static void SendMessagesWithThreads() 
        { 
            Console.WriteLine("Getting Ready");

            Thread thread1 = new Thread(Message1);
            thread1.Start();

            Thread thread2 = new Thread(Message2);
            thread2.Start();

            Thread thread3 = new Thread(Message3);
            thread3.Start();

            Console.WriteLine("All messages are recieved");

            Console.ReadLine();
        }

        private static void Message1()
        {
            Thread.Sleep(2000);
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
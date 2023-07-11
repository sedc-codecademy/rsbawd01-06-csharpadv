namespace GenericsExamples.Helpers
{
    public class GenericListHelpers<T>
    {
        public static void GoThrough(List<T> items)
        {
            foreach (T item in items)
                Console.WriteLine(item);
        }

        public static void GetInfo(List<T> items) 
        {
            //if (items.GetType() == typeof(List<string>) )
            //    Console.WriteLine("This is list of strings");

            Console.WriteLine($"This is list of {items.GetType().FullName} " +
                $"and the count is {items.Count}");
        }
    }
}

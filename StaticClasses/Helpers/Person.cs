namespace StaticClasses.Helpers
{
    public class Person
    {
        public string FullName { get; set; }

        public static int CounterOfPersonsCreated = 0;

        public Person(string name)
        {
            CounterOfPersonsCreated++;
            FullName = name;
        }
    }
}

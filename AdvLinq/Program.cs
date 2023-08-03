using System.Globalization;

namespace AdvLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>
            {
                new Person { FirstName = "Alice", LastName = "Smith", Age = 25, Country = "USA", Hobbies = new List<string> { "Reading", "Hiking" } },
                new Person { FirstName = "Bob", LastName = "Johnson", Age = 30, Country = "Canada", Hobbies = new List<string> { "Cooking", "Painting" } },
                new Person { FirstName = "Charlie", LastName = "Brown", Age = 22, Country = "UK", Hobbies = new List<string> { "Swimming", "Gaming" } },
                new Person { FirstName = "David", LastName = "Wilson", Age = 27, Country = "USA", Hobbies = new List<string> { "Photography", "Gardening" } },
                new Person { FirstName = "Emily", LastName = "Davis", Age = 28, Country = "Canada", Hobbies = new List<string> { "Traveling", "Yoga" } },
                new Person { FirstName = "John", LastName = "Smith", Age = 35, Country = "USA", Hobbies = new List<string> { "Reading", "Cooking", "Hiking" } },
                new Person { FirstName = "Jane", LastName = "Doe", Age = 32, Country = "Canada", Hobbies = new List<string> { "Reading", "Gaming" } },
                new Person { FirstName = "Michael", LastName = "Brown", Age = 24, Country = "UK", Hobbies = new List<string> { "Swimming", "Hiking" } },
                new Person { FirstName = "Daniel", LastName = "Wilson", Age = 30, Country = "USA", Hobbies = new List<string> { "Gardening" } },
                new Person { FirstName = "Emma", LastName = "Johnson", Age = 29, Country = "Canada", Hobbies = new List<string> { "Yoga", "Cooking" } },
                new Person { FirstName = "Olivia", LastName = "Smith", Age = 23, Country = "USA", Hobbies = new List<string> { "Reading", "Gardening" } },
                new Person { FirstName = "James", LastName = "Davis", Age = 26, Country = "Canada", Hobbies = new List<string> { "Traveling" } },
                new Person { FirstName = "Noah", LastName = "Brown", Age = 29, Country = "UK", Hobbies = new List<string> { "Swimming", "Gaming" } },
                new Person { FirstName = "Ella", LastName = "Wilson", Age = 28, Country = "USA", Hobbies = new List<string> { "Photography", "Cooking" } },
                new Person { FirstName = "Liam", LastName = "Davis", Age = 31, Country = "Canada", Hobbies = new List<string> { "Reading", "Yoga" } }
            };

            // find the person with name Michael and last name brown

            Person michaelItem = personList
                .Where(p => p.FirstName == "Michael" && p.LastName == "Brown")
                .FirstOrDefault();


            Console.WriteLine($"{michaelItem.FirstName} {michaelItem.LastName} {michaelItem.Age}");

            List<Person> ageBetween20and27 = personList
                .Where(p => p.Age >= 20 && p.Age <= 27)
                .OrderByDescending(p => p.Age)
                .ToList();

            Person oldestPerson = personList
                .OrderBy(p => p.Age)
                .LastOrDefault();

            foreach (Person item in ageBetween20and27)
                Console.WriteLine($"{item.FirstName} {item.Age}");

            Console.WriteLine($"Oldest Person: {oldestPerson.FirstName} {oldestPerson.LastName} - {oldestPerson.Age}");

            var firstNamesFromUSA = personList
                .Where(p => p.Country == "USA")
                .OrderByDescending(p => p.Age)
                .Select(p => p.FirstName)
                .ToList();

            Console.WriteLine("From USA:");
            foreach (var name in firstNamesFromUSA)
            {
                Console.WriteLine(name);
            }

            // find average age

            double averageAge = personList
                .Average(p => p.Age);

            double minAge = personList
              .Min(p => p.Age);

            double maxAge = personList
              .Max(p => p.Age);

            double count = personList
             .Count();

            Console.WriteLine($"Count of items {count}, average age is {averageAge}, " +
                $"the youngest age is {minAge}, the oldest age is {maxAge}");

            List<Person> fiveOldestOnes = personList
                .OrderByDescending(p => p.Age)
                .ThenByDescending(p => p.LastName)
                .Take(5)
                .ToList();

            Console.WriteLine("Top 5 Oldest people");

            foreach (Person person in fiveOldestOnes)
                Console.WriteLine($"{person.FirstName} {person.LastName} - {person.Age}");
        }
    }
}
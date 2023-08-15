using Newtonsoft.Json;
using System.Xml;

namespace C11E1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>();

            while (true)
            {
                Console.Write("Enter dog's name (or type 'exit' to finish): ");
                string name = Console.ReadLine();

                if (name.ToLower() == "exit")
                    break;

                Console.Write("Enter dog's age: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Enter dog's color: ");
                string color = Console.ReadLine();

                dogs.Add(new Dog { Name = name, Age = age, Color = color });
            }

            // Serialize and write to txt file
            string json = JsonConvert.SerializeObject(dogs);
            File.WriteAllText("dogs.txt", json);

            Console.WriteLine("Dogs written to dogs.txt");

            // Deserialize and read from txt file
            string jsonData = File.ReadAllText("dogs.txt");
            List<Dog> readDogs = JsonConvert.DeserializeObject<List<Dog>>(jsonData);

            Console.WriteLine("Dogs read from dogs.txt:");
            foreach (var dog in readDogs)
            {
                Console.WriteLine($"Name: {dog.Name}, Age: {dog.Age}, Color: {dog.Color}");
            }
        }
    }

    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
    }
}
using System.Globalization;

namespace PolymorphismExamples.Models
{
    public class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Eat() 
        {
            Console.WriteLine($"I am pet {Name} and currently I am eating my food");
        }
    }

    public class Dog : Pet
    {
        public string DogFamilyType { get; set; }

        public override void Eat()
        {
            Console.WriteLine($"I am dog {Name}, of the " +
                $"type {DogFamilyType} and now I am eating");
        }
    }

    public class Cat : Pet
    {
        public bool KnowsHowToUseSand { get; set; }
        public bool CanDrinkMilk { get; set; }

        public override void Eat()
        {
            // string candrinkMilk = "";
            string candrinkMilk = string.Empty;

            if (CanDrinkMilk)
                candrinkMilk = "I can drink milk";
            else
                candrinkMilk = "I am not able to drink milk";

            Console.WriteLine($"I am cat {Name}, I am {Age} old and " +
                $"{candrinkMilk}");
        }

    }

}

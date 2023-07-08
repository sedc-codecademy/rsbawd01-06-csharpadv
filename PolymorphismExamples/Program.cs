using PolymorphismExamples.Models;

namespace PolymorphismExamples
{
    internal class Program
    {
        static void Main()
        {
            Dog rex = new Dog();

            // Properties from the base type "Pet"
            rex.Name = "Rex";
            rex.Age = 5;

            // Specific property to type "Dog"
            rex.DogFamilyType = "German Shepherd";

            Cat cat = new Cat();

            // Properties from the base type "Pet"
            cat.Name = "Cicko";
            cat.Age = 1;

            // Specific property to type "Cat"
            cat.CanDrinkMilk = true;
            cat.KnowsHowToUseSand = true;

            DoThePrinting(cat);
            DoThePrinting(rex);

            Pet newPet = new Pet();
            newPet.Name = "Pet sam na svijetu";

            newPet.Eat();
        }

        public static void DoThePrinting(Pet paramemter) 
        {
            // other complex logic
            // ....

            paramemter.Eat();
        }

        public static void ShowDetails(Pet pet)
        {
            Console.WriteLine(pet.Name);
            Console.WriteLine(pet.Age);
        }

        public static void ShowDetails(Pet pet, string price)
        {
            Console.WriteLine($"Pet with the price {price}, has following data:");
            Console.WriteLine(pet.Name);
            Console.WriteLine(pet.Age);
        }

        public static void ShowDetails(Pet pet, string price, string newOwner)
        {
            Console.WriteLine($"Pet with the price {price} and new owner {newOwner}, has following data:");
            Console.WriteLine(pet.Name);
            Console.WriteLine(pet.Age);
        }
    }
}
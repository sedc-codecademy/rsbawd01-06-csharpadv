using Exercise.Entities;
using Exercise;

namespace C4E1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PetStore<Dog> dogStore = new PetStore<Dog>();
            PetStore<Cat> catStore = new PetStore<Cat>();
            PetStore<Fish> fishStore = new PetStore<Fish>();

            dogStore.Pets.Add(new Dog("Sparky", 3, true, "Carrot"));
            dogStore.Pets.Add(new Dog("Zoe", 1, false, "Apple"));
            catStore.Pets.Add(new Cat("Meow", 2, false, 9));
            catStore.Pets.Add(new Cat("Kitty", 4, true, 7));
            fishStore.Pets.Add(new Fish("Blob", 0, "Yellow", 5));
            fishStore.Pets.Add(new Fish("Bubbles", 1, "Blue", 12));

            dogStore.BuyPet("Sparky");
            catStore.BuyPet("Meow");

            dogStore.PrintPets();
            catStore.PrintPets();
            fishStore.PrintPets();

            Console.ReadLine();
        }
    }
}
using System;

namespace ClasAndObj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first dog:");
            string dogName = Console.ReadLine();
            Console.WriteLine("First dog breeding:");
            string dogBreed = Console.ReadLine();
            Console.WriteLine("Legs:");
            int legs = int.Parse(Console.ReadLine());

            Dog firstDog = new Dog(dogName,dogBreed, legs);
            Dog secondDog = new Dog();
            Console.WriteLine("Enter second dog:");
            secondDog.Name = Console.ReadLine();
            Console.WriteLine("Second dog breed:");
            secondDog.Breed = Console.ReadLine();
            Console.WriteLine("Second dog Legs:");
            secondDog.Legs = int.Parse(Console.ReadLine());

            Dog[] dogs = new Dog[]
            {
                firstDog,
                secondDog
            };

            foreach (var dog in dogs)
            {
                dog.SayBau();
            }


        }
    }
}

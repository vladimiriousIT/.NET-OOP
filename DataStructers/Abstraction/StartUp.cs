using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction.Animals;
using Abstraction.CarsInterface;
using Abstraction.Store;

namespace Abstraction
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var implementator = new Implementator();
            Console.WriteLine(implementator.Name());
            Console.WriteLine();
            IFirst impFirst = new Implementator();
            Console.WriteLine(impFirst.Name());
            Console.WriteLine();
            ISecond impSecond = new Implementator();
            Console.WriteLine(impSecond.Name());
            //==================================>
            //var cars = new List<ICar>();
            //cars.Add(new Audi("Audi A6"));
            //cars.Add(new Mercedess("CL63AMG"));
            //foreach (var car in cars)
            //{
            //    Console.WriteLine(car.Model);
            //    car.Start();
            //    Console.WriteLine("Brymkalo si -> " + car.Model);
            //    car.Stop();
            //}
            //==========================================>
            //Animal someAnimal = new Cat();
            //someAnimal.SayHello(); //викам абстрактния от Animal но понеже имплементацията е котка ще използва SayHelloCat

            //var listOfAnimals = new List<Animal>();
            //listOfAnimals.Add(new Dog());
            //listOfAnimals.Add(new Cat());
            //listOfAnimals.Add(new Bunny());

            //foreach (var animal in listOfAnimals)
            //{
            //    Console.WriteLine(animal.SayHello());
            //}
        }
    }
}

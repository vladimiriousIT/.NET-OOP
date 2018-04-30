using System;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dice dice = new Dice();
            //dice.SetSides(5);
            //dice.Roll();
            //dice.Sides1 = 5;
            //Console.WriteLine(dice.Sides1);
            var person = new Person();
            person.FirstName = Console.ReadLine();
            person.SecondName = Console.ReadLine();

            Console.WriteLine(person.FullName);
        }
    }
}

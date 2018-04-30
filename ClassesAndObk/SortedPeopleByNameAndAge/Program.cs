using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var personsInput = int.Parse(Console.ReadLine());
        var personList = new List<Person>();

        for (int counter = 0; counter < personsInput; counter++)
        {
            var input = Console.ReadLine().Split();
            var person = new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));
            personList.Add(person);
        }

        var persentange = decimal.Parse(Console.ReadLine());
        personList.ForEach(p => p.IncreaseSalary(persentange));
        personList.ForEach(p => Console.WriteLine(p));
        
        
        
        
        //personList.OrderBy(p => p.FirstName).ThenBy(p => p.Age).ToList().ForEach(p => Console.WriteLine(p));
        //foreach (var person in personList)
        //{
        //    Console.WriteLine(person);
        //}
    }
}


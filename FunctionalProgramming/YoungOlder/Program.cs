using System;
using System.Collections.Generic;
using System.Linq;

namespace YoungOlder
{
    class Program
    {
        static void Main(string[] args)
        {
            var peopleCount = int.Parse(Console.ReadLine());
            var people = new Dictionary<string, int>(peopleCount);

            for (int counter = 0; counter < peopleCount; counter++)
            {
                var nameAndAge = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                people.Add(nameAndAge[0], int.Parse(nameAndAge[1]));
            }
            var condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();
            var filter = GetFilter(condition, age);
            var printer = CreatePrinter(format);
            PrintPeople(people, filter, printer);
            // people.Where(p => p.Value > 10);
            //people.Where(p=>filter(p.value)).ToList().ForEach(printer);
        }

        private static void PrintPeople(Dictionary<string, int> people, Func<int, bool> filter, Action<KeyValuePair<string, int>> printer)
        {
            foreach (var person in people)
            {
                if (filter(person.Value))
                {
                    printer(person);
                }
            }
        }

        static Func<int, bool> GetFilter(string condition, int age)
        //static Func<KeyValuePair<string,int>, bool> GetFilter (string condition, int age)
        {
            if(condition == "younger")
            {
                return x => x < age;
            }
            else
            {
                return x => x >= age;
            }
        }

        static Action<KeyValuePair<string, int>> CreatePrinter (string format)
        {
            switch (format)
            {
                case "name":
                    return x => Console.WriteLine(x.Key);
                case "age":
                    return x => Console.WriteLine(x.Value);
                case "name age":
                    return x => Console.WriteLine($"{x.Key} - {x.Value}");
                default:
                    throw new NotImplementedException();
            }
        }
    }
}

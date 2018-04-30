using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            numbers = numbers.OrderByDescending(n => n).Take(3).ToList();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}

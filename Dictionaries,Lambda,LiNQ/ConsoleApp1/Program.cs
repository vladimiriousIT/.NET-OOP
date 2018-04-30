using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int sum = 0;
            Dictionary<double, int> numbersCount = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!numbersCount.ContainsKey(number) )
                {
                    numbersCount[number] = 1;
                    sum++;
                }
                else
                {
                    numbersCount[number]++;
                }
            }

            foreach (var kvp in numbersCount.Reverse())
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value} times and sum: {sum}");
            }
        }
    }
}

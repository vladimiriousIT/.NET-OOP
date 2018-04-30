using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumsSecondOpt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            numbers.Sort();

            //var currentNumber = numbers[0];
            //var currentCount = 1;

            int[] numbersCount = new int[1001];

            for (int i = 0; i < numbers.Count; i++)
            {
                var currentNumber = numbers[i];
                numbersCount[currentNumber]++;
            }

            for (int i = 0; i < numbersCount.Length; i++)
            {
                var currentNumberInArray = numbersCount[i];
                if (currentNumberInArray > 0)
                {
                    Console.WriteLine($"{i} -> {currentNumberInArray}");
                }
            }
        }
    }
}

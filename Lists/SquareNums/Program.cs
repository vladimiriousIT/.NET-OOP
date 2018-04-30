using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                var currentNum = numbers[i];
                var square = Math.Sqrt(currentNum);

                if(square == (int)square)
                {
                    result.Add((int)currentNum);
                }
            }
            result.Sort();
            result.Reverse();
            Console.WriteLine(string.Join(" ",result));
        }
    }
}

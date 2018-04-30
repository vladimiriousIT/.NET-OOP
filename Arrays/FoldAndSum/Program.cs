using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = numbers.Length / 4;

            int[] uper = new int[numbers.Length / 2];
            int[] lower = new int[numbers.Length / 2];

            for (int i = 0; i < 2 * k; i++)
            {
                lower[i] = numbers[k + i];
            }
            for (int i = 0; i < k; i++)
            {
                uper[i] = numbers[k - 1 - i];
                uper[k + i] = numbers[4 * k - 1 - i];
            }
            int[] sum = new int[2 * k];
            for (int i = 0; i < 2*k; i++)
            {
                sum[i] = uper[i] + lower[i];
            }
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}

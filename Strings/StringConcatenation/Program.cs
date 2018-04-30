using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Stopwatch();
            timer.Start();
            var result = new StringBuilder();
            for (int i = 0; i < 50000; i++)
            {
                result.Append(Convert.ToString(i, 2));
            }
            Console.WriteLine(result.Length);

            Console.WriteLine(timer.Elapsed);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenDecNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = int.Parse;
            var number = Console.ReadLine().Split(new string[] { "," } ,StringSplitOptions.None).
                Select(n => int.Parse(n)).Where(n => n % 2 == 0)
                .OrderBy(n => n);
            Console.WriteLine(string.Join(", ", number));
        }
    }
}
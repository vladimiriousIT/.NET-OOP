using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestovShogi
{
    class Program
    {
        static void Main(string[] args)
        {

            string shogu = Console.ReadLine();
            int ageOfshogi = int.Parse(Console.ReadLine());
            Console.WriteLine($"The name of the ultras is :{shogu} and he is: + {ageOfshogi}");
        }
    }
}

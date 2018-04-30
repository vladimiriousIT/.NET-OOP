using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries_Lambda_LiNQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> marks= new Dictionary<string, double>();
            marks["Ivan"] = 6.00;
            marks["Vladi"] = 7.00;

            double vladiMark = marks["Vladi"];
            Console.WriteLine(vladiMark);

            //a - 100
            //v - 777
            //z - 3

            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            letterCount['a'] = 100;
            letterCount['v'] = 777;
            letterCount['z'] = 77;
            Console.WriteLine(letterCount['v']);
        }
    }
}

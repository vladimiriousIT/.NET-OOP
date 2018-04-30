using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var pattern = Console.ReadLine();
            var count = 0;
            var index = 0;

            while (true)
            {
                index = text.IndexOf(pattern, index);

                if (index < 0)
                {
                    break;
                }

                count++;
                index++;
            } 
            Console.WriteLine(count);
        }
    }
}

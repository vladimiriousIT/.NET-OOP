using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> commands = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int bombNumber = commands[0];
            int power = commands[1];
            while( numbers.Contains(bombNumber))
            {
                int position = numbers.IndexOf(bombNumber);
                if (position - power < 0 && position + power > numbers.Count)
                {

                }
            }
        }
    }
}

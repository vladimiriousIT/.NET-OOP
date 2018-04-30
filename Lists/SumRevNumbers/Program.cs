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
            var sequence = Console.ReadLine()
                           .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToList();

            var info = Console.ReadLine()
                           .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToList();

            var bombNumber = info[0];
            var bombRadius = info[1];


            for (int i = 0; i < sequence.Count; i++)
            {
                var startIndex = 0;
                var endIndex = 0;

                if (bombNumber == sequence[i])
                {
                    if (bombRadius - i < 0)
                    {
                        startIndex = i - bombRadius;
                    }
                    else
                    {
                        startIndex = 0;
                    }

                    if (i + bombRadius > sequence.Count - 1)
                    {
                        endIndex = sequence.Count - 1;
                    }
                    else
                    {
                        endIndex = i + bombRadius;
                    }

                    for (int X = endIndex; X >= startIndex; X--)
                    {
                        sequence.Remove(sequence[startIndex]);
                    }
                }

            }

            Console.WriteLine(sequence.Sum());
        }
    }
}
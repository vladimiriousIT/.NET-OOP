using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProc
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("lines.txt");
            var result = new StringBuilder();

            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 2 != 0)
                {
                    result.AppendLine(lines[i]);
                }
            }
            File.WriteAllText("odd-lines.txt", result.ToString());
        }
    }
}

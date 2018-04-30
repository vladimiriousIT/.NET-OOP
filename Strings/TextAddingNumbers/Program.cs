using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace TextAddingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("input.txt");

            var result = new StringBuilder();

            for (int i = 0; i < lines.Length; i++)
            {
                var currentLine = lines[i];
                result.AppendLine($"{i + 1}.{currentLine}");
            }

            File.WriteAllText("output.txt", result.ToString());
        }
    }
}

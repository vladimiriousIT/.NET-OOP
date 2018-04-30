﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Console.ReadLine().Split(new char[] { '.', ',', ':', ';', '(',')','[',']', '\"', '\'', '/', '\\', '!', '?', ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length < 5)
                .Select(w => w.ToLower())
                .OrderBy(w => w)
                .Distinct()
                .ToList();

            Console.WriteLine(String.Join(", ", result));
        }
    }
}

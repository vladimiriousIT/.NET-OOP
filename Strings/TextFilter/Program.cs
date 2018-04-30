﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(new[] {',', ' ' },StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();

            foreach (var word in words)
            {
                var replacement = new string('*',word.Length);
                text = text.Replace(word,replacement);
            }
            Console.WriteLine(text);
        }
    }
}

﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace NumbersVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new string[] { "," },StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(d => d * 1.2)
                .ToList();

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number:F2}");
            }
        }
    }
}

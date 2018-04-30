﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words1 = Console.ReadLine().Split(' ').ToArray();
            string[] words2 = Console.ReadLine().Split(' ').ToArray();
            int leftCount = 0;
            int rightCount = 0;

            for (int i = 0; i < Math.Min(words1.Length,words2.Length); i++)
            {
                if (words1[i] == words2[i])
                {
                    leftCount++;
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < Math.Min(words1.Length, words2.Length); i++)
            {
                if(words1[words1.Length-1-i] == words2[words2.Length-1-i])
                {
                    rightCount++;
                }
                else
                {
                    break;
                }
            }
            if(leftCount > rightCount)
            {
                Console.WriteLine(leftCount);
            }
            else
            {
                Console.WriteLine(rightCount);
            }
        }
    }
}

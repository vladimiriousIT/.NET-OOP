using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        Lion lion = new Lion(true, 77);
        Console.WriteLine(lion.Male);
        Console.WriteLine(lion.Weight);
    }
}

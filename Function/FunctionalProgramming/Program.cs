using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Func<string, string, List<int>, string> namesGrade = (firstName, lastName, grade) => $"FirstName:{firstName}, SecondName:{lastName} -> {grade.Average()}";
            List<int> gradesAver = new List<int>() { 7, 13, 25, 16, 91 };
            var theStudent = namesGrade("vladi","stratiev",gradesAver);
            Console.WriteLine(theStudent);
            */
            Func<string> readFromConsole = () => Console.ReadLine();
            Action<string> printToConsole = text => Console.WriteLine(text);

            var input = readFromConsole();
            printToConsole(input);
        }
    }
}

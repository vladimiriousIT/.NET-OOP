using System;

namespace PrintAgeAndName
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.PrintNameAndAge("Vladi", 25);
        }
    }
}

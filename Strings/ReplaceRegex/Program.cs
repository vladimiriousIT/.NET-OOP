using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ReplaceRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = @"<ul><li><a href=""http://softuni.bg"">SoftUni</a></li></ul> <a <a href=""a"">a<a></a></a>";

            var regex = new Regex(@"<a.+href=""(.+?)"">(.+?)<\/a>");
            var matches = regex.Matches(text);

            var result = regex.Replace(text, "[URL href =\"$1\"]$2[/ URL]");
            Console.WriteLine();
            Console.WriteLine(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(\d{2})-(\w{3})-(\d{4})");
            var text = "This text has date: 20-Jan-2018. Another Date : 02-Aug-1992 .";

            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
                Console.WriteLine(match.Groups[3].Value);
            }
        }
    }
}

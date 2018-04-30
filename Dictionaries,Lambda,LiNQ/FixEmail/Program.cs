using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> mailbook = new Dictionary<string, string>();
            string name = "";
            string mail = "";
            string commands = Console.ReadLine();

            while (commands != "stop")
            {
                name = commands;
                mail = Console.ReadLine();
                if (!mailbook.ContainsKey(name))
                {
                    mailbook.Add(name, mail);
                }
                commands = Console.ReadLine();
            }
            foreach (var kvp in mailbook.Where(x => !x.Value.EndsWith(".us") && !x.Value.EndsWith(".uk")))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinnerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> miner = new Dictionary<string, int>();
            string commands = Console.ReadLine();
            string metal = "";
            int quantity = 0;

            while (commands != "stop")
            {
                metal = commands;
                quantity = int.Parse(Console.ReadLine());
                if (!miner.ContainsKey(metal))
                {
                    miner.Add(metal, quantity);
                }
                else
                {
                    miner[metal] += quantity;
                }
                commands = Console.ReadLine();
            }

            foreach (var kvp in miner)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}

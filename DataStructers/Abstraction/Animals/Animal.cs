using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Animals
{
    public abstract class Animal
    {
        public const int NumberOfEyes = 2;
        public string Name { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }

        public abstract string SayHello(); 
    }
}

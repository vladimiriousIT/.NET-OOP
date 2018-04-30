using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.CarsInterface
{
    public class Audi : ICar
    {
        public string Model { get; private set; }
        
        public Audi(string model)
        {
            this.Model = model;
        }


        public void Start()
        {
            Console.WriteLine("Start Brum of Audi");
        }

        public void Stop()
        {
            Console.WriteLine("Stop Brum of Audi");
        }
    }
}

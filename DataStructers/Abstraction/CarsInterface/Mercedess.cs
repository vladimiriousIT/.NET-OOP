using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.CarsInterface
{
    class Mercedess : ICar
    {
        public string Model { get; private set; }
        public Mercedess(string modelOfMerc)
        {
            this.Model = modelOfMerc;
        }

        public void Start()
        {
            Console.WriteLine("Start Brum of Merc");
        }

        public void Stop()
        {
            Console.WriteLine("End Brum of Merc");
        }
    }
}

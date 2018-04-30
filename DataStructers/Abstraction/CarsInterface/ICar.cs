using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.CarsInterface
{
    public interface ICar
    {
        string Model { get; }
        void Start();
        void Stop();
    }
}

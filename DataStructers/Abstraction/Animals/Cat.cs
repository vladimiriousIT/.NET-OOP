using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Animals
{
    public class Cat : Animal
    {
        public void Sleep()
        {

        }

        public override string SayHello()
        {
            return "Myauuu";
        }
    }
}

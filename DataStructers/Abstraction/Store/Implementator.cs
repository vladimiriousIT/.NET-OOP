using System;

namespace Abstraction.Store
{
    public class Implementator : IFirst, ISecond
    {
        public string Name()
        {
            return "Vladi Uminkov";
        }
        string IFirst.Name()
        {
            return "Vladi";
        }

        int ISecond.Name()
        {
            return 5;
        }
    }
}

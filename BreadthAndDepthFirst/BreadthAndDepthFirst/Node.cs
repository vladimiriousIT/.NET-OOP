using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthAndDepthFirst
{
    public class Node
    {
        public Node Left;
        public Node Right;
        public String Data;

        public Node(String Data, Node Left, Node Right)
        {
            this.Data = Data;
            this.Left = Left;
            this.Right = Right;
        }
        public Node(String Data)
        {
            this.Data = Data;
            this.Left = null;
            this.Right = null;
        }
    }
}


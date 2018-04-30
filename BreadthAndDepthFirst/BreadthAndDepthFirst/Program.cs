using System;
using System.Collections.Generic;

namespace BreadthAndDepthFirst
{
    class Program
    {
        static Node sample_tree()
        {
            Node root = new Node("A",
                new Node("B",
                new Node("C"),
                new Node("D")),
                new Node("E", new Node("F"), new Node("G", new Node("H"), null)));

            return root;
        }

        static void Main(string[] args)
        {
            Node tree = sample_tree();
            Console.WriteLine("BFS -> ");
           // Bfs_traversal(tree);

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("\r\nDFS -->");
            //Dfs_traversal(tree);
        }
    }
}

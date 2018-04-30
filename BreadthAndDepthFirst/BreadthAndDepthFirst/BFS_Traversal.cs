using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthAndDepthFirst
{
    public class BFS_Traversal
    { 
        public static void Bfs_traversal(Node nodeBFS)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(nodeBFS);
            while (q.Count > 0)
            {
                nodeBFS = q.Dequeue();
                Console.WriteLine(nodeBFS.Data + " ");
                if (nodeBFS.Left != null)
                {
                    q.Enqueue(nodeBFS.Left);
                }

                if (nodeBFS.Right != null)
                {
                    q.Enqueue(nodeBFS.Right);
                }
            }
        }
    }
}

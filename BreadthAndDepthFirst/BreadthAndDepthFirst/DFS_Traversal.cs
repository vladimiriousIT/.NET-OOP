using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthAndDepthFirst
{
    public class DFS_Traversal
    {
        static void Dfs_traversal(Node nodeDfs)
        {
            if (nodeDfs == null)
            {
                return;
            }
            Console.WriteLine(nodeDfs.Data + " ");
            Dfs_traversal(nodeDfs.Left);            
            Dfs_traversal(nodeDfs.Right);

        }
    }
}

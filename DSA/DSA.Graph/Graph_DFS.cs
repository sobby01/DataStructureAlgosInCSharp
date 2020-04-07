using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Graph
{
    public class Graph_DFS
    {
        //Graph Traversal
        private List<int>[] adj;
        private int Vertex;
        public Graph_DFS(int vertex)
        {
            this.Vertex = vertex;
            adj =new List<int>[vertex];

            for (int i = 0; i < vertex; i++)
            {
                adj[i] = new List<int>();
            }
        }

        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
        }

        /// <summary>
        /// Pass vertex from where we are planning to traverse the graph
        /// </summary>
        /// <param name="v"></param>
        public void TraverseGraph(int v)
        {
            bool[] visited = new bool[Vertex];
            for (int i = 0; i < Vertex; i++)
            {
                visited[i] = false;
            }
            TraverseGraphUtil(v, visited);
        }

        public void TraverseGraphUtil(int v, bool[] visited)
        {
            visited[v] = true;
            Console.Write(v + " ");
            
            //Get the adjacent vertex;
            List<int> adjVertex = adj[v];

            foreach (var ver in adjVertex)
            {
                if (visited[ver] == false)
                {
                    TraverseGraphUtil(ver, visited);
                }
            }

        }

        public void BuildGraph()
        {
            AddEdge(0, 1);
            AddEdge(0, 2);
            AddEdge(1, 2);
            AddEdge(2, 0);
            AddEdge(2, 3);
            AddEdge(3, 3);
        }

    }

    public class GraphDemo
    {
        public void BuildAndTraverse()
        {
            Graph_DFS graph = new Graph_DFS(4);

            graph.BuildGraph();

            Console.WriteLine("Following is Depth First Traversal " +
                              "(starting from vertex 2)");

            graph.TraverseGraph(2);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Graph
{
    public class ShortestPathInUndirectedGraph
    {
        private int Vertex;
        private List<int>[] adjNodes;
        ShortestPathInUndirectedGraph(int vertex)
        {
            Vertex = vertex;
            adjNodes = new List<int>[vertex];

            for (int i = 0; i < vertex; i++)
            {
                adjNodes[i] = new List<int>();
            }
        }

        public void AddEdge(int v, int w)
        {
            adjNodes[v].Add(w);
        }

        public void FindShortestPath(int s)
        {
            bool[] visitedarray = new bool[Vertex];

            Queue<int> q = new Queue<int>();

            q.Enqueue(s);
            visitedarray[s] = true;


        }


        public void BuildGraph()
        {
            AddEdge(0,1);
            AddEdge(0, 2);
            AddEdge(1, 2);
            AddEdge(1, 3);
            AddEdge(2, 3);
        }
    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Graph
{
    public class Graph_BFS
    {
        private int Vertex;
        private List<int>[] adjList;

        public Graph_BFS(int vertex)
        {
            this.Vertex = vertex;
            adjList= new List<int>[vertex];

            for (int indexer = 0; indexer < vertex; indexer++)
            {
                adjList[indexer]= new List<int>();
            }
        }

        private void AddEdge(int v, int w)
        {
            adjList[v].Add(w);
        }

        //Print BFS from the source S
        public void BFS(int s)
        {
            Queue<int> queue = new Queue<int>();
            bool[] visited = new bool[Vertex];

            queue.Enqueue(s);
            visited[s] = true;

            while (queue.Count > 0)
            {
                int number = queue.Dequeue();
                Console.Write(number + " ");

                List<int> adjListForVertex = adjList[number];

                foreach (var i in adjListForVertex)
                {
                    if (visited[i] == false)
                    {
                        visited[i] = true;
                        queue.Enqueue(i);
                    }
                }
            }
        }

        public void BuildGraph()
        {
            AddEdge(0,1);
            AddEdge(0, 2);
            AddEdge(1, 2);
            AddEdge(2, 0);
            AddEdge(2, 3);
            AddEdge(3, 3);
        }
    }

    public class Graph_BFS_Demo
    {
        public void BuildAndTraverse()
        {
            Graph_BFS graph = new Graph_BFS(4);
            graph.BuildGraph();
            graph.BFS(2);
        }

               
    }
}

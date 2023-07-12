using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_1753
    {
        public No_1753()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int V = int.Parse(inputs[0]);
            int E = int.Parse(inputs[1]);

            List<(int vertex, int weight)>[] weights = new List<(int vertex, int weight)>[V + 1];
            for (int i = 0; i < V + 1; i++)
            {
                weights[i] = new List<(int, int)>();
            }

            int startVertex = int.Parse(reader.ReadLine());
            for (int i = 0; i < E; i++)
            {
                inputs = reader.ReadLine().Split();
                weights[int.Parse(inputs[0])].Add((int.Parse(inputs[1]), int.Parse(inputs[2])));
            }

            int[] minWeights = Dijkstra(startVertex);
            for (int i = 1; i <= V; i++)
            {
                if (minWeights[i] >= int.MaxValue)
                    print.WriteLine("INF");
                else
                    print.WriteLine(minWeights[i]);
            }

            int[] Dijkstra(int start)
            {
                bool[] visited = new bool[V + 1];
                Queue<(int v, int weight)> queue = new Queue<(int, int)>();
                queue.Enqueue((start, 0));
                visited[start] = true;

                int[] minWeights = new int[V + 1];
                for (int i = 1; i <= V; i++)
                {
                    minWeights[i] = int.MaxValue;
                }

                minWeights[start] = 0;

                while (queue.Count > 0)
                {
                    (int v, int weight) = queue.Dequeue();

                    int count = weights[v].Count;
                    for (int i = 0; i < count; i++)
                    {
                        minWeights[weights[v][i].vertex] = Math.Min(weight + weights[v][i].weight, minWeights[weights[v][i].vertex]);
                    }

                    int index = 0;
                    int min = int.MaxValue;
                    for (int i = 1; i <= V; i++)
                    {
                        if (!visited[i])
                        {
                            if (min > minWeights[i])
                            {
                                min = minWeights[i];
                                index = i;
                            }
                        }
                    }

                    if (min == int.MaxValue)
                        break;

                    queue.Enqueue((index, min));
                    visited[index] = true;
                }

                return minWeights;
            }

            reader.Close();
            print.Close();
        }
    }
}

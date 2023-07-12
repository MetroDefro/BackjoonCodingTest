using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_1504
    {
        public No_1504()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int N = int.Parse(inputs[0]);
            int E = int.Parse(inputs[1]);

            int[,] distances = new int[N + 1, N + 1];
            for (int i = 0; i < E; i++)
            {
                inputs = reader.ReadLine().Split();
                distances[int.Parse(inputs[0]), int.Parse(inputs[1])] = int.Parse(inputs[2]);
                distances[int.Parse(inputs[1]), int.Parse(inputs[0])] = int.Parse(inputs[2]);
            }

            inputs = reader.ReadLine().Split();
            int v1 = int.Parse(inputs[0]);
            int v2 = int.Parse(inputs[1]);

            int startToV1 = BFS(1, v1);
            int startToV2 = BFS(1, v2);
            int v1ToV2 = BFS(v1, v2);
            int v1ToEnd = BFS(v1, N);
            int v2ToEnd = BFS(v2, N);

            if (1 == v1 && N == v2)
            {
                int startToEnd = BFS(1, N);
                if (startToEnd >= int.MaxValue)
                    print.WriteLine(-1);
                else
                    print.WriteLine(startToEnd);
            }
            else if (1 == v1)
            {
                if (startToV2 >= int.MaxValue || v2ToEnd >= int.MaxValue)
                    print.WriteLine(-1);
                else
                    print.WriteLine(startToV2 + v2ToEnd);
            }
            else if (N == v2)
            {
                if (startToV1 >= int.MaxValue || v1ToEnd >= int.MaxValue)
                    print.WriteLine(-1);
                else
                    print.WriteLine(startToV1 + v1ToEnd);
            }
            else
            {
                if ((startToV1 >= int.MaxValue || v1ToV2 >= int.MaxValue || v2ToEnd >= int.MaxValue) || (startToV2 >= int.MaxValue || v1ToV2 >= int.MaxValue || v1ToEnd >= int.MaxValue))
                    print.WriteLine(-1);
                else
                    print.WriteLine(Math.Min(startToV1 + v1ToV2 + v2ToEnd, startToV2 + v1ToV2 + v1ToEnd));
            }

            int BFS(int start, int end)
            {
                bool[] visited = new bool[N + 1];
                Queue<(int v, int distance)> queue = new Queue<(int, int)>();
                queue.Enqueue((start, 0));
                visited[start] = true;

                int[] minDistance = new int[N + 1];
                for (int i = 1; i <= N; i++)
                {
                    minDistance[i] = int.MaxValue;
                }
                while (queue.Count > 0)
                {
                    (int v, int distance) = queue.Dequeue();

                    for (int i = 1; i <= N; i++)
                    {
                        if (distances[v, i] != 0)
                            minDistance[i] = Math.Min(distance + distances[v, i], minDistance[i]);
                    }

                    int index = 0;
                    int min = int.MaxValue;
                    for (int i = 1; i <= N; i++)
                    {
                        if (!visited[i])
                        {
                            if (min > minDistance[i])
                            {
                                min = minDistance[i];
                                index = i;
                            }
                        }
                    }

                    if (min == int.MaxValue)
                        break;

                    queue.Enqueue((index, min));
                    visited[index] = true;
                }

                return minDistance[end];
            }

            reader.Close();
            print.Close();
        }
    }
}

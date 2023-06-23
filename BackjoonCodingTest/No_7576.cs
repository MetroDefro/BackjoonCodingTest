using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_7576
    {
        public No_7576()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int M = int.Parse(inputs[0]);
            int N = int.Parse(inputs[1]);
            int[,] tomatos = new int[M, N];
            for (int n = 0; n < N; n++)
            {
                inputs = reader.ReadLine().Split();
                for (int m = 0; m < M; m++)
                {
                    tomatos[m, n] = int.Parse(inputs[m]);
                }
            }

            print.WriteLine(BFS());

            reader.Close();
            print.Close();

            int BFS()
            {
                bool[,] visited = new bool[M, N];

                Queue<(int x, int y, int count)> queue = new Queue<(int x, int y, int count)>();

                for (int n = 0; n < N; n++)
                {
                    for (int m = 0; m < M; m++)
                    {
                        if (tomatos[m, n] == 1)
                        {
                            visited[m, n] = true;
                            queue.Enqueue((m, n, 0));
                        }
                    }
                }

                int max = 0;
                while (queue.Count > 0)
                {
                    (int x, int y, int count) = queue.Dequeue();

                    if (x > 0 && !visited[x - 1, y] && tomatos[x - 1, y] == 0)
                    {
                        visited[x - 1, y] = true;
                        queue.Enqueue((x - 1, y, count + 1));
                    }

                    if (y > 0 && !visited[x, y - 1] && tomatos[x, y - 1] == 0)
                    {
                        visited[x, y - 1] = true;
                        queue.Enqueue((x, y - 1, count + 1));
                    }

                    if (x < M - 1 && !visited[x + 1, y] && tomatos[x + 1, y] == 0)
                    {
                        visited[x + 1, y] = true;
                        queue.Enqueue((x + 1, y, count + 1));
                    }

                    if (y < N - 1 && !visited[x, y + 1] && tomatos[x, y + 1] == 0)
                    {
                        visited[x, y + 1] = true;
                        queue.Enqueue((x, y + 1, count + 1));
                    }

                    max = Math.Max(count, max);
                }

                for (int n = 0; n < N; n++)
                {
                    for (int m = 0; m < M; m++)
                    {
                        if (!visited[m, n])
                        {
                            if (tomatos[m, n] != -1)
                                return -1;
                        }
                    }
                }
                return max;
            }
        }
    }
}

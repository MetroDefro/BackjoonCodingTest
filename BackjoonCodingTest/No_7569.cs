using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_7569
    {
        public No_7569()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int M = int.Parse(inputs[0]);
            int N = int.Parse(inputs[1]);
            int H = int.Parse(inputs[2]);
            int[,,] tomatos = new int[M, N, H];
            for (int h = 0; h < H; h++)
            {
                for (int n = 0; n < N; n++)
                {
                    inputs = reader.ReadLine().Split();
                    for (int m = 0; m < M; m++)
                    {
                        tomatos[m, n, h] = int.Parse(inputs[m]);
                    }
                }
            }

            print.WriteLine(BFS());

            reader.Close();
            print.Close();

            int BFS()
            {
                bool[,,] visited = new bool[M, N, H];

                Queue<(int x, int y, int h, int count)> queue = new Queue<(int x, int y, int h, int count)>();

                for (int h = 0; h < H; h++)
                {
                    for (int n = 0; n < N; n++)
                    {
                        for (int m = 0; m < M; m++)
                        {
                            if (tomatos[m, n, h] == 1)
                            {
                                visited[m, n, h] = true;
                                queue.Enqueue((m, n, h, 0));
                            }
                        }
                    }
                }

                int max = 0;
                while (queue.Count > 0)
                {
                    (int x, int y, int h, int count) = queue.Dequeue();

                    if (x > 0 && !visited[x - 1, y, h] && tomatos[x - 1, y, h] == 0)
                    {
                        visited[x - 1, y, h] = true;
                        queue.Enqueue((x - 1, y, h, count + 1));
                    }

                    if (y > 0 && !visited[x, y - 1, h] && tomatos[x, y - 1, h] == 0)
                    {
                        visited[x, y - 1, h] = true;
                        queue.Enqueue((x, y - 1, h, count + 1));
                    }

                    if (h > 0 && !visited[x, y, h - 1] && tomatos[x, y, h - 1] == 0)
                    {
                        visited[x, y, h - 1] = true;
                        queue.Enqueue((x, y, h - 1, count + 1));
                    }

                    if (x < M - 1 && !visited[x + 1, y, h] && tomatos[x + 1, y, h] == 0)
                    {
                        visited[x + 1, y, h] = true;
                        queue.Enqueue((x + 1, y, h, count + 1));
                    }

                    if (y < N - 1 && !visited[x, y + 1, h] && tomatos[x, y + 1, h] == 0)
                    {
                        visited[x, y + 1, h] = true;
                        queue.Enqueue((x, y + 1, h, count + 1));
                    }

                    if (h < H - 1 && !visited[x, y, h + 1] && tomatos[x, y, h + 1] == 0)
                    {
                        visited[x, y, h + 1] = true;
                        queue.Enqueue((x, y, h + 1, count + 1));
                    }

                    max = Math.Max(count, max);
                }

                for (int h = 0; h < H; h++)
                {
                    for (int n = 0; n < N; n++)
                    {
                        for (int m = 0; m < M; m++)
                        {
                            if (!visited[m, n, h])
                            {
                                if (tomatos[m, n, h] != -1)
                                    return -1;
                            }
                        }
                    }
                }
                return max;
            }
        }
    }
}

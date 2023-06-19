using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_2178
    {
        public No_2178()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            int[,] maze = new int[M, N];
            for (int i = 0; i < N; i++)
            {
                string input = reader.ReadLine();
                for (int j = 0; j < M; j++)
                {
                    maze[j, i] = input[j] - '0';
                }
            }

            BFS();

            void BFS()
            {
                bool[,] visited = new bool[M, N];
                Queue<(int x, int y)> queue = new Queue<(int x, int y)>();
                Dictionary<(int x, int y), int> dp = new Dictionary<(int x, int y), int>();

                queue.Enqueue((0, 0));
                dp.Add((0, 0), 0);
                visited[0, 0] = true;

                while (queue.Count > 0)
                {
                    (int x, int y) = queue.Dequeue();

                    if (x == M - 1 && y == N - 1)
                    {
                        print.WriteLine(dp[(x, y)] + 1);
                        return;
                    }

                    if (x + 1 < M && maze[x + 1, y] == 1 && !visited[x + 1, y])
                    {
                        visited[x + 1, y] = true;
                        queue.Enqueue((x + 1, y));
                        dp.Add((x + 1, y), dp[(x, y)] + 1);
                    }
                    if (y + 1 < N && maze[x, y + 1] == 1 && !visited[x, y + 1])
                    {
                        visited[x, y + 1] = true;
                        queue.Enqueue((x, y + 1));
                        dp.Add((x, y + 1), dp[(x, y)] + 1);
                    }
                    if (x > 0 && maze[x - 1, y] == 1 && !visited[x - 1, y])
                    {
                        visited[x - 1, y] = true;
                        queue.Enqueue((x - 1, y));
                        dp.Add((x - 1, y), dp[(x, y)] + 1);
                    }
                    if (y > 0 && maze[x, y - 1] == 1 && !visited[x, y - 1])
                    {
                        visited[x, y - 1] = true;
                        queue.Enqueue((x, y - 1));
                        dp.Add((x, y - 1), dp[(x, y)] + 1);
                    }
                }
            }
        }
    }
}

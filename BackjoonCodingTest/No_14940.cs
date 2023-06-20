using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_14940
    {
        public No_14940()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);

            int[,] map = new int[n, m];
            int startY = 0;
            int startX = 0;
            for (int i = 0; i < n; i++)
            {
                inputs = reader.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    map[i, j] = int.Parse(inputs[j]);

                    if (map[i, j] == 2)
                    {
                        startY = i;
                        startX = j;
                    }
                }
            }

            int[,] countMap = new int[n, m];
            BFS();


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (countMap[i, j] == 0 && map[i, j] == 1)
                        print.Write("-1 ");
                    else
                        print.Write(countMap[i, j] + " ");
                }
                print.WriteLine();
            }


            void BFS()
            {
                bool[,] visited = new bool[n, m];
                Queue<(int y, int x, int count)> queue = new Queue<(int, int, int)>();

                queue.Enqueue((startY, startX, 0));
                visited[startY, startX] = true;

                while (queue.Count > 0)
                {
                    (int y, int x, int count) = queue.Dequeue();
                    countMap[y, x] = count;

                    if (x > 0 && !visited[y, x - 1] && map[y, x - 1] == 1)
                    {
                        queue.Enqueue((y, x - 1, count + 1));
                        visited[y, x - 1] = true;
                    }
                    if (y > 0 && !visited[y - 1, x] && map[y - 1, x] == 1)
                    {
                        queue.Enqueue((y - 1, x, count + 1));
                        visited[y - 1, x] = true;
                    }
                    if (x < m - 1 && !visited[y, x + 1] && map[y, x + 1] == 1)
                    {
                        queue.Enqueue((y, x + 1, count + 1));
                        visited[y, x + 1] = true;
                    }
                    if (y < n - 1 && !visited[y + 1, x] && map[y + 1, x] == 1)
                    {
                        queue.Enqueue((y + 1, x, count + 1));
                        visited[y + 1, x] = true;
                    }
                }
            }
        }
    }
}

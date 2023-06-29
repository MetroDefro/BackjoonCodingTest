using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_1926
    {
        public No_1926()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);

            int[,] pictures = new int[m, n];

            for (int i = 0; i < n; i++)
            {
                inputs = reader.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    pictures[j, i] = int.Parse(inputs[j]);
                }
            }

            bool[,] visited = new bool[m, n];

            int max = 0;
            int pictureCount = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (!visited[i, j])
                    {
                        if (pictures[i, j] == 1)
                        {
                            pictureCount++;
                            max = Math.Max(BFS(i, j), max);
                        }
                    }
                }
            }

            print.WriteLine(pictureCount);
            print.WriteLine(max);

            int BFS(int startX, int startY)
            {
                int[] addX = { -1, 1, 0, 0 };
                int[] addY = { 0, 0, -1, 1 };

                Queue<(int x, int y)> queue = new Queue<(int x, int y)>();
                int count = 1;
                queue.Enqueue((startX, startY));
                visited[startX, startY] = true;

                while (queue.Count > 0)
                {
                    (int x, int y) = queue.Dequeue();
                    for (int i = 0; i < 4; i++)
                    {
                        if (x + addX[i] < m && x + addX[i] >= 0
                            && y + addY[i] < n && y + addY[i] >= 0)
                        {
                            if (!visited[x + addX[i], y + addY[i]])
                            {
                                if (pictures[x + addX[i], y + addY[i]] == 1)
                                {
                                    count++;
                                    queue.Enqueue((x + addX[i], y + addY[i]));
                                    visited[x + addX[i], y + addY[i]] = true;
                                }
                            }
                        }
                    }
                }

                return count;
            }

            reader.Close();
            print.Close();
        }
    }
}

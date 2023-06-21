using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_7562
    {
        public No_7562()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int T = int.Parse(reader.ReadLine());

            for (int testCase = 0; testCase < T; testCase++)
            {
                int I = int.Parse(reader.ReadLine());

                string[] inputs = reader.ReadLine().Split();
                int startX = int.Parse(inputs[0]);
                int startY = int.Parse(inputs[1]);

                inputs = reader.ReadLine().Split();
                int endX = int.Parse(inputs[0]);
                int endY = int.Parse(inputs[1]);

                print.WriteLine(BFS(I, startX, startY, endX, endY));
            }

            reader.Close();
            print.Close();

            long BFS(int l, int startX, int startY, int endX, int endY)
            {
                Queue<(int x, int y, int count)> queue = new Queue<(int, int, int)>();
                bool[,] visited = new bool[l, l];
                visited[startX, startY] = true;
                queue.Enqueue((startX, startY, 0));

                int[] addedX = { -1, -1, -2, -2, +1, +1, +2, +2 };
                int[] addedY = { -2, +2, -1, +1, -2, +2, -1, +1 };
                long min = long.MaxValue;
                while (queue.Count > 0)
                {
                    (int x, int y, int count) = queue.Dequeue();

                    if (x == endX && y == endY)
                    {
                        min = Math.Min(count, min);
                    }

                    for (int i = 0; i < 8; i++)
                    {
                        if (x + addedX[i] > -1 && x + addedX[i] < l &&
                            y + addedY[i] > -1 && y + addedY[i] < l &&
                            !visited[x + addedX[i], y + addedY[i]])
                        {
                            visited[x + addedX[i], y + addedY[i]] = true;
                            queue.Enqueue((x + addedX[i], y + addedY[i], count + 1));
                        }
                    }
                }

                return min;
            }
        }
    }
}

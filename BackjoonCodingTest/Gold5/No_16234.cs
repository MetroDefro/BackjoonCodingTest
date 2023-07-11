using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Gold5
{
    public class No_16234
    {
        public No_16234()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int N = int.Parse(inputs[0]);
            int L = int.Parse(inputs[1]);
            int R = int.Parse(inputs[2]);

            int[,] A = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                inputs = reader.ReadLine().Split();
                for (int j = 0; j < N; j++)
                {
                    A[j, i] = int.Parse(inputs[j]);
                }
            }

            int[] addX = { -1, 1, 0, 0 };
            int[] addY = { 0, 0, -1, 1 };

            int days = 0;
            while (true)
            {
                bool[,] visited = new bool[N, N];
                bool allVisited = true;
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (!visited[i, j])
                        {
                            if (!BFS(i, j))
                            {
                                allVisited = false;
                            }
                        }
                    }
                }

                if (allVisited)
                    break;

                days++;

                bool BFS(int startX, int startY)
                {
                    Queue<(int x, int y)> queue = new Queue<(int, int)>();
                    queue.Enqueue((startX, startY));
                    visited[startX, startY] = true;

                    List<(int x, int y)> list = new List<(int x, int y)>();
                    int sum = 0;
                    while (queue.Count > 0)
                    {
                        (int x, int y) = queue.Dequeue();
                        list.Add((x, y));
                        sum += A[x, y];

                        for (int i = 0; i < 4; i++)
                        {
                            if (x + addX[i] >= 0 && x + addX[i] < N && y + addY[i] >= 0 && y + addY[i] < N && !visited[x + addX[i], y + addY[i]])
                            {
                                if (Math.Abs(A[x + addX[i], y + addY[i]] - A[x, y]) >= L && Math.Abs(A[x + addX[i], y + addY[i]] - A[x, y]) <= R)
                                {
                                    queue.Enqueue((x + addX[i], y + addY[i]));
                                    visited[x + addX[i], y + addY[i]] = true;
                                }
                            }
                        }
                    }

                    int count = list.Count;
                    int avg = sum / count;
                    for (int i = 0; i < count; i++)
                    {
                        (int x, int y) = list[i];
                        A[x, y] = avg;
                    }

                    if (count == 1)
                        return true;
                    else
                        return false;
                }
            }

            print.WriteLine(days);

            reader.Close();
            print.Close();
        }
    }
}

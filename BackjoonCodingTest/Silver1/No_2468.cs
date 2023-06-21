using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_2468
    {
        public No_2468()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());
            int[,] heights = new int[N, N];

            int maxHeight = 0;
            int minHeight = 0;
            for (int i = 0; i < N; i++)
            {
                string[] inputs = reader.ReadLine().Split();
                for (int j = 0; j < N; j++)
                {
                    heights[j, i] = int.Parse(inputs[j]);

                    maxHeight = Math.Max(heights[j, i], maxHeight);
                }
            }

            int max = 0;
            for (int h = minHeight; h <= maxHeight; h++)
            {
                int count = 0;
                bool[,] visited = new bool[N, N];
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (!visited[j, i] && heights[j, i] > h)
                        {
                            visited[j, i] = true;
                            DFS(visited, j, i, h);
                            count++;
                        }
                    }
                }

                max = Math.Max(max, count);
            }

            print.WriteLine(max);

            reader.Close();
            print.Close();

            void DFS(bool[,] visited, int x, int y, int height)
            {
                if (x > 0 && !visited[x - 1, y] && heights[x - 1, y] > height)
                {
                    visited[x - 1, y] = true;
                    DFS(visited, x - 1, y, height);
                }

                if (y > 0 && !visited[x, y - 1] && heights[x, y - 1] > height)
                {
                    visited[x, y - 1] = true;
                    DFS(visited, x, y - 1, height);
                }

                if (x < N - 1 && !visited[x + 1, y] && heights[x + 1, y] > height)
                {
                    visited[x + 1, y] = true;
                    DFS(visited, x + 1, y, height);
                }

                if (y < N - 1 && !visited[x, y + 1] && heights[x, y + 1] > height)
                {
                    visited[x, y + 1] = true;
                    DFS(visited, x, y + 1, height);
                }
            }
        }
    }
}

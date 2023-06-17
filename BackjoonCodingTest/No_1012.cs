using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_1012
    {
        public No_1012()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();

            int T = int.Parse(inputs[0]);

            for (int t = 0; t < T; t++)
            {
                inputs = reader.ReadLine().Split();

                int M = int.Parse(inputs[0]);
                int N = int.Parse(inputs[1]);
                int K = int.Parse(inputs[2]);

                bool[,] field = new bool[M, N];

                for (int i = 0; i < K; i++)
                {
                    inputs = reader.ReadLine().Split();
                    field[int.Parse(inputs[0]), int.Parse(inputs[1])] = true;
                }

                bool[,] visited = new bool[M, N];


                int count = 0;
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        if (field[j, i])
                        {
                            if (!visited[j, i])
                            {
                                DFS(j, i);
                                count++;
                            }
                        }
                    }
                }

                print.WriteLine(count);

                void DFS(int width, int height)
                {
                    if (!visited[width, height])
                    {
                        visited[width, height] = true;

                        if (width - 1 >= 0)
                        {
                            if (field[width - 1, height])
                                DFS(width - 1, height);
                        }
                        if (height - 1 >= 0)
                        {
                            if (field[width, height - 1])
                                DFS(width, height - 1);
                        }
                        if (width + 1 < M)
                        {
                            if (field[width + 1, height])
                                DFS(width + 1, height);
                        }
                        if (height + 1 < N)
                        {
                            if (field[width, height + 1])
                                DFS(width, height + 1);
                        }
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_11403
    {
        public No_11403()
        {
            static void Main(string[] args)
            {
                using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
                using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

                int N = int.Parse(reader.ReadLine());
                int[,] metrix = new int[N, N];
                for (int i = 0; i < N; i++)
                {
                    string[] inputs = reader.ReadLine().Split();
                    for (int j = 0; j < N; j++)
                    {
                        metrix[i, j] = int.Parse(inputs[j]);
                    }
                }

                for (int i = 0; i < N; i++)
                {
                    bool[] visited = new bool[N];
                    for (int k = 0; k < N; k++)
                    {
                        if (metrix[i, k] == 1)
                        {
                            DFS(visited, i, k, N);
                        }
                    }
                }

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        print.Write(metrix[i, j] + " ");
                    }
                    print.WriteLine();
                }

                void DFS(bool[] visited, int id, int index, int N)
                {
                    if (!visited[index])
                    {
                        visited[index] = true;
                        metrix[id, index] = 1;
                        for (int i = 0; i < N; i++)
                        {
                            if (metrix[index, i] == 1)
                            {
                                DFS(visited, id, i, N);
                            }
                        }
                    }
                }
            }
        }
    }
}

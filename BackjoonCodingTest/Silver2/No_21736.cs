using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver2
{
    public class No_21736
    {
        private static int count = 0;
        public No_21736()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            char[,] school = new char[N, M];
            int x = 0;
            int y = 0;
            for (int i = 0; i < N; i++)
            {
                string input = reader.ReadLine();
                for (int j = 0; j < M; j++)
                {
                    school[i, j] = input[j];

                    if (school[i, j] == 'I')
                    {
                        x = j;
                        y = i;
                    }
                }
            }

            bool[,] visited = new bool[N, M];

            DFS(visited, school, y, x, N, M);

            if (count == 0)
                print.WriteLine("TT");
            else
                print.WriteLine(count);
        }

        private static void DFS(bool[,] visited, char[,] list, int y, int x, int N, int M)
        {
            if (!visited[y, x])
            {
                visited[y, x] = true;

                if (list[y, x] == 'X')
                    return;
                else if (list[y, x] == 'P')
                    count++;

                if (y > 0)
                    DFS(visited, list, y - 1, x, N, M);
                if (x > 0)
                    DFS(visited, list, y, x - 1, N, M);
                if (y < N - 1)
                    DFS(visited, list, y + 1, x, N, M);
                if (x < M - 1)
                    DFS(visited, list, y, x + 1, N, M);
            }
        }
    }
}

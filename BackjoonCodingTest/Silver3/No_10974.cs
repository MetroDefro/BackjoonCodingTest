using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver3
{
    public class No_10974
    {
        public No_10974()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int n = int.Parse(input.Split()[0]);

            int[] list = new int[n];
            bool[] visited = new bool[n + 1];
            DFS(0);

            void DFS(int depth)
            {
                if (depth == n)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    for (int i = 0; i < n; i++)
                        stringBuilder.Append(list[i] + " ");
                    print.WriteLine(stringBuilder.ToString());

                    return;
                }
                for (int i = 1; i <= n; i++)
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        list[depth] = i;

                        DFS(depth + 1);

                        visited[i] = false;
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver3
{
    public class No_15651
    {
        public No_15651()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int n = int.Parse(input.Split()[0]);
            int m = int.Parse(input.Split()[1]);

            int[] list = new int[m];
            DFS(0, 0);

            void DFS(int depth, int prev)
            {
                if (depth == m)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    for (int i = 0; i < m; i++)
                        stringBuilder.Append(list[i] + " ");
                    print.WriteLine(stringBuilder.ToString());

                    return;
                }
                for (int i = 1; i <= n; i++)
                {
                    list[depth] = i;

                    DFS(depth + 1, i);
                }
            }
        }
    }
}

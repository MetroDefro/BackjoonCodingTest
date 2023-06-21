using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_1992
    {
        public No_1992()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());

            int[,] colors = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                string input = reader.ReadLine();
                for (int j = 0; j < N; j++)
                {
                    colors[j, i] = input[j] - '0';
                }
            }

            StringBuilder stringBuilder = new StringBuilder();
            Divide(N, 0, 0);

            print.WriteLine(stringBuilder.ToString());

            reader.Close();
            print.Close();

            void Divide(int n, int x, int y)
            {
                if (n == 1)
                {
                    stringBuilder.Append(colors[x, y]);
                    return;
                }

                int[] count = new int[2];
                for (int i = x; i < x + n; i++)
                {
                    for (int j = y; j < y + n; j++)
                    {
                        if (colors[i, j] == 0)
                            count[0]++;
                        else
                            count[1]++;
                    }
                }

                if (count[0] == n * n || count[1] == n * n)
                {
                    stringBuilder.Append(colors[x, y]);
                    return;
                }

                int half = n / 2;

                stringBuilder.Append("(");

                Divide(half, x, y);
                Divide(half, x + half, y);
                Divide(half, x, y + half);
                Divide(half, x + half, y + half);

                stringBuilder.Append(")");
            }
        }
    }
}

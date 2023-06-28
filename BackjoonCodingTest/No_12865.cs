using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_12865
    {
        public No_12865()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int N = int.Parse(inputs[0]);
            int K = int.Parse(inputs[1]);

            (int W, int V)[] items = new (int, int)[N];
            for (int i = 0; i < N; i++)
            {
                inputs = reader.ReadLine().Split();
                items[i] = (int.Parse(inputs[0]), int.Parse(inputs[1]));
            }

            int[,] dp = new int[N, K + 1];

            for (int i = 0; i < N; i++)
            {
                for (int j = 1; j <= K; j++)
                {
                    if (i == 0)
                    {
                        if (items[i].W <= j)
                            dp[i, j] = items[i].V;
                        else
                            dp[i, j] = 0;
                    }
                    else
                    {
                        if (items[i].W <= j)
                            dp[i, j] = Math.Max(dp[i - 1, j - items[i].W] + items[i].V, dp[i - 1, j]);
                        else
                            dp[i, j] = dp[i - 1, j];
                    }
                }
            }

            print.WriteLine(dp[N - 1, K]);

            reader.Close();
            print.Close();
        }
    }
}

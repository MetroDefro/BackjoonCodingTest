using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_9465
    {
        public No_9465()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int T = int.Parse(reader.ReadLine());

            for (int testCase = 0; testCase < T; testCase++)
            {
                int n = int.Parse(reader.ReadLine());

                int[,] stickers = new int[2, n];
                for (int i = 0; i < 2; i++)
                {
                    string[] inputs = reader.ReadLine().Split();
                    for (int j = 0; j < n; j++)
                    {
                        stickers[i, j] = int.Parse(inputs[j]);
                    }
                }

                if (n == 1)
                {
                    print.WriteLine(Math.Max(stickers[0, 0], stickers[1, 0]));
                    continue;
                }

                int[,] dp = new int[2, n];
                dp[0, 0] = stickers[0, 0];
                dp[1, 0] = stickers[1, 0];
                dp[0, 1] = dp[1, 0] + stickers[0, 1];
                dp[1, 1] = dp[0, 0] + stickers[1, 1];

                for (int i = 2; i < n; i++)
                {
                    dp[0, i] = Math.Max(dp[1, i - 1] + stickers[0, i], dp[1, i - 2] + stickers[0, i]);
                    dp[1, i] = Math.Max(dp[0, i - 1] + stickers[1, i], dp[0, i - 2] + stickers[1, i]);
                }

                print.WriteLine(Math.Max(dp[0, n - 1], dp[1, n - 1]));
            }
        }
    }
}
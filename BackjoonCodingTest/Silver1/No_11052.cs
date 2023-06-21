using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_11052
    {
        public No_11052()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());
            int[] price = new int[N + 1];
            string[] inputs = reader.ReadLine().Split();
            for (int i = 0; i < N; i++)
            {
                price[i + 1] = int.Parse(inputs[i]);
            }

            if (N == 1)
            {
                print.WriteLine(price[1]);
                return;
            }

            int[] dp = new int[N + 1];
            dp[1] = price[1];
            dp[2] = Math.Max(dp[1] * 2, price[2]);

            for (int i = 2; i <= N; i++)
            {
                int max = price[i];
                if ((i & 1) == 0)
                    max = Math.Max(max, (dp[((i - 1) / 2) + 1]) * 2);

                for (int j = 1; j <= (i - 1) / 2; j++)
                {
                    max = Math.Max(max, dp[j] + dp[i - j]);
                }

                dp[i] = max;
            }

            print.WriteLine(dp[N]);

            reader.Close();
            print.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver3
{
    public class No_14501
    {
        public No_14501()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(reader.ReadLine());

            int[] T = new int[n + 1];
            int[] P = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                string input = reader.ReadLine();
                T[i] = int.Parse(input.Split()[0]);
                P[i] = int.Parse(input.Split()[1]);
            }

            int[] dp = new int[n + 2];

            for (int i = n; i > 0; i--)
            {
                if (i + T[i] - 1 > n)
                {
                    dp[i] = dp[i + 1];
                }
                else
                {
                    dp[i] = Math.Max(dp[i + 1], dp[i + T[i]] + P[i]);
                }
            }

            print.WriteLine(dp[1]);
        }
    }
}

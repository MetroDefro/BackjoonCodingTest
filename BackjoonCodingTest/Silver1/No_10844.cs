using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_10844
    {
        public No_10844()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(reader.ReadLine());

            long[,] dp = new long[10, 101];

            for (int i = 1; i < 10; i++)
            {
                dp[i, 1] = 1;
            }

            if (n == 1)
            {
                print.WriteLine(9);
                return;
            }

            for (int i = 2; i <= n; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (j == 0)
                        dp[j, i] = dp[j + 1, i - 1];
                    else if (j == 9)
                        dp[j, i] = dp[j - 1, i - 1];
                    else
                        dp[j, i] = (dp[j - 1, i - 1] + dp[j + 1, i - 1]) % 1000000000;
                }
            }

            long sum = 0;
            for (int i = 0; i <= 9; i++)
            {
                sum = (sum + dp[i, n]) % 1000000000;
            }

            print.WriteLine(sum);
        }
    }
}

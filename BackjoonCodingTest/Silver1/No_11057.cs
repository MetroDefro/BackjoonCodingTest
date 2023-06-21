using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_11057
    {
        public No_11057()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(reader.ReadLine());

            long[,] dp = new long[10, 1001];

            for (int i = 0; i < 10; i++)
            {
                dp[i, 1] = 1;
            }

            if (n == 1)
            {
                print.WriteLine(10);
                return;
            }

            for (int i = 2; i <= n; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (j == 0)
                        dp[j, i] = dp[j, i - 1];
                    else
                    {
                        for (int k = 0; k <= j; k++)
                        {
                            dp[j, i] = (dp[j, i] + dp[k, i - 1]) % 10007;
                        }
                    }
                }
            }

            long sum = 0;
            for (int i = 0; i <= 9; i++)
            {
                sum = (sum + dp[i, n]) % 10007;
            }

            print.WriteLine(sum);

            reader.Close();
            print.Close();
        }
    }
}

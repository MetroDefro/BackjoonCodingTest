using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_2156
    {
        public No_2156()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(reader.ReadLine());
            int[] wine = new int[n];
            for (int i = 0; i < n; i++)
            {
                wine[i] = int.Parse(reader.ReadLine());
            }

            int[] dp = new int[n];
            dp[0] = wine[0];
            if (n == 1)
            {
                print.WriteLine(dp[0]);
                return;
            }

            dp[1] = wine[0] + wine[1];
            if (n == 2)
            {
                print.WriteLine(dp[1]);
                return;
            }

            dp[2] = Math.Max(wine[1] + wine[2], Math.Max(wine[0] + wine[2], dp[1]));
            for (int i = 3; i < n; i++)
            {
                dp[i] = Math.Max(dp[i - 3] + wine[i - 1] + wine[i], Math.Max(dp[i - 2] + wine[i], dp[i - 1]));
            }

            print.WriteLine(dp[n - 1]);
        }
    }
}

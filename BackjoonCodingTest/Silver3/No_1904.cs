using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver3
{
    public class No_1904
    {
        public No_1904()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(reader.ReadLine());

            int[] dp = new int[1000001];
            dp[1] = 1;
            dp[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                dp[i] = (dp[i - 1] + dp[i - 2]) % 15746;
            }

            print.WriteLine(dp[n]);
        }
    }
}

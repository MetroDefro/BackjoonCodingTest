using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver3
{
    public class No_17626
    {
        public No_17626()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(reader.ReadLine());

            int[] dp = new int[50001];
            dp[0] = 0;

            int[] sqrs = new int[501];
            sqrs[0] = 0;

            int index = 0;
            while (sqrs[index] <= n)
            {
                index++;
                sqrs[index] = index * index;
            }


            for (int i = 1; i <= n; i++)
            {
                int max = 4;

                for (int j = 1; sqrs[j] <= i; j++)
                {
                    int dpNum = i - sqrs[j];
                    if (dp[dpNum] + 1 < max)
                    {
                        max = dp[dpNum] + 1;
                    }
                }

                dp[i] = max;
            }

            print.WriteLine(dp[n]);
        }
    }
}

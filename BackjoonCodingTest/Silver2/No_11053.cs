using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver2
{
    public class No_11053
    {
        public No_11053()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());
            string[] inputs = reader.ReadLine().Split();

            int[] nums = new int[N];
            for (int i = 0; i < N; i++)
            {
                nums[i] = int.Parse(inputs[i]);
            }

            int[] dp = new int[N];
            dp[0] = 1;
            int max = 1;
            for (int i = 0; i < N; i++)
            {
                dp[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        dp[i] = Math.Max(dp[j] + 1, dp[i]);
                    }
                }

                if (dp[i] > max)
                    max = dp[i];
            }

            print.WriteLine(max);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_1912
    {
        public No_1912()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(reader.ReadLine());
            string[] inputs = reader.ReadLine().Split();
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(inputs[i]);
            }

            int[] dp = new int[n];
            dp[0] = nums[0];

            int max = dp[0];
            for (int i = 1; i < n; i++)
            {
                dp[i] = Math.Max(nums[i] + dp[i - 1], nums[i]);

                max = Math.Max(max, dp[i]);
            }

            print.WriteLine(max);

            reader.Close();
            print.Close();
        }
    }
}

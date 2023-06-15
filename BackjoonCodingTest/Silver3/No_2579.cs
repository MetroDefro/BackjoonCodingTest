using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver3
{
    public class No_2579
    {
        public No_2579()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(reader.ReadLine());
            int[] floors = new int[301];

            for (int i = 0; i < n; i++)
            {
                floors[i] = int.Parse(reader.ReadLine());
            }

            int[] dp = new int[301];
            dp[0] = floors[0];
            dp[1] = floors[0] + floors[1];
            dp[2] = Math.Max(floors[0] + floors[2], floors[1] + floors[2]);
            for (int i = 3; i < floors.Length; i++)
            {
                dp[i] = Math.Max(dp[i - 3] + floors[i - 1] + floors[i], dp[i - 2] + floors[i]);
            }

            print.WriteLine(dp[n - 1]);
        }
    }
}

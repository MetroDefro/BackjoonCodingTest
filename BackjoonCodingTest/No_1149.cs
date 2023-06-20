using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_1149
    {
        public No_1149()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());

            (int red, int green, int blue)[] colorPrices = new (int red, int green, int blue)[N];

            for (int i = 0; i < N; i++)
            {
                string[] inputs = reader.ReadLine().Split();

                colorPrices[i] = (int.Parse(inputs[0]), int.Parse(inputs[1]), int.Parse(inputs[2]));
            }

            int[,] dp = new int[N, 3];
            dp[0, 0] = colorPrices[0].red;
            dp[0, 1] = colorPrices[0].green;
            dp[0, 2] = colorPrices[0].blue;

            for (int i = 1; i < N; i++)
            {
                dp[i, 0] = Math.Min(dp[i - 1, 1], dp[i - 1, 2]) + colorPrices[i].red;
                dp[i, 1] = Math.Min(dp[i - 1, 0], dp[i - 1, 2]) + colorPrices[i].green;
                dp[i, 2] = Math.Min(dp[i - 1, 0], dp[i - 1, 1]) + colorPrices[i].blue;
            }

            print.WriteLine(Math.Min(dp[N - 1, 0], Math.Min(dp[N - 1, 1], dp[N - 1, 2])));
        }
    }
}

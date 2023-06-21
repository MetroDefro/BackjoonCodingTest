using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_1932
    {
        public No_1932()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(reader.ReadLine());

            int[,] triangle = new int[n, n];

            int width = 0;
            for (int i = 0; i < n; i++)
            {
                width++;
                string[] inputs = reader.ReadLine().Split();
                for (int j = 0; j < width; j++)
                {
                    triangle[i, j] = int.Parse(inputs[j]);
                }
            }

            int[,] dp = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                dp[n - 1, i] = triangle[n - 1, i];
            }

            width = n;
            for (int i = n - 2; i >= 0; i--)
            {
                width--;
                for (int j = 0; j < width; j++)
                {
                    dp[i, j] = triangle[i, j] + Math.Max(dp[i + 1, j], dp[i + 1, j + 1]);
                }
            }

            print.WriteLine(dp[0, 0]);
        }
    }
}

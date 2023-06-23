using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_1890
    {
        public No_1890()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());
            int[,] plate = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                string[] inputs = reader.ReadLine().Split();
                for (int j = 0; j < N; j++)
                {
                    plate[j, i] = int.Parse(inputs[j]);
                }
            }

            long[,] dp = new long[N, N];
            dp[0, 0] = 1;

            for (int y = 0; y < N; y++)
            {
                for (int x = 0; x < N; x++)
                {
                    if (plate[x, y] == 0)
                        continue;

                    int addNum = plate[x, y];
                    if (x + addNum < N)
                        dp[x + addNum, y] += dp[x, y];
                    if (y + addNum < N)
                        dp[x, y + addNum] += dp[x, y];
                }
            }

            print.WriteLine(dp[N - 1, N - 1]);

            reader.Close();
            print.Close();
        }
    }
}

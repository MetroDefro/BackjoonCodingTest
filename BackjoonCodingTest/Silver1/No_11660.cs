using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_11660
    {
        public No_11660()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            int[,] nums = new int[N, N];
            int[,] sums = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                inputs = reader.ReadLine().Split();
                for (int j = 0; j < N; j++)
                {
                    nums[i, j] = int.Parse(inputs[j]);
                }
            }

            sums[0, 0] = nums[0, 0];
            for (int i = 1; i < N; i++)
            {
                sums[i, 0] = sums[i - 1, 0] + nums[i, 0];
            }
            for (int i = 1; i < N; i++)
            {
                sums[0, i] = sums[0, i - 1] + nums[0, i];
            }

            for (int i = 1; i < N; i++)
            {
                for (int j = 1; j < N; j++)
                {
                    int sum = sums[i - 1, j - 1] + nums[i, j];
                    for (int k = 0; k < i; k++)
                    {
                        sum += nums[k, j];
                    }
                    for (int k = 0; k < j; k++)
                    {
                        sum += nums[i, k];
                    }

                    sums[i, j] = sum;
                }
            }

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < M; i++)
            {
                inputs = reader.ReadLine().Split();
                int x1 = int.Parse(inputs[0]);
                int y1 = int.Parse(inputs[1]);
                int x2 = int.Parse(inputs[2]);
                int y2 = int.Parse(inputs[3]);

                int result = 0;
                if (x1 == 1 && y1 == 1)
                {
                    result = sums[x2 - 1, y2 - 1];
                }
                else if (x1 == 1)
                {
                    int total = sums[x2 - 1, y2 - 1];
                    int width = sums[x2 - 1, y1 - 2];

                    result = total - width;
                }
                else if (y1 == 1)
                {
                    int total = sums[x2 - 1, y2 - 1];
                    int height = sums[x1 - 2, y2 - 1];

                    result = total - height;
                }
                else
                {
                    int total = sums[x2 - 1, y2 - 1];
                    int height = sums[x1 - 2, y2 - 1];
                    int width = sums[x2 - 1, y1 - 2];
                    int overlap = sums[x1 - 2, y1 - 2];

                    result = total - (height + width - overlap);
                }

                stringBuilder.AppendLine(result.ToString());
            }
            print.WriteLine(stringBuilder.ToString());
        }
    }
}

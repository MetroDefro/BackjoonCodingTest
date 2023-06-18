using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver2
{
    public class No_18111
    {
        public No_18111()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();

            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            int B = int.Parse(inputs[2]);

            int[] heights = new int[256 + 1];
            int min = 256;
            int max = 0;
            for (int i = 0; i < N; i++)
            {
                inputs = reader.ReadLine().Split();
                for (int j = 0; j < M; j++)
                {
                    int temp = int.Parse(inputs[j]);

                    if (min > temp)
                        min = temp;

                    if (max < temp)
                        max = temp;

                    heights[temp]++;
                }
            }

            int minCount = 128000000;
            int maxIndex = 0;
            for (int i = min; i <= max; i++)
            {
                int upCount = 0;
                int downCount = 0;
                int inven = B;
                for (int j = max; j >= min; j--)
                {
                    if (i > j)
                    {
                        upCount += heights[j] * (i - j);
                        if (upCount > inven)
                        {
                            upCount = -1;
                            break;
                        }

                    }
                    else if (i < j)
                    {
                        int temp = heights[j] * (j - i);
                        inven += temp;
                        downCount += temp * 2;
                    }

                }

                if (upCount == -1)
                    continue;

                if (minCount >= upCount + downCount)
                {
                    minCount = upCount + downCount;
                    maxIndex = i;
                }
            }

            print.WriteLine(minCount + " " + maxIndex);
        }
    }
}

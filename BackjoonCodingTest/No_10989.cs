using System;

namespace BackjoonCodingTest
{
    public class No_10989
    {
        public No_10989()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());
            string input = reader.ReadLine();
            int maxCount = int.Parse(input);

            int[] nums = new int[10001];
            for (int i = 0; i < maxCount; i++)
            {
                nums[short.Parse(reader.ReadLine())]++;
            }

            for (int i = 0; i < 10001; i++)
            {
                if (nums[i] != 0)
                {
                    int curNum = nums[i];
                    for (int j = 0; j < curNum; j++)
                        print.WriteLine(i);
                }
            }
        }
    }
}

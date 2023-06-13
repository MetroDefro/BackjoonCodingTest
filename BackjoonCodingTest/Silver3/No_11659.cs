using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_11659
    {
        public No_11659()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int N = int.Parse(input.Split()[0]);
            int M = int.Parse(input.Split()[1]);

            input = reader.ReadLine();
            string[] inputs = input.Split();
            int[] nums = new int[N];
            int[] sums = new int[N];
            for (int i = 0; i < N; i++)
            {
                nums[i] = int.Parse(inputs[i]);
            }

            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += nums[i];
                sums[i] = sum;
            }

            for (int i = 0; i < M; i++)
            {
                input = reader.ReadLine();
                int start = int.Parse(input.Split()[0]) - 2;
                int end = int.Parse(input.Split()[1]) - 1;

                if (start < 0)
                    print.WriteLine(sums[end]);
                else
                    print.WriteLine(sums[end] - sums[start]);
            }
        }
    }
}

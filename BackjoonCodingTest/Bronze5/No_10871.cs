using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze5
{
    public class No_10871
    {
        public No_10871()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            short N = short.Parse(input.Split()[0]);
            short X = short.Parse(input.Split()[1]);
            input = reader.ReadLine();

            string[] nums = input.Split();

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                if (int.Parse(nums[i]) < X)
                {
                    stringBuilder.Append(nums[i]);
                    stringBuilder.Append(" ");
                }

                if (N % 10 == 0)
                {
                    print.Write(stringBuilder.ToString());
                    stringBuilder.Clear();
                }
            }

            print.Write(stringBuilder.ToString());
        }
    }
}

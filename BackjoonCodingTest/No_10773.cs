using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_10773
    {
        public No_10773()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int K = int.Parse(input);
            int sum = 0;

            int[] nums = new int[K];

            for (int i = 0; i < K; i++)
            {
                input = reader.ReadLine();
                nums[i] = int.Parse(input);
                if (nums[i] == 0)
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (nums[j] != 0)
                        {
                            sum -= nums[j];
                            nums[j] = 0;
                            break;
                        }
                    }
                }
                else
                {
                    sum += nums[i];
                }
            }

            print.WriteLine(sum);
        }
    }
}

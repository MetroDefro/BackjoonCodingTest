using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_1463
    {
        public No_1463()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());

            int[] nums = new int[N + 1];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != 0 || i < 2)
                    continue;

                if (i % 6 == 0)
                {
                    nums[i] = Math.Min(Math.Min(nums[i / 2], nums[i / 3]), nums[i - 1]) + 1;
                }
                else if (i % 2 == 0)
                {
                    nums[i] = Math.Min(nums[i / 2], nums[i - 1]) + 1;
                }
                else if (i % 3 == 0)
                {
                    nums[i] = Math.Min(nums[i / 3], nums[i - 1]) + 1;
                }
                else
                {
                    nums[i] = nums[i - 1] + 1;
                }
            }
            print.WriteLine(nums[N]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_9095
    {
        public No_9095()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int T = int.Parse(reader.ReadLine());

            int[] nums = new int[11];
            nums[1] = 1;
            nums[2] = 2;
            nums[3] = 4;

            for (int i = 0; i < T; i++)
            {
                int n = int.Parse(reader.ReadLine());
                if (nums[n] != 0)
                {
                    print.WriteLine(nums[n]);
                    continue;
                }

                for (int j = 1; j <= n; j++)
                {
                    if (nums[j] != 0)
                        continue;

                    nums[j] = nums[j - 1] + nums[j - 2] + nums[j - 3];
                }

                print.WriteLine(nums[n]);
            }
        }
    }
}

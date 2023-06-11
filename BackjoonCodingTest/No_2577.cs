using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_2577
    {
        public No_2577()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int a = int.Parse(reader.ReadLine());
            int b = int.Parse(reader.ReadLine());
            int c = int.Parse(reader.ReadLine());

            int result = a * b * c;

            int[] nums = new int[10];
            while (result > 0)
            {
                nums[result % 10]++;
                result /= 10;
            }

            for (int i = 0; i < nums.Length; i++)
                print.WriteLine(nums[i]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_10818
    {
        public No_10818()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int N = int.Parse(input);
            string[] datas = reader.ReadLine().Split();

            int[] nums = new int[N];
            for (int i = 0; i < N; i++)
            {
                nums[i] = int.Parse(datas[i]);
            }

            int min = 1000000;
            int max = -1000000;
            for (int i = 0; i < N; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
                if (nums[i] < min)
                    min = nums[i];
            }

            print.WriteLine(min + " " + max);
        }
    }
}

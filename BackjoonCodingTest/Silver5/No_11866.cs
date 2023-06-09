using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver5
{
    public class No_11866
    {
        public No_11866()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int N = int.Parse(input.Split()[0]);
            int K = int.Parse(input.Split()[1]);
            List<int> nums = new List<int>();
            int index = 0;
            List<int> disableNums = new List<int>();

            for (int i = 1; i <= N; i++)
            {
                nums.Add(i);
            }

            while (nums.Count > 0)
            {
                index += K;
                while (index > nums.Count)
                {
                    index -= nums.Count;
                }

                disableNums.Add(nums[--index]);
                nums.RemoveAt(index);
            }

            print.Write("<");
            for (int i = 0; i < N; i++)
            {
                print.Write(disableNums[i]);
                if (i != N - 1)
                    print.Write(", ");
            }
            print.Write(">");
        }
    }
}

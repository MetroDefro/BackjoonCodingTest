using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze5
{
    public class No_10807
    {
        public No_10807()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());
            string[] inputs = reader.ReadLine().Split();

            int[] nums = new int[N];
            for (int i = 0; i < N; i++)
            {
                nums[i] = int.Parse(inputs[i]);
            }

            int v = int.Parse(reader.ReadLine());
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                if (v == nums[i])
                {
                    count++;
                }
            }

            print.WriteLine(count);

            reader.Close();
            print.Close();
        }
    }
}

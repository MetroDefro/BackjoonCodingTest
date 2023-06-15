using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver3
{
    public class No_2559
    {
        public No_2559()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();

            int n = int.Parse(input.Split()[0]);
            int k = int.Parse(input.Split()[1]);

            string[] inputs = reader.ReadLine().Split();

            int[] sums = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                    sums[i] = int.Parse(inputs[i]);
                else
                    sums[i] = sums[i - 1] + int.Parse(inputs[i]);
            }

            int max = sums[k - 1];

            for (int i = 0; i < n - k; i++)
            {
                int temp = sums[k + i] - sums[i];
                if (max < temp)
                    max = temp;
            }

            print.WriteLine(max);
        }
    }
}

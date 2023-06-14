using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver3
{
    public class No_13305
    {
        public No_13305()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(reader.ReadLine());
            string[] input = reader.ReadLine().Split();

            int[] kms = new int[n];
            for (int i = 0; i < n - 1; i++)
            {
                kms[i] = int.Parse(input[i]);
            }
            kms[n - 1] = 0;

            input = reader.ReadLine().Split();
            int[] prices = new int[n];
            for (int i = 0; i < n; i++)
            {
                prices[i] = int.Parse(input[i]);
            }

            int minIndex = n;
            int prevMinIndex = minIndex;
            long sumPrice = 0;
            while (minIndex > 0)
            {
                long minPrice = prices[0];

                for (int i = 0; i < prevMinIndex; i++)
                {
                    if (prices[i] <= minPrice)
                    {
                        minPrice = prices[i];
                        minIndex = i;
                    }
                }

                long sumKm = 0;
                for (int i = minIndex; i < prevMinIndex; i++)
                {
                    sumKm += kms[i];
                }

                sumPrice += sumKm * minPrice;
                prevMinIndex = minIndex;
            }

            print.WriteLine(sumPrice);
        }
    }
}

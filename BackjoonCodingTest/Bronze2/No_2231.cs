using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze2
{
    public class No_2231
    {
        public No_2231()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(reader.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int temp = i;
                int sum = i;
                while (temp > 0)
                {
                    sum += temp % 10;
                    temp /= 10;
                }

                if (sum == n)
                {
                    print.WriteLine(i);
                    break;
                }

                if (i == n - 1)
                    print.WriteLine(0);
            }
        }
    }
}

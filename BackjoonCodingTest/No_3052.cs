using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_3052
    {
        public No_3052()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int[] remain = new int[10];
            int count = 1;
            for (int i = 0; i < 10; i++)
            {
                remain[i] = int.Parse(reader.ReadLine()) % 42;

                for (int j = 0; j < i; j++)
                {
                    if (remain[i] == remain[j])
                        break;

                    if (j == i - 1)
                        count++;
                }
            }
            print.WriteLine(count);
        }
    }
}

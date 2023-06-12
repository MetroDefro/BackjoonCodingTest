using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze3
{
    public class No_2562
    {
        public No_2562()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int length = 9;
            int max = 0;
            int maxIndex = 0;
            int num = 0;
            for (int i = 0; i < length; i++)
            {
                num = int.Parse(reader.ReadLine());
                if (num > max)
                {
                    max = num;
                    maxIndex = i + 1;
                }
            }

            print.WriteLine(max);
            print.WriteLine(maxIndex);
        }
    }
}

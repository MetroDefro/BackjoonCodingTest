using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze2
{
    public class No_2292
    {
        public No_2292()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(reader.ReadLine());

            int mul = 1;
            int count = 1;
            while (mul < n)
            {
                mul += count * 6;
                count++;
            }

            print.WriteLine(count);
        }
    }
}

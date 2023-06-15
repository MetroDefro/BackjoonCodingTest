using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze2
{
    public class No_15829
    {
        public No_15829()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int L = int.Parse(reader.ReadLine());

            string input = reader.ReadLine();

            ulong sum = 0;
            ulong r = 1;
            for (int i = 0; i < L; i++)
            {
                char c = input[i];

                sum = (sum + ((ulong)c - 96) * r) % 1234567891;
                r = r * 31 % 1234567891;
            }

            print.WriteLine(sum);
        }
    }
}

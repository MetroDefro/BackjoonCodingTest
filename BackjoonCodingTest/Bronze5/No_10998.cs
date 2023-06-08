using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze5
{
    public class No_10998
    {
        public No_10998()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();

            int a = int.Parse(input.Split()[0]);
            int b = int.Parse(input.Split()[1]);

            print.WriteLine(a * b);
        }
    }
}

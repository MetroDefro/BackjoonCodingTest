using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze5
{
    public class No_11382
    {
        public No_11382()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();

            print.WriteLine(long.Parse(inputs[0]) + long.Parse(inputs[1]) + long.Parse(inputs[2]));
        }
    }
}

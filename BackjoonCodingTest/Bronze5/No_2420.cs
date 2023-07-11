using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze5
{
    public class No_2420
    {
        public No_2420()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            long n = int.Parse(inputs[0]);
            long m = int.Parse(inputs[1]);

            print.WriteLine(Math.Abs(n - m));

            reader.Close();
            print.Close();
        }
    }
}

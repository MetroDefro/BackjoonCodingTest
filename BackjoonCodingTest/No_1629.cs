using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_1629
    {
        public No_1629()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();

            long A = long.Parse(inputs[0]);
            long B = long.Parse(inputs[1]);
            long C = long.Parse(inputs[2]);

            print.WriteLine(pow(A, B, C));
        }

        private static long pow(long a, long n, long c)
        {
            long result = 1;
            while (n > 0)
            {
                if ((n & 1) == 1)
                    result = (result * a) % c;

                a = (a * a) % c;

                n = n >> 1;

            }

            return result;
        }
    }
}

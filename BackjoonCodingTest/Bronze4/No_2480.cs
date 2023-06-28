using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze4
{
    public class No_2480
    {
        public No_2480()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();

            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            int c = int.Parse(inputs[2]);

            if (a == b && a == c)
            {
                print.WriteLine(a * 1000 + 10000);
            }
            else
            {
                if (a == b)
                {
                    print.WriteLine(a * 100 + 1000);
                }
                else if (a == c)
                {
                    print.WriteLine(a * 100 + 1000);
                }
                else if (b == c)
                {
                    print.WriteLine(c * 100 + 1000);
                }
                else
                {
                    print.WriteLine(Math.Max(a, Math.Max(b, c)) * 100);
                }
            }

            reader.Close();
            print.Close();
        }
    }
}

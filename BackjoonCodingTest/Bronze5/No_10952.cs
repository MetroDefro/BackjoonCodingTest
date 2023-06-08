using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze5
{
    public class No_10952
    {
        public No_10952()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input;

            while (true)
            {
                input = reader.ReadLine();

                int a = int.Parse(input.Split()[0]);
                int b = int.Parse(input.Split()[1]);

                if (a == 0 && b == 0)
                    break;

                Console.WriteLine(a + b);
            }
        }
    }
}

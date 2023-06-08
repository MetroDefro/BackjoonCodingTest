using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze5
{
    public class No_10951
    {
        public No_10951()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input;

            while (true)
            {
                input = reader.ReadLine();

                if (input == null)
                    break;

                int a = int.Parse(input.Split()[0]);
                int b = int.Parse(input.Split()[1]);

                Console.WriteLine(a + b);
            }
        }
    }
}

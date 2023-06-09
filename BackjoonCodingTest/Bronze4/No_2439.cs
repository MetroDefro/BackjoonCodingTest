using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze4
{
    public class No_2439
    {
        public No_2439()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int N = int.Parse(input);

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N - i; j++)
                {
                    print.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    print.Write('*');
                }

                print.WriteLine();
            }
        }
    }
}

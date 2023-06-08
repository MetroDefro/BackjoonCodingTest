using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze5
{
    public class No_10950
    {
        public No_10950()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int T = int.Parse(input);

            int[] results = new int[T];
            for (int i = 0; i < T; i++)
            {
                input = reader.ReadLine();
                int a = int.Parse(input.Split()[0]);
                int b = int.Parse(input.Split()[1]);

                results[i] = a + b;
            }

            for (int i = 0; i < T; i++)
            {
                print.WriteLine(results[i]);
            }
        }
    }
}

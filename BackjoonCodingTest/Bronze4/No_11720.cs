using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze4
{
    public class No_11720
    {
        public No_11720()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int N = int.Parse(input);
            input = reader.ReadLine();

            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += int.Parse(input[i].ToString());
            }

            print.WriteLine(sum);
        }
    }
}

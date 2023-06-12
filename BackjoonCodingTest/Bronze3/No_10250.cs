using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze3
{
    public class No_10250
    {
        public No_10250()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int cases = int.Parse(input);

            for (int i = 0; i < cases; i++)
            {
                input = reader.ReadLine();
                int H = int.Parse(input.Split()[0]);
                int W = int.Parse(input.Split()[1]);
                int N = int.Parse(input.Split()[2]);

                int x = (N - 1) / H + 1;
                int y = N % H;
                if (y == 0)
                    y = H;

                print.WriteLine(y + string.Format("{0:D2}", x));
            }
        }
    }
}

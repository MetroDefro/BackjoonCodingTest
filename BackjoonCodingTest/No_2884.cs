using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_2884
    {
        public No_2884()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int H = int.Parse(input.Split()[0]);
            int M = int.Parse(input.Split()[1]);

            if (M >= 45)
                M -= 45;
            else
            {
                M += 15;
                if (H != 0)
                    H--;
                else
                    H = 23;
            }

            print.WriteLine(H + " " + M);
        }
    }
}

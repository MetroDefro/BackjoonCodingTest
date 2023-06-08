using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze5
{
    public class No_2753
    {
        public No_2753()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            short year = short.Parse(input);

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        print.WriteLine(1);
                    }
                    else
                    {
                        print.WriteLine(0);
                    }
                }
                else
                {
                    print.WriteLine(1);
                }
            }
            else
            {
                print.WriteLine(0);
            }
        }
    }
}

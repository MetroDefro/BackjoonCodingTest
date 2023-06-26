using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze4
{
    public class No_16486
    {
        public No_16486()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int d1 = int.Parse(reader.ReadLine());
            int d2 = int.Parse(reader.ReadLine());

            print.WriteLine((d1 * 2) + (d2 * 3.141592 * 2));

            reader.Close();
            print.Close();
        }
    }
}

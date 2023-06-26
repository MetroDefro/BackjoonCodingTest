using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze4
{
    public class No_10101
    {
        public No_10101()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int a = int.Parse(reader.ReadLine());
            int b = int.Parse(reader.ReadLine());
            int c = int.Parse(reader.ReadLine());

            if (a + b + c != 180)
                print.WriteLine("Error");
            else
            {
                if (a == b && b == c)
                    print.WriteLine("Equilateral");
                else if (a == b || b == c || a == c)
                    print.WriteLine("Isosceles");
                else
                    print.WriteLine("Scalene");
            }

            reader.Close();
            print.Close();
        }
    }
}

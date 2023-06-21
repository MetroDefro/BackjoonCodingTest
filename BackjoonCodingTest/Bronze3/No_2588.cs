using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze3
{
    public class No_2588
    {
        public No_2588()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int A = int.Parse(reader.ReadLine());
            int B = int.Parse(reader.ReadLine());


            print.WriteLine(A * (B % 10));
            print.WriteLine(A * (B / 10 % 10));
            print.WriteLine(A * (B / 100 % 10));
            print.WriteLine(A * B);
            reader.Close();
            print.Close();
        }
    }
}

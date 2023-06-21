using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze5
{
    public class No_10430
    {
        public No_10430()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            int C = int.Parse(inputs[2]);

            print.WriteLine((A + B) % C);
            print.WriteLine(((A % C) + (B % C)) % C);
            print.WriteLine((A * B) % C);
            print.WriteLine(((A % C) * (B % C)) % C);

            reader.Close();
            print.Close();
        }
    }
}

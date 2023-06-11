using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_1152
    {
        public No_1152()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] input = reader.ReadLine().Split();

            int count = input.Length;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == string.Empty)
                    count--;
            }

            print.WriteLine(count);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze4
{
    public class No_15552
    {
        public No_15552()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int T = int.Parse(reader.ReadLine());
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < T; i++)
            {
                string[] inputs = reader.ReadLine().Split();
                stringBuilder.AppendLine((int.Parse(inputs[0]) + int.Parse(inputs[1])).ToString());
            }

            print.WriteLine(stringBuilder.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_2675
    {
        public No_2675()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int testCase = int.Parse(input);

            for (int i = 0; i < testCase; i++)
            {
                input = reader.ReadLine();
                int n = int.Parse(input.Split()[0]);
                string str = input.Split()[1];

                for (int j = 0; j < str.Length; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        print.Write(str[j]);
                    }
                }

                print.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze2
{
    public class No_8958
    {
        public No_8958()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int testCase = int.Parse(reader.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                int sum = 0;
                int count = 0;
                string input = reader.ReadLine();
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == 'O')
                    {
                        count++;
                        sum += count;
                    }
                    else
                    {
                        count = 0;
                    }
                }
                print.WriteLine(sum);
            }
        }
    }
}

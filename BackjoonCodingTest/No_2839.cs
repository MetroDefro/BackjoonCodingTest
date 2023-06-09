using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_2839
    {
        public No_2839()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int N = int.Parse(input);

            int five = 0;
            int three = 0;

            int length3 = N / 3;
            int length5 = N / 5;

            print.WriteLine(Check(N));
        }

        private static int Check(int N)
        {
            int length3 = N / 3;
            int length5 = N / 5;
            int num;
            for (int i = 0; i <= length3; i++)
            {
                for (int j = 0; j <= length5; j++)
                {
                    num = i * 3 + j * 5;
                    if (num > N)
                        break;
                    else if (num == N)
                    {
                        return i + j;
                    }
                }
            }

            return -1;
        }
    }
}

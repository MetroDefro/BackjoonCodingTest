using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_1676
    {
        public No_1676()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int N = int.Parse(input);

            int two = 0;
            int five = 0;

            for (int i = 2; i <= N; i++)
            {
                int temp = i;
                while (temp % 2 == 0)
                {
                    temp /= 2;
                    two++;
                }

                temp = i;
                while (temp % 5 == 0)
                {
                    temp /= 5;
                    five++;
                }


            }

            if (two >= five)
            {
                print.WriteLine(five);
            }
            else
            {
                print.WriteLine(two);
            }
        }
    }
}

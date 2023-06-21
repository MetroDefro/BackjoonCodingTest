using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_6064
    {
        public No_6064()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int T = int.Parse(reader.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string[] inputs = reader.ReadLine().Split();
                int M = int.Parse(inputs[0]);
                int N = int.Parse(inputs[1]);
                int x = int.Parse(inputs[2]);
                int y = int.Parse(inputs[3]);

                int abs = Math.Abs(x - y);
                int gcd = GCD(M, N);
                int lcm = LCM(M, N);

                if (abs % gcd != 0)
                    print.WriteLine("-1");
                else
                {
                    int curX = x;
                    int curY = y;
                    while (curX != curY)
                    {
                        if (curX < curY)
                            curX += M;
                        else
                            curY += N;
                    }

                    print.WriteLine(curY);
                }
            }
        }

        private static int GCD(int value1, int value2)
        {
            int smallValue = value1 < value2 ? value1 : value2;
            int maxMeasure = 1;

            for (int i = 2; i <= smallValue; i++)
            {
                if (value1 % i == 0)
                {
                    if (value2 % i == 0)
                    {
                        maxMeasure = i;
                    }
                }
            }

            return maxMeasure;
        }

        private static int LCM(int value1, int value2)
        {
            return value1 * value2 / GCD(value1, value2);
        }
    }
}

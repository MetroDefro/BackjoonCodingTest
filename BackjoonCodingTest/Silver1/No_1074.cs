using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_1074
    {
        public No_1074()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int N = int.Parse(inputs[0]);
            int r = int.Parse(inputs[1]);
            int c = int.Parse(inputs[2]);

            int n = (int)Math.Pow(2, N);

            Divide(n, 0, 0, 0);

            void Divide(int n, int startIndex, int x, int y)
            {
                if (x == c && y == r)
                {
                    print.WriteLine(startIndex);
                    return;
                }

                if (n == 1)
                {
                    return;
                }
                else
                {
                    int half = n / 2;

                    if (c < x + half && r < y + half)
                        Divide(half, startIndex + half * half * 0, x, y);
                    else if (c >= x + half && r < y + half)
                        Divide(half, startIndex + half * half * 1, x + half, y);
                    else if (c < x + half && r >= y + half)
                        Divide(half, startIndex + half * half * 2, x, y + half);
                    else if (c >= x + half && r >= y + half)
                        Divide(half, startIndex + half * half * 3, x + half, y + half);
                }
            }
        }
    }
}

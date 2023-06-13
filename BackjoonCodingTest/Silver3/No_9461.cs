using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_9461
    {
        public No_9461()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            long[] P = new long[101];
            P[1] = 1;
            P[2] = 1;
            P[3] = 1;
            P[4] = 2;
            P[5] = 2;
            P[6] = 3;
            P[7] = 4;
            P[8] = 5;
            P[9] = 7;
            P[10] = 9;

            int T = int.Parse(reader.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int n = int.Parse(reader.ReadLine());

                for (int j = 1; j <= n; j++)
                {
                    if (P[j] != 0)
                        continue;

                    P[j] = P[j - 1] + P[j - 5];
                }

                print.WriteLine(P[n]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver3
{
    public class No_1929
    {
        public No_1929()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int M = int.Parse(input.Split()[0]);
            int N = int.Parse(input.Split()[1]);

            bool[] isPrimes = new bool[N + 1];

            isPrimes[0] = false;
            isPrimes[1] = false;

            for (int i = 2; i <= N; i++)
            {
                isPrimes[i] = true;
            }

            for (int i = 2; i <= N; i++)
            {
                if (isPrimes[i] == false)
                    continue;

                for (int j = i * 2; j <= N; j += i)
                {
                    isPrimes[j] = false;
                }
            }

            for (int i = 1; i <= N; i++)
                if (isPrimes[i] && i >= M)
                    print.WriteLine(i);
        }
    }
}

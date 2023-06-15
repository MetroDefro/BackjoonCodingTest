using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_1978
    {
        public No_1978()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());
            string[] inputs = reader.ReadLine().Split();

            bool[] isPrimes = new bool[1001];
            for (int i = 2; i < 1001; i++)
            {
                isPrimes[i] = true;
            }

            for (int i = 2; i < 1001; i++)
            {
                if (isPrimes[i] == false)
                    continue;

                for (int j = i * 2; j < 1001; j += i)
                {
                    isPrimes[j] = false;
                }
            }

            int count = 0;
            for (int i = 0; i < N; i++)
            {
                if (isPrimes[int.Parse(inputs[i])])
                    count++;
            }

            print.WriteLine(count);
        }
    }
}

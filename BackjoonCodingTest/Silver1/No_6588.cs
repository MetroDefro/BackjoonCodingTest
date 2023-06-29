using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_6588
    {
        public No_6588()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            bool[] isPrimes = new bool[1000001];

            isPrimes[0] = false;
            isPrimes[1] = false;

            for (int i = 2; i < 1000001; i++)
            {
                isPrimes[i] = true;
            }

            for (int i = 2; i < 1000001; i++)
            {
                if (isPrimes[i] == false)
                    continue;

                for (int j = i * 2; j < 1000001; j += i)
                {
                    isPrimes[j] = false;
                }
            }

            StringBuilder stringBuilder = new StringBuilder();
            while (true)
            {
                int n = int.Parse(reader.ReadLine());
                if (n == 0)
                    break;

                int index = TwoPointer(isPrimes, n);
                if (index == 0)
                {
                    stringBuilder.Append("Goldbach's conjecture is wrong.");
                    stringBuilder.AppendLine();
                }
                else
                {
                    stringBuilder.Append(n + " = " + index + " + " + (n - index));
                    stringBuilder.AppendLine();
                }
            }

            print.WriteLine(stringBuilder.ToString());

            reader.Close();
            print.Close();
        }

        private static int TwoPointer(bool[] isPrimes, int target)
        {
            int index = 3;
            int length = isPrimes.Length;

            while (index < length)
            {
                if (isPrimes[index])
                {
                    if (isPrimes[target - index])
                    {
                        return index;
                    }
                }

                index++;
            }

            return 0;
        }
    }
}

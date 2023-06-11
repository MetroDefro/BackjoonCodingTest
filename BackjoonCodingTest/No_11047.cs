using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_11047
    {
        public No_11047()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();

            int N = int.Parse(input.Split()[0]);
            int K = int.Parse(input.Split()[1]);

            int[] coins = new int[N];

            for (int i = 0; i < N; i++)
            {
                coins[i] = int.Parse(reader.ReadLine());
            }

            int sum = 0;
            int count = 0;
            int index = 0;
            for (int i = 0; i < N; i++)
            {
                if (coins[i] > K)
                {
                    index = i - 1;
                    break;
                }

                if (i == N - 1)
                    index = i;
            }

            int temp;
            int Ktemp = K;
            while (sum < K)
            {
                temp = Ktemp / coins[index];
                count += temp;
                sum += temp * coins[index];

                Ktemp = K - sum;

                index--;
            }

            print.WriteLine(count);
        }
    }
}

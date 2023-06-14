using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_2798
    {
        public No_2798()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int n = int.Parse(input.Split()[0]);
            int m = int.Parse(input.Split()[1]);

            int[] cards = new int[n];
            string[] inputs = reader.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                cards[i] = int.Parse(inputs[i]);
            }


            int max = 0;
            for (int i = 0; i < n; i++)
            {
                if (cards[i] > m)
                    continue;
                for (int j = i + 1; j < n; j++)
                {
                    if (cards[j] > m)
                        continue;
                    for (int k = j + 1; k < n; k++)
                    {
                        if (cards[k] > m)
                            continue;

                        int result = cards[i] + cards[j] + cards[k];
                        if (result > max && result <= m)
                            max = result;
                    }
                }
            }

            if (max != 0)
                print.WriteLine(max);
        }
    }
}

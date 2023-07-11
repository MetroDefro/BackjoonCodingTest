using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Gold5
{
    public class No_1107
    {
        public No_1107()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());
            int M = int.Parse(reader.ReadLine());

            bool[] broken = new bool[10];
            if (M != 0)
            {
                string[] inputs = reader.ReadLine().Split();

                for (int i = 0; i < M; i++)
                {
                    broken[int.Parse(inputs[i])] = true;
                }
            }

            string NString = N.ToString();

            int startIndex = (int)Math.Pow(10, NString.Length - 2) - 1;
            int endIndex = (int)Math.Pow(10, NString.Length + 1);

            int min = endIndex;
            int minIndex = endIndex;

            for (int i = startIndex; i < endIndex; i++)
            {
                if (i == 0 && !broken[i])
                {
                    if (Math.Abs(N - i) < min)
                    {
                        min = Math.Abs(N - i);
                        minIndex = i;
                    }
                }

                int num = i;

                while (num > 0)
                {
                    if (broken[num % 10])
                    {
                        break;
                    }

                    num /= 10;

                    if (num <= 0)
                    {
                        if (Math.Abs(N - i) < min)
                        {
                            min = Math.Abs(N - i);
                            minIndex = i;
                        }
                    }
                }
            }

            print.WriteLine(Math.Min(Math.Abs(N - 100), Math.Abs(N - minIndex) + minIndex.ToString().Length));

            reader.Close();
            print.Close();
        }
    }
}

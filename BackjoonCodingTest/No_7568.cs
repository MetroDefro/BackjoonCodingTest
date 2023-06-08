using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_7568
    {
        public No_7568()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int N = int.Parse(input);

            int[,] datas = new int[2, N];

            for (int i = 0; i < N; i++)
            {
                input = reader.ReadLine();
                datas[0, i] = int.Parse(input.Split()[0]);
                datas[1, i] = int.Parse(input.Split()[1]);
            }

            for (int i = 0; i < N; i++)
            {
                int count = 0;
                for (int j = 0; j < N; j++)
                {
                    if (datas[0, i] < datas[0, j] && datas[1, i] < datas[1, j])
                    {
                        count++;
                    }
                }

                print.WriteLine(++count);
            }
        }
    }
}

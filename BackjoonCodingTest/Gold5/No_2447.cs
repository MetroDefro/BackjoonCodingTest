using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Gold5
{
    public class No_2447
    {
        public No_2447()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());
            char[,] stars = new char[N, N];
            StringBuilder stringBuilder = new StringBuilder();
            Divide(stars, N, 0, 0);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (stars[i, j] == '\0')
                        stringBuilder.Append(' ');
                    else
                        stringBuilder.Append(stars[i, j]);
                }
                stringBuilder.AppendLine();
            }
            print.WriteLine(stringBuilder);
            reader.Close();
            print.Close();
        }

        private static void Divide(char[,] stars, int n, int startX, int startY)
        {
            if (n == 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (i != 1 || j != 1)
                            stars[startX + i, startY + j] = '*';
                    }
                }

                return;
            }

            int position = n / 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i != 1 || j != 1)
                        Divide(stars, n / 3, startX + position * i, startY + position * j);
                }
            }
        }
    }
}

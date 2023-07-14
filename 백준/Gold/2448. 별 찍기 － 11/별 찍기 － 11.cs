using System;
using System.Text;

namespace BackjoonCodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());
            char[,] stars = new char[N, N * 2];
            StringBuilder stringBuilder = new StringBuilder();
            Divide(stars, N, 0, 0);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N * 2; j++)
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
                stars[startY + 0, startX + 2] = '*';
                stars[startY + 1, startX + 1] = '*';
                stars[startY + 1, startX + 3] = '*';
                for (int i = 0; i < 5; i++)
                    stars[startY + 2, startX + i] = '*';

                return;
            }

            int position = n / 2;
            // 위쪽 삼각형
            Divide(stars, n / 2, startX + position, startY);
            // 왼쪽 삼각형
            Divide(stars, n / 2, startX, startY + position);
            // 오른쪽 삼각형
            Divide(stars, n / 2, startX + n, startY + position);
        }
    }
}
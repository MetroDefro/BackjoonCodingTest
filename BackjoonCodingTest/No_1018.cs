using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_1018
    {
        public No_1018()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int N = int.Parse(input.Split()[0]);
            int M = int.Parse(input.Split()[1]);


            char[,] match1 = { { 'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B' },
                                { 'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' },
                                { 'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B' },
                                { 'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' },
                                { 'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B' },
                                { 'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' },
                                { 'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B' },
                                { 'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' },};

            char[,] match2 = { { 'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' },
                                { 'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B' },
                                { 'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' },
                                { 'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B' },
                                { 'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' },
                                { 'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B' },
                                { 'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' },
                                { 'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B' }};

            char[,] coord = new char[N, M];

            for (int i = 0; i < N; i++)
            {
                input = reader.ReadLine();
                for (int j = 0; j < M; j++)
                {
                    coord[i, j] = input[j];
                }
            }

            int[,] wrongCount1 = new int[N - 7, M - 7];
            int[,] wrongCount2 = new int[N - 7, M - 7];

            for (int i = 0; i < N - 7; i++)
            {
                for (int j = 0; j < M - 7; j++)
                {
                    wrongCount1[i, j] = 0;
                    wrongCount2[i, j] = 0;
                }
            }


            for (int k = 0; k < N - 7; k++)
            {
                for (int l = 0; l < M - 7; l++)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (coord[i + k, j + l] != match1[i, j])
                            {
                                wrongCount1[k, l]++;
                            }

                            if (coord[i + k, j + l] != match2[i, j])
                            {
                                wrongCount2[k, l]++;
                            }
                        }
                    }
                }
            }

            int minimum = 64;
            for (int i = 0; i < N - 7; i++)
            {
                for (int j = 0; j < M - 7; j++)
                {
                    if (wrongCount1[i, j] < minimum)
                    {
                        minimum = wrongCount1[i, j];
                    }

                    if (wrongCount2[i, j] < minimum)
                    {
                        minimum = wrongCount2[i, j];
                    }
                }
            }

            print.WriteLine(minimum);
        }
    }
}

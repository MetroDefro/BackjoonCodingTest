using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_14500
    {
        public No_14500()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            short[,] arr = new short[M, N];
            for (int i = 0; i < N; i++)
            {
                inputs = reader.ReadLine().Split();
                for (int j = 0; j < M; j++)
                {
                    arr[j, i] = short.Parse(inputs[j]);
                }
            }

            byte[,,] tetris = {
                {   {1, 1, 0, 0 },
                    {1, 1, 0, 0 },
                    {0, 0, 0, 0 },
                    {0, 0, 0, 0 }   } ,

                {   {1, 1, 1, 1 },
                    {0, 0, 0, 0 },
                    {0, 0, 0, 0 },
                    {0, 0, 0, 0 }   } ,

                {   {1, 0, 0, 0 },
                    {1, 0, 0, 0 },
                    {1, 0, 0, 0 },
                    {1, 0, 0, 0 }   } ,

                {   {1, 0, 0, 0 },
                    {1, 0, 0, 0 },
                    {1, 1, 0, 0 },
                    {0, 0, 0, 0 }   } ,

                {   {0, 0, 1, 0 },
                    {1, 1, 1, 0 },
                    {0, 0, 0, 0 },
                    {0, 0, 0, 0 }   } ,

                {   {1, 1, 0, 0 },
                    {0, 1, 0, 0 },
                    {0, 1, 0, 0 },
                    {0, 0, 0, 0 }   } ,

                {   {1, 1, 1, 0 },
                    {1, 0, 0, 0 },
                    {0, 0, 0, 0 },
                    {0, 0, 0, 0 }   } ,

                {   {0, 1, 0, 0 },
                    {0, 1, 0, 0 },
                    {1, 1, 0, 0 },
                    {0, 0, 0, 0 }   } ,

                {   {1, 1, 1, 0 },
                    {0, 0, 1, 0 },
                    {0, 0, 0, 0 },
                    {0, 0, 0, 0 }   } ,

                {   {1, 1, 0, 0 },
                    {1, 0, 0, 0 },
                    {1, 0, 0, 0 },
                    {0, 0, 0, 0 }   } ,

                {   {1, 0, 0, 0 },
                    {1, 1, 1, 0 },
                    {0, 0, 0, 0 },
                    {0, 0, 0, 0 }   } ,

                {   {1, 0, 0, 0 },
                    {1, 1, 0, 0 },
                    {0, 1, 0, 0 },
                    {0, 0, 0, 0 }   } ,

                {   {0, 1, 1, 0 },
                    {1, 1, 0, 0 },
                    {0, 0, 0, 0 },
                    {0, 0, 0, 0 }   } ,

                {   {0, 1, 0, 0 },
                    {1, 1, 0, 0 },
                    {1, 0, 0, 0 },
                    {0, 0, 0, 0 }   } ,

                {   {1, 1, 0, 0 },
                    {0, 1, 1, 0 },
                    {0, 0, 0, 0 },
                    {0, 0, 0, 0 }   } ,

                {   {0, 1, 0, 0 },
                    {1, 1, 1, 0 },
                    {0, 0, 0, 0 },
                    {0, 0, 0, 0 }   } ,

                {   {0, 1, 0, 0 },
                    {1, 1, 0, 0 },
                    {0, 1, 0, 0 },
                    {0, 0, 0, 0 }   } ,

                {   {1, 1, 1, 0 },
                    {0, 1, 0, 0 },
                    {0, 0, 0, 0 },
                    {0, 0, 0, 0 }   } ,

                {   {1, 0, 0, 0 },
                    {1, 1, 0, 0 },
                    {1, 0, 0, 0 },
                    {0, 0, 0, 0 }   } ,
            };

            int max = 0;
            for (int m = 0; m < M; m++)
            {
                for (int n = 0; n < N; n++)
                {
                    for (int i = 0; i < 19; i++)
                    {
                        max = Math.Max(max, Sum(i, m, n));
                    }
                }
            }

            print.WriteLine(max);

            int Sum(int index, int m, int n)
            {
                int sum = 0;
                for (int x = 0; x < 4; x++)
                {
                    for (int y = 0; y < 4; y++)
                    {
                        if (tetris[index, x, y] == 0)
                            continue;

                        if (m + x >= M || n + y >= N)
                            return 0;

                        sum += arr[m + x, n + y];
                    }
                }

                return sum;
            }

            reader.Close();
            print.Close();
        }
    }
}

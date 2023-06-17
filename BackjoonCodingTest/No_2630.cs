using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_2630
    {
        public No_2630()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());

            int[,] colors = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] inputs = reader.ReadLine().Split();
                for (int j = 0; j < N; j++)
                {
                    colors[i, j] = int.Parse(inputs[j]);
                }
            }

            int[] count = new int[2];
            Divide(colors, N);

            print.WriteLine(count[0]);
            print.WriteLine(count[1]);


            void Divide(int[,] arr, int n)
            {
                if (n == 1)
                {
                    if (arr[0, 0] == 0)
                        count[0]++;
                    else
                        count[1]++;

                    return;
                }

                int white = 0;
                int blue = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (arr[i, j] == 0)
                            white++;
                        else
                            blue++;
                    }
                }

                if (white == n * n)
                {
                    count[0]++;
                    return;
                }
                else if (blue == n * n)
                {
                    count[1]++;
                    return;
                }


                int half = n / 2;
                int[,] divideArrLeftTop = new int[half, half];
                int[,] divideArrLeftBottom = new int[half, half];
                int[,] divideArrRightTop = new int[half, half];
                int[,] divideArrRightBottom = new int[half, half];
                for (int i = 0; i < half; i++)
                {
                    for (int j = 0; j < half; j++)
                    {
                        divideArrLeftTop[i, j] = arr[i, j];
                        divideArrLeftBottom[i, j] = arr[i + half, j];
                        divideArrRightTop[i, j] = arr[i, j + half];
                        divideArrRightBottom[i, j] = arr[i + half, j + half];
                    }
                }

                Divide(divideArrLeftTop, half);
                Divide(divideArrLeftBottom, half);
                Divide(divideArrRightTop, half);
                Divide(divideArrRightBottom, half);
            }
        }
    }
}

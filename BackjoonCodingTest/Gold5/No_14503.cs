using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Gold5
{
    public class No_14503
    {
        public No_14503()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            inputs = reader.ReadLine().Split();
            int r = int.Parse(inputs[0]);
            int c = int.Parse(inputs[1]);
            int d = int.Parse(inputs[2]);

            int[,] maps = new int[M, N];
            for (int i = 0; i < N; i++)
            {
                inputs = reader.ReadLine().Split();
                for (int j = 0; j < M; j++)
                {
                    maps[j, i] = int.Parse(inputs[j]);
                }
            }

            Queue<(int x, int y, int dr)> queue = new Queue<(int, int, int)>();

            queue.Enqueue((c, r, d));
            maps[c, r] = 2;
            int count = 1;

            int[] addX = { 0, 1, 0, -1 };
            int[] addY = { -1, 0, 1, 0 };

            while (queue.Count > 0)
            {
                (int x, int y, int dr) = queue.Dequeue();

                for (int i = 3; i >= 0; i--)
                {
                    int index = (i + dr) % 4;

                    if (maps[x + addX[index], y + addY[index]] == 0)
                    {
                        queue.Enqueue((x + addX[index], y + addY[index], index));
                        maps[x + addX[index], y + addY[index]] = 2;
                        count++;

                        break;
                    }

                    if (i == 0)
                    {
                        if (maps[x + addX[(2 + dr) % 4], y + addY[(2 + dr) % 4]] != 1)
                        {
                            queue.Enqueue((x + addX[(2 + dr) % 4], y + addY[(2 + dr) % 4], dr));
                        }
                    }
                }
            }

            print.WriteLine(count);

            reader.Close();
            print.Close();
        }
    }
}

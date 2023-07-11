using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Gold5
{
    public class No_10026
    {
        public No_10026()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());

            char[,] colors = new char[N, N];
            for (int i = 0; i < N; i++)
            {
                string inputs = reader.ReadLine();
                for (int j = 0; j < N; j++)
                {
                    colors[j, i] = inputs[j];
                }
            }

            bool[,] visited = new bool[N, N];

            int count = 0;
            for (int width = 0; width < N; width++)
            {
                for (int height = 0; height < N; height++)
                {
                    if (!visited[width, height])
                    {
                        count++;
                        DFS(visited, colors, colors[width, height], width, height, N, false);
                    }
                }
            }

            print.WriteLine(count);

            count = 0;
            bool[,] visited2 = new bool[N, N];
            for (int width = 0; width < N; width++)
            {
                for (int height = 0; height < N; height++)
                {
                    if (!visited2[width, height])
                    {
                        count++;
                        DFS(visited2, colors, colors[width, height], width, height, N, true);
                    }
                }
            }

            print.WriteLine(count);

            reader.Close();
            print.Close();
        }

        private static void DFS(bool[,] visited, char[,] colors, char color, int x, int y, int N, bool isWeakness)
        {
            int[] addedX = { +1, 0, -1, 0 };
            int[] addedY = { 0, +1, 0, -1 };

            for (int i = 0; i < 4; i++)
            {
                if (x + addedX[i] < N && x + addedX[i] > -1
                    && y + addedY[i] < N && y + addedY[i] > -1
                    && !visited[x + addedX[i], y + addedY[i]])
                {
                    if (isWeakness && (color == 'R' || color == 'G'))
                    {
                        if (colors[x + addedX[i], y + addedY[i]] == 'R' || colors[x + addedX[i], y + addedY[i]] == 'G')
                        {
                            visited[x + addedX[i], y + addedY[i]] = true;
                            DFS(visited, colors, color, x + addedX[i], y + addedY[i], N, isWeakness);
                        }
                    }
                    else
                    {
                        if (colors[x + addedX[i], y + addedY[i]] == color)
                        {
                            visited[x + addedX[i], y + addedY[i]] = true;
                            DFS(visited, colors, color, x + addedX[i], y + addedY[i], N, isWeakness);
                        }
                    }
                }
            }
        }
    }
}

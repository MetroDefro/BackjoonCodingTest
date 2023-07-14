using System;

namespace BackjoonCodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int R = int.Parse(inputs[0]);
            int C = int.Parse(inputs[1]);

            char[,] chars = new char[C , R];
            for(int i = 0; i < R; i++)
            {
                string input = reader.ReadLine();
                for(int j = 0; j < C; j++)
                {
                    chars[j,i] = input[j];
                }
            }

            bool[] visited = new bool[26];
            int[] addX = { 1, -1, 0, 0 };
            int[] addY = { 0, 0, 1, -1 };

            int max = 0;
            visited[chars[0, 0] - 'A'] = true;
            DFS(0, 0, 1);

            void DFS(int x, int y, int count)
            {
                max = Math.Max(max, count);

                for (int i = 0; i < 4; i++)
                {
                    if(x + addX[i] < C && x + addX[i] >= 0 && y + addY[i] < R && y + addY[i] >= 0)
                    {
                        int index = chars[x + addX[i], y + addY[i]] - 'A';
                        if (!visited[index])
                        {
                            visited[index] = true;
                            DFS(x + addX[i], y + addY[i], count + 1);
                            visited[index] = false;
                        }
                    }
                }
            }

            print.WriteLine(max);

            reader.Close();
            print.Close();
        }
    }
}
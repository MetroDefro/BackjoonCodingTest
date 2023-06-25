using System;
using System.Collections.Generic;

namespace BackjoonCodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());
            int M = int.Parse(reader.ReadLine());

            int[,] cities = new int[N + 1, N + 1];
            bool[,] isCityConnect = new bool[N + 1, N + 1];
            string[] inputs;
            for (int i = 0; i < M; i++)
            {
                inputs = reader.ReadLine().Split();
                cities[int.Parse(inputs[0]), int.Parse(inputs[1])] = int.Parse(inputs[2]);
                isCityConnect[int.Parse(inputs[0]), int.Parse(inputs[1])] = true;
            }
            inputs = reader.ReadLine().Split();
            int startCity = int.Parse(inputs[0]);
            int endCity = int.Parse(inputs[1]);

            bool[] visited = new bool[N + 1];
            Queue<(int city, int price)> queue = new Queue<(int, int)>();
            queue.Enqueue((startCity, 0));
            visited[startCity] = true;
            int[] dp = new int[N + 1];

            int min = int.MaxValue;
            while (queue.Count > 0)
            {
                (int city, int price) = queue.Dequeue();

                if (city == endCity)
                {
                    min = Math.Min(min, price);
                }

                for (int i = 1; i <= N; i++)
                {
                    if (isCityConnect[city, i])
                    {
                        if (!visited[i])
                        {
                            queue.Enqueue((i, price + cities[city, i]));

                            visited[i] = true;
                        }
                    }
                }
            }


            print.WriteLine(min);

            reader.Close();
            print.Close();
        }
    }
}
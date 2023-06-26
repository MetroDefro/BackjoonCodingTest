using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_1916
    {
        public No_1916()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());
            int M = int.Parse(reader.ReadLine());

            List<(int city, int price)>[] connectlist = new List<(int, int)>[N + 1];
            for (int i = 1; i <= N; i++)
            {
                connectlist[i] = new List<(int, int)>();
            }

            string[] inputs;
            for (int i = 0; i < M; i++)
            {
                inputs = reader.ReadLine().Split();

                connectlist[int.Parse(inputs[0])].Add((int.Parse(inputs[1]), int.Parse(inputs[2])));
            }

            inputs = reader.ReadLine().Split();
            int startCity = int.Parse(inputs[0]);
            int endCity = int.Parse(inputs[1]);

            bool[] visited = new bool[N + 1];
            Queue<(int city, int price)> queue = new Queue<(int, int)>();
            queue.Enqueue((startCity, 0));
            visited[startCity] = true;

            int[] minPrice = new int[N + 1];
            for (int i = 1; i <= N; i++)
            {
                minPrice[i] = int.MaxValue;
            }
            while (queue.Count > 0)
            {
                (int city, int price) = queue.Dequeue();

                int count = connectlist[city].Count;
                for (int i = 0; i < count; i++)
                {
                    minPrice[connectlist[city][i].city]
                        = Math.Min(price + connectlist[city][i].price, minPrice[connectlist[city][i].city]);
                }

                int index = startCity;
                int min = int.MaxValue;
                for (int i = 1; i <= N; i++)
                {
                    if (!visited[i])
                    {
                        if (min > minPrice[i])
                        {
                            min = minPrice[i];
                            index = i;
                        }
                    }
                }

                if (min == int.MaxValue)
                {
                    break;
                }

                queue.Enqueue((index, min));
                visited[index] = true;
            }


            print.WriteLine(minPrice[endCity]);

            reader.Close();
            print.Close();
        }
    }
}

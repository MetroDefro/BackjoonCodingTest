using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_1389
    {
        public No_1389()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();

            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            List<int>[] freinds = new List<int>[N + 1];

            for (int i = 1; i <= N; i++)
            {
                freinds[i] = new List<int>();
            }

            for (int i = 0; i < M; i++)
            {
                inputs = reader.ReadLine().Split();
                freinds[int.Parse(inputs[0])].Add(int.Parse(inputs[1]));
                freinds[int.Parse(inputs[1])].Add(int.Parse(inputs[0]));
            }

            int[] kevin = new int[N + 1];
            int min = 500000;
            int minIndex = 0;
            for (int i = 1; i <= N; i++)
            {
                BFS(kevin, i, freinds, i);

                if (min > kevin[i])
                {
                    min = kevin[i];
                    minIndex = i;
                }
            }

            print.WriteLine(minIndex);
        }

        private static void BFS(int[] kevin, int person, List<int>[] list, int id)
        {
            bool[] visited = new bool[list.Length];
            Queue<(int index, int depth)> queue = new Queue<(int, int)>();

            queue.Enqueue((id, 0));

            while (queue.Count > 0)
            {
                (int index, int depth) = queue.Dequeue();

                for (int i = 0; i < list[index].Count; i++)
                {
                    if (!visited[list[index][i]])
                        queue.Enqueue((list[index][i], depth + 1));
                }

                if (!visited[index])
                {
                    kevin[person] += depth;
                    visited[index] = true;
                }
            }
        }
    }
}

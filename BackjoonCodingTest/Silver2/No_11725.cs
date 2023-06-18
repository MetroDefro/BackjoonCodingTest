using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver2
{
    public class No_11725
    {
        public No_11725()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());

            List<int>[] tree = new List<int>[N + 1];
            int[] parents = new int[N + 1];
            for (int i = 0; i <= N; i++)
            {
                tree[i] = new List<int>();
                parents[i] = 1;
            }

            for (int i = 1; i < N; i++)
            {
                string[] inputs = reader.ReadLine().Split();
                tree[int.Parse(inputs[0])].Add(int.Parse(inputs[1]));
                tree[int.Parse(inputs[1])].Add(int.Parse(inputs[0]));
            }
            bool[] visited = new bool[N + 1];

            DFS(visited, tree, 1, 1, parents);
            for (int i = 2; i <= N; i++)
            {
                print.WriteLine(parents[i]);
            }
        }

        private static void DFS(bool[] visited, List<int>[] list, int id, int parentID, int[] parents)
        {
            if (!visited[id])
            {
                visited[id] = true;

                parents[id] = parentID;
                for (int i = 0; i < list[id].Count; i++)
                {
                    DFS(visited, list, list[id][i], id, parents);
                }
            }
        }
    }
}

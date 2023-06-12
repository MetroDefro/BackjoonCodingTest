using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_2606
    {
        public No_2606()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(reader.ReadLine());
            int pairCount = int.Parse(reader.ReadLine());

            List<int>[] computer = new List<int>[n + 1];
            for (int i = 1; i <= n; i++)
            {
                computer[i] = new List<int>();
            }

            for (int i = 1; i <= pairCount; i++)
            {
                string input = reader.ReadLine();
                computer[int.Parse(input.Split()[0])].Add(int.Parse(input.Split()[1]));
                computer[int.Parse(input.Split()[1])].Add(int.Parse(input.Split()[0]));
            }

            bool[] visited = new bool[n + 1];

            DFS(visited, computer, 1);

            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (visited[i])
                    count++;
            }

            print.WriteLine(count - 1);
        }

        private static void DFS(bool[] visited, List<int>[] computer, int id)
        {
            if (!visited[id])
            {
                visited[id] = true;
                for (int i = 0; i < computer[id].Count; i++)
                {
                    DFS(visited, computer, computer[id][i]);
                }
            }
        }
    }
}

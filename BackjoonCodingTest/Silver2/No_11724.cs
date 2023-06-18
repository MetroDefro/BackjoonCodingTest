using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver2
{
    public class No_11724
    {
        public No_11724()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();

            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            List<int>[] nums = new List<int>[N + 1];
            for (int i = 1; i <= N; i++)
            {
                nums[i] = new List<int>();
            }

            for (int i = 0; i < M; i++)
            {
                inputs = reader.ReadLine().Split();
                nums[int.Parse(inputs[0])].Add(int.Parse(inputs[1]));
                nums[int.Parse(inputs[1])].Add(int.Parse(inputs[0]));
            }

            bool[] visited = new bool[N + 1];
            int count = 0;
            for (int i = 1; i <= N; i++)
            {
                if (!visited[i])
                {
                    DFS(visited, nums, i);
                    count++;
                }
            }

            print.WriteLine(count);
        }

        private static void DFS(bool[] visited, List<int>[] list, int id)
        {
            if (!visited[id])
            {
                visited[id] = true;
                for (int i = 0; i < list[id].Count; i++)
                {
                    DFS(visited, list, list[id][i]);
                }
            }
        }
    }
}

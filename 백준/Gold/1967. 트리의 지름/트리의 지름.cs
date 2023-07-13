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

            int n = int.Parse(reader.ReadLine());

            Tree[] trees = new Tree[n + 1];
            for(int i = 1; i <= n; i++)
            {
                trees[i] = new Tree();
                trees[i].Num = i;
            }

            trees[1].Parent = (trees[1], 0);

            for (int i = 1; i < n; i++)
            {
                string[] inputs = reader.ReadLine().Split();

                trees[int.Parse(inputs[0])].Childe.Add((trees[int.Parse(inputs[1])], int.Parse(inputs[2])));
                trees[int.Parse(inputs[1])].Parent = (trees[int.Parse(inputs[0])], int.Parse(inputs[2]));
            }

            int max = 0;
            for (int i = 1; i <= n; i++)
            {
                bool[] visited = new bool[n + 1];
                DFS(visited, trees[i], 0);
            }

            void DFS(bool[] visited, Tree node, int sum)
            {
                if (!visited[node.Num])
                {
                    max = Math.Max(max, sum);
                    visited[node.Num] = true;

                    DFS(visited, node.Parent.node, sum + node.Parent.distance);
                    int count = node.Childe.Count;
                    for(int i = 0; i < count; i++)
                    {
                        DFS(visited, node.Childe[i].node, sum + node.Childe[i].distance);
                    }
                }
            }

            print.WriteLine(max);

            reader.Close();
            print.Close();
        }
    }

    class Tree
    {
        public int Num { get; set; }
        public (Tree node, int distance) Parent { get; set; }
        public List<(Tree node, int distance)> Childe = new List<(Tree node, int distance)>();
    }
}
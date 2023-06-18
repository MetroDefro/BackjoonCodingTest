using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver2
{
    public class No_1260
    {
        public No_1260()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();

            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            int V = int.Parse(inputs[2]);

            List<int>[] vertices = new List<int>[N + 1];

            for (int i = 1; i <= N; i++)
            {
                vertices[i] = new List<int>();
            }

            for (int i = 0; i < M; i++)
            {
                inputs = reader.ReadLine().Split();
                vertices[int.Parse(inputs[0])].Add(int.Parse(inputs[1]));
                vertices[int.Parse(inputs[1])].Add(int.Parse(inputs[0]));
            }

            for (int i = 1; i <= N; i++)
            {
                vertices[i] = Sort(vertices[i]);
            }


            bool[] visited = new bool[N + 1];

            DFS(visited, vertices, V);
            print.WriteLine();
            BFS(vertices, V);


            void DFS(bool[] visited, List<int>[] list, int id)
            {
                if (!visited[id])
                {
                    visited[id] = true;
                    print.Write(id + " ");

                    for (int i = 0; i < list[id].Count; i++)
                    {
                        DFS(visited, list, list[id][i]);
                    }
                }
            }

            void BFS(List<int>[] list, int id)
            {
                bool[] visited = new bool[list.Length];
                Queue<int> queue = new Queue<int>();

                queue.Enqueue(id);

                while (queue.Count > 0)
                {
                    int index = queue.Dequeue();

                    for (int i = 0; i < list[index].Count; i++)
                    {
                        if (!visited[list[index][i]])
                            queue.Enqueue(list[index][i]);
                    }

                    if (!visited[index])
                    {
                        visited[index] = true;
                        print.Write(index + " ");
                    }
                }
            }
        }

        private static List<int> Sort(List<int> array)
        {
            array = Divide(array, array.Count);

            return array;
        }

        private static List<int> Divide(List<int> list, int count)
        {
            int harfCount = count / 2;

            List<int> divideListLeft = new List<int>();
            for (int i = 0; i < harfCount; i++)
            {
                divideListLeft.Add(list[i]);
            }

            if (harfCount > 1)
            {
                divideListLeft = Divide(divideListLeft, harfCount);
            }

            List<int> divideListRight = new List<int>();
            for (int i = 0; i < count - harfCount; i++)
            {
                divideListRight.Add(list[harfCount + i]);
            }

            if (count - harfCount > 1)
            {
                divideListRight = Divide(divideListRight, count - harfCount);
            }


            return Merge(divideListLeft, divideListRight, divideListLeft.Count, divideListRight.Count);
        }

        private static List<int> Merge(List<int> leftList, List<int> rightList, int leftListCount, int rightListCount)
        {
            List<int> list = new List<int>();

            int leftIndex = 0;
            int rightIndex = 0;
            int mergeIndex = 0;
            while (leftIndex < leftListCount && rightIndex < rightListCount)
            {
                if (leftList[leftIndex] < rightList[rightIndex])
                {
                    list.Add(leftList[leftIndex++]);
                }
                else
                {
                    list.Add(rightList[rightIndex++]);
                }
            }

            while (leftIndex < leftListCount)
            {
                list.Add(leftList[leftIndex++]);
            }

            while (rightIndex < rightListCount)
            {
                list.Add(rightList[rightIndex++]);
            }

            return list;
        }
    }
}

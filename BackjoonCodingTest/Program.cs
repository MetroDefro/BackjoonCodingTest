using System;
using System.Collections.Generic;
using System.Text;

namespace BackjoonCodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();

            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            List<int>[] hackList = new List<int>[N + 1];
            for(int i = 0; i < N + 1; i++)
            {
                hackList[i] = new List<int>();
            }

            for(int i = 0; i < M; i++)
            {
                inputs = reader.ReadLine().Split();
                hackList[int.Parse(inputs[1])].Add(int.Parse(inputs[0]));
            }

            (int, int)[] hackedComputers = new (int, int)[N + 1];
            int hackedcount = 0;
            for(int i = 1; i < N + 1; i++)
            {
                hackedcount = 0;
                bool[] visited = new bool[N + 1];
                DFS(visited, i);
                hackedComputers[i] = (i, hackedcount);
            }

            hackedComputers = Sort(hackedComputers);

            int max = hackedComputers[0].Item2;

            StringBuilder stringBuilder = new StringBuilder();
            for(int i = 0; i < N; i++)
            {
                if (max > hackedComputers[i].Item2)
                    break;

                stringBuilder.Append(hackedComputers[i].Item1 + " ");
            }

            print.WriteLine(stringBuilder.ToString());

            void DFS(bool[] visited, int index)
            {
                if (!visited[index])
                {
                    visited[index]= true;
                    hackedcount++;

                    int count = hackList[index].Count;
                    for(int i = 0; i < count; i++)
                    {
                        DFS(visited, hackList[index][i]);
                    }
                }
            }

            reader.Close();
            print.Close();
        }

        private static (int, int)[] Sort((int, int)[] array)
        {
            array = Divide(array, array.Length);

            return array;
        }

        private static (int, int)[] Divide((int, int)[] list, int count)
        {
            int harfCount = count / 2;

            (int, int)[] divideListLeft = new (int, int)[harfCount];
            for (int i = 0; i < harfCount; i++)
            {
                divideListLeft[i] = list[i];
            }

            if (harfCount > 1)
            {
                divideListLeft = Divide(divideListLeft, harfCount);
            }

            (int, int)[] divideListRight = new (int, int)[count - harfCount];
            for (int i = 0; i < count - harfCount; i++)
            {
                divideListRight[i] = list[harfCount + i];
            }

            if (count - harfCount > 1)
            {
                divideListRight = Divide(divideListRight, count - harfCount);
            }


            return Merge(divideListLeft, divideListRight, divideListLeft.Length, divideListRight.Length);
        }

        private static (int, int)[] Merge((int, int)[] leftList, (int, int)[] rightList, int leftListCount, int rightListCount)
        {
            (int, int)[] list = new (int, int)[leftListCount + rightListCount];

            int leftIndex = 0;
            int rightIndex = 0;
            int mergeIndex = 0;
            while (leftIndex < leftListCount && rightIndex < rightListCount)
            {
                if (leftList[leftIndex].Item2 > rightList[rightIndex].Item2)
                {
                    list[mergeIndex++] = leftList[leftIndex++];
                }
                else if(leftList[leftIndex].Item2 < rightList[rightIndex].Item2)
                {
                    list[mergeIndex++] = rightList[rightIndex++];
                }
                else
                {
                    if(leftList[leftIndex].Item1 < rightList[rightIndex].Item1)
                    {
                        list[mergeIndex++] = leftList[leftIndex++];
                    }
                    else
                    {
                        list[mergeIndex++] = rightList[rightIndex++];
                    }
                }
            }

            while (leftIndex < leftListCount)
            {
                list[mergeIndex++] = leftList[leftIndex++];
            }

            while (rightIndex < rightListCount)
            {
                list[mergeIndex++] = rightList[rightIndex++];
            }

            return list;
        }
    }
}
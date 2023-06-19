using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_2667
    {
        static int count = 0;

        public No_2667()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());

            int[,] map = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                string input = reader.ReadLine();
                for (int j = 0; j < N; j++)
                {
                    map[j, i] = input[j] - '0';
                }
            }

            bool[,] visited = new bool[N, N];

            int townCount = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (map[j, i] == 1)
                    {
                        if (!visited[j, i])
                        {
                            townCount++;
                            count = 0;
                            DFS(visited, map, j, i, N);
                            list.Add(count);
                        }
                    }
                }
            }

            print.WriteLine(townCount);

            int[] result = list.ToArray();

            result = Sort(result);

            int length = result.Length;
            for (int i = 0; i < length; i++)
            {
                print.WriteLine(result[i]);
            }
        }

        private static int[] Sort(int[] array)
        {
            array = Divide(array, array.Length);

            return array;
        }

        private static int[] Divide(int[] list, int count)
        {
            int harfCount = count / 2;

            int[] divideListLeft = new int[harfCount];
            for (int i = 0; i < harfCount; i++)
            {
                divideListLeft[i] = list[i];
            }

            if (harfCount > 1)
            {
                divideListLeft = Divide(divideListLeft, harfCount);
            }

            int[] divideListRight = new int[count - harfCount];
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

        private static int[] Merge(int[] leftList, int[] rightList, int leftListCount, int rightListCount)
        {
            int[] list = new int[leftListCount + rightListCount];

            int leftIndex = 0;
            int rightIndex = 0;
            int mergeIndex = 0;
            while (leftIndex < leftListCount && rightIndex < rightListCount)
            {
                if (leftList[leftIndex] < rightList[rightIndex])
                {
                    list[mergeIndex++] = leftList[leftIndex++];
                }
                else
                {
                    list[mergeIndex++] = rightList[rightIndex++];
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
        private static void DFS(bool[,] visited, int[,] list, int x, int y, int N)
        {
            if (!visited[x, y])
            {
                visited[x, y] = true;
                count++;

                if (x + 1 < N && list[x + 1, y] == 1)
                {
                    DFS(visited, list, x + 1, y, N);
                }
                if (y + 1 < N && list[x, y + 1] == 1)
                {
                    DFS(visited, list, x, y + 1, N);
                }
                if (x > 0 && list[x - 1, y] == 1)
                {
                    DFS(visited, list, x - 1, y, N);
                }
                if (y > 0 && list[x, y - 1] == 1)
                {
                    DFS(visited, list, x, y - 1, N);
                }
            }
        }
    }
}

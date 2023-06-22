using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_2583
    {
        public No_2583()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int M = int.Parse(inputs[0]);
            int N = int.Parse(inputs[1]);
            int K = int.Parse(inputs[2]);

            (int x1, int y1, int x2, int y2)[] square = new (int, int, int, int)[K];
            for (int i = 0; i < K; i++)
            {
                inputs = reader.ReadLine().Split();
                square[i] = (int.Parse(inputs[0]), int.Parse(inputs[1]), int.Parse(inputs[2]), int.Parse(inputs[3]));
            }

            bool[,] visited = new bool[N, M];
            for (int k = 0; k < K; k++)
            {
                for (int i = square[k].x1; i < square[k].x2; i++)
                {
                    for (int j = square[k].y1; j < square[k].y2; j++)
                    {
                        visited[i, j] = true;
                    }
                }
            }

            int[] addedX = { -1, 0, +1, 0 };
            int[] addedY = { 0, -1, 0, +1 };

            int count = 0;
            int areaCount = 0;
            List<int> area = new List<int>();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (!visited[i, j])
                    {
                        visited[i, j] = true;
                        areaCount = 1;
                        DFS(i, j);
                        count++;
                        area.Add(areaCount);
                    }
                }
            }

            int[] areaArray = Sort(area.ToArray());

            print.WriteLine(count);
            for (int i = 0; i < areaArray.Length; i++)
            {
                print.Write(areaArray[i] + " ");
            }

            reader.Close();
            print.Close();

            void DFS(int x, int y)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (x + addedX[i] > -1 && y + addedY[i] > -1 && x + addedX[i] < N && y + addedY[i] < M)
                    {
                        if (!visited[x + addedX[i], y + addedY[i]])
                        {
                            visited[x + addedX[i], y + addedY[i]] = true;
                            areaCount++;
                            DFS(x + addedX[i], y + addedY[i]);
                        }
                    }
                }
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
    }
}

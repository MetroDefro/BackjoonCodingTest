using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver3
{
    public class No_15657
    {
        public No_15657()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int n = int.Parse(input.Split()[0]);
            int m = int.Parse(input.Split()[1]);

            int[] nums = new int[n];
            string[] inputs = reader.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(inputs[i]);
            }

            nums = Sort(nums);

            int[] list = new int[m];
            DFS(0, 0);

            void DFS(int depth, int prev)
            {
                if (depth == m)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    for (int i = 0; i < m; i++)
                        stringBuilder.Append(list[i] + " ");
                    print.WriteLine(stringBuilder.ToString());

                    return;
                }
                for (int i = 0; i < n; i++)
                {
                    if (i >= prev)
                    {
                        list[depth] = nums[i];

                        DFS(depth + 1, i);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Gold5
{
    public class No_1759
    {
        public No_1759()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int L = int.Parse(input.Split()[0]);
            int c = int.Parse(input.Split()[1]);

            string[] strs = new string[c];
            string[] inputs = reader.ReadLine().Split();
            for (int i = 0; i < c; i++)
            {
                strs[i] = inputs[i];
            }

            strs = Sort(strs);

            string[] list = new string[L];
            DFS(0, -1, 0, 0);

            void DFS(int depth, int prev, int countA, int countB)
            {
                if (depth == L)
                {
                    if (countA < 1 || countB < 2)
                        return;

                    StringBuilder stringBuilder = new StringBuilder();
                    for (int i = 0; i < L; i++)
                        stringBuilder.Append(list[i]);
                    print.WriteLine(stringBuilder.ToString());

                    return;
                }
                for (int i = 0; i < c; i++)
                {
                    if (i > prev)
                    {
                        list[depth] = strs[i];
                        if (strs[i] == "a" || strs[i] == "e" || strs[i] == "i" || strs[i] == "o" || strs[i] == "u")
                            DFS(depth + 1, i, countA + 1, countB);
                        else
                            DFS(depth + 1, i, countA, countB + 1);
                    }
                }
            }

            reader.Close();
            print.Close();
        }

        private static string[] Sort(string[] array)
        {
            array = Divide(array, array.Length);

            return array;
        }

        private static string[] Divide(string[] list, int count)
        {
            int harfCount = count / 2;

            string[] divideListLeft = new string[harfCount];
            for (int i = 0; i < harfCount; i++)
            {
                divideListLeft[i] = list[i];
            }

            if (harfCount > 1)
            {
                divideListLeft = Divide(divideListLeft, harfCount);
            }

            string[] divideListRight = new string[count - harfCount];
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

        private static string[] Merge(string[] leftList, string[] rightList, int leftListCount, int rightListCount)
        {
            string[] list = new string[leftListCount + rightListCount];

            int leftIndex = 0;
            int rightIndex = 0;
            int mergeIndex = 0;
            while (leftIndex < leftListCount && rightIndex < rightListCount)
            {
                if (leftList[leftIndex][0] < rightList[rightIndex][0])
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

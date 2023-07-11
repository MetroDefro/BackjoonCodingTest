using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Gold5
{
    public class No_2467
    {
        public No_2467()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());
            string[] inputs = reader.ReadLine().Split();

            int[] solutions = new int[N];
            for (int i = 0; i < N; i++)
            {
                solutions[i] = int.Parse(inputs[i]);
            }

            solutions = Sort(solutions);
            (int a, int b) = BinarySearch(solutions);

            print.WriteLine(a + " " + b);

            reader.Close();
            print.Close();
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

        private static (int, int) BinarySearch(int[] list)
        {
            int start = 0;
            int end = list.Length - 1;

            int min = Math.Abs(list[start] + list[end]);
            int minStart = list[start];
            int minEnd = list[end];
            while (start < end)
            {
                int distance = list[start] + list[end];
                int Absolutedistance = Math.Abs(list[start] + list[end]);
                if (Absolutedistance < min)
                {
                    min = Absolutedistance;
                    minStart = list[start];
                    minEnd = list[end];
                }

                if (distance < 0)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }

            return (minStart, minEnd);
        }
    }
}

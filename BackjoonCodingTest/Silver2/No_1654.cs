using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver2
{
    public class No_1654
    {
        public No_1654()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int k = int.Parse(input.Split()[0]);
            int n = int.Parse(input.Split()[1]);

            int[] lines = new int[k];
            for (int i = 0; i < k; i++)
            {
                lines[i] = int.Parse(reader.ReadLine());
            }

            lines = Sort(lines);

            long max = 0;

            for (int i = 0; i < k; i++)
            {
                max += lines[i];
            }

            max /= n;

            print.WriteLine(BinarySearch(lines, n, (int)max));
        }

        private static int BinarySearch(int[] list, int target, long max)
        {
            long start = 1;
            long end = max + 1;
            long mid = (end + start) / 2;

            long count = 0;
            int listLength = list.Length;
            while (start <= end)
            {
                count = 0;
                for (int i = 0; i < listLength; i++)
                {
                    count += list[i] / mid;
                }

                if (count >= target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
                mid = (end + start) / 2;
            }

            return (int)mid;
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

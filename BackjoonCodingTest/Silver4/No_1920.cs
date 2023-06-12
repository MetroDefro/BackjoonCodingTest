using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver4
{
    public class No_1920
    {
        public No_1920()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int N = int.Parse(input);

            input = reader.ReadLine();
            string[] numsString = input.Split();
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(numsString[i]);
            }

            input = reader.ReadLine();
            int M = int.Parse(input);

            input = reader.ReadLine();
            numsString = input.Split();
            int[] nums = new int[M];
            for (int i = 0; i < M; i++)
            {
                nums[i] = int.Parse(numsString[i]);
            }

            A = Sort(A);

            for (int i = 0; i < M; i++)
            {
                print.WriteLine(BinarySearch(A, nums[i]));
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

        private static int BinarySearch(int[] list, int target)
        {
            int start = 0;
            int end = list.Length - 1;
            int mid = (end + start) / 2;

            while (start <= end)
            {
                if (list[mid] == target)
                {
                    return 1;
                }
                else if (list[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
                mid = (end + start) / 2;
            }

            return 0;
        }
    }
}

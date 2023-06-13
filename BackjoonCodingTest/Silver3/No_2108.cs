using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver3
{
    public class No_2108
    {
        public No_2108()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int N = int.Parse(input);

            int[] nums = new int[N];
            for (int i = 0; i < N; i++)
            {
                nums[i] = int.Parse(reader.ReadLine());
            }

            nums = Sort(nums);

            int sum = 0;
            int min = 4000;
            int max = -4000;
            int[] counts = new int[8001];
            for (int i = 0; i < N; i++)
            {
                sum += nums[i];
                if (nums[i] > max)
                    max = nums[i];
                if (nums[i] < min)
                    min = nums[i];

                counts[nums[i] + 4000]++;
            }

            int maxCount = 0;
            int maxCountIndex = 0;
            bool isIndexSmall = true;
            for (int i = 0; i < 8001; i++)
            {
                if (maxCount < counts[i])
                {
                    maxCount = counts[i];
                    maxCountIndex = i;
                }
            }

            for (int i = 0; i < 8001; i++)
            {
                if (maxCount == counts[i])
                {
                    if (maxCountIndex < i)
                    {
                        maxCount = counts[i];
                        maxCountIndex = i;
                        break;
                    }
                }
            }

            double temp = (double)sum / N;
            int avg = (int)temp;

            if (temp >= 0)
            {
                if (temp - avg >= 0.5)
                {
                    avg++;
                }
            }
            else
            {
                if (temp - avg <= -0.5)
                {
                    avg--;
                }
            }

            int midIndex = N / 2;
            int mid = nums[midIndex];

            print.WriteLine(avg);
            print.WriteLine(mid);
            print.WriteLine(maxCountIndex - 4000);
            print.WriteLine(max - min);
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

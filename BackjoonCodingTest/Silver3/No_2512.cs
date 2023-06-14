using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver3
{
    public class No_2512
    {
        public No_2512()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(reader.ReadLine());

            string[] inputs = reader.ReadLine().Split();
            int[] province = new int[n];
            for (int i = 0; i < n; i++)
            {
                province[i] = int.Parse(inputs[i]);
            }

            int m = int.Parse(reader.ReadLine());

            province = Sort(province);

            long sum = 0;
            int index = n - 1;
            int price = province[index];
            for (int i = 0; i < n; i++)
            {
                sum += province[i];
            }

            if (sum > m)
            {
                while (true)
                {
                    sum = 0;
                    for (int i = 0; i < index; i++)
                    {
                        sum += province[i];
                    }

                    sum += price * (n - index);
                    if (sum > m)
                    {
                        index--;
                        if (index < 0)
                        {
                            price = m / n;
                            break;
                        }

                        price = province[index];
                    }
                    else
                    {
                        if (sum < m)
                        {
                            int remain = m - (int)sum;

                            price += remain / (n - index - 1);
                        }
                        break;
                    }
                }
            }

            print.WriteLine(price);
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

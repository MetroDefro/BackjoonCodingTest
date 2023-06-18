using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver2
{
    public class No_18870
    {
        public No_18870()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());

            string[] inputs = reader.ReadLine().Split();

            int[] vectors = new int[N];
            for (int i = 0; i < N; i++)
            {
                vectors[i] = int.Parse(inputs[i]);
            }

            Dictionary<int, int> dictionary = Dedupe(Sort(vectors));

            for (int i = 0; i < N; i++)
            {
                print.Write(dictionary[vectors[i]] + " ");
            }
        }

        private static Dictionary<int, int> Dedupe(int[] array)
        {
            int length = array.Length;
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            int count = 0;

            dictionary.Add(array[0], count);
            int prevNum = array[0];
            count++;
            for (int i = 1; i < length; i++)
            {
                if (array[i] != prevNum)
                {
                    dictionary.Add(array[i], count);
                    prevNum = array[i];
                    count++;
                }
            }

            return dictionary;
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

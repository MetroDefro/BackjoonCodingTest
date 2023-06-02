using System;
using System.Collections.Generic;

namespace BackjoonCodingTest
{
    public class No_1181
    {
        public No_1181()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            short count = short.Parse(input);
            string[] words = new string[count];

            for (int i = 0; i < count; i++)
            {
                words[i] = reader.ReadLine();
            }

            words = Sort(words);

            for (int i = 0; i < words.Length; i++)
            {
                print.WriteLine(words[i]);
            }
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
            List<string> list = new List<string>();

            int leftIndex = 0;
            int rightIndex = 0;
            while (leftIndex < leftListCount && rightIndex < rightListCount)
            {
                if (leftList[leftIndex].Length < rightList[rightIndex].Length)
                {
                    list.Add(leftList[leftIndex++]);
                }
                else if (leftList[leftIndex].Length > rightList[rightIndex].Length)
                {
                    list.Add(rightList[rightIndex++]);
                }
                else
                {
                    int length = leftList[leftIndex].Length;
                    for (int i = 0; i < length; i++)
                    {
                        if (leftList[leftIndex][i] < rightList[rightIndex][i])
                        {
                            list.Add(leftList[leftIndex++]);
                            break;
                        }
                        else if (leftList[leftIndex][i] > rightList[rightIndex][i])
                        {
                            list.Add(rightList[rightIndex++]);
                            break;
                        }

                        if (i == length - 1)
                        {
                            list.Add(leftList[leftIndex++]);
                            rightIndex++;
                            break;
                        }
                    }
                }
            }

            while (leftIndex < leftListCount)
            {
                list.Add(leftList[leftIndex++]);
            }

            while (rightIndex < rightListCount)
            {
                list.Add(rightList[rightIndex++]);
            }

            return list.ToArray();
        }
    }
}

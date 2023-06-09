using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver5
{
    public class No_11651
    {
        public No_11651()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int N = int.Parse(input);

            (int x, int y)[] coord = new (int x, int y)[N];

            for (int i = 0; i < N; i++)
            {
                input = reader.ReadLine();
                coord[i] = (int.Parse(input.Split()[0]), int.Parse(input.Split()[1]));
            }

            coord = Sort(coord);

            for (int i = 0; i < coord.Length; i++)
            {
                print.WriteLine(coord[i].x + " " + coord[i].y);
            }
        }

        private static (int x, int y)[] Sort((int x, int y)[] array)
        {
            array = Divide(array, array.Length);

            return array;
        }

        private static (int x, int y)[] Divide((int x, int y)[] list, int count)
        {
            int harfCount = count / 2;

            (int x, int y)[] divideListLeft = new (int x, int y)[harfCount];
            for (int i = 0; i < harfCount; i++)
            {
                divideListLeft[i] = list[i];
            }

            if (harfCount > 1)
            {
                divideListLeft = Divide(divideListLeft, harfCount);
            }

            (int x, int y)[] divideListRight = new (int x, int y)[count - harfCount];
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

        private static (int x, int y)[] Merge((int x, int y)[] leftList, (int x, int y)[] rightList, int leftListCount, int rightListCount)
        {
            (int x, int y)[] list = new (int x, int y)[leftListCount + rightListCount];

            int leftIndex = 0;
            int rightIndex = 0;
            int mergeIndex = 0;
            while (leftIndex < leftListCount && rightIndex < rightListCount)
            {
                if (leftList[leftIndex].y < rightList[rightIndex].y)
                {
                    list[mergeIndex++] = leftList[leftIndex++];
                }
                else if (leftList[leftIndex].y > rightList[rightIndex].y)
                {
                    list[mergeIndex++] = rightList[rightIndex++];
                }
                else
                {
                    if (leftList[leftIndex].x < rightList[rightIndex].x)
                    {
                        list[mergeIndex++] = leftList[leftIndex++];
                    }
                    else if (leftList[leftIndex].x > rightList[rightIndex].x)
                    {
                        list[mergeIndex++] = rightList[rightIndex++];
                    }
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

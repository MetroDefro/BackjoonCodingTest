using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_1931
    {
        public No_1931()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());
            List<(int start, int end)> times = new List<(int, int)>();
            for (int i = 0; i < N; i++)
            {
                string[] inputs = reader.ReadLine().Split();

                times.Add((int.Parse(inputs[0]), int.Parse(inputs[1])));
            }

            times = Sort(times);

            int length = times.Count;

            int count = 0;
            int prevEnd = 0;
            for (int i = 0; i < length; i++)
            {
                if (times[i].start >= prevEnd)
                {
                    count++;
                    prevEnd = times[i].end;
                }
            }

            print.WriteLine(count);
        }

        private static List<(int, int)> Sort(List<(int, int)> array)
        {
            array = Divide(array, array.Count);

            return array;
        }

        private static List<(int, int)> Divide(List<(int, int)> list, int count)
        {
            int harfCount = count / 2;

            List<(int, int)> divideListLeft = new List<(int, int)>();
            for (int i = 0; i < harfCount; i++)
            {
                divideListLeft.Add(list[i]);
            }

            if (harfCount > 1)
            {
                divideListLeft = Divide(divideListLeft, harfCount);
            }

            List<(int, int)> divideListRight = new List<(int, int)>();
            for (int i = 0; i < count - harfCount; i++)
            {
                divideListRight.Add(list[harfCount + i]);
            }

            if (count - harfCount > 1)
            {
                divideListRight = Divide(divideListRight, count - harfCount);
            }


            return Merge(divideListLeft, divideListRight, divideListLeft.Count, divideListRight.Count);
        }

        private static List<(int, int)> Merge(List<(int, int)> leftList, List<(int, int)> rightList, int leftListCount, int rightListCount)
        {
            List<(int, int)> list = new List<(int, int)>();

            int leftIndex = 0;
            int rightIndex = 0;
            while (leftIndex < leftListCount && rightIndex < rightListCount)
            {
                if (leftList[leftIndex].Item2 == rightList[rightIndex].Item2)
                {
                    if (leftList[leftIndex].Item1 < rightList[rightIndex].Item1)
                    {
                        list.Add(leftList[leftIndex++]);
                    }
                    else
                    {
                        list.Add(rightList[rightIndex++]);
                    }
                }
                else if (leftList[leftIndex].Item2 < rightList[rightIndex].Item2)
                {
                    list.Add(leftList[leftIndex++]);
                }
                else
                {
                    list.Add(rightList[rightIndex++]);
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

            return list;
        }
    }
}

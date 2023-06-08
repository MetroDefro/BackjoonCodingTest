using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_10814
    {
        public No_10814()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int N = int.Parse(input);
            (int age, string name)[] datas = new (int, string)[N];

            for (int i = 0; i < N; i++)
            {
                input = reader.ReadLine();
                datas[i] = (int.Parse(input.Split()[0]), input.Split()[1]);
            }

            datas = Sort(datas);

            for (int i = 0; i < datas.Length; i++)
            {
                print.WriteLine(datas[i].age + " " + datas[i].name);
            }
        }

        private static (int age, string name)[] Sort((int age, string name)[] array)
        {
            array = Divide(array, array.Length);

            return array;
        }

        private static (int age, string name)[] Divide((int age, string name)[] list, int count)
        {
            int harfCount = count / 2;

            (int age, string name)[] divideListLeft = new (int age, string name)[harfCount];
            for (int i = 0; i < harfCount; i++)
            {
                divideListLeft[i] = list[i];
            }

            if (harfCount > 1)
            {
                divideListLeft = Divide(divideListLeft, harfCount);
            }

            (int age, string name)[] divideListRight = new (int age, string name)[count - harfCount];
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

        private static (int age, string name)[] Merge((int age, string name)[] leftList, (int age, string name)[] rightList, int leftListCount, int rightListCount)
        {
            (int age, string name)[] list = new (int age, string name)[leftListCount + rightListCount];

            int leftIndex = 0;
            int rightIndex = 0;
            int mergeIndex = 0;
            while (leftIndex < leftListCount && rightIndex < rightListCount)
            {
                if (leftList[leftIndex].age < rightList[rightIndex].age)
                {
                    list[mergeIndex++] = leftList[leftIndex++];
                }
                else if (leftList[leftIndex].age > rightList[rightIndex].age)
                {
                    list[mergeIndex++] = rightList[rightIndex++];
                }
                else
                {
                    list[mergeIndex++] = leftList[leftIndex++];
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

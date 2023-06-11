using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_1764
    {
        public No_1764()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int N = int.Parse(input.Split()[0]);
            int M = int.Parse(input.Split()[1]);

            string[] noSee = new string[N];
            string[] noHear = new string[M];


            List<string> results = new List<string>();
            for (int i = 0; i < N; i++)
            {
                noSee[i] = reader.ReadLine();
            }

            for (int i = 0; i < M; i++)
            {
                noHear[i] = reader.ReadLine();
            }

            noHear = Sort(noHear);
            noSee = Sort(noSee);

            for (int i = 0; i < N; i++)
            {
                if (BinarySearch(noHear, noSee[i]))
                {
                    results.Add(noSee[i]);
                }
            }

            int count = results.Count;
            print.WriteLine(count);
            for (int i = 0; i < count; i++)
            {
                print.WriteLine(results[i]);
            }
        }

        private static bool BinarySearch(string[] list, string target)
        {
            int start = 0;
            int end = list.Length - 1;
            int mid = (end + start) / 2;
            int length;
            while (start <= end)
            {
                if (list[mid] == target)
                {
                    return true;
                }
                else
                {
                    if (list[mid].Length > target.Length)
                    {
                        length = target.Length;
                        for (int i = 0; i < length; i++)
                        {
                            if (list[mid][i] > target[i])
                            {
                                end = mid - 1;
                                break;
                            }
                            else if ((list[mid][i] < target[i]))
                            {
                                start = mid + 1;
                                break;
                            }

                            if (i == length - 1)
                            {
                                end = mid - 1;
                                break;
                            }
                        }
                    }
                    else
                    {
                        length = list[mid].Length;
                        for (int i = 0; i < length; i++)
                        {
                            if (list[mid][i] > target[i])
                            {
                                end = mid - 1;
                                break;
                            }
                            else if ((list[mid][i] < target[i]))
                            {
                                start = mid + 1;
                                break;
                            }

                            if (i == length - 1)
                            {
                                start = mid + 1;
                                break;
                            }
                        }
                    }

                }
                mid = (end + start) / 2;
            }

            return false;
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
            int length = 0;
            while (leftIndex < leftListCount && rightIndex < rightListCount)
            {
                if (leftList[leftIndex].Length < rightList[rightIndex].Length)
                {
                    length = leftList[leftIndex].Length;
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
                            break;
                        }
                    }
                }
                else
                {
                    length = rightList[rightIndex].Length;
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
                            list.Add(rightList[rightIndex++]);
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

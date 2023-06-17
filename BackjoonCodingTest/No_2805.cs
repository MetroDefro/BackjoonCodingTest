using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_2805
    {
        public No_2805()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            inputs = reader.ReadLine().Split();

            int max = 0;
            int[] trees = new int[N];
            for (int i = 0; i < N; i++)
            {
                trees[i] = int.Parse(inputs[i]);
                if (trees[i] > max)
                    max = trees[i];
            }

            print.WriteLine(BinarySearch(trees, M, max));
        }

        private static int BinarySearch(int[] list, int target, int max)
        {
            int start = 0;
            int end = max;
            int mid = (end + start) / 2;

            while (start <= end)
            {
                long sum = 0;
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i] > mid)
                        sum += (list[i] - mid);
                }

                if (sum == target)
                {
                    return mid;
                }
                else if (sum > target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
                mid = (end + start) / 2;
            }


            return mid;
        }
    }
}

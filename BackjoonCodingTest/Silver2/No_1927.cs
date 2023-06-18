using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver2
{
    public class No_1927
    {
        static int[] heap = new int[100001];
        static int heapSize = 0;
        public No_1927()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(reader.ReadLine());


            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(reader.ReadLine());
                if (input == 0)
                    print.WriteLine(Delete());
                else
                    Insert(input);

            }
        }
        private static void Insert(int x)
        {
            int hear = ++heapSize;
            while (hear != 1)
            {
                if (x < heap[hear / 2])
                {
                    heap[hear] = heap[hear / 2];
                    hear /= 2;
                }
                else
                    break;
            }

            heap[hear] = x;
        }

        private static int Delete()
        {
            if (heapSize == 0)
                return 0;

            int result = heap[1];
            heap[1] = heap[heapSize];
            int parent = 1;
            int child;
            while (true)
            {
                child = parent * 2;
                if (child + 1 <= heapSize && heap[child] > heap[child + 1])
                    child++;

                if (child > heapSize || heap[child] > heap[parent])
                {
                    break;
                }

                int temp = heap[parent];
                heap[parent] = heap[child];
                heap[child] = temp;


                parent = child;
            }

            heapSize--;

            return result;
        }
    }
}

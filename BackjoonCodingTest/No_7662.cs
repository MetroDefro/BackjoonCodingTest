using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_7662
    {
        public No_7662()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int T = int.Parse(reader.ReadLine());
            for (int tc = 0; tc < T; tc++)
            {
                int k = int.Parse(reader.ReadLine());

                long[] MinHeap = new long[1000001];
                long[] MaxHeap = new long[1000001];
                int MinHeapSize = 0;
                int MaxHeapSize = 0;
                int heapSize = 0;
                Dictionary<long, int> visited = new Dictionary<long, int>();

                for (int i = 0; i < k; i++)
                {
                    string[] inputs = reader.ReadLine().Split();
                    if (inputs[0] == "I")
                    {
                        heapSize++;
                        MinHeapSize++;
                        MaxHeapSize++;
                        if (visited.ContainsKey(long.Parse(inputs[1])))
                            visited[long.Parse(inputs[1])]++;
                        else
                            visited.Add(long.Parse(inputs[1]), 1);
                        InsertMin(MinHeap, MinHeapSize, long.Parse(inputs[1]));
                        InsertMax(MaxHeap, MaxHeapSize, long.Parse(inputs[1]));
                    }
                    else
                    {
                        if (heapSize == 0)
                            continue;

                        if (inputs[1] == "1")
                        {
                            long num = 0;
                            while (MaxHeapSize != 0 && visited[num = MaxHeap[1]] == 0)
                            {
                                DeleteMax(MaxHeap, MaxHeapSize);
                                MaxHeapSize--;
                            }
                            visited[num]--;
                        }
                        else
                        {
                            long num = 0;
                            while (MinHeapSize != 0 && visited[num = MinHeap[1]] == 0)
                            {
                                DeleteMin(MinHeap, MinHeapSize);
                                MinHeapSize--;
                            }
                            visited[num]--;
                        }

                        heapSize--;
                    }
                }

                while (MaxHeapSize != 0 && visited[MaxHeap[1]] == 0)
                {
                    DeleteMax(MaxHeap, MaxHeapSize);
                    MaxHeapSize--;
                }

                while (MinHeapSize != 0 && visited[MinHeap[1]] == 0)
                {
                    DeleteMin(MinHeap, MinHeapSize);
                    MinHeapSize--;
                }

                if (heapSize == 0)
                    print.WriteLine("EMPTY");
                else
                    print.WriteLine(MaxHeap[1] + " " + MinHeap[1]);
            }
        }

        private static void InsertMin(long[] heap, int heapSize, long x)
        {
            int hear = heapSize;
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

        private static void InsertMax(long[] heap, int heapSize, long x)
        {
            int hear = heapSize;
            while (hear != 1)
            {
                if (x > heap[hear / 2])
                {
                    heap[hear] = heap[hear / 2];
                    hear /= 2;
                }
                else
                    break;
            }

            heap[hear] = x;
        }

        private static long DeleteMin(long[] heap, int heapSize)
        {
            if (heapSize == 0)
                return 0;

            long result = heap[1];
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

                long temp = heap[parent];
                heap[parent] = heap[child];
                heap[child] = temp;


                parent = child;
            }

            return result;
        }

        private static long DeleteMax(long[] heap, int heapSize)
        {
            if (heapSize == 0)
                return 0;

            long result = heap[1];
            heap[1] = heap[heapSize];
            int parent = 1;
            int child;
            while (true)
            {
                child = parent * 2;
                if (child + 1 <= heapSize && heap[child] < heap[child + 1])
                    child++;

                if (child > heapSize || heap[child] < heap[parent])
                {
                    break;
                }

                long temp = heap[parent];
                heap[parent] = heap[child];
                heap[child] = temp;


                parent = child;
            }

            return result;
        }
    }
}

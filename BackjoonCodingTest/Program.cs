using System;

namespace BackjoonCodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(reader.ReadLine());
            string[] inputs = reader.ReadLine().Split();
            int[] sums = new int[n];
            int[] nums = new int[n];
            sums[0] = int.Parse(inputs[0]);
            for (int i = 1; i < n; i++)
            {
                nums[i] = int.Parse(inputs[i]);
                sums[i] = sums[i - 1] + nums[i];
            }

            print.WriteLine(TwoPointer(sums, nums));

            reader.Close();
            print.Close();
        }

        private static int TwoPointer(int[] sums, int[] nums)
        {
            int end = sums.Length - 1;
            int start = 0;

            int max = Math.Max(sums[start], sums[end]);
            while (start < end)
            {
                int sum = sums[end] - sums[start];
                max = Math.Max(sum, max);

                if(sums[end - 1] - sums[start] > sums[end] - sums[start + 1])
                {
                    end--;
                }
                else
                {
                    start++;
                }
            }

            return max;
        }
    }
}



//using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
//using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

//string[] inputs = reader.ReadLine().Split();
//int M = int.Parse(inputs[0]);
//int N = int.Parse(inputs[1]);
//int H = int.Parse(inputs[2]);
//int[,,] tomatos = new int[M, N, H];
//for (int h = 0; h < H; h++)
//{
//    for (int n = 0; n < N; n++)
//    {
//        inputs = reader.ReadLine().Split();
//        for (int m = 0; m < M; m++)
//        {
//            tomatos[m, n, h] = int.Parse(inputs[m]);
//        }
//    }
//}

//reader.Close();
//print.Close();

//void BFS(int startX, int startY, int startH)
//{
//    bool[,,] visited = new bool[M, N, H];

//    Queue<(int x, int y, int h, int count)> queue = new Queue<(int x, int y, int h, int count)>();

//    visited[startX, startY, startH] = true;
//    queue.Enqueue((startX, startY, startH, 0));

//    int min = int.MaxValue;
//    while (queue.Count > 0)
//    {
//        (int x, int y, int h, int count) = queue.Dequeue();



//        if (x > 0 && !visited[x - 1, y, h])
//        {
//            visited[x - 1, y, h] = true;
//            queue.Enqueue((x - 1, y, h, count + 1));
//        }

//        if (y > 0 && !visited[x, y - 1, h])
//        {
//            visited[x, y - 1, h] = true;
//            queue.Enqueue((x, y - 1, h, count + 1));
//        }

//        if (h > 0 && !visited[x, y, h - 1])
//        {
//            visited[x, y, h - 1] = true;
//            queue.Enqueue((x, y, h - 1, count + 1));
//        }

//        if (x < M - 1 && !visited[x + 1, y, h])
//        {
//            visited[x + 1, y, h] = true;
//            queue.Enqueue((x + 1, y, h, count + 1));
//        }

//        if (y < N - 1 && !visited[x, y + 1, h])
//        {
//            visited[x, y + 1, h] = true;
//            queue.Enqueue((x, y + 1, h, count + 1));
//        }

//        if (h < H - 1 && !visited[x, y, h + 1])
//        {
//            visited[x, y, h + 1] = true;
//            queue.Enqueue((x, y, h + 1, count + 1));
//        }
//    }
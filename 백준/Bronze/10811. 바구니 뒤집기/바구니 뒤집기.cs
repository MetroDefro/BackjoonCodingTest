using System;

namespace BackjoonCodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            int[] nums = new int[N + 1];
            for(int i = 1; i <= N; i++)
            {
                nums[i] = i;
            }
            for(int i = 0; i < M; i++)
            {
                inputs = reader.ReadLine().Split();
                int start = int.Parse(inputs[0]);
                int end = int.Parse(inputs[1]);

                while(start < end)
                {
                    int temp = nums[start];
                    nums[start] = nums[end];
                    nums[end] = temp;

                    start++;
                    end--;
                }
            }

            for(int i = 1; i <= N; i++)
            {
                print.Write(nums[i] + " ");
            }

            reader.Close();
            print.Close();


        }
    }
}
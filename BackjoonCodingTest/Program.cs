using System;

namespace BackjoonCodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());
            string[] inputs = reader.ReadLine().Split();

            int[] nums = new int[N];
            for(int i = 0; i < N; i++)
            {
                nums[i] = int.Parse(inputs[i]);
            }

            int[] dp = new int[N];
            int max = 0;
            for( int i = 0; i < N; i++)
            {

            }
        }
    }
}
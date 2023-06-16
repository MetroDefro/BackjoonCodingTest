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

            int T = int.Parse(inputs[0]);

            inputs = reader.ReadLine().Split();

            int M = int.Parse(inputs[0]);
            int N = int.Parse(inputs[1]);
            int K = int.Parse(inputs[2]);

            bool[,] field = new bool[M, N]; 
            for (int i = 0; i < N; i++)
            {
                inputs = reader.ReadLine().Split();
                field[int.Parse(inputs[0]), int.Parse(inputs[1])] = true;


            }
        }
    }
}
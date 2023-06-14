using System;

namespace BackjoonCodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int L = int.Parse(reader.ReadLine());

            string input = reader.ReadLine();

            ulong sum = 0;
            for(int i = 0; i < L; i++)
            {
                char c = input[i];
                sum += (((ulong)c - 96) * (ulong)Math.Pow(31, i) )% (ulong)1234567891;
            }

            print.WriteLine(sum);
        }
    }
}
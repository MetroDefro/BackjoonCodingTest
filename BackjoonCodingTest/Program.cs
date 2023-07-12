using System;
using System.Collections.Generic;

namespace BackjoonCodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int V = int.Parse(inputs[0]);
            int E = int.Parse(inputs[1]);

            reader.Close();
            print.Close();
        }
    }
}
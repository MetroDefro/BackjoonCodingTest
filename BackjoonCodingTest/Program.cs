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

            while (true)
            {
                int n = int.Parse(reader.ReadLine());
                if (n == 0)
                    break;

            }

            reader.Close();
            print.Close();
        }
    }
}

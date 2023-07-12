using System;

namespace BackjoonCodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            bool[] student = new bool[30];
            for (int i = 0; i < 28; i++)
            {
                student[int.Parse(reader.ReadLine()) - 1] = true;
            }

            for(int i = 0; i < 30; i++)
            {
                if (!student[i])
                    print.WriteLine(i + 1);
            }

            reader.Close();
            print.Close();
        }
    }
}
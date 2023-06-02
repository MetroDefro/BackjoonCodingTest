using System;

namespace BackjoonCodingTest
{
    public class No_2741
    {
        public No_2741()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int num = int.Parse(input);

            for (int i = 1; i <= num; i++)
                print.WriteLine(i);
        }
    }
}

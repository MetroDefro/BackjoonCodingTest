using System;

namespace BackjoonCodingTest.Bronze1
{
    public class No_11050
    {
        public No_11050()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            byte N = byte.Parse(input.Split()[0]);
            byte K = byte.Parse(input.Split()[1]);

            int a = 1;
            for (int i = N; i > 0; i--)
                a *= i;

            int b = 1;
            for (int i = K; i > 0; i--)
                b *= i;

            int c = 1;
            for (int i = N - K; i > 0; i--)
                c *= i;

            int result = a / (b * c);
            print.WriteLine(result);
        }
    }
}

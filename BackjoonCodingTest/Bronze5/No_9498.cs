using System;

namespace BackjoonCodingTest.Bronze5
{
    public class No_9498
    {
        public No_9498()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            byte score = byte.Parse(input);
            if (90 <= score && score <= 100)
            {
                print.WriteLine("A");
            }
            else if (80 <= score && score <= 89)
            {
                print.WriteLine("B");
            }
            else if (70 <= score && score <= 79)
            {
                print.WriteLine("C");
            }
            else if (60 <= score && score <= 69)
            {
                print.WriteLine("D");
            }
            else
            {
                print.WriteLine("F");
            }
        }
    }
}

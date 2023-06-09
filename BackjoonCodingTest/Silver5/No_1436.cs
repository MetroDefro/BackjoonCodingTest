using System;

namespace BackjoonCodingTest.Silver5
{
    public class No_1436
    {
        public No_1436()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int num = int.Parse(input);

            int i = 666;
            int count = 1;
            while (count < num)
            {
                i++;
                if (i.ToString().Contains("666"))
                {
                    count++;
                }
            }

            print.WriteLine(i);
        }
    }
}

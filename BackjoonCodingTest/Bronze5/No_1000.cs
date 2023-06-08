using System;

namespace BackjoonCodingTest.Bronze5
{
    public class No_1000
    {
        public No_1000()
        {
            string input = Console.ReadLine();
            string[] result = input.Split(' ');
            int a = int.Parse(result[0]);
            int b = int.Parse(result[1]);
            Console.WriteLine(a + b);
        }
    }
}

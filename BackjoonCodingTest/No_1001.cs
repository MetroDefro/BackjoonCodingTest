using System;

namespace BackjoonCodingTest
{
    public class No_1001
    {
        public No_1001()
        {
            string input = Console.ReadLine();
            string[] result = input.Split(' ');
            int a = int.Parse(result[0]);
            int b = int.Parse(result[1]);
            Console.WriteLine(a - b);
        }
    }
}

using System;

namespace BackjoonCodingTest
{
    public class No_2475
    {
        public No_2475()
        {
            string input = Console.ReadLine();

            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += (int)Math.Pow(int.Parse(input.Split()[i]), 2);
            }

            Console.WriteLine(sum % 10);
        }
    }
}

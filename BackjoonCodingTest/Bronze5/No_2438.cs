using System;

namespace BackjoonCodingTest.Bronze5
{
    public class No_2438
    {
        public No_2438()
        {
            string input = Console.ReadLine();
            int num = int.Parse(input);

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}

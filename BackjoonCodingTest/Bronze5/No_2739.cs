using System;

namespace BackjoonCodingTest.Bronze5
{
    public class No_2739
    {
        public No_2739()
        {
            string input = Console.ReadLine();
            int num = int.Parse(input);

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine(num + " * " + i + " = " + num * i);
            }
        }
    }
}

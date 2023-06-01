using System;

namespace BackjoonCodingTest
{
    public class No_1008
    {
        public No_1008()
        {
            string input = Console.ReadLine();
            string[] result = input.Split(' ');
            double a = double.Parse(result[0]);
            double b = double.Parse(result[1]);
            Console.WriteLine(a / b);
        }
    }
}

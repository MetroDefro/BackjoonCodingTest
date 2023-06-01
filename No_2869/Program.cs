using System;

namespace No_2869
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long A = long.Parse(input.Split()[0]);
            long B = long.Parse(input.Split()[1]);
            long V = long.Parse(input.Split()[2]);

            long temp = V - A;
            long oneDaySum = A - B;
            long day = temp / oneDaySum;

            if(temp % oneDaySum != 0)
            {
                Console.WriteLine(day + 2);
            }
            else
            {
                Console.WriteLine(day + 1);
            }
        }
    }
}
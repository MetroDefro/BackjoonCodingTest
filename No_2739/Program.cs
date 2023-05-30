using System;

namespace No_2739
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num = int.Parse(input);

            for(int i = 1; i <= 9; i++)
            {
                Console.WriteLine(num + " * " + i + " = " + num * i);
            }
        }
    }
}
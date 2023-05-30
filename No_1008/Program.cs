using System;

namespace No_1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] result = input.Split(' ');
            double a = double.Parse(result[0]);
            double b = double.Parse(result[1]);
            Console.WriteLine(a / b);
        }
    }
}
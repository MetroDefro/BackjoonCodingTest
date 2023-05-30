using System;

namespace No_1001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] result = input.Split(' ');
            int a = int.Parse(result[0]);
            int b = int.Parse(result[1]);
            Console.WriteLine(a - b);
        }
    }
}
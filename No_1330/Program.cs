using System;

namespace No_1330
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] result = input.Split(' ');
            int a = int.Parse(result[0]);
            int b = int.Parse(result[1]);
            if(a == b)
                Console.WriteLine("==");
            else if(a < b)
                Console.WriteLine("<");
            else
                Console.WriteLine(">");
        }
    }
}
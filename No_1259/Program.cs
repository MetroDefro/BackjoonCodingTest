using System;
using System.Collections.Generic;

namespace No_1259
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<bool> resultList = new List<bool>();

            string input = Console.ReadLine();
            while (input != "0")
            {
                char[] results = new char[input.Length];
                for(int i = 0; i < input.Length; i++)
                {
                    results[i] = input[i];
                }

                for (int i = 0; i < results.Length; i++)
                {
                    if (i >= results.Length - 1 - i)
                    {
                        resultList.Add(true);
                        break;
                    }

                    if (results[i] != results[results.Length - 1 - i])
                    {
                        resultList.Add(false);
                        break;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var result in resultList)
            {
                string output = result ? "yes" : "no";
                Console.WriteLine(output);
            }
        }
    }
}
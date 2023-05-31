using System;
using System.Collections.Generic;

namespace No_4153
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<bool> resultList = new List<bool>();

            string input = Console.ReadLine();
            while (input != "0 0 0")
            {
                string[] results = input.Split();
                int[] intResults = new int[results.Length];

                for (int i = 0; i < results.Length; i++)
                {
                    intResults[i] = int.Parse(results[i]);
                }

                for (int i = 0; i < intResults.Length; i++)
                {
                    for (int j = 1; j < intResults.Length; j++)
                    {
                        if (intResults[j - 1] > intResults[j])
                        {
                            int temp = intResults[j - 1];
                            intResults[j - 1] = intResults[j];
                            intResults[j] = temp;
                        }
                    }
                }

                resultList.Add(Math.Pow(intResults[2], 2) == Math.Pow(intResults[1], 2) + Math.Pow(intResults[0], 2));

                input = Console.ReadLine();
            }
            
            foreach(var result in resultList)
            {
                string output = result ? "right" : "wrong";
                Console.WriteLine(output);
            }
        }
    }
}
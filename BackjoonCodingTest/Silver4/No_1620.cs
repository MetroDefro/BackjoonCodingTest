using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver4
{
    public class No_1620
    {
        public No_1620()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int N = int.Parse(input.Split()[0]);
            int M = int.Parse(input.Split()[1]);

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            Dictionary<string, int> dictionaryInverse = new Dictionary<string, int>();

            for (int i = 0; i < N; i++)
            {
                input = reader.ReadLine();
                dictionary.Add(i + 1, input);
                dictionaryInverse.Add(input, i + 1);
            }


            for (int i = 0; i < M; i++)
            {
                input = reader.ReadLine();
                if (int.TryParse(input, out int num))
                {
                    if (dictionary.TryGetValue(num, out string value))
                        print.WriteLine(value);
                }
                else
                {
                    if (dictionaryInverse.TryGetValue(input, out int key))
                        print.WriteLine(key);
                }
            }
        }
    }
}

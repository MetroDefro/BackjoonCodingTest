using System;

namespace No_1157
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            long[] alphabet = new long[26];

            for(int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if((char)input[i] == 'A' + j || (char)input[i] == 'a' + j)
                        alphabet[j]++;
                }
            }

            long max = 0;
            int maxIndex = 0;
            bool same = false;
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] > max)
                {
                    max = alphabet[i];
                    maxIndex = i;
                    same = false;
                }
                else if (alphabet[i] == max)
                {
                    same = true;
                }
            }

            char output = same ? '?' : (char)('A' + maxIndex);
           
            Console.WriteLine(output);
        }
    }
}
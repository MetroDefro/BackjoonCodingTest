using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze4
{
    public class No_10808
    {
        public No_10808()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();

            int[] alphabet = new int[26];

            for (int i = 0; i < input.Length; i++)
            {
                alphabet[input[i] - 'a']++;
            }

            for (int i = 0; i < alphabet.Length; i++)
            {
                print.Write(alphabet[i] + " ");
            }

            reader.Close();
            print.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_10809
    {
        public No_10809()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int[] alphabet = new int[26];

            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = -1;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (alphabet[input[i] - 97] == -1)
                {
                    alphabet[input[i] - 97] = i;
                }

            }

            for (int i = 0; i < 26; i++)
            {
                if (i < 25)
                    print.Write(alphabet[i] + " ");
                else
                    print.Write(alphabet[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver3
{
    public class No_2407
    {
        private static string[,] temp = new string[101, 101];

        public No_2407()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();

            int n = int.Parse(input.Split()[0]);
            int m = int.Parse(input.Split()[1]);

            string result = Combination(n, m);
            print.WriteLine(result);
        }

        private static string Combination(int n, int r)
        {
            if (temp[n, r] != null)
                return temp[n, r];
            else
            {
                if (n == r || r == 0)
                    return "1";

                temp[n, r] = AddString(Combination(n - 1, r - 1), Combination(n - 1, r));

                return temp[n, r];
            }
        }

        private static string AddString(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            char[] aArray = a.ToCharArray();
            Array.Reverse(aArray);
            char[] bArray = b.ToCharArray();
            Array.Reverse(bArray);

            int index = 0;
            int sum = 0;

            while (index < a.Length || index < b.Length || sum != 0)
            {
                if (index < a.Length && index < b.Length)
                {
                    sum = sum + aArray[index] - '0' + bArray[index] - '0';
                }
                else if (index < a.Length)
                {
                    sum = sum + (int)aArray[index] - '0';
                }
                else if (index < b.Length)
                {
                    sum = sum + (int)bArray[index] - '0';
                }

                sb.Append(sum % 10);
                sum /= 10;

                index++;
            }
            char[] result = sb.ToString().ToCharArray();
            Array.Reverse(result);

            return string.Concat(result);
        }
    }
}

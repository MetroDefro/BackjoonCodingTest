using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Gold5
{
    public class No_9251
    {
        public No_9251()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string str1 = reader.ReadLine();
            string str2 = reader.ReadLine();

            int[,] dp = new int[str1.Length + 1, str2.Length + 1];

            for (int i = 0; i <= str1.Length; i++)
            {
                for (int j = 0; j <= str2.Length; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = 0;
                        continue;
                    }


                    if (str1[i - 1] == str2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            print.WriteLine(dp[str1.Length, str2.Length]);

            reader.Close();
            print.Close();
        }
    }
}

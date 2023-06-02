using System;

namespace BackjoonCodingTest
{
    public class No_10172
    {
        public No_10172()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] strs = { "|\\_/|", "|q p|   /}", "( 0 )\"\"\"\\", "|\"^\"`    |", "||_/=\\\\__|" };

            for (int i = 0; i < strs.Length; i++)
                print.WriteLine(strs[i]);
        }
    }
}

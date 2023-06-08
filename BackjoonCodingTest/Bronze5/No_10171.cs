using System;

namespace BackjoonCodingTest.Bronze5
{
    public class No_10171
    {
        public No_10171()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] strs = { "\\    /\\", " )  ( ')", "(  /  )", " \\(__)|" };

            for (int i = 0; i < strs.Length; i++)
                print.WriteLine(strs[i]);
        }
    }
}

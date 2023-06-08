using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze5
{
    public class No_25083
    {
        public No_25083()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] picture = { "         ,r'\"7", "r`-_   ,'  ,/", " \\. \". L_r'", "   `~\\/", "      |", "      |" };

            for (int i = 0; i < picture.Length; i++)
                print.WriteLine(picture[i]);
        }
    }
}

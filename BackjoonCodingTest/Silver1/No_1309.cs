using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_1309
    {
        public No_1309()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());

            int[,] lion = new int[3, N];
            lion[0, 0] = 1;
            lion[1, 0] = 1;
            lion[2, 0] = 1;

            for (int i = 1; i < N; i++)
            {
                lion[0, i] = (lion[0, i - 1] + lion[1, i - 1] + lion[2, i - 1]) % 9901;
                lion[1, i] = (lion[0, i - 1] + lion[2, i - 1]) % 9901;
                lion[2, i] = (lion[0, i - 1] + lion[1, i - 1]) % 9901;
            }

            print.WriteLine((lion[0, N - 1] + lion[1, N - 1] + lion[2, N - 1]) % 9901);

            reader.Close();
            print.Close();
        }
    }
}

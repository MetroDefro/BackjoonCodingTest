using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_11729
    {
        public No_11729()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(reader.ReadLine());

            StringBuilder stringBuilder = new StringBuilder();

            HanoiTop(n, 1, 3, 2);

            print.WriteLine((int)Math.Pow(2, n) - 1);
            print.WriteLine(stringBuilder.ToString());

            void HanoiTop(int n, int start, int end, int blank)
            {
                if (n == 1)
                {
                    stringBuilder.AppendLine(start + " " + end);
                    return;
                }

                HanoiTop(n - 1, start, blank, end);
                stringBuilder.AppendLine(start + " " + end);
                HanoiTop(n - 1, blank, end, start);
            }
        }
    }
}

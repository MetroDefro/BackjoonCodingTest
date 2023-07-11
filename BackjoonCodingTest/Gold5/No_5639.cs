using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Gold5
{
    public class No_5639
    {
        public No_5639()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int[] nodes = new int[10001];
            int index = 0;

            while (true)
            {
                string input = reader.ReadLine();
                if (input == null || input == "")
                    break;

                nodes[index++] = int.Parse(input);
            }

            StringBuilder stringBuilder = new StringBuilder();
            Divide(stringBuilder, nodes, 0, index);
            print.WriteLine(stringBuilder.ToString());

            reader.Close();
            print.Close();
        }

        private static void Divide(StringBuilder stringBuilder, int[] nodes, int start, int end)
        {
            if (start >= end)
                return;

            int i;
            for (i = start + 1; i < end; i++)
            {
                if (nodes[i] > nodes[start])
                    break;
            }

            Divide(stringBuilder, nodes, start + 1, i);
            Divide(stringBuilder, nodes, i, end);
            stringBuilder.Append(nodes[start]);
            stringBuilder.AppendLine();
        }
    }
}

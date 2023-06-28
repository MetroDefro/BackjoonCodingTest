using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze3
{
    public class No_3009
    {
        public No_3009()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();

            int x1 = int.Parse(inputs[0]);
            int y1 = int.Parse(inputs[1]);

            inputs = reader.ReadLine().Split();
            int x2 = int.Parse(inputs[0]);
            int y2 = int.Parse(inputs[1]);

            inputs = reader.ReadLine().Split();
            int x3 = int.Parse(inputs[0]);
            int y3 = int.Parse(inputs[1]);

            int x4;
            int y4;
            if (x1 != x2 && x1 != x3)
            {
                x4 = x1;
            }
            else if (x2 != x3 && x2 != x1)
            {
                x4 = x2;
            }
            else
            {
                x4 = x3;
            }

            if (y1 != y2 && y1 != y3)
            {
                y4 = y1;
            }
            else if (y2 != y3 && y2 != y1)
            {
                y4 = y2;
            }
            else
            {
                y4 = y3;
            }

            print.WriteLine(x4 + " " + y4);

            reader.Close();
            print.Close();
        }
    }
}

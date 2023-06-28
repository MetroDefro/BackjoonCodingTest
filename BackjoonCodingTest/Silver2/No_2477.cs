using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver2
{
    public class No_2477
    {
        public No_2477()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int K = int.Parse(reader.ReadLine());

            (int direction, int length)[] edges = new (int, int)[6];
            for (int i = 0; i < 6; i++)
            {
                string[] inputs = reader.ReadLine().Split();
                edges[i] = (int.Parse(inputs[0]), int.Parse(inputs[1]));
            }

            int[] edgeCount = new int[4];
            int s = 1;
            int b = 1;
            for (int i = 0; i < 6; i++)
            {
                (int direction, int length) next1 = edges[(i + 1) % 6];
                (int direction, int length) next2 = edges[(i + 2) % 6];
                (int direction, int length) next3 = edges[(i + 3) % 6];
                edgeCount[edges[i].direction - 1]++;

                if (edges[i].direction == next2.direction)
                {
                    if (next1.direction == next3.direction)
                    {
                        s = next1.length * next2.length;
                    }
                }
            }

            for (int i = 0; i < 6; i++)
            {
                if (edgeCount[edges[i].direction - 1] == 1)
                    b *= edges[i].length;
            }

            print.WriteLine((b - s) * K);

            reader.Close();
            print.Close();
        }
    }
}

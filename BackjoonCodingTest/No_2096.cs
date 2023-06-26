using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_2096
    {
        public No_2096()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());

            byte[,] scores = new byte[N, 3];
            for (int i = 0; i < N; i++)
            {
                string[] inputs = reader.ReadLine().Split();
                scores[i, 0] = byte.Parse(inputs[0]);
                scores[i, 1] = byte.Parse(inputs[1]);
                scores[i, 2] = byte.Parse(inputs[2]);
            }

            int[] dpMax = new int[3];
            dpMax[0] = scores[0, 0];
            dpMax[1] = scores[0, 1];
            dpMax[2] = scores[0, 2];
            int[] dpMin = new int[3];
            dpMin[0] = scores[0, 0];
            dpMin[1] = scores[0, 1];
            dpMin[2] = scores[0, 2];

            int[] prevDpMax = new int[3];
            int[] prevDpMin = new int[3];

            for (int i = 1; i < N; i++)
            {
                prevDpMax[0] = dpMax[0];
                prevDpMax[1] = dpMax[1];
                prevDpMax[2] = dpMax[2];

                prevDpMin[0] = dpMin[0];
                prevDpMin[1] = dpMin[1];
                prevDpMin[2] = dpMin[2];

                dpMax[0] = Math.Max(prevDpMax[0], prevDpMax[1]) + scores[i, 0];
                dpMax[1] = Math.Max(prevDpMax[0], Math.Max(prevDpMax[1], prevDpMax[2])) + scores[i, 1];
                dpMax[2] = Math.Max(prevDpMax[1], prevDpMax[2]) + scores[i, 2];

                dpMin[0] = Math.Min(prevDpMin[0], prevDpMin[1]) + scores[i, 0];
                dpMin[1] = Math.Min(prevDpMin[0], Math.Min(prevDpMin[1], prevDpMin[2])) + scores[i, 1];
                dpMin[2] = Math.Min(prevDpMin[1], prevDpMin[2]) + scores[i, 2];
            }

            print.Write(Math.Max(dpMax[0], Math.Max(dpMax[1], dpMax[2])));
            print.Write(" ");
            print.Write(Math.Min(dpMin[0], Math.Min(dpMin[1], dpMin[2])));

            reader.Close();
            print.Close();
        }
    }
}

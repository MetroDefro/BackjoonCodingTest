using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver3
{
    public class No_1966
    {
        public No_1966()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int testCase = int.Parse(input);

            Queue<(int index, int value)> queue = new Queue<(int index, int value)>();
            for (int i = 0; i < testCase; i++)
            {
                input = reader.ReadLine();
                int N = int.Parse(input.Split()[0]);
                int M = int.Parse(input.Split()[1]);

                input = reader.ReadLine();
                string[] inputs = input.Split();

                for (int j = 0; j < inputs.Length; j++)
                {
                    queue.Enqueue((j, int.Parse(inputs[j])));
                }

                int cur;
                int curIndex;
                int count = 0;
                while (queue.Count > 0)
                {
                    (curIndex, cur) = queue.Dequeue();

                    if (!Check(queue.ToArray(), cur, queue.Count))
                    {
                        queue.Enqueue((curIndex, cur));
                    }
                    else
                    {
                        count++;
                        if (curIndex == M)
                            break;
                    }
                }

                print.WriteLine(count);

                queue.Clear();
            }
        }

        private static bool Check((int, int)[] list, int cur, int count)
        {
            for (int i = 0; i < count; i++)
            {
                if (list[i].Item2 > cur)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

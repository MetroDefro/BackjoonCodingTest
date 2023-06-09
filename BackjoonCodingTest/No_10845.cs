using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_10845
    {
        public No_10845()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int N = int.Parse(input);

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < N; i++)
            {
                input = reader.ReadLine();

                if (input.Contains("push"))
                {
                    queue.Enqueue(int.Parse(input.Split()[1]));
                }
                else if (input.Contains("pop"))
                {
                    if (queue.Count > 0)
                    {
                        print.WriteLine(queue.Dequeue());
                    }
                    else
                    {
                        print.WriteLine(-1);
                    }
                }
                else if (input.Contains("size"))
                {
                    print.WriteLine(queue.Count);
                }
                else if (input.Contains("empty"))
                {
                    if (queue.Count > 0)
                    {
                        print.WriteLine(0);
                    }
                    else
                    {
                        print.WriteLine(1);
                    }
                }
                else if (input.Contains("front"))
                {
                    if (queue.Count > 0)
                    {
                        print.WriteLine(queue.Peek());
                    }
                    else
                    {
                        print.WriteLine(-1);
                    }
                }
                else if (input.Contains("back"))
                {
                    if (queue.Count > 0)
                    {
                        int[] array = queue.ToArray();
                        print.WriteLine(array[array.Length - 1]);
                    }
                    else
                    {
                        print.WriteLine(-1);
                    }
                }
            }
        }
    }
}

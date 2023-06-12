using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_10866
    {
        public No_10866()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int N = int.Parse(input);

            List<int> deque = new List<int>();

            for (int i = 0; i < N; i++)
            {
                input = reader.ReadLine();

                if (input.Contains("push_front"))
                {
                    deque.Insert(0, int.Parse(input.Split()[1]));
                }
                else if (input.Contains("push_back"))
                {
                    deque.Add(int.Parse(input.Split()[1]));
                }
                else if (input.Contains("pop_front"))
                {
                    if (deque.Count > 0)
                    {
                        print.WriteLine(deque[0]);
                        deque.RemoveAt(0);
                    }
                    else
                    {
                        print.WriteLine(-1);
                    }
                }
                else if (input.Contains("pop_back"))
                {
                    if (deque.Count > 0)
                    {
                        print.WriteLine(deque[deque.Count - 1]);
                        deque.RemoveAt(deque.Count - 1);
                    }
                    else
                    {
                        print.WriteLine(-1);
                    }
                }
                else if (input.Contains("size"))
                {
                    print.WriteLine(deque.Count);
                }
                else if (input.Contains("empty"))
                {
                    if (deque.Count > 0)
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
                    if (deque.Count > 0)
                    {
                        print.WriteLine(deque[0]);
                    }
                    else
                    {
                        print.WriteLine(-1);
                    }
                }
                else if (input.Contains("back"))
                {
                    if (deque.Count > 0)
                    {
                        print.WriteLine(deque[deque.Count - 1]);
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

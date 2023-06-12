using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_10828
    {
        public No_10828()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int N = int.Parse(input);

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                input = reader.ReadLine();

                if (input.Contains("push"))
                {
                    stack.Push(int.Parse(input.Split()[1]));
                }
                else if (input.Contains("pop"))
                {
                    if (stack.Count > 0)
                    {
                        print.WriteLine(stack.Pop());
                    }
                    else
                    {
                        print.WriteLine(-1);
                    }
                }
                else if (input.Contains("size"))
                {
                    print.WriteLine(stack.Count);
                }
                else if (input.Contains("empty"))
                {
                    if (stack.Count > 0)
                    {
                        print.WriteLine(0);
                    }
                    else
                    {
                        print.WriteLine(1);
                    }
                }
                else if (input.Contains("top"))
                {
                    if (stack.Count > 0)
                    {
                        print.WriteLine(stack.Peek());
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

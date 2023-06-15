using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver3
{
    public class No_17413
    {
        public No_17413()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();

            Queue<Stack<char>> stackQueue = new Queue<Stack<char>>();

            int length = input.Length;

            Stack<char> stack = new Stack<char>();
            bool isTagging = false;
            for (int i = 0; i < length; i++)
            {
                char c = input[i];
                if (c == ' ')
                {
                    if (!isTagging)
                    {
                        stackQueue.Enqueue(stack);
                        stack = new Stack<char>();
                        stack.Push(c);
                        stackQueue.Enqueue(stack);
                        stack = new Stack<char>();
                    }
                    else
                    {
                        stack.Push(c);
                    }
                }
                else if (c == '<')
                {
                    isTagging = true;
                    stackQueue.Enqueue(stack);
                    stack = new Stack<char>();
                    stack.Push(c);
                }
                else if (c == '>')
                {
                    stack.Push(c);
                    isTagging = false;
                    stackQueue.Enqueue(stack);
                    stack = new Stack<char>();
                }
                else
                {
                    stack.Push(c);
                }

                if (i == length - 1)
                {
                    stackQueue.Enqueue(stack);
                }
            }

            StringBuilder sb = new StringBuilder();
            Stack<char> reverseStack = new Stack<char>();

            while (stackQueue.Count > 0)
            {
                stack = stackQueue.Dequeue();
                while (stack.Count > 0)
                {
                    char c = stack.Pop();
                    if (!isTagging)
                    {
                        if (c == '>')
                        {
                            isTagging = true;
                            reverseStack.Push(c);
                        }
                        else
                        {
                            sb.Append(c);
                        }
                    }
                    else
                    {
                        if (c == '<')
                        {
                            reverseStack.Push(c);

                            while (reverseStack.Count > 0)
                            {
                                c = reverseStack.Pop();
                                sb.Append(c);
                            }

                            isTagging = false;
                        }
                        else
                        {
                            reverseStack.Push(c);
                        }
                    }
                }
            }

            print.WriteLine(sb.ToString());
        }
    }
}

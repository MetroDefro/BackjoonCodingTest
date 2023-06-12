using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_4949
    {
        public No_4949()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            Stack<char> stack = new Stack<char>();

            string input = reader.ReadLine();

            while (input != ".")
            {
                int length = input.Length;
                for (int i = 0; i < length; i++)
                {
                    if (input[i] == '(')
                        stack.Push(input[i]);
                    else if (input[i] == '[')
                        stack.Push(input[i]);
                    else if (input[i] == ')')
                    {
                        if (stack.Count != 0)
                        {
                            if (stack.Peek() == '(')
                                stack.Pop();
                            else
                                stack.Push(input[i]);
                        }
                        else
                            stack.Push(input[i]);
                    }
                    else if (input[i] == ']')
                    {
                        if (stack.Count != 0)
                        {
                            if (stack.Peek() == '[')
                                stack.Pop();
                            else
                                stack.Push(input[i]);
                        }
                        else
                            stack.Push(input[i]);
                    }
                }

                if (stack.Count == 0)
                    print.WriteLine("yes");
                else
                    print.WriteLine("no");

                stack.Clear();

                input = reader.ReadLine();
            }
        }
    }
}

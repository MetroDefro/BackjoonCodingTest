using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_2504
    {
        public No_2504()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();

            Stack<char> stack = new Stack<char>();

            int multiplier = 1;
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    multiplier *= 2;
                    stack.Push(input[i]);
                }
                else if (input[i] == ')')
                {
                    if (stack.Count > 0 && stack.Peek() == '(')
                    {
                        if (input[i - 1] == '(')
                            sum += multiplier;
                        multiplier /= 2;
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(input[i]);
                    }
                }
                else if (input[i] == '[')
                {
                    multiplier *= 3;
                    stack.Push(input[i]);
                }
                else
                {
                    if (stack.Count > 0 && stack.Peek() == '[')
                    {
                        if (input[i - 1] == '[')
                            sum += multiplier;
                        multiplier /= 3;
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(input[i]);
                    }
                }
            }

            if (stack.Count > 0)
                print.WriteLine(0);
            else
                print.WriteLine(sum);

            reader.Close();
            print.Close();
        }
    }
}

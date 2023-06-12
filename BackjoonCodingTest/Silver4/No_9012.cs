using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver4
{
    public class No_9012
    {
        public No_9012()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            Stack<char> stack = new Stack<char>();

            string input = reader.ReadLine();
            int N = int.Parse(input);

            for (int i = 0; i < N; i++)
            {
                input = reader.ReadLine();

                int length = input.Length;
                for (int j = 0; j < length; j++)
                {
                    if (input[j] == '(')
                        stack.Push(input[j]);
                    else if (input[j] == ')')
                    {
                        if (stack.Count != 0)
                        {
                            if (stack.Peek() == '(')
                                stack.Pop();
                            else
                                stack.Push(input[j]);
                        }
                        else
                            stack.Push(input[j]);
                    }
                }
                if (stack.Count == 0)
                    print.WriteLine("YES");
                else
                    print.WriteLine("NO");

                stack.Clear();
            }
        }
    }
}

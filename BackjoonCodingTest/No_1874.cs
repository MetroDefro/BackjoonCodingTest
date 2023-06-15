using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_1874
    {
        public No_1874()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(reader.ReadLine());

            Queue<int> queue = new Queue<int>();
            Stack<int> stack = new Stack<int>();
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(reader.ReadLine());
                queue.Enqueue(i + 1);
            }

            StringBuilder stringBuilder = new StringBuilder();
            int index = 0;
            int num = queue.Peek();
            while (queue.Count > 0 || stack.Count > 0)
            {
                if (queue.Count > 0)
                {
                    if (nums[index] >= queue.Peek())
                    {
                        if (queue.Count > 0)
                        {
                            stack.Push(queue.Dequeue());
                            stringBuilder.Append("+");
                            stringBuilder.AppendLine();
                        }
                    }


                }
                if (stack.Count > 0)
                {
                    if (stack.Peek() == nums[index])
                    {
                        stack.Pop();
                        stringBuilder.Append("-");
                        stringBuilder.AppendLine();
                        index++;
                    }
                    else if (stack.Peek() > nums[index])
                    {
                        print.WriteLine("NO");
                        return;
                    }

                }

            }

            print.WriteLine(stringBuilder.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver2
{
    public class No_16953
    {
        public No_16953()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            Dictionary<long, int> dp = new Dictionary<long, int>();
            dp.Add(A, 1);
            print.WriteLine(BFS());

            long BFS()
            {
                Queue<long> queue = new Queue<long>();

                queue.Enqueue(A);

                while (queue.Count > 0)
                {
                    long num = queue.Dequeue();

                    if (num == B)
                    {
                        return dp[num];
                    }

                    if (num * 2 <= B)
                    {
                        dp.Add(num * 2, dp[num] + 1);
                        queue.Enqueue(num * 2);
                    }
                    if (long.Parse(num.ToString() + 1) <= B)
                    {
                        dp.Add(long.Parse(num.ToString() + 1), dp[num] + 1);
                        queue.Enqueue(long.Parse(num.ToString() + 1));
                    }
                }

                return -1;
            }
        }
    }
}

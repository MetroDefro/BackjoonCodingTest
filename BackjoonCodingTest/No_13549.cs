using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_13549
    {
        public No_13549()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);

            Dictionary<int, int> dp = new Dictionary<int, int>();

            print.WriteLine(BFS());

            int BFS()
            {
                Queue<int> queue = new Queue<int>();

                dp.Add(A, 0);
                queue.Enqueue(A);

                while (queue.Count > 0)
                {
                    int num = queue.Dequeue();

                    if (num > 200000)
                        continue;

                    if (num == B)
                    {
                        return dp[num];
                    }

                    if (!dp.ContainsKey(num * 2) && num < B)
                    {
                        dp.Add(num * 2, dp[num]);
                        queue.Enqueue(num * 2);
                    }

                    if (!dp.ContainsKey(num - 1))
                    {
                        dp.Add(num - 1, dp[num] + 1);
                        queue.Enqueue(num - 1);
                    }

                    if (!dp.ContainsKey(num + 1))
                    {
                        dp.Add(num + 1, dp[num] + 1);
                        queue.Enqueue(num + 1);
                    }
                }

                return -1;
            }
        }
    }
}

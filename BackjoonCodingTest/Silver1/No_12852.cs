using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_12852
    {
        public No_12852()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());

            int[] nums = new int[N + 1];
            List<int> results = new List<int>();
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != 0 || i < 2)
                    continue;

                if (i % 6 == 0)
                {
                    nums[i] = Math.Min(Math.Min(nums[i / 2], nums[i / 3]), nums[i - 1]) + 1;
                }
                else if (i % 2 == 0)
                {
                    nums[i] = Math.Min(nums[i / 2], nums[i - 1]) + 1;
                }
                else if (i % 3 == 0)
                {
                    nums[i] = Math.Min(nums[i / 3], nums[i - 1]) + 1;
                }
                else
                {
                    nums[i] = nums[i - 1] + 1;
                }
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(N);

            while (queue.Count > 0)
            {
                int i = queue.Dequeue();
                results.Add(i);

                if (i == 1)
                    break;

                if (i % 6 == 0)
                {
                    if (nums[i / 3] <= nums[i - 1] && nums[i / 3] <= nums[i / 2])
                        queue.Enqueue(i / 3);
                    else if (nums[i / 2] <= nums[i - 1] && nums[i / 2] <= nums[i / 3])
                        queue.Enqueue(i / 2);
                    else
                        queue.Enqueue(i - 1);
                }
                else if (i % 2 == 0)
                {
                    if (nums[i / 2] < nums[i - 1])
                        queue.Enqueue(i / 2);
                    else
                        queue.Enqueue(i - 1);
                }
                else if (i % 3 == 0)
                {
                    if (nums[i / 3] < nums[i - 1])
                        queue.Enqueue(i / 3);
                    else
                        queue.Enqueue(i - 1);
                }
                else
                {
                    queue.Enqueue(i - 1);
                }
            }

            print.WriteLine(nums[N]);

            StringBuilder stringBuilder = new StringBuilder();

            int count = results.Count;
            for (int i = 0; i < count; i++)
            {
                stringBuilder.Append(results[i] + " ");
            }

            print.WriteLine(stringBuilder.ToString());
            reader.Close();
            print.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_5014
    {
        public No_5014()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int F = int.Parse(inputs[0]);
            int S = int.Parse(inputs[1]);
            int G = int.Parse(inputs[2]);
            int U = int.Parse(inputs[3]);
            int D = int.Parse(inputs[4]);

            bool[] visited = new bool[F];

            long num = BFS();

            if (num == long.MaxValue)
                print.WriteLine("use the stairs");
            else
                print.WriteLine(num);

            reader.Close();
            print.Close();

            long BFS()
            {
                Queue<(int grade, long count)> queue = new Queue<(int, long)>();

                visited[S - 1] = true;
                queue.Enqueue((S - 1, 0));

                long min = long.MaxValue;
                while (queue.Count > 0)
                {
                    (int grade, long count) = queue.Dequeue();

                    if (grade == G - 1)
                    {
                        min = Math.Min(count, min);
                    }

                    if (grade + U < F)
                    {
                        if (!visited[grade + U])
                        {
                            visited[grade + U] = true;
                            queue.Enqueue((grade + U, count + 1));
                        }
                    }

                    if (grade - D > -1)
                    {
                        if (!visited[grade - D])
                        {
                            visited[grade - D] = true;
                            queue.Enqueue((grade - D, count + 1));
                        }
                    }
                }

                return min;
            }
        }
    }
}

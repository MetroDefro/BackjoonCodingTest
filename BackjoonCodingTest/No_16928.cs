using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_16928
    {
        public No_16928()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            int[] ladder = new int[101];
            int[] snake = new int[101];
            for (int i = 0; i < N; i++)
            {
                inputs = reader.ReadLine().Split();
                ladder[int.Parse(inputs[0])] = int.Parse(inputs[1]);
            }

            for (int i = 0; i < M; i++)
            {
                inputs = reader.ReadLine().Split();
                snake[int.Parse(inputs[0])] = int.Parse(inputs[1]);
            }

            print.WriteLine(BFS());

            reader.Close();
            print.Close();

            int BFS()
            {
                Queue<(int pos, int count)> queue = new Queue<(int pos, int count)>();
                bool[] visited = new bool[101];

                queue.Enqueue((1, 0));
                visited[1] = true;

                int min = int.MaxValue;
                while (queue.Count > 0)
                {
                    (int pos, int count) = queue.Dequeue();

                    if (pos == 100)
                    {
                        min = Math.Min(count, min);
                    }

                    for (int i = 1; i <= 6; i++)
                    {
                        if (pos + i <= 100 && !visited[pos + i])
                        {
                            if (ladder[pos + i] != 0)
                            {
                                queue.Enqueue((ladder[pos + i], count + 1));
                                visited[pos + i] = true;
                                visited[ladder[pos + i]] = true;
                            }
                            else if (snake[pos + i] != 0)
                            {
                                queue.Enqueue((snake[pos + i], count + 1));
                                visited[pos + i] = true;
                                visited[snake[pos + i]] = true;
                            }
                            else
                            {
                                queue.Enqueue((pos + i, count + 1));
                                visited[pos + i] = true;
                            }
                        }
                    }
                }

                return min;
            }
        }
    }
}

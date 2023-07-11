using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_9019
    {
        public No_9019()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int T = int.Parse(reader.ReadLine());

            for (int tc = 0; tc < T; tc++)
            {
                string[] inputs = reader.ReadLine().Split();
                short a = short.Parse(inputs[0]);
                short b = short.Parse(inputs[1]);

                bool[] visited = new bool[10000];

                BFS();

                void BFS()
                {
                    Queue<(short num, string str)> queue = new Queue<(short, string)>();

                    queue.Enqueue((a, string.Empty));
                    visited[a] = true;
                    StringBuilder stringBuilder = new StringBuilder();

                    while (queue.Count > 0)
                    {
                        (short num, string str) = queue.Dequeue();

                        if (num == b)
                        {
                            print.WriteLine(str);
                            break;
                        }

                        short D = (short)((num * 2) % 10000);
                        short S = (short)(num - 1 < 0 ? 9999 : num - 1);

                        short temp = num;
                        short d4 = (short)(temp % 10);
                        temp /= 10;
                        short d3 = (short)(temp % 10);
                        temp /= 10;
                        short d2 = (short)(temp % 10);
                        temp /= 10;
                        short d1 = (short)(temp % 10);

                        stringBuilder.Append(d2);
                        stringBuilder.Append(d3);
                        stringBuilder.Append(d4);
                        stringBuilder.Append(d1);
                        short L = short.Parse(stringBuilder.ToString());
                        stringBuilder.Clear();
                        stringBuilder.Append(d4);
                        stringBuilder.Append(d1);
                        stringBuilder.Append(d2);
                        stringBuilder.Append(d3);
                        short R = short.Parse(stringBuilder.ToString());
                        stringBuilder.Clear();

                        if (!visited[D])
                        {
                            queue.Enqueue((D, str + "D"));
                            visited[D] = true;
                        }

                        if (!visited[S])
                        {
                            queue.Enqueue((S, str + "S"));
                            visited[S] = true;
                        }

                        if (!visited[L])
                        {
                            queue.Enqueue((L, str + "L"));
                            visited[L] = true;
                        }

                        if (!visited[R])
                        {
                            queue.Enqueue((R, str + "R"));
                            visited[R] = true;
                        }
                    }
                }
            }

            reader.Close();
            print.Close();
        }
    }
}

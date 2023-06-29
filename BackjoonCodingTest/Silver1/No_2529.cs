using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_2529
    {
        public No_2529()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int k = int.Parse(reader.ReadLine());
            string[] inputs = reader.ReadLine().Split();
            string[] inequalitySigns = new string[k];
            for (int i = 0; i < k; i++)
            {
                inequalitySigns[i] = inputs[i];
            }

            StringBuilder stringBuilder = new StringBuilder();

            int[] arr = new int[k + 1];
            bool[] visited = new bool[10];
            long max = 0;
            long min = 9876543210;

            for (int i = 0; i <= 9; i++)
            {
                visited[i] = true;
                arr[0] = i;
                DFS(0, i, arr);
                visited[i] = false;
            }

            print.WriteLine("{0:D" + (k + 1) + "}", max);
            print.WriteLine("{0:D" + (k + 1) + "}", min);

            void DFS(int index, int prev, int[] arr)
            {
                if (index == k)
                {
                    for (int i = 0; i < k + 1; i++)
                        stringBuilder.Append(arr[i]);

                    max = Math.Max(max, long.Parse(stringBuilder.ToString()));
                    min = Math.Min(min, long.Parse(stringBuilder.ToString()));

                    stringBuilder.Clear();

                    return;
                }

                for (int i = 0; i <= 9; i++)
                {
                    if (inequalitySigns[index] == ">")
                    {
                        if (prev < i)
                            continue;
                    }
                    else
                    {
                        if (prev > i)
                            continue;
                    }

                    if (!visited[i])
                    {
                        visited[i] = true;
                        arr[index + 1] = i;
                        DFS(index + 1, i, arr);

                        visited[i] = false;
                    }
                }
            }

            reader.Close();
            print.Close();
        }
    }
}

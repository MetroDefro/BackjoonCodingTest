using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_1043
    {
        public No_1043()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            int[] parent = new int[N + 1];
            int[] party = new int[M + 1];
            for (int i = 0; i <= N; i++)
            {
                parent[i] = i;
            }

            inputs = reader.ReadLine().Split();
            int count = int.Parse(inputs[0]);
            int prev = 0;
            if (count > 0)
                prev = int.Parse(inputs[1]);
            int truth = prev;
            for (int i = 1; i <= count; i++)
            {
                int cur = int.Parse(inputs[i]);
                Union(prev, cur);

                prev = cur;
            }

            for (int i = 0; i < M; i++)
            {
                inputs = reader.ReadLine().Split();
                count = int.Parse(inputs[0]);
                prev = int.Parse(inputs[1]);
                party[i] = prev;
                for (int j = 1; j <= count; j++)
                {
                    int cur = int.Parse(inputs[j]);
                    Union(prev, cur);

                    prev = cur;
                }
            }

            int lieCount = 0;
            for (int i = 0; i < M; i++)
            {
                if (Findroot(truth) != Findroot(party[i]))
                {
                    lieCount++;
                }
            }

            print.WriteLine(lieCount);

            void Union(int x, int y)
            {
                x = Findroot(x);
                y = Findroot(y);

                if (x != y)
                {
                    if (x < y)
                    {
                        parent[y] = x;
                    }
                    else
                    {
                        parent[x] = y;
                    }
                }
            }


            int Findroot(int x)
            {
                if (parent[x] == x)
                    return x;

                return parent[x] = Findroot(parent[x]);
            }

            reader.Close();
            print.Close();
        }
    }
}

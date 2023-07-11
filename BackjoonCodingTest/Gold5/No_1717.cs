using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Gold5
{
    public class No_1717
    {
        public No_1717()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();
            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);

            int[] parent = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                parent[i] = i;
            }

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < m; i++)
            {
                inputs = reader.ReadLine().Split();

                if (int.Parse(inputs[0]) == 1)
                {
                    stringBuilder.Append(Findroot(int.Parse(inputs[1])) == Findroot(int.Parse(inputs[2])) ? "YES" : "NO");
                    stringBuilder.AppendLine();
                }
                else
                {
                    Union(int.Parse(inputs[1]), int.Parse(inputs[2]));
                }
            }

            print.WriteLine(stringBuilder);

            reader.Close();
            print.Close();

            void Union(int x, int y)
            {
                int rootX = Findroot(x);
                int rootY = Findroot(y);

                if (rootX != rootY)
                {
                    if (rootX < rootY)
                    {
                        parent[y] = rootX;
                        parent[x] = rootX;
                        parent[rootY] = rootX;
                    }
                    else
                    {
                        parent[y] = rootY;
                        parent[x] = rootY;
                        parent[rootX] = rootY;
                    }
                }
            }


            int Findroot(int x)
            {
                if (parent[x] == x)
                    return x;

                return parent[x] = Findroot(parent[x]);
            }
        }
    }
}

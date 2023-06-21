using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_14888
    {
        public No_14888()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());

            int[] nums = new int[N];
            string[] inputs = reader.ReadLine().Split();
            for (int i = 0; i < N; i++)
            {
                nums[i] = int.Parse(inputs[i]);
            }

            int[] fourOperator = new int[4];
            inputs = reader.ReadLine().Split();
            for (int i = 0; i < 4; i++)
            {
                fourOperator[i] = int.Parse(inputs[i]);
            }

            int max = -1000000000;
            int min = 1000000000;

            DFS(nums[0], 1, 0, 0, 0, 0);

            print.WriteLine(max);
            print.WriteLine(min);

            reader.Close();
            print.Close();

            void DFS(int sum, int depth, int usedPlus, int usedMinus, int usedMultiply, int usedDivide)
            {
                if (depth == N)
                {
                    max = Math.Max(max, sum);
                    min = Math.Min(min, sum);

                    return;
                }

                if (usedPlus < fourOperator[0])
                {
                    int newSum = sum + nums[depth];
                    DFS(newSum, depth + 1, usedPlus + 1, usedMinus, usedMultiply, usedDivide);
                }
                if (usedMinus < fourOperator[1])
                {
                    int newSum = sum - nums[depth];
                    DFS(newSum, depth + 1, usedPlus, usedMinus + 1, usedMultiply, usedDivide);
                }
                if (usedMultiply < fourOperator[2])
                {
                    int newSum = sum * nums[depth];
                    DFS(newSum, depth + 1, usedPlus, usedMinus, usedMultiply + 1, usedDivide);
                }
                if (usedDivide < fourOperator[3])
                {
                    int newSum = sum / nums[depth];
                    DFS(newSum, depth + 1, usedPlus, usedMinus, usedMultiply, usedDivide + 1);
                }
            }
        }
    }
}

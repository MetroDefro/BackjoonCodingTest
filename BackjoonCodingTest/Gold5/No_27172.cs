using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Gold5
{
    public class No_27172
    {
        public No_27172()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());
            string[] inputs = reader.ReadLine().Split();

            int[] nums = new int[N];
            for (int i = 0; i < N; i++)
            {
                nums[i] = int.Parse(inputs[i]);
            }

            int[] compares = new int[1000001];
            int[] players = new int[N];

            compares[1] = N - 1;
            for (int i = 0; i < N; i++)
            {
                for (int j = 2 * nums[i]; j < 1000001; j += nums[i])
                {
                    compares[j]--;
                }

                for (int j = 2; j * j <= nums[i]; j++)
                {
                    if (j * j == nums[i])
                    {
                        compares[j]++;
                    }
                    else if (nums[i] % j == 0)
                    {
                        compares[j]++;
                        compares[nums[i] / j]++;
                    }
                }
            }

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                stringBuilder.Append(compares[nums[i]] + " ");
            }

            print.WriteLine(stringBuilder.ToString());

            reader.Close();
            print.Close();
        }
    }
}

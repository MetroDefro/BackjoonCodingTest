using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_1946
    {
        public No_1946()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int T = int.Parse(reader.ReadLine());
            for (int testCase = 0; testCase < T; testCase++)
            {
                int N = int.Parse(reader.ReadLine());
                int [] rank2WithRank1Index = new int[N];
                int [] rank1WithRank2Index = new int[N];
                for (int i = 0; i < N; i++)
                {
                    string[] inputs = reader.ReadLine().Split();
                    rank2WithRank1Index[int.Parse(inputs[0])] = int.Parse(inputs[1]);
                    rank1WithRank2Index[int.Parse(inputs[1])] = int.Parse(inputs[2]);
                }

                List<int> passList = new List<int>();

                passList.Add(rank2WithRank1Index[0]);

                int maxRank1 = N + 1;
                int maxRank2 = rank2WithRank1Index[0];

                int index = 0;
                while (index < maxRank2 - 1)
                {
                    if (rank1WithRank2Index[index] < maxRank1)
                    {
                        passList.Add(rank1WithRank2Index[index]);

                        maxRank1 = rank1WithRank2Index[index];
                    }

                    index++;
                }

                print.WriteLine(passList.Count);
            }

            reader.Close();
            print.Close();
        }
    }
}

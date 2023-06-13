using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_9375
    {
        public No_9375()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int T = int.Parse(reader.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int n = int.Parse(reader.ReadLine());

                Dictionary<string, int> gears = new Dictionary<string, int>();


                for (int j = 0; j < n; j++)
                {
                    string[] input = reader.ReadLine().Split();

                    if (!gears.ContainsKey(input[1]))
                        gears.Add(input[1], 1);
                    else
                        gears[input[1]]++;
                }

                int combination = 1;
                foreach (var gear in gears)
                {
                    combination *= (gear.Value + 1);
                }

                print.WriteLine(combination - 1);
            }
        }
    }
}

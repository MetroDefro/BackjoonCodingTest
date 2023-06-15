using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver4
{
    public class No_17219
    {
        public No_17219()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();

            int N = int.Parse(input.Split()[0]);
            int M = int.Parse(input.Split()[1]);

            Dictionary<string, string> sites = new Dictionary<string, string>();

            for (int i = 0; i < N; i++)
            {
                input = reader.ReadLine();
                sites.Add(input.Split()[0], input.Split()[1]);
            }

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < M; i++)
            {
                input = reader.ReadLine();
                sites.TryGetValue(input, out string value);
                builder.Append(value);
                builder.AppendLine();
            }

            print.WriteLine(builder.ToString());
        }
    }
}

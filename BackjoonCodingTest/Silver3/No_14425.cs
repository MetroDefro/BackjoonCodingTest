using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver3
{
    public class No_14425
    {
        public No_14425()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();

            int n = int.Parse(input.Split()[0]);
            int m = int.Parse(input.Split()[1]);

            Dictionary<string, int> s = new Dictionary<string, int>();
            int[] nums = new int[m];
            for (int i = 0; i < n; i++)
            {
                s.Add(reader.ReadLine(), 0);
            }

            int count = 0;
            for (int i = 0; i < m; i++)
            {
                if (s.ContainsKey(reader.ReadLine()))
                    count++;
            }

            print.WriteLine(count);
        }
    }
}

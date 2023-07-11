using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Gold5
{
    public class No_1011
    {
        public No_1011()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int T = int.Parse(reader.ReadLine());

            for (int tc = 0; tc < T; tc++)
            {
                string[] inputs = reader.ReadLine().Split();

                int x = int.Parse(inputs[0]);
                int y = int.Parse(inputs[1]);

                int distance = y - x;

                int index = 1;
                int result = 0;
                while (true)
                {
                    distance -= index;
                    if (distance <= 0)
                    {
                        result = index * 2 - 1;
                        break;
                    }

                    distance -= index;
                    if (distance <= 0)
                    {
                        result = index * 2;
                        break;
                    }

                    index++;
                }

                print.WriteLine(result);
            }
            reader.Close();
            print.Close();
        }
    }
}

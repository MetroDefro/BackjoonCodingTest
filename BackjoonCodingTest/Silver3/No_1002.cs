using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver3
{
    public class No_1002
    {
        public No_1002()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();

            int T = int.Parse(input);

            for (int i = 0; i < T; i++)
            {
                input = reader.ReadLine();
                (int x, int y) vector2A = (int.Parse(input.Split()[0]), int.Parse(input.Split()[1]));
                int distanceA = int.Parse(input.Split()[2]);
                (int x, int y) vector2B = (int.Parse(input.Split()[3]), int.Parse(input.Split()[4]));
                int distanceB = int.Parse(input.Split()[5]);

                if (distanceA == distanceB && vector2A.x == vector2B.x && vector2A.y == vector2B.y)
                {
                    print.WriteLine(-1);
                }
                else if (distanceA + distanceB < Math.Sqrt(Math.Pow(vector2A.x - vector2B.x, 2) + (Math.Pow(vector2A.y - vector2B.y, 2))))
                {
                    print.WriteLine(0);
                }
                else if (distanceA + distanceB == Math.Round(Math.Sqrt(Math.Pow(vector2A.x - vector2B.x, 2) + (Math.Pow(vector2A.y - vector2B.y, 2)))))
                {
                    print.WriteLine(1);
                }
                else if (distanceA + distanceB > Math.Sqrt(Math.Pow(vector2A.x - vector2B.x, 2) + (Math.Pow(vector2A.y - vector2B.y, 2))))
                {
                    if (Math.Abs(distanceA - distanceB) < Math.Sqrt(Math.Pow(vector2A.x - vector2B.x, 2) + (Math.Pow(vector2A.y - vector2B.y, 2))))
                    {
                        print.WriteLine(2);
                    }
                    else if (Math.Abs(distanceA - distanceB) == Math.Round(Math.Sqrt(Math.Pow(vector2A.x - vector2B.x, 2) + (Math.Pow(vector2A.y - vector2B.y, 2)))))
                    {
                        print.WriteLine(1);
                    }
                    else if (Math.Abs(distanceA - distanceB) > Math.Sqrt(Math.Pow(vector2A.x - vector2B.x, 2) + (Math.Pow(vector2A.y - vector2B.y, 2))))
                    {
                        print.WriteLine(0);
                    }
                }
            }
        }
    }
}

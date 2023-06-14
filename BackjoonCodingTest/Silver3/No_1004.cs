using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver3
{
    public class No_1004
    {
        public No_1004()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();

            int t = int.Parse(input);

            for (int j = 0; j < t; j++)
            {
                input = reader.ReadLine();

                int startX = int.Parse(input.Split()[0]);
                int startY = int.Parse(input.Split()[1]);
                int endX = int.Parse(input.Split()[2]);
                int endY = int.Parse(input.Split()[3]);

                input = reader.ReadLine();

                int n = int.Parse(input);

                (int x, int y, int r)[] planets = new (int, int, int)[n];
                for (int i = 0; i < n; i++)
                {
                    input = reader.ReadLine();
                    planets[i].x = int.Parse(input.Split()[0]);
                    planets[i].y = int.Parse(input.Split()[1]);
                    planets[i].r = int.Parse(input.Split()[2]);
                }

                bool[] isStartPoinInPlanets = new bool[n];
                bool[] isEndPoinInPlanets = new bool[n];
                for (int i = 0; i < n; i++)
                {
                    if (planets[i].r > Math.Sqrt(Math.Pow(startX - planets[i].x, 2) + (Math.Pow(startY - planets[i].y, 2))))
                    {
                        isStartPoinInPlanets[i] = true;
                    }

                    if (planets[i].r > Math.Sqrt(Math.Pow(endX - planets[i].x, 2) + (Math.Pow(endY - planets[i].y, 2))))
                    {
                        isEndPoinInPlanets[i] = true;
                    }
                }

                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    if (!isStartPoinInPlanets[i] && isEndPoinInPlanets[i] || isStartPoinInPlanets[i] && !isEndPoinInPlanets[i])
                    {
                        count++;
                    }
                }

                print.WriteLine(count);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver5
{
    public class No_11723
    {
        public No_11723()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int M = int.Parse(input);

            int num = 0;

            for (int i = 0; i < M; i++)
            {
                input = reader.ReadLine();
                string command = input.Split()[0];

                if (command == "add")
                {
                    num += (int)MathF.Pow(2, short.Parse(input.Split()[1]) - 1);
                }
                else if (command == "remove")
                {
                    int x = (int)MathF.Pow(2, short.Parse(input.Split()[1]) - 1);
                    if ((num & x) != 0)
                        num -= x;
                }
                else if (command == "check")
                {
                    int x = (int)MathF.Pow(2, short.Parse(input.Split()[1]) - 1);
                    if ((num & x) != 0)
                        print.WriteLine(1);
                    else
                        print.WriteLine(0);
                }
                else if (command == "toggle")
                {
                    int x = (int)MathF.Pow(2, short.Parse(input.Split()[1]) - 1);
                    if ((num & x) != 0)
                        num -= (int)MathF.Pow(2, short.Parse(input.Split()[1]) - 1);
                    else
                        num += (int)MathF.Pow(2, short.Parse(input.Split()[1]) - 1); ;
                }
                else if (command == "all")
                {
                    num = 16777215;
                }
                else
                {
                    num = 0;
                }
            }
        }
    }
}

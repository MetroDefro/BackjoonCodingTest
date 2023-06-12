using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_2920
    {
        public No_2920()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();

            string[] strings = input.Split();

            if (int.Parse(strings[0]) == 8)
            {
                for (int i = 0; i < 7; i++)
                {
                    if (int.Parse(strings[i]) - 1 != int.Parse(strings[i + 1]))
                    {
                        print.WriteLine("mixed");
                        break;
                    }
                    else
                    {
                        if (i == 6)
                            print.WriteLine("descending");
                    }
                }
            }
            else if (int.Parse(strings[0]) == 1)
            {
                for (int i = 0; i < 7; i++)
                {
                    if (int.Parse(strings[i]) + 1 != int.Parse(strings[i + 1]))
                    {
                        print.WriteLine("mixed");
                        break;
                    }
                    else
                    {
                        if (i == 6)
                            print.WriteLine("ascending");
                    }
                }
            }
            else
            {
                print.WriteLine("mixed");
            }
        }
    }
}

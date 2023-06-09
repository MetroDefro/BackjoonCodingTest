using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze1
{
    public class No_2609
    {
        public No_2609()
        {
            string input = Console.ReadLine();
            int value1 = int.Parse(input.Split()[0]);
            int value2 = int.Parse(input.Split()[1]);

            Console.WriteLine(GCD(value1, value2));
            Console.WriteLine(LCM(value1, value2));
        }

        private static long GCD(int value1, int value2)
        {
            int smallValue = value1 < value2 ? value1 : value2;
            int maxMeasure = 1;

            for (int i = 2; i <= smallValue; i++)
            {
                if (value1 % i == 0)
                {
                    if (value2 % i == 0)
                    {
                        maxMeasure = i;
                    }
                }
            }

            return maxMeasure;
        }

        private static long LCM(int value1, int value2)
        {
            return value1 * value2 / GCD(value1, value2);
        }
    }
}

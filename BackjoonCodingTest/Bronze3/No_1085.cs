﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_1085
    {
        public No_1085()
        {
            string input = Console.ReadLine();
            int x = int.Parse(input.Split()[0]);
            int y = int.Parse(input.Split()[1]);
            int w = int.Parse(input.Split()[2]);
            int h = int.Parse(input.Split()[3]);

            int min = x < y ? x : y;
            if (w - x < min)
                min = w - x;
            if (h - y < min)
                min = h - y;

            Console.WriteLine(min);
        }
    }
}

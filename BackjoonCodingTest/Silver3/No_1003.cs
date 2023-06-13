using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver3
{
    public class No_1003
    {
        public No_1003()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();

            int T = int.Parse(input);

            int[] fibonaccis = new int[41];
            fibonaccis[0] = 0;
            fibonaccis[1] = 1;

            for (int i = 0; i < T; i++)
            {
                input = reader.ReadLine();
                if (int.Parse(input) == 0)
                {
                    print.WriteLine(1 + " " + fibonacci(fibonaccis, int.Parse(input)));
                }
                else
                {
                    print.WriteLine(fibonacci(fibonaccis, int.Parse(input) - 1) + " " + fibonacci(fibonaccis, int.Parse(input)));
                }
            }
        }

        private static int fibonacci(int[] fibonaccis, int n)
        {
            if (fibonaccis[n] != 0)
            {
                return fibonaccis[n];
            }

            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                fibonaccis[n] = fibonacci(fibonaccis, n - 1) + fibonacci(fibonaccis, n - 2);
                return fibonaccis[n];
            }
        }
    }
}

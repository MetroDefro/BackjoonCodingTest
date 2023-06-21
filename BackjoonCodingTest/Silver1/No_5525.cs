using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_5525
    {
        public No_5525()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());
            int M = int.Parse(reader.ReadLine());

            string input = reader.ReadLine();

            char[] chars = input.ToCharArray();

            int count = 0;

            int i = 0;
            while (M - i >= 2 * N + 1)
            {
                int temp = Serch(i, true, 0);
                if (temp == 0)
                    i++;
                else
                    i += temp;
                if (2 * N + 1 <= temp)
                {
                    temp -= 2 * N + 1;

                    temp /= 2;

                    count += temp + 1;
                }
            }

            print.WriteLine(count);


            int Serch(int id, bool isI, int count)
            {
                if (id < M)
                {
                    if (isI)
                    {
                        if (chars[id] == 'I')
                        {
                            count++;
                            return Serch(id + 1, !isI, count);
                        }
                    }
                    else
                    {
                        if (chars[id] == 'O')
                        {
                            count++;
                            return Serch(id + 1, !isI, count);
                        }
                    }
                }

                return count;
            }
        }
    }
}

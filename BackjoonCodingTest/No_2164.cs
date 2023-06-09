using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_2164
    {
        public No_2164()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int N = int.Parse(input);

            int curNum = 0;
            Queue<int> cards = new Queue<int>();

            for (int i = 1; i <= N; i++)
            {
                cards.Enqueue(i);
            }

            while (cards.Count > 1)
            {
                cards.Dequeue();
                curNum = cards.Dequeue();
                cards.Enqueue(curNum);
            }

            print.WriteLine(cards.Dequeue());
        }
    }
}

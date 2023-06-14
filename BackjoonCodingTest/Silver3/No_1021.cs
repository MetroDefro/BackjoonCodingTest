using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver3
{
    public class No_1021
    {
        public No_1021()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int n = int.Parse(input.Split()[0]);
            int m = int.Parse(input.Split()[1]);

            string[] inputs = reader.ReadLine().Split();
            Queue<int> nums = new Queue<int>();
            List<int> deck = new List<int>();
            for (int i = 0; i < m; i++)
            {
                nums.Enqueue(int.Parse(inputs[i]));
            }

            for (int i = 1; i <= n; i++)
            {
                deck.Add(i);
            }

            int count = 0;
            while (nums.Count > 0)
            {
                int curIndex = nums.Dequeue();

                int findIndex = deck.FindIndex(o => o == curIndex);
                if (findIndex < deck.Count - findIndex)
                {
                    for (int i = 0; i < findIndex; i++)
                    {
                        int num = deck[0];
                        deck.RemoveAt(0);
                        deck.Add(num);
                    }
                    count += findIndex;
                }
                else
                {
                    for (int i = 0; i < deck.Count - findIndex; i++)
                    {
                        int num = deck[deck.Count - 1];
                        deck.RemoveAt(deck.Count - 1);
                        deck.Insert(0, num);
                    }
                    count += deck.Count - findIndex;
                }

                deck.RemoveAt(0);
            }

            print.WriteLine(count);
        }
    }
}

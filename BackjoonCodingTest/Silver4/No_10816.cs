using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_10816
    {
        public No_10816()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();
            int N = int.Parse(input);

            input = reader.ReadLine();
            string[] numsString = input.Split();
            Dictionary<int, int> myCards = new Dictionary<int, int>();
            List<int> myCardKeysList = new List<int>();

            for (int i = 0; i < N; i++)
            {
                int num = int.Parse(numsString[i]);
                if (myCards.ContainsKey(num))
                    myCards[num]++;
                else
                {
                    myCards.Add(num, 1);
                }
            }

            input = reader.ReadLine();
            int M = int.Parse(input);

            input = reader.ReadLine();
            numsString = input.Split();
            int[] nums = new int[M];
            for (int i = 0; i < M; i++)
            {
                nums[i] = int.Parse(numsString[i]);
                if (myCards.TryGetValue(nums[i], out int value))
                    print.Write(value);
                else
                    print.Write(0);

                if (i != M - 1)
                    print.Write(" ");
            }
        }
    }
}

using System;

namespace BackjoonCodingTest.Bronze1
{
    public class No_1546
    {
        public No_1546()
        {
            string input = Console.ReadLine();
            int count = int.Parse(input);
            input = Console.ReadLine();

            int[] scores = new int[count];
            double max = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = int.Parse(input.Split()[i]);
                if (scores[i] > max)
                    max = scores[i];
            }

            double sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i] / max * 100;
            }

            double aver = sum / count;
            Console.WriteLine(aver);
        }
    }
}
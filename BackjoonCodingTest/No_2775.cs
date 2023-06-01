using System;

namespace BackjoonCodingTest
{
    public class No_2775
    {
        public No_2775()
        {
            string input = Console.ReadLine();
            int testCaseCount = int.Parse(input);

            int[] results = new int[testCaseCount];
            int curCase = 0;
            while (testCaseCount > curCase)
            {
                input = Console.ReadLine();
                int k = int.Parse(input);
                input = Console.ReadLine();
                int n = int.Parse(input);

                int[] prevCount = new int[n];
                int[] count = new int[n];

                for (int i = 1; i <= n; i++)
                {
                    prevCount[i - 1] = i;
                }

                for (int floor = 1; floor <= k; floor++)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        int sum = 0;
                        for (int j = 1; j <= i; j++)
                        {
                            sum += prevCount[j - 1];
                        }
                        count[i - 1] = sum;
                    }

                    Array.Copy(count, prevCount, n);
                }

                results[curCase] = count[n - 1];
                curCase++;
            }

            for (int i = 0; i < results.Length; i++)
                Console.WriteLine(results[i]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Gold5
{
    public class No_5430
    {
        public No_5430()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int T = int.Parse(reader.ReadLine());
            for (int testCase = 0; testCase < T; testCase++)
            {
                string p = reader.ReadLine();
                int n = int.Parse(reader.ReadLine());
                string[] input = reader.ReadLine().Split(',', '[', ']');
                int[] nums = new int[n];
                List<int> numList = new List<int>();
                for (int i = 1; i <= n; i++)
                {
                    numList.Add(int.Parse(input[i]));
                }

                char[] command = p.ToCharArray();
                print.WriteLine(PlayCommand(command, numList));
            }
            reader.Close();
            print.Close();
        }

        private static string PlayCommand(char[] command, List<int> nums)
        {
            bool isReverse = false;
            int count = command.Length;
            for (int i = 0; i < count; i++)
            {
                if (command[i] == 'R')
                {
                    isReverse = !isReverse;
                }
                else
                {
                    if (nums.Count > 0)
                        nums = D(nums, isReverse);
                    else
                        return "error";
                }
            }

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("[");
            count = nums.Count;
            if (isReverse)
            {
                for (int i = count - 1; i >= 0; i--)
                {
                    stringBuilder.Append(nums[i]);
                    if (i > 0)
                        stringBuilder.Append(",");
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    stringBuilder.Append(nums[i]);
                    if (i < count - 1)
                        stringBuilder.Append(",");
                }
            }
            stringBuilder.Append("]");
            return stringBuilder.ToString();
        }

        private static List<int> D(List<int> arr, bool isReverse)
        {
            if (isReverse)
                arr.RemoveAt(arr.Count - 1);
            else
                arr.RemoveAt(0);
            return arr;
        }
    }
}

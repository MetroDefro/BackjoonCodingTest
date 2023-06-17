using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_1541
    {
        public No_1541()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string input = reader.ReadLine();

            StringBuilder num = new StringBuilder();
            string plusNums = string.Empty;
            List<int> nums = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '-')
                {
                    if (plusNums != string.Empty)
                    {
                        nums.Add((int.Parse(plusNums) + int.Parse(num.ToString())));
                        plusNums = string.Empty;
                        num.Clear();
                    }
                    else
                    {
                        nums.Add(int.Parse(num.ToString()));
                        num.Clear();
                    }

                }
                else if (input[i] == '+')
                {
                    if (plusNums != string.Empty)
                    {
                        plusNums = (int.Parse(plusNums) + int.Parse(num.ToString())).ToString();
                        num.Clear();
                    }
                    else
                    {
                        plusNums = num.ToString();
                        num.Clear();
                    }

                }
                else
                {
                    num.Append(input[i]);
                }
            }

            if (plusNums != string.Empty)
            {
                nums.Add((int.Parse(plusNums) + int.Parse(num.ToString())));
                plusNums = string.Empty;
                num.Clear();
            }
            else
            {
                nums.Add(int.Parse(num.ToString()));
                num.Clear();
            }

            int result = nums[0];
            for (int i = 1; i < nums.Count; i++)
            {
                result -= nums[i];
            }

            print.WriteLine(result);
        }
    }
}

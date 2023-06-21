using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze5
{
    public class No_14681
    {
        public No_14681()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int x = int.Parse(reader.ReadLine());
            int y = int.Parse(reader.ReadLine());

            if (x > 0)
            {
                if (y > 0)
                    print.WriteLine(1);
                else
                    print.WriteLine(4);
            }
            else
            {
                if (y > 0)
                    print.WriteLine(2);
                else
                    print.WriteLine(3);
            }

            reader.Close();
            print.Close();
        }
    }
}

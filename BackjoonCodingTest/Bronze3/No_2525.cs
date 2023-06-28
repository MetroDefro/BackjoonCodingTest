using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Bronze3
{
    public class No_2525
    {
        public No_2525()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            string[] inputs = reader.ReadLine().Split();

            int h = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);
            int duringM = int.Parse(reader.ReadLine());

            int fixH = duringM / 60;
            int fixM = duringM % 60;

            int resultH = 0;
            int resultM = 0;

            resultM = (m + fixM) % 60;
            if (m + fixM >= 60)
            {
                resultH++;
            }
            resultH = (resultH + h + fixH) % 24;

            print.WriteLine(resultH + " " + resultM);

            reader.Close();
            print.Close();
        }
    }
}

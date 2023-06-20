using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest
{
    public class No_20529
    {
        public No_20529()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int T = int.Parse(reader.ReadLine());

            for (int testCase = 0; testCase < T; testCase++)
            {
                Dictionary<string, int> mbtiDictionary = new Dictionary<string, int>();
                for (int EorI = 0; EorI < 2; EorI++)
                {
                    for (int SorN = 0; SorN < 2; SorN++)
                    {
                        for (int TorF = 0; TorF < 2; TorF++)
                        {
                            for (int JorP = 0; JorP < 2; JorP++)
                            {
                                StringBuilder stringBuilder = new StringBuilder();
                                stringBuilder.Append(EorI == 0 ? 'E' : 'I');
                                stringBuilder.Append(SorN == 0 ? 'S' : 'N');
                                stringBuilder.Append(TorF == 0 ? 'T' : 'F');
                                stringBuilder.Append(JorP == 0 ? 'J' : 'P');
                                mbtiDictionary.Add(stringBuilder.ToString(), 0);
                            }
                        }
                    }
                }

                int N = int.Parse(reader.ReadLine());

                string[] mbti = reader.ReadLine().Split();

                for (int i = 0; i < N; i++)
                {
                    string curMbti = mbti[i];

                    mbtiDictionary[curMbti]++;
                }

                print.WriteLine(SertchMin(mbtiDictionary));
            }

            int SertchMin(Dictionary<string, int> mbtiDictionary)
            {
                int min = 4096;
                foreach (var a in mbtiDictionary)
                {
                    if (a.Value < 1)
                    {
                        continue;
                    }

                    foreach (var b in mbtiDictionary)
                    {
                        if (b.Value < 1)
                        {
                            continue;
                        }

                        if (a.Key == b.Key && b.Value < 2)
                        {
                            continue;
                        }

                        foreach (var c in mbtiDictionary)
                        {
                            if (c.Value < 1)
                            {
                                continue;
                            }

                            if (a.Key == c.Key && c.Value < 2 ||
                                b.Key == c.Key && c.Value < 2)
                            {
                                continue;
                            }

                            if (a.Key == c.Key && b.Key == c.Key && c.Value < 3)
                            {
                                continue;
                            }

                            int temp = CalDistance(a.Key, b.Key, c.Key);
                            if (temp < min)
                                min = temp;
                            if (min == 0)
                                return 0;
                        }
                    }
                }

                return min;
            }


            int CalDistance(string a, string b, string c)
            {
                if (a.Equals(b) && b.Equals(c))
                    return 0;

                int count = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (a[i] != b[i])
                    {
                        count++;
                    }
                    if (b[i] != c[i])
                    {
                        count++;
                    }
                    if (c[i] != a[i])
                    {
                        count++;
                    }
                }

                return count;
            }
        }
    }
}

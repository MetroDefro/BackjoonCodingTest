using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonCodingTest.Silver1
{
    public class No_1991
    {
        public No_1991()
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(reader.ReadLine());

            Tree[] trees = new Tree[26];
            for (int i = 0; i < N; i++)
            {
                trees[i] = new Tree();
            }

            for (int i = 0; i < N; i++)
            {
                string[] inputs = reader.ReadLine().Split();

                if (inputs[1] != ".")
                    trees[char.Parse(inputs[0]) - 'A'].LeftChilde = char.Parse(inputs[1]) - 'A';

                if (inputs[2] != ".")
                    trees[char.Parse(inputs[0]) - 'A'].RightChilde = char.Parse(inputs[2]) - 'A';
            }

            StringBuilder stringBuilder = new StringBuilder();

            Preorder(stringBuilder, trees, 0);
            stringBuilder.AppendLine();
            Inorder(stringBuilder, trees, 0);
            stringBuilder.AppendLine();
            Postorder(stringBuilder, trees, 0);
            print.WriteLine(stringBuilder.ToString());
        }

        private static void Preorder(StringBuilder stringBuilder, Tree[] trees, int root)
        {
            stringBuilder.Append((char)(root + 'A'));
            if (trees[root].LeftChilde != -1)
                Preorder(stringBuilder, trees, trees[root].LeftChilde);
            if (trees[root].RightChilde != -1)
                Preorder(stringBuilder, trees, trees[root].RightChilde);
        }

        private static void Inorder(StringBuilder stringBuilder, Tree[] trees, int root)
        {
            if (trees[root].LeftChilde != -1)
                Inorder(stringBuilder, trees, trees[root].LeftChilde);
            stringBuilder.Append((char)(root + 'A'));
            if (trees[root].RightChilde != -1)
                Inorder(stringBuilder, trees, trees[root].RightChilde);
        }

        private static void Postorder(StringBuilder stringBuilder, Tree[] trees, int root)
        {
            if (trees[root].LeftChilde != -1)
                Postorder(stringBuilder, trees, trees[root].LeftChilde);
            if (trees[root].RightChilde != -1)
                Postorder(stringBuilder, trees, trees[root].RightChilde);
            stringBuilder.Append((char)(root + 'A'));
        }

        private class Tree
        {
            public int LeftChilde { get; set; } = -1;
            public int RightChilde { get; set; } = -1;
        }
    }
}

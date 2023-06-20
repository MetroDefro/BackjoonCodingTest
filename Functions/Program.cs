using System.Text;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static int[] Sort(int[] array)
        {
            array = Divide(array, array.Length);

            return array;
        }

        private static int[] Divide(int[] list, int count)
        {
            int harfCount = count / 2;

            int[] divideListLeft = new int[harfCount];
            for (int i = 0; i < harfCount; i++)
            {
                divideListLeft[i] = list[i];
            }

            if (harfCount > 1)
            {
                divideListLeft = Divide(divideListLeft, harfCount);
            }

            int[] divideListRight = new int[count - harfCount];
            for (int i = 0; i < count - harfCount; i++)
            {
                divideListRight[i] = list[harfCount + i];
            }

            if (count - harfCount > 1)
            {
                divideListRight = Divide(divideListRight, count - harfCount);
            }


            return Merge(divideListLeft, divideListRight, divideListLeft.Length, divideListRight.Length);
        }

        private static int[] Merge(int[] leftList, int[] rightList, int leftListCount, int rightListCount)
        {
            int[] list = new int[leftListCount + rightListCount];

            int leftIndex = 0;
            int rightIndex = 0;
            int mergeIndex = 0;
            while (leftIndex < leftListCount && rightIndex < rightListCount)
            {
                if (leftList[leftIndex] < rightList[rightIndex])
                {
                    list[mergeIndex++] = leftList[leftIndex++];
                }
                else
                {
                    list[mergeIndex++] = rightList[rightIndex++];
                }
            }

            while (leftIndex < leftListCount)
            {
                list[mergeIndex++] = leftList[leftIndex++];
            }

            while (rightIndex < rightListCount)
            {
                list[mergeIndex++] = rightList[rightIndex++];
            }

            return list;
        }

        private static int BinarySearch(int[] list, int target)
        {
            int start = 0;
            int end = list.Length - 1;
            int mid = (end + start) / 2;

            while (start <= end)
            {
                if (list[mid] == target)
                {
                    return 1;
                }
                else if (list[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
                mid = (end + start) / 2;
            }

            return 0;
        }

        private static void DFS(bool[] visited, List<int>[] list, int id)
        {
            if (!visited[id])
            {
                visited[id] = true;
                for (int i = 0; i < list[id].Count; i++)
                {
                    DFS(visited, list, list[id][i]);
                }
            }
        }

        void BFS(List<int>[] list, int id)
        {
            bool[] visited = new bool[list.Length];
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(id);

            while (queue.Count > 0)
            {
                int index = queue.Dequeue();

                for (int i = 0; i < list[index].Count; i++)
                {
                    if (!visited[list[index][i]])
                        queue.Enqueue(list[index][i]);
                }

                if (!visited[index])
                {
                    visited[index] = true;
                }
            }
        }

        private static int Combination(int n, int r)
        {
            int molecule = 1;
            for (int i = 1; i <= n; i++)
            {
                molecule *= i;
            }

            int denominator = 1;
            for (int i = 1; i <= r; i++)
            {
                denominator *= i;
            }
            for (int i = 1; i <= n - r; i++)
            {
                denominator *= i;
            }

            return molecule / denominator;
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
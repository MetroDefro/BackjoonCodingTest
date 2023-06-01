namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static LinkedList<short> Divide(LinkedList<short> list, int count)
        {
            int harfCount = count / 2;

            LinkedList<short> divideListLeft = new LinkedList<short>();
            LinkedListNode<short> curNode = list.First;
            for (int i = 0; i < harfCount; i++)
            {
                divideListLeft.AddLast(curNode);
                curNode = curNode.Next;
            }

            if (harfCount > 1)
            {
                divideListLeft = Divide(divideListLeft, harfCount);
            }

            LinkedList<short> divideListRight = new LinkedList<short>();
            for (int i = 0; i < count - harfCount; i++)
            {
                divideListRight.AddLast(curNode);
                curNode = curNode.Next;
            }

            if (count - harfCount > 1)
            {
                divideListRight = Divide(divideListRight, count - harfCount);
            }


            return Merge(divideListLeft, divideListRight, harfCount, count - harfCount);
        }

        private static LinkedList<short> Merge(LinkedList<short> leftList, LinkedList<short> rightList, int leftListCount, int rightListCount)
        {
            LinkedList<short> list = new LinkedList<short>();
            LinkedListNode<short> curLeftNode = leftList.First;
            LinkedListNode<short> curRightNode = rightList.First;
            while (curLeftNode != null && curRightNode != null)
            {
                if (curLeftNode.Value < curRightNode.Value)
                {
                    list.AddLast(curLeftNode.Value);
                }
                else
                {
                    list.AddLast(curRightNode.Value);
                }
            }

            while (curLeftNode != null)
            {
                list.AddLast(curLeftNode.Value);
            }

            while (curRightNode != null)
            {
                list.AddLast(curRightNode.Value);
            }

            return list;
        }
    }
}
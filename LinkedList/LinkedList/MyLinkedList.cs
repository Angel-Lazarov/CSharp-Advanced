
namespace LinkedList
{
    public class MyLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public int Count { get; set; }

        public void AddLast(int value)
        {
            Count++;
            Node newNode = new Node(value);

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            }

            newNode.Previous = Tail;
            Tail.Next = newNode;
            Tail = newNode;
        }

        public void AddFirst(int value)
        {
            Count++;

            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            }

            newNode.Next = Head;
            Head.Previous = newNode;
            Head = newNode;
        }

        public void RemoveFirst()
        {
            Count--;

            Node newHead = Head.Next;

            newHead.Previous = null;
            Head.Next = null;
            Head = newHead;
        }

        public void RemoveLast()
        {
            Count--;
            Node newTail = Tail.Previous;

            newTail.Next = null;
            Tail.Previous = null;
            Tail = newTail;
        }

        public int[] ToArray()
        {
            int[] newArray = new int[Count];
            int index = 0;
            Node currentNode = Head;

            while (currentNode != null)
            {
                newArray[index++] = currentNode.Value;
                currentNode = currentNode.Next;
            }
            return newArray;
        }

        public void ForEach(Action<int> action)
        {
            Node node1 = Head;

            while (node1 != null)
            {
                action(node1.Value);
                node1 = node1.Next;
            }
        }
    }
}

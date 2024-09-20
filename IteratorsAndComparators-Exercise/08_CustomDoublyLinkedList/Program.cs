namespace _08_CustomDoublyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using CustomLinkedList;

            CustomDoublyLinkedList<int> list = new();

            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);

            Console.WriteLine(list.RemoveFirst());
            Console.WriteLine(list.RemoveLast());

            int[] ints = list.ToArray();

            list.ForEach(x => Console.WriteLine(x + " "));

            list.AddFirst(0);
            list.AddFirst(-1);
            list.AddFirst(-2);

            list.RemoveLast();
            list.RemoveFirst();
            Console.WriteLine(list.Count);



            //подаваме функция(action) за печатане на метода като параметър. Метода върти елементите и функцията ги печата.
            Console.WriteLine("\n\n");

            //while (node != null) 
            //{
            //    Console.WriteLine(node.Value);
            //    node = node.Next;
            //}

            Console.WriteLine(string.Join(",", ints));

            CustomDoublyLinkedList<string> stringList = new CustomDoublyLinkedList<string>();
            stringList.AddFirst("a");
            stringList.AddFirst("bsdd");
            stringList.AddLast("gdfa");

            stringList.ForEach(i => Console.WriteLine(i));

            Console.WriteLine("\n\n");
            Console.WriteLine(stringList.Count);
        }
    }
}

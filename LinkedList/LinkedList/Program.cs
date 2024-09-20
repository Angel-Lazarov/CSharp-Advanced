using LinkedList;

MyLinkedList myLinkedList = new MyLinkedList();

myLinkedList.AddLast(1);
myLinkedList.AddLast(2);
myLinkedList.AddLast(3);
myLinkedList.AddLast(4);
myLinkedList.AddLast(5);
myLinkedList.AddLast(6);
myLinkedList.AddLast(7);


myLinkedList.AddFirst(0);
myLinkedList.AddFirst(-1);
myLinkedList.AddFirst(-2);

myLinkedList.RemoveLast();
myLinkedList.RemoveFirst();

Node node = myLinkedList.Head;

int[] ints = myLinkedList.ToArray();

//подаваме функция(action) за шечатане на метода като параметър. Метода върти елементите и функцията ги печата.
myLinkedList.ForEach(x=> Console.WriteLine(x));
Console.WriteLine("\n\n");

//while (node != null) 
//{
//    Console.WriteLine(node.Value);
//    node = node.Next;
//}

Console.WriteLine(string.Join(",", ints));
using CustomStructures;


CustomQueue queue = new();

queue.Enqueue(1);
queue.Enqueue(4);
queue.Enqueue(7);
queue.Enqueue(55);
queue.Enqueue(155);

Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());

Console.WriteLine(queue.Peek());
Console.WriteLine(queue.Peek());
Console.WriteLine(queue.Peek());

queue.ForEach(i => Console.WriteLine($"{i} "));


queue.ForEach(i => Console.WriteLine($"{i} "));

Console.WriteLine();
Console.WriteLine(queue.Count);

queue.Clear();
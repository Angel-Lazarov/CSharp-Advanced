int food = int.Parse(Console.ReadLine());

Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

Console.WriteLine(queue.Max());
int orders = queue.Count;

for (int i = 0; i < orders; i++)
{
    int currentOrder = queue.Peek();

    if (food >= currentOrder)
    {
        queue.Dequeue();
        food -= currentOrder;
    }
}

if (queue.Count == 0)
{
    Console.WriteLine("Orders complete");
}
else 
{
    Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
}

/*
348
20 54 30 16 7 9

 
 
 */
int food = int.Parse(Console.ReadLine());

Queue<int> foodOrders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

Console.WriteLine(foodOrders.Max());

while (foodOrders.Count > 0 && food > 0)
{
    int currentOrder = foodOrders.Peek();

    if (food - currentOrder >= 0)
    {
        food -= foodOrders.Dequeue();
    }
    else 
    {
        break; 
    }
}

if (foodOrders.Count == 0)
{
    Console.WriteLine("Orders complete");
}
else
{
    Console.WriteLine($"Orders left: {string.Join(" ", foodOrders)}");
}
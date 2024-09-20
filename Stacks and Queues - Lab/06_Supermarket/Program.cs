string input = string.Empty;
Queue<string> queue = new Queue<string>();

while ((input = Console.ReadLine()) != "End")
{
    if (input == "Paid")
    {
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
    else
    {
        queue.Enqueue(input);
    }

}
Console.WriteLine($"{queue.Count} people remaining.");

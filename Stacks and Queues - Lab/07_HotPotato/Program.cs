//List<string> names = Console.ReadLine().Split().ToList();
//Queue<string> circle = new Queue<string> (names);
Queue<string> circle = new Queue<string> (Console.ReadLine().Split());

int toss = int.Parse(Console.ReadLine());
int count = 0;

while (circle.Count > 1)
{
    count++;

    string currentName = circle.Dequeue ();

    if (count != toss)
    {
        circle.Enqueue(currentName);
    }
    else 
    {
        Console.WriteLine($"Removed {currentName}");
        count = 0;
    }
}

Console.WriteLine($"Last is {circle.Dequeue()}");
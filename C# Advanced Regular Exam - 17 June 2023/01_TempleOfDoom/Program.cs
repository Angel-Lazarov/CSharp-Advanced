// 21:10 - 21:19 -> 9
// 21:45 - 22:10 -> 25 => 34

using System.Collections.Generic;
using System;

Queue<int> tools = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Stack<int> substances = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

List<int> challenges = new List<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

bool isLost = false;

while (challenges.Any())
{
    int result = tools.Peek() * substances.Peek();

    if (challenges.Contains(result))
    {
        tools.Dequeue();
        substances.Pop();
        challenges.Remove(result);
    }
    else
    {
        int tool = tools.Dequeue() + 1;
        tools.Enqueue(tool);
        int substance = substances.Pop() - 1;
        if (substance > 0)
        {
            substances.Push(substance);
        }
    }

    if (!tools.Any() || !substances.Any())
    {
        if (challenges.Any())
        {
            Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
            break;
        }
    }
}

if (!challenges.Any())
{
    Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
}

if (tools.Any())
{
    Console.WriteLine($"Tools: {string.Join(", ", tools)}");
}
if (substances.Any())
{
    Console.WriteLine($"Substances: {string.Join(", ", substances)}");
}
if (challenges.Any())
{
    Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
}



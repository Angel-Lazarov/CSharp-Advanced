//21:18 - 21:43-50 -> 22:24

Queue<int> monstersArmor = new Queue<int>(Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Stack<int> soldierStrenghts = new Stack<int>(Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

int killed = 0;

while (monstersArmor.Any() && soldierStrenghts.Any())
{
    int armor = monstersArmor.Dequeue();
    int strenght = soldierStrenghts.Pop();


    if (strenght >= armor)
    {
        killed++;
        strenght -= armor;

        if (soldierStrenghts.Any())
        {
            int nextSoldier = soldierStrenghts.Pop() + strenght;
            soldierStrenghts.Push(nextSoldier);
        }
        else if (strenght > 0 && !soldierStrenghts.Any()) 
        {
            soldierStrenghts.Push(strenght);
        }
    }
    else
    {
        armor -= strenght;
        monstersArmor.Enqueue(armor);
    }
}

if (!monstersArmor.Any())
{
    Console.WriteLine("All monsters have been killed!");
}

if (!soldierStrenghts.Any())
{
    Console.WriteLine("The soldier has been defeated.");
}
Console.WriteLine($"Total monsters killed: {killed}");

Stack<int> initialFuel = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
int fuelCount = initialFuel.Count;
Queue<int> addConsumptionIndex = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));


Queue<int> fuelNeeded = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
/*
 
200 90 40 100
20 40 30 50
50 60 80 90
 
 */
int goals = 0;

//for (int i = 0; i < altitudes; i++)
while(initialFuel.Any())
{
    int result = initialFuel.Pop() - addConsumptionIndex.Dequeue();

    if (result >= fuelNeeded.Dequeue())
    {
        goals++;
        Console.WriteLine($"John has reached: Altitude {goals}");

    }
    else
    {
        Console.WriteLine($"John did not reach: Altitude {goals +1}");
        break;
        //end
    }
}

if (goals < fuelCount && goals > 0)  //not winner
{
    Console.WriteLine($"John failed to reach the top.");
    Console.Write($"Reached altitudes: ");

    List<string> print = new List<string>();

    for (int i = 1; i <= goals; i++)
    {
        print.Add($"Altitude {i}");
    }
    Console.Write(string.Join(", ", print));
}
else if (goals < fuelCount && goals == 0)
{
    Console.WriteLine($"John failed to reach the top.");
    Console.WriteLine("John didn't reach any altitude.");
}
else if (goals == fuelCount) 
{
    Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
}
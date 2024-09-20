int[] cupsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] bottlesInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

Queue<int> cups = new Queue<int>(cupsInput);
Stack<int> bottles = new Stack<int>(bottlesInput);

int wastedWater = 0;

while (cups.Count > 0 && bottles.Count > 0) 
{
    int currentCup = cups.Peek();
    int filledcup = currentCup;
    //    10          -    8        2

    while (filledcup > 0) 
    {
        int currentBottle = bottles.Pop();

        if (currentBottle >= filledcup)
        {
            cups.Dequeue();
            wastedWater += currentBottle - filledcup;
            break;
        }
        else 
        {
            filledcup-= currentBottle;
        }
    }
   
}

if (cups.Count == 0 && bottles.Count > 0)
{
    Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
}
else if (cups.Count > 0 && bottles.Count == 0) 
{
    Console.WriteLine($"Cups: {string.Join(" ", cups)}");
}
Console.WriteLine($"Wasted litters of water: {wastedWater}");
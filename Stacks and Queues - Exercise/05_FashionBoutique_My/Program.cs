Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

int rackCapacity = int.Parse(Console.ReadLine());
int currentRackCapacity = 0;

int racks = 1;

while (stack.Count > 0)
{
    int currentElement = stack.Pop();

    if (currentElement + currentRackCapacity <= rackCapacity)
    {
        currentRackCapacity += currentElement;
    }
    else
    {
        racks++;
        currentRackCapacity = currentElement;
    }
}
Console.WriteLine(racks);

/*
20 0 20 19 18 17 0
20
 */

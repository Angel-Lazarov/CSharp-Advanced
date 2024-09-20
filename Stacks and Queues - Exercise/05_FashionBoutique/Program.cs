Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

int capacity = int.Parse(Console.ReadLine());
int currentCapacity = 0;

int racks = 1;

while (clothes.Count > 0)
{
    int currentValue = clothes.Pop();

    if (currentValue + currentCapacity <= capacity)
    {
        currentCapacity += currentValue;
    }
    else if (currentValue + currentCapacity > capacity)
    { 
        racks++;
        currentCapacity = currentValue;
    }
}
Console.WriteLine(racks);
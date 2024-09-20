HashSet<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToHashSet();

Func<HashSet<int>, int> findMinimal = (element) => 
{
    int minimal = int.MaxValue;
    foreach (var number in numbers)
    {
        if(number < minimal) 
        {
            minimal = number; 
        }
    }
    return minimal;
};

Console.WriteLine(findMinimal(numbers));
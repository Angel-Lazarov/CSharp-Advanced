List<Predicate<int>> predicates = new();
int end = int.Parse(Console.ReadLine());

HashSet<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToHashSet();

int[] numbers = Enumerable.Range(1, end).ToArray();

foreach (var divider in dividers)
{
    predicates.Add(n => n % divider == 0);
}

foreach (int number in numbers)
{
    bool isDivisable = true;
    foreach (var match in predicates)
    {
        if (!match(number))
        {
            isDivisable = false;
            break;
        }
    }
    if (isDivisable)
    {
        Console.Write($"{number} ");
    }
}

string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Action<string, string[]> titleAdder = (string title, string[] item) =>
{
    foreach (var name in names)
    {
        Console.WriteLine($"{title} {name}");
    }
};

titleAdder("Sir",names);



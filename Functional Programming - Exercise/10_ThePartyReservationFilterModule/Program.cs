List<string> people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
Dictionary<string, Predicate<string>> filters = new();

string command = string.Empty;

while ((command = Console.ReadLine()) != "Print")
{
    string[] commandInfo = command.Split(";", StringSplitOptions.RemoveEmptyEntries);
    string action = commandInfo[0];
    string filter = commandInfo[1];
    string value = commandInfo[2];

    if (commandInfo[0] == "Add filter")
    {
        if (!filters.ContainsKey(filter + value))
        {
            filters.Add(filter + value, GetPredicate(filter, value));
        }
    }
    else //remove
    {
        filters.Remove(filter + value);
    }
}

foreach (var filter in filters)
{
    people.RemoveAll(filter.Value);
}

if (people.Any())
{
    Console.WriteLine($"{string.Join(" ", people)}");
}


static Predicate<string> GetPredicate(string filter, string value)
{
    switch (filter)
    {
        case "Starts with":
            return p => p.StartsWith(value);
        case "Ends with":
            return p => p.EndsWith(value);
        case "Length":
            return p => p.Length == int.Parse(value);
        case "Contains":
            return p => p.Contains(value);
        default:
            return default;
    }
}
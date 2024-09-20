List<string> people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();


string command = string.Empty;

while ((command = Console.ReadLine()) != "Party!")
{
    string[] commandInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string action = commandInfo[0];
    string filter = commandInfo[1];
    string value = commandInfo[2];

    if (commandInfo[0] == "Remove")
    {
        people.RemoveAll(GetPredicate(filter, value));
    }
    else //double
    {
        List<string> peopleToDouble = people.FindAll(GetPredicate(filter, value));
        foreach (var person in peopleToDouble)
        {
            int index = people.IndexOf(person);
            people.Insert(index, person);

        }
    }
}

if (people.Any())
{
    Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}


static Predicate<string> GetPredicate(string filter, string value)
{
    switch (filter)
    {
        case "StartsWith":
            return p => p.StartsWith(value);
        case "EndsWith":
            return p => p.EndsWith(value);
        case "Length":
            return p => p.Length == int.Parse(value);
        default:
            return default;
    }
}
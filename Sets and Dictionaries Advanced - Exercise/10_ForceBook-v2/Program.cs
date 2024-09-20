
Dictionary<string, HashSet<string>> armies = new();

string input = string.Empty;
while ((input = Console.ReadLine()) != "Lumpawaroo")
{
    string[] commandInfo = input.Split(new[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries);

    if (input.Contains(" | "))
    {
        //{forceSide} | {forceUser}
        string forceSide = commandInfo[0];
        string forceUser = commandInfo[1];
        string registeredInArmy = RegisteredInArmy(forceUser, armies);

        if (!armies.ContainsKey(forceSide))
        {
            armies.Add(forceSide, new HashSet<string>());

        }

        if (!armies.Values.Any(x => x.Contains(forceUser)))
        {
            armies[forceSide].Add(forceUser);
        }

    }
    else if (input.Contains(" -> "))
    {
        // {forceUser} -> {forceSide}
        string forceUser = commandInfo[0];
        string forceSide = commandInfo[1];

        if (!armies.ContainsKey(forceSide))
        {
            armies.Add(forceSide, new HashSet<string>());
        }

        if (armies.Values.Any(y => y.Contains(forceUser)))
        {
            foreach (var army in armies)
            {
                if (army.Value.Contains(forceUser))
                {
                    armies[army.Key].Remove(forceUser);
                    break;
                }
            }
            armies[forceSide].Add(forceUser);
            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
        }
        else 
        {
            armies[forceSide].Add(forceUser);
            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
        }
    }
}

foreach (var army in armies.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).Where(x => x.Value.Count > 0))
{
    Console.WriteLine($"Side: {army.Key}, Members: {army.Value.Count}");
    foreach (var name in army.Value.OrderBy(x => x))
    {
        Console.WriteLine($"! {name}");
    }
}
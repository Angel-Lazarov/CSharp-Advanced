Func<List<string>, Predicate<string>, List<string>> orderNames = (names, inLength) =>
{ 
    List<string> result = new List<string>();

    foreach (var name in names) 
    {
        if (inLength(name)) 
        {
            result.Add(name);
        }
    }
    return result;
};


int n = int.Parse(Console.ReadLine());
List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

Predicate<string> inLength = name => name.Length <= n;

names = orderNames(names, inLength);


Console.WriteLine(string.Join(Environment.NewLine, names));
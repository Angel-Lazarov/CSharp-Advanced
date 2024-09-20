int n = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, int>> wardrob = new Dictionary<string, Dictionary<string, int>>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    if (!wardrob.ContainsKey(input[0]))
    {
        wardrob.Add(input[0], new Dictionary<string, int>());
    }

    string[] tokens = input[1].Split(',', StringSplitOptions.RemoveEmptyEntries).ToArray();

    for (int j = 0; j < tokens.Length; j++)
    {

        if (!wardrob[input[0]].ContainsKey(tokens[j]))
        {
            wardrob[input[0]].Add(tokens[j], 0);
        }
        wardrob[input[0]][tokens[j]]++;
    }
}

string[] wanted = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
string wantedColor = wanted[0];
string wantedCloth = wanted[1];

foreach (var color in wardrob)
{
    Console.WriteLine($"{color.Key} clothes:");

    foreach (var item in color.Value)
    {
        if (color.Key == wantedColor && item.Key == wantedCloth)
        {
            Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
        }
        else
        {
            Console.WriteLine($"* {item.Key} - {item.Value}");
        }
    }
}

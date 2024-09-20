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
string color = wanted[0];
string cloth = wanted[1];

foreach (var item in wardrob)
{
    Console.WriteLine($"{item.Key} clothes:");

    foreach (var kvp in item.Value)
    {
        if (item.Key == color && kvp.Key == cloth)
        {
            Console.WriteLine($"* {kvp.Key} - {kvp.Value} (found!)");
        }
        else
        {
            Console.WriteLine($"* {kvp.Key} - {kvp.Value}");
        }
    }
}

int.TryParse(Console.ReadLine(), out int n);

SortedSet<string> table = new SortedSet<string>();

for (int i = 0; i < n; i++) 
{
    string[] input = Console.ReadLine().Split();

    foreach (string element in input) 
    {
        table.Add(element);
    }
}

Console.WriteLine(string.Join(" ", table));
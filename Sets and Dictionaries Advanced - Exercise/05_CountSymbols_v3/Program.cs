string input = Console.ReadLine();
SortedDictionary<char, int> results = new SortedDictionary<char, int>();

foreach (var simbol in input)
{

    if (!results.ContainsKey(simbol))
    {
        // results[simbol] = 0;
        results.Add(simbol, 0);
    }
    results[simbol]++;
}

//foreach (var simbol in results)
//{
//    Console.WriteLine($"{simbol.Key}: {simbol.Value} time/s");
//}

foreach (char simbol in results.Keys)
{
    Console.WriteLine($"{simbol}: {results[simbol]} time/s");
}
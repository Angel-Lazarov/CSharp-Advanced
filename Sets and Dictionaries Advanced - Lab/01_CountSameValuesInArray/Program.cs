List<double> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

Dictionary<double, int> times = new Dictionary<double, int>();

foreach (double number in input) 
{
    if (!times.ContainsKey(number)) 
    {
        times.Add(number, 0);
    }
    times[number] += 1;
}

//foreach (var (number, count) in times)
//{
//    Console.WriteLine($"{number} - {count} times");
//}

foreach (var time in times)
{
    Console.WriteLine($"{time.Key} - {time.Value} times");
}



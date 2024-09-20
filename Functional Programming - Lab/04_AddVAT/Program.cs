double[] numbers = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(n=>double.Parse(n)).Select(n => n*1.2).ToArray();

foreach (var number in numbers) 
{
    Console.WriteLine($"{number:f2}");
}
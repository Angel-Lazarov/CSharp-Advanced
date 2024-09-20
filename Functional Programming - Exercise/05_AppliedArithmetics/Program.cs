Func<string, List<int>, List<int>> calculate = (command, numbers) =>
{
    List<int> calculated = new();
    foreach (int number in numbers)
    {
        if (command == "add")
        {
            calculated.Add(number + 1);
        }
        else if (command == "multiply")
        {
            calculated.Add(number * 2);
        }
        else if (command == "subtract")
        {
            calculated.Add(number - 1);
        }
    }
    return calculated;
};

Action<List<int>> print = numbers =>
{
    Console.WriteLine(string.Join(" ", numbers));
};

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string command = string.Empty;

while ((command = Console.ReadLine()) != "end") 
{
    if (command == "print")
    {
        print(numbers);
    }
    else 
    {
    numbers = calculate(command, numbers);
    }
}
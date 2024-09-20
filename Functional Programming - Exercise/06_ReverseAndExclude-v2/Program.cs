Func<List<int>, List<int>> reversed = numbers =>
{
    List<int> result = new List<int>();
    for (int i = numbers.Count - 1; i >= 0; i--)
    {
        result.Add(numbers[i]);
    }
    return result;
};

Func<List<int>, Predicate<int>, List<int>> exclude = (numbers, isMatch) =>
{
    List<int> result = new List<int>();

    foreach (var number in numbers)
    {
        if (isMatch(number))
        {
            result.Add(number);
        }
    }
    return result;
};


Action<List<int>> print = numbers => Console.WriteLine(string.Join(" ", numbers));

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

int divider = int.Parse(Console.ReadLine());

Predicate<int> isMatch = number =>
 number % divider != 0;

numbers = exclude(numbers, isMatch);
numbers = reversed(numbers);

print(numbers);
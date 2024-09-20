int[] range = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int start = range[0];
int end = range[1];
string typeNumber = Console.ReadLine();


Func<int, int, List<int>> generateNumbers = (start, end) =>
{
    List<int> list = new List<int>();
    for (int i = start; i <= end; i++)
    {
        list.Add(i);
    }
    return list;
};

List<int> numbers = generateNumbers(start, end);


Func<string, int, bool> check = (type, number) =>
    {
        if (type == "even")
        {
            return number % 2 == 0;
        }
        else
        {
            return number % 2 != 0;
        }
    };

foreach (var number in numbers)
{
    if (check(typeNumber, number)) 
    {
        Console.Write($"{number} ");
    }
}
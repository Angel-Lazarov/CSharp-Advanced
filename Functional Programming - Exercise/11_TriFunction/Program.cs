int number = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


Func<string, int, bool> checkForEqualOrLarger =
    (name, number) =>
    //name.Sum(ch=>ch) >= number;
{
    int currentSum = name.Sum(ch => ch);

    return currentSum >= number;
};

Func<string[], int, Func<string, int, bool>, string> getFirstNamne =
    //(names, number, match) => names.FirstOrDefault(name => match(name, number));
    (names, number, match) =>
    {
        foreach (var name in names)
        {
            if (match(name, number)) 
            {
                return name;
            }
        }

        return default;
    };

string firstName = getFirstNamne(names, number, checkForEqualOrLarger);
Console.WriteLine(firstName);
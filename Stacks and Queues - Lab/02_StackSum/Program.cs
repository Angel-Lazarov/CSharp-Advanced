Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

string commandInfo = string.Empty;

while ((commandInfo = Console.ReadLine().ToLower()) != "end")
{
    string[] commandTokens = commandInfo.Split();

    if (commandInfo.Contains("add"))
    {
        int numberOne = int.Parse(commandTokens[1]);
        int numberTwo = int.Parse(commandTokens[2]);
        stack.Push(numberOne);
        stack.Push(numberTwo);
    }

    else if (commandInfo.Contains("remove"))
    {
        int numbersToRemove = int.Parse(commandTokens[1]);

        if (numbersToRemove <= stack.Count)
        {
            for (int i = 0; i < numbersToRemove; i++)
            {
                stack.Pop();
            }
        }
    }
}

int sum = 0;

foreach (int number in stack)
{
    sum += number;
}
Console.WriteLine($"Sum: {sum}");


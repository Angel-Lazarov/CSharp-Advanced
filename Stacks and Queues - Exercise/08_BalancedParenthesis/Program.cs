string input = Console.ReadLine();

Stack<char> brakets = new Stack<char>();

for (int i = 0; i < input.Length; i++)
{
    char currentBraket = input[i];

    if (currentBraket == '(' || currentBraket == '{' || currentBraket == '[')
    {
        brakets.Push(currentBraket);
        continue;
    }

    if (brakets.Count == 0) 
    {
        brakets.Push(currentBraket);
        break;
    }

        char lastBraket = brakets.Peek();

    if (currentBraket == ')' && lastBraket == '(')
    {
        brakets.Pop();
    }
    else if (currentBraket == '}' && lastBraket == '{')
    {
        brakets.Pop();
    }
    else if (currentBraket == ']' && lastBraket == '[')
    {
        brakets.Pop();
    }
}

if (brakets.Count == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}

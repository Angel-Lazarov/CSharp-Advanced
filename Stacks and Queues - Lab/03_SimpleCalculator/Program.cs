
// 2 + 5 + 10 - 2 - 1
string[] input = Console.ReadLine().Split().Reverse().ToArray();
//Console.WriteLine(String.Join("", input));

Stack<string> output = new Stack<string>(input);

int sum = int.Parse(output.Pop());

//Console.WriteLine(String.Join("", output));

while (output.Count > 0)
{
    char operant = char.Parse(output.Pop());
    int number = int.Parse(output.Pop());

    if (operant == '+')
    {
        sum += number;
    }
    else if (operant == '-')
    {
        sum -= number;
    }
}

Console.WriteLine(sum);
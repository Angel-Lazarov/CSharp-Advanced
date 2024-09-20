int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

int nNumbElementsToBePushed = input[0];
int sNumbElementstoBePoped = input[1];
int xCheckedFor = input[2];

int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

Stack<int> stack = new Stack<int>(elements.Take(nNumbElementsToBePushed));


while (stack.Count > 0 && sNumbElementstoBePoped > 0)
{
    stack.Pop();
    sNumbElementstoBePoped--;
}

if (stack.Contains(xCheckedFor))
{
    Console.WriteLine("true");
}
else if (stack.Count == 0)
{
    Console.WriteLine(0);
}
else
{
    Console.WriteLine($"{stack.Min()}");
}

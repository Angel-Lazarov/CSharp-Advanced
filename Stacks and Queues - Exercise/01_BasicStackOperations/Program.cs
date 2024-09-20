int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

int nNumbElementsToBePushed = input[0];
int sNumbElementstoBePoped = input[1];
int xCheckedFor = input[2];

Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

for (int i = 0; i < sNumbElementstoBePoped && stack.Count > 0; i++)
{
    stack.Pop();
}

if (stack.Contains(xCheckedFor) && stack.Count > 0)
{
    Console.WriteLine("true");
}
else if (!stack.Contains(xCheckedFor) && stack.Count > 0)
{
    Console.WriteLine($"{stack.Min()}");
}
else if (stack.Count == 0) 
{
    Console.WriteLine(0);
}

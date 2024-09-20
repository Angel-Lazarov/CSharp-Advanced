string expression = Console.ReadLine();

Stack<int> openingBrakets = new Stack<int>();

for (int i = 0; i < expression.Length; i++)
{
    if (expression[i] == '(')
    {
        openingBrakets.Push(i);   
    }
    if (expression[i] == ')') 
    {
        int openingBraketStartIndex = openingBrakets.Pop();
        int count = i - openingBraketStartIndex + 1;
        Console.WriteLine(expression.Substring(openingBraketStartIndex, count));
    }
}

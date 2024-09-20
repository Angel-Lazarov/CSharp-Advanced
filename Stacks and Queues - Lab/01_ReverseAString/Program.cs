using System.Collections;

string input = Console.ReadLine();

Stack<char> stack = new Stack<char>();

//for (int i = 0; i < input.Length; i++)
//{
//    stack.Push(input[i]);
//}

foreach (var character in input )
{
    stack.Push(character);
}

while (stack.Count > 0) 
{
    Console.Write(stack.Pop());
}
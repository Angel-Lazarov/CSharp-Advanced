using System.Collections;

string text = string.Empty;

int operations = int.Parse(Console.ReadLine());
Stack<string> states = new Stack<string>();

for (int i = 0; i < operations; i++)
{
    string[] commandInfo = Console.ReadLine().Split();

    if (commandInfo[0] == "1") //appends someString to the end of the text.
    {
        states.Push(text);
        string argument = commandInfo[1];
        text += argument;
    }
    else if (commandInfo[0] == "2") //erases the last count elements from the text.
    {
        states.Push(text);
        int count = int.Parse(commandInfo[1]);
        text = text.Substring(0, text.Length - count);
    }
    else if (commandInfo[0] == "3") //index - returns the element at position index from the text.
    {
        int index = int.Parse(commandInfo[1]);
        Console.WriteLine(text[index-1]);
    }
    else if (commandInfo[0] == "4") //undoes the last not undone command of type 1 or 2 and returns the text to the state before that operation.
    {
        text = states.Pop();
    }
}

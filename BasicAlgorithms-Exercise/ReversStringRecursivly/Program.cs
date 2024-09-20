string text = "hello";

string result = Reverse(text, text.Length - 1);
Console.WriteLine(result);

string Reverse(string text, int index)
{
    if (index < 0)
    {
        return null;
    }

    string result = text[index] + Reverse(text, index - 1);

    return result;
}

using CountMethodStrings;

Box<string> box = new Box<string>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    box.Add(input);
}

string element = Console.ReadLine();

int count = box.Count(element);
Console.WriteLine(count);
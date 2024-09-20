string input = string.Empty;
HashSet<string> vip = new HashSet<string>();
HashSet<string> regular = new HashSet<string>();

while ((input = Console.ReadLine()) != "PARTY")
{
    if (char.IsDigit(input[0]))
    {
        vip.Add(input);
    }
    else
    {
        regular.Add(input);
    }
}

while ((input = Console.ReadLine()) != "END")
{
    if (char.IsDigit(input[0]))
    {
       vip.Remove(input);
    }
    else 
    {
    regular.Remove(input);
    }
}

Console.WriteLine(vip.Count + regular.Count);
if (vip.Count > 0) 
{
    Console.WriteLine(string.Join("\n", vip));
}
if (regular.Count > 0) 
{
    Console.WriteLine(string.Join("\n", regular));
}

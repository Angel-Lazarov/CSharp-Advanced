
//             , този стринг с такава дължина ли е?   
Action<string[], Predicate<string>> print = (names, match) =>
{
    foreach (var name in names)
    {
        if (match(name)) 
        {
            Console.WriteLine(name);
        }
    }
};

int length = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine().Split();

print(names, n=> n.Length <= length );


//print(names, n=> n.StartsWith('K') );




Predicate<string> checker = x => x[0] == x.ToUpper()[0];

string[] words = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Where(word => checker(word))
                 .ToArray();
foreach (string word in words)
{
    Console.WriteLine(word);
}

//string[] wordws = Console.ReadLine()
//                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
//                 .Where(x => char.IsUpper(x[0]))
//                 .ToArray();
//foreach (string word in wordws)
//{
//    Console.WriteLine(word);
//}

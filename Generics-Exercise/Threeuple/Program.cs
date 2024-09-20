using Threeuple;

string[] nameAdresInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
CustomThreeuple<string, string, string> tuple1 = new($"{nameAdresInfo[0]} {nameAdresInfo[1]}", nameAdresInfo[2], string.Join(" ", nameAdresInfo[3..]));



string[] nameStatusInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


CustomThreeuple<string, int, bool> tuple2 = new(nameStatusInfo[0], int.Parse(nameStatusInfo[1]), nameStatusInfo[2] == "drunk");


string[] bankInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
CustomThreeuple<string, double, string> tuple3 = new(bankInfo[0], double.Parse(bankInfo[1]), bankInfo[2]);


Console.WriteLine(tuple1);
Console.WriteLine(tuple2);
Console.WriteLine(tuple3);
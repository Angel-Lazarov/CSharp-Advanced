

using System.Security.AccessControl;
using Tuple;

string[] nameAdressTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

CustomTuple<string, string> nameAdress = new($"{nameAdressTokens[0]} {nameAdressTokens[1]}", nameAdressTokens[2]);

string[] nameBearTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
CustomTuple<string, int> nameBear = new(nameBearTokens[0], int.Parse(nameBearTokens[1]));


string[] numbersTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

CustomTuple<int, double> numbers = new(int.Parse(numbersTokens[0]), double.Parse(numbersTokens[1]));


Console.WriteLine(nameAdress);
Console.WriteLine(nameBear.ToString());
Console.WriteLine(numbers);